using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeAccounting.Enums;
using CafeAccounting.Forms;
using CafeAccounting.Logic;
using CafeAccounting.Models;

namespace CafeAccounting.Views
{
    public partial class FoodView : UserControl
    {
        private Database<Food> _foodDatabase;
        private Food? _selectedFood;

        public FoodView(Database<Food> foodDatabase)
        {
            InitializeComponent();

            _foodDatabase = foodDatabase;
            _foodDatabase.LoadFromFile();

            InitializeFoodList();
        }

        private void InitializeFoodList()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);

            foodList.LargeImageList = imageList;

            UpdateFoodList(_foodDatabase.GetList());

            _foodDatabase.OnCollectionChanged += (_, e) =>
            {
                UpdateFoodList(e.List);
            };
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FoodForm newFoodForm = new FoodForm();

            if (newFoodForm.ShowDialog() == DialogResult.OK)
            {
                _foodDatabase.Add(newFoodForm.Food);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            FoodForm newFoodForm = new FoodForm(_selectedFood!);

            if (newFoodForm.ShowDialog() == DialogResult.OK)
            {
                UpdateFoodList(_foodDatabase.GetList());
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Food selectedItem = _selectedFood!;

            if (_foodDatabase.GetList().Count == 1)
            {
                foodList.SelectedItems[0].Selected = false;
                foodList.SelectedItems.Clear();
            }

            _foodDatabase.Remove(selectedItem);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = ((TextBox)sender).Text;
            List<Food> searchResults = _foodDatabase.Search(searchText);

            UpdateFoodList(searchResults);
        }

        private void foodList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected || e.Item == null || e.Item.Tag == null)
            {
                _selectedFood = null;
            }
            else
            {
                Food food = (Food)e.Item.Tag;
                _selectedFood = food;
            }

            editButton.Enabled = _selectedFood != null;
            removeButton.Enabled = _selectedFood != null;
        }

        private void UpdateFoodList(List<Food> list)
        {
            foodList.Items.Clear();
            foodList.LargeImageList!.Images.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Food food = list[i];
                Image img = Image.FromFile(!string.IsNullOrEmpty(food.ImagePath) ? food.ImagePath : "img-fallback.jpg");

                foodList.LargeImageList!.Images.Add(img);
                foodList.Items.Add(new ListViewItem(food.Name, i)
                {
                    Tag = food
                });
            }
        }
    }
}
