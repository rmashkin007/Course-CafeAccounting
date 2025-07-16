using CafeAccounting.Logic;
using CafeAccounting.Models;
using CafeAccounting.Views;

namespace CafeAccounting.Forms;

public partial class MainForm : Form
{
    private ExtendedCollection[] _databases;
    private UserControl[] _views;

    public MainForm()
    {
        InitializeComponent();

        _databases = new ExtendedCollection[]
        {
            new Database<Order>("Orders"),
            new Database<Food>("Food")
        };

        _views = new UserControl[]
        {
            new OrdersView((Database<Order>)_databases[0]),
            new FoodView((Database<Food>)_databases[1])
        };

        mainContainer.Controls.Add(_views[0]);

        CreateViewSwitches();
    }

    /// <summary>
    /// Створює список кнопок для перемикання вкладок та додає їх до viewButtonContainer
    /// </summary>
    private void CreateViewSwitches()
    {
        for (int i = 0; i < _views.Length; i++)
        {
            int leftPadding = 10 * (i + 1) + i * 150;

            Button viewSwitcher = new Button()
            {
                Text = _views[i].Tag!.ToString(),
                Width = 150,
                Height = 28,
                Left = leftPadding,
                Top = 10
            };

            int innerI = i;
            viewSwitcher.Click += (_, _) =>
            {
                UserControl selectedView = (UserControl)mainContainer.Controls[0];
                UserControl wantedView = _views[innerI];

                if (wantedView.Tag!.Equals(selectedView.Tag))
                    return;

                wantedView.Dock = DockStyle.Fill;

                mainContainer.Controls.Clear();
                mainContainer.Controls.Add(wantedView);
            };

            viewButtonContainer.Controls.Add(viewSwitcher);
        }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        foreach (ExtendedCollection collection in _databases)
        {
            collection.SaveToFile();
        }
    }
}