using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Classes;
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
            OrdersTab1.Customers = _store.Customers;
            PriorityOrdersTab1.Items = _store.Items;
            PriorityOrdersTab1.Customers = _store.Customers;

            ItemsTab1.ItemsChanged += ItemsTab_ItemsChanged;
        }

        private Store _store = new Store();

        /// <summary>
        /// Обновляет значения на вкладке с корзиной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ItemsTabControl.SelectedIndex)
            {
                case 0:
                    break; 
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    OrdersTab1.RefreshData();
                    break;
                case 4:
                    PriorityOrdersTab1.RefreshData();
                    break;
            }
            
        }

        /// <summary>
        /// Обновляет данные на вкладке с корзиной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            CartsTab1.RefreshData(); 
        }
    }
}
