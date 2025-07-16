namespace CafeAccounting.Views
{
    partial class FoodView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            addButton = new Button();
            editButton = new Button();
            removeButton = new Button();
            button4 = new Button();
            searchBox = new TextBox();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            foodList = new ListView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(addButton, 0, 0);
            tableLayoutPanel1.Controls.Add(editButton, 0, 1);
            tableLayoutPanel1.Controls.Add(removeButton, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 2);
            tableLayoutPanel1.Controls.Add(searchBox, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 0, 4);
            tableLayoutPanel1.Controls.Add(button6, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(670, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(250, 531);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // addButton
            // 
            tableLayoutPanel1.SetColumnSpan(addButton, 2);
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(244, 26);
            addButton.TabIndex = 0;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Dock = DockStyle.Fill;
            editButton.Enabled = false;
            editButton.Location = new Point(3, 35);
            editButton.Name = "editButton";
            editButton.Size = new Size(119, 26);
            editButton.TabIndex = 1;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Dock = DockStyle.Fill;
            removeButton.Enabled = false;
            removeButton.Location = new Point(128, 35);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(119, 26);
            removeButton.TabIndex = 2;
            removeButton.Text = "Видалити";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            tableLayoutPanel1.SetColumnSpan(button4, 2);
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 67);
            button4.Name = "button4";
            button4.Size = new Size(244, 26);
            button4.TabIndex = 3;
            button4.Text = "Застосувати фільтри";
            button4.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            tableLayoutPanel1.SetColumnSpan(searchBox, 2);
            searchBox.Dock = DockStyle.Fill;
            searchBox.Location = new Point(3, 99);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Пошук...";
            searchBox.Size = new Size(244, 23);
            searchBox.TabIndex = 4;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 131);
            button5.Name = "button5";
            button5.Size = new Size(119, 26);
            button5.TabIndex = 5;
            button5.Text = "Імпорт";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(128, 131);
            button6.Name = "button6";
            button6.Size = new Size(119, 26);
            button6.TabIndex = 6;
            button6.Text = "Експорт";
            button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(foodList);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 0, 10);
            panel1.Size = new Size(670, 531);
            panel1.TabIndex = 3;
            // 
            // foodList
            // 
            foodList.Dock = DockStyle.Fill;
            foodList.Location = new Point(10, 0);
            foodList.Name = "foodList";
            foodList.Size = new Size(660, 521);
            foodList.TabIndex = 0;
            foodList.UseCompatibleStateImageBehavior = false;
            foodList.ItemSelectionChanged += foodList_ItemSelectionChanged;
            // 
            // FoodView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "FoodView";
            Size = new Size(920, 531);
            Tag = "Страви";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button addButton;
        private Button editButton;
        private Button removeButton;
        private Panel panel1;
        private ListView foodList;
        private Button button4;
        private TextBox searchBox;
        private Button button5;
        private Button button6;
    }
}
