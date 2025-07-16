using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAccounting.Logic
{
    public abstract class ExtendedCollection
    {
        protected string CollectionName;
        protected List<object> Items;
        protected ExtendedCollection(string collectionName)
        {
            CollectionName = collectionName;
            Items = new List<object>();
        }

        public abstract void LoadFromFile();
        public abstract void SaveToFile();

        protected void Add(object item)
        {
            Items.Add(item);
        }

        protected List<object> GetList()
        {
            return new List<object>(Items);
        }
    }
}
