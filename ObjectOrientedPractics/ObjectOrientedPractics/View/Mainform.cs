using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            ItemsTab1.Items = _store.Items;
            CustomersTab1.Customers = _store.Customers;
            CartsTab1.Items = _store.Items;
            CartsTab1.Customers = _store.Customers;
        }

        private Store _store = new Store();

        /// <summary>
        /// Обновляет значения на вкладке с корзиной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsTabControl.SelectedIndex == 2)
            {
                CartsTab1.RefreshData();
            }
        }
    }
}
