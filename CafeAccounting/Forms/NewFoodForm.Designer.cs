namespace CafeAccounting.Forms
{
    partial class NewFoodForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            orderCountInput = new NumericUpDown();
            label8 = new Label();
            panel2 = new Panel();
            availabilityInput = new NumericUpDown();
            label7 = new Label();
            label1 = new Label();
            nameInput = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            priceInput = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            addButton = new Button();
            label9 = new Label();
            panel4 = new Panel();
            imagePathInput = new TextBox();
            imageSelectButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderCountInput).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availabilityInput).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 5);
            tableLayoutPanel1.Controls.Add(panel2, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(nameInput, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(addButton, 0, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(306, 251);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(orderCountInput);
            panel3.Controls.Add(label8);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(133, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 26);
            panel3.TabIndex = 8;
            // 
            // orderCountInput
            // 
            orderCountInput.Dock = DockStyle.Fill;
            orderCountInput.Location = new Point(0, 0);
            orderCountInput.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            orderCountInput.Name = "orderCountInput";
            orderCountInput.Size = new Size(144, 23);
            orderCountInput.TabIndex = 1;
            orderCountInput.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label8
            // 
            label8.Dock = DockStyle.Right;
            label8.Location = new Point(144, 0);
            label8.Name = "label8";
            label8.Size = new Size(26, 26);
            label8.TabIndex = 0;
            label8.Text = "шт";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(availabilityInput);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(133, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 26);
            panel2.TabIndex = 7;
            // 
            // availabilityInput
            // 
            availabilityInput.Dock = DockStyle.Fill;
            availabilityInput.Location = new Point(0, 0);
            availabilityInput.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            availabilityInput.Name = "availabilityInput";
            availabilityInput.Size = new Size(144, 23);
            availabilityInput.TabIndex = 1;
            availabilityInput.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label7
            // 
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(144, 0);
            label7.Name = "label7";
            label7.Size = new Size(26, 26);
            label7.TabIndex = 0;
            label7.Text = "шт";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва:";
            // 
            // nameInput
            // 
            nameInput.Dock = DockStyle.Fill;
            nameInput.Location = new Point(133, 3);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(170, 23);
            nameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Ціна:";
            // 
            // panel1
            // 
            panel1.Controls.Add(priceInput);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(133, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 26);
            panel1.TabIndex = 3;
            // 
            // priceInput
            // 
            priceInput.Dock = DockStyle.Fill;
            priceInput.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            priceInput.Location = new Point(0, 0);
            priceInput.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            priceInput.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(144, 23);
            priceInput.TabIndex = 1;
            priceInput.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // label3
            // 
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(144, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 26);
            label3.TabIndex = 0;
            label3.Text = "грн";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 104);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 4;
            label4.Text = "Категорія:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 136);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 5;
            label5.Text = "Наявність:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 168);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 6;
            label6.Text = "Кількість замовлень:";
            // 
            // addButton
            // 
            tableLayoutPanel1.SetColumnSpan(addButton, 2);
            addButton.Dock = DockStyle.Bottom;
            addButton.Location = new Point(3, 225);
            addButton.Name = "addButton";
            addButton.Size = new Size(300, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Створити";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 40);
            label9.Name = "label9";
            label9.Size = new Size(122, 15);
            label9.TabIndex = 10;
            label9.Text = "Путь до зображення:";
            // 
            // panel4
            // 
            panel4.Controls.Add(imagePathInput);
            panel4.Controls.Add(imageSelectButton);
            panel4.Location = new Point(133, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 26);
            panel4.TabIndex = 11;
            // 
            // imagePathInput
            // 
            imagePathInput.Dock = DockStyle.Fill;
            imagePathInput.Location = new Point(0, 0);
            imagePathInput.Name = "imagePathInput";
            imagePathInput.ReadOnly = true;
            imagePathInput.Size = new Size(144, 23);
            imagePathInput.TabIndex = 1;
            imagePathInput.Tag = "NoValidation";
            // 
            // imageSelectButton
            // 
            imageSelectButton.Dock = DockStyle.Right;
            imageSelectButton.Location = new Point(144, 0);
            imageSelectButton.Name = "imageSelectButton";
            imageSelectButton.Size = new Size(26, 26);
            imageSelectButton.TabIndex = 0;
            imageSelectButton.Text = "...";
            imageSelectButton.UseVisualStyleBackColor = true;
            imageSelectButton.Click += imageSelectButton_Click;
            // 
            // NewFoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 251);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewFoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Створення страви";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderCountInput).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)availabilityInput).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox nameInput;
        private Label label2;
        private Panel panel1;
        private NumericUpDown priceInput;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private NumericUpDown orderCountInput;
        private Label label8;
        private Panel panel2;
        private NumericUpDown availabilityInput;
        private Label label7;
        private Button addButton;
        private Label label9;
        private Panel panel4;
        private TextBox imagePathInput;
        private Button imageSelectButton;
    }
}