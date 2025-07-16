using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CafeAccounting.Enums;
using CafeAccounting.Models;

namespace CafeAccounting.Logic
{
    public class Database<T> : ExtendedCollection where T : class, new()
    {
        public class ListChangedEventArgs<T> : EventArgs
        {
            public List<T> List { get; set; }
        }

        public EventHandler<ListChangedEventArgs<T>> OnCollectionChanged;
        private bool _isSearching;

        public Database(string fileName) : base(fileName) { }

        /// <summary>
        /// Завантажує БД з файлу
        /// </summary>
        public override void LoadFromFile()
        {
            Items.Clear();

            string filePath = CollectionName + ".txt";

            if (!File.Exists(filePath))
                return;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    T item = DeserializeObject<T>(line);
                    Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Зберігає БД у файл
        /// </summary>
        public override void SaveToFile()
        {
            string filePath = CollectionName + ".txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach(T item in this.GetList())
                {
                    string line = SerializeObject<T>(item);
                    writer.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Отримує та повертає список всіх об'єктів
        /// </summary>
        /// <returns>список всіх об'єктів</returns>
        public List<T> GetList()
        {
            return base.GetList().Cast<T>().ToList();
        }

        /// <summary>
        /// Додає об'єкт в список
        /// </summary>
        /// <param name="item">об'єкт який треба додати</param>
        public void Add(T item)
        {
            base.Add(item);
            
            if (!_isSearching)
                OnCollectionChanged?.Invoke(this, new ListChangedEventArgs<T>
                {
                    List = this.GetList()
                });
        }

        public void Remove(T item)
        {
            base.Remove(item);

            if (!_isSearching)
                OnCollectionChanged?.Invoke(this, new ListChangedEventArgs<T>
                {
                    List = this.GetList()
                });
        }

        public List<T> Search(string query)
        {
            List<T> list = this.GetList();

            if (string.IsNullOrEmpty(query))
                return list;

            _isSearching = true;

            PropertyInfo[] properties = typeof(T).GetProperties();

            List<T> searchResult = list.Where(item => properties.Any(prop =>
            {
                string? stringValue = prop.GetValue(item)?.ToString();
                return stringValue != null && stringValue.ToLowerInvariant().Contains(query.ToLowerInvariant());
            })).ToList();

            return searchResult;
        }

        /// <summary>
        /// Перетворює вхідний об'єкт в стрічку
        /// </summary>
        /// <typeparam name="T">тип вхідного об'єкту</typeparam>
        /// <param name="obj">об'єект, який треба перетворити</param>
        /// <returns>стрічка у форматі Name1|Value|Name2|Value...</returns>
        private static string SerializeObject<T>(T obj)
        {
            List<string> serializedProperties = new List<string>();

            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                object? value = property.GetValue(obj, null);
                if (value == null)
                    continue;

                // на випадок, якщо властивість є стрічкою та містить символ '|'
                // замінюємо '|' на '\|'
                // а також перед цим замінюємо \ на \\, адже при десеріалізації один знак \ упускається
                string? stringValue = value.ToString()?.Replace("\\", "\\\\")?.Replace("|", "\\|");
                if (stringValue == null)
                    continue;

                serializedProperties.Add(property.Name + "|" + stringValue);
            }

            return string.Join("|", serializedProperties.ToArray());
        }

        /// <summary>
        /// Перетворює вхідну стрічку на об'єкт
        /// </summary>
        /// <typeparam name="T">тип вихідного об'єкту</typeparam>
        /// <param name="input">стрічка у форматі Name1|Value|Name2|Value...</param>
        /// <returns>об'єкт із заданим типом</returns>
        private static T DeserializeObject<T>(string input) where T : new()
        {
            // ітерація по кожному символу, щоб перевірити де '|' є роздільником, а де є частиною стрічки
            List<string> parts = new List<string>();
            var current = "";
            bool escape = false;

            foreach (var c in input)
            {
                if (escape)
                {
                    current += c;
                    escape = false;
                }
                else if (c == '\\')
                {
                    escape = true;
                }
                else if (c == '|')
                {
                    parts.Add(current);
                    current = "";
                }
                else
                {
                    current += c;
                }
            }
            parts.Add(current);

            T result = new T();
            for(int i = 0; i < parts.Count; i += 2)
            {
                string propertyName = parts[i];
                string propertyStringValue = parts[i + 1];

                PropertyInfo? property = typeof(T).GetProperty(propertyName);
                if (property == null)
                    continue;

                object propertyValue = Convert.ChangeType(propertyStringValue, property.PropertyType);
                property.SetValue(result, propertyValue, null);
            }

            return result;
        }
    }
}
