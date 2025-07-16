namespace CafeAccounting.Forms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        viewButtonContainer = new Panel();
        mainContainer = new Panel();
        SuspendLayout();
        // 
        // viewButtonContainer
        // 
        viewButtonContainer.Dock = DockStyle.Top;
        viewButtonContainer.Location = new Point(0, 0);
        viewButtonContainer.Name = "viewButtonContainer";
        viewButtonContainer.Size = new Size(800, 48);
        viewButtonContainer.TabIndex = 0;
        // 
        // mainContainer
        // 
        mainContainer.Dock = DockStyle.Fill;
        mainContainer.Location = new Point(0, 48);
        mainContainer.Name = "mainContainer";
        mainContainer.Size = new Size(800, 402);
        mainContainer.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(mainContainer);
        Controls.Add(viewButtonContainer);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Облік замовлень кафе";
        FormClosing += MainForm_FormClosing;
        ResumeLayout(false);
    }

    #endregion

    private Panel viewButtonContainer;
    private Panel mainContainer;
}