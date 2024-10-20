using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Classes.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public CartsTab()
        {
            InitializeComponent();
        }

        private void CartsTab_Load(object sender, EventArgs e)
        {
        }

        private Customer CurrentCustomer {  get; set; }

        private int _cartListBoxSelectedIndex;

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Заполняет листбокс товарами.
        /// </summary>
        private void FillItemsListbox()
        {
            //Очищает.
            ItemsListBox.Items.Clear();

            //Заполняет.
            foreach (Item item in Items)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }

        }

        /// <summary>
        /// Заполняет комбобокс значениями.
        /// </summary>
        private void FillCustomersComboBox()
        {
            CustomersComboBox.Items.Clear();
            foreach (Customer customer in Customers)
            {
                CustomersComboBox.Items.Add($"{customer.FullName}");
            }
        }

        /// <summary>
        /// Обновляет значения товаров и покупателей.
        /// </summary>
        public void RefreshData()
        {
            FillCustomersComboBox();
            FillItemsListbox();
            CartListBox.Items.Clear();
            TotalCostLabel.Text = "0";
        }

        /// <summary>
        /// Обновляет корзину.
        /// </summary>
        private void RefreshCartListBox()
        {
            CartListBox.Items.Clear();
            //Заполняет.
            if (CurrentCustomer.CustomerCart.Items.Count != 0)
            {
                foreach (Item item in CurrentCustomer.CustomerCart.Items)
                {
                    CartListBox.Items.Add($"{item.Name}");
                }
            }
            else
            {
                CartListBox.Items.Clear ();
            }
            
            TotalCostLabel.Text = CurrentCustomer.CustomerCart.Amount.ToString();
        }

        /// <summary>
        /// Меняет выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex == -1)
            {
                CurrentCustomer = null;
                CartListBox.Items.Clear();
            }
            else
            {
                CurrentCustomer = Customers[CustomersComboBox.SelectedIndex];
                RefreshCartListBox();
            }
        }

        /// <summary>
        /// Добавляет товар в корзину выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.CustomerCart.Items.Add(Items[ItemsListBox.SelectedIndex]);
                RefreshCartListBox();
            }

        }

        /// <summary>
        /// Удаляет товар из корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.CustomerCart.Items.RemoveAt(_cartListBoxSelectedIndex);
                RefreshCartListBox();
            }
        }

        /// <summary>
        /// Полностью очищает корзину.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.CustomerCart.Items.Clear();
                RefreshCartListBox();
            }
        }

        /// <summary>
        /// Сохраняет выбранный индекс.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cartListBoxSelectedIndex = CartListBox.SelectedIndex;
        }

        /// <summary>
        /// Создаёт заказ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if ( CustomersComboBox.SelectedIndex != -1 && CurrentCustomer.CustomerCart.Items.Count != 0)
            {
                if (CurrentCustomer.IsPriority)
                {
                    DateTime deliveryDate = DateTime.Now.Date;
                    CurrentCustomer.CustomerOrders.Add(new PriorityOrder(CurrentCustomer.CustomerCart.Items, CurrentCustomer.CustomerAddress, CurrentCustomer.FullName, CurrentCustomer.CustomerCart.Amount, CurrentCustomer.ID, DeliveryTime.Morning, deliveryDate)) ;
                    CurrentCustomer.CustomerCart.Items.Clear();
                    RefreshCartListBox();
                }
                else
                {
                    CurrentCustomer.CustomerOrders.Add(new Order(CurrentCustomer.CustomerCart.Items, CurrentCustomer.CustomerAddress, CurrentCustomer.FullName, CurrentCustomer.CustomerCart.Amount, CurrentCustomer.ID));
                    CurrentCustomer.CustomerCart.Items.Clear();
                    RefreshCartListBox();
                }
                
            }
        }
    }
}
