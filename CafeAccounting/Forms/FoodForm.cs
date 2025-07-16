using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeAccounting.Logic;
using CafeAccounting.Models;

namespace CafeAccounting.Forms
{
    public partial class FoodForm : Form
    {
        public Food Food;
        private FormValidator _validator;

        public FoodForm(Food? food = null)
        {
            InitializeComponent();

            Food = food ?? new Food();
            if (food != null)
            {
                Text = "Редагування страви";
                addButton.Text = "Зберегти зміни";
            }

            nameInput.Text = Food.Name;
            imagePathInput.Text = Food.ImagePath;
            imagePreviewBox.Image = Image.FromFile(!string.IsNullOrEmpty(Food.ImagePath) ? Food.ImagePath : "img-fallback.jpg");
            priceInput.Value = (decimal)Food.Price;
            availabilityInput.Value = Food.AvailableCount;
            orderCountInput.Value = Food.TotalOrderCount;

            _validator = new FormValidator(this, addButton);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Food.Name = nameInput.Text;
            Food.ImagePath = imagePathInput.Text;
            Food.Price = (double)priceInput.Value;
            Food.AvailableCount = (int)availabilityInput.Value;
            Food.TotalOrderCount = (int)orderCountInput.Value;

            DialogResult = DialogResult.OK;
        }

        private void imageSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Зображення (.jpg, .jpeg, .png, .webp)|*.jpg;*.jpeg;*.png;*.webp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePathInput.Text = openFileDialog.FileName;
                imagePreviewBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
