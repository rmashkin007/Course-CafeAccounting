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
    public partial class NewFoodForm : Form
    {
        public Food FoodResult;
        private FormValidator _validator;

        public NewFoodForm()
        {
            InitializeComponent();

            _validator = new FormValidator(this, addButton);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FoodResult = new Food()
            {
                Name = nameInput.Text,
                ImagePath = imagePathInput.Text,
                Price = (double)priceInput.Value,
                AvailableCount = (int)availabilityInput.Value,
                TotalOrderCount = (int)orderCountInput.Value
            };

            DialogResult = DialogResult.OK;
        }

        private void imageSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Зображення (.jpg, .jpeg, .png, .webp)|*.jpg;*.jpeg;*.png;*.webp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePathInput.Text = openFileDialog.FileName;
            }
        }
    }
}
