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

namespace CafeAccounting.Views
{
    public partial class OrdersView : UserControl
    {
        public OrdersView(Database<Order> orderDatabase)
        {
            InitializeComponent();
        }
    }
}
