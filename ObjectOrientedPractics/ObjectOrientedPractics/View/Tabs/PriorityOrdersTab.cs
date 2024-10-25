using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            StatusComboBox.SelectedItem = null;

            DeliverytimeComboBox.DataSource = _desiredDeliveryTime;
            DeliverytimeComboBox.SelectedItem = null;

            AddressControl1.DisableTextBoxs();

        }

        private int _selectedOrderIndex;

        private string _selectedDeliveryTime;

        private string[] _desiredDeliveryTime = new string[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };

        private int _selectedCustomerId;

        private PriorityOrder _selectedorder;

        private List<Order> _orders = new List<Order>();
        
        private List<PriorityOrder> _priorityOrders = new List<PriorityOrder>();

        private Random rand = new Random();


        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Обновляет данные при переключении на вкладку.
        /// </summary>
        public void RefreshData()
        {
            RefreshOrdersList();
            RefreshDataGrid();
        }

        /// <summary>
        /// Обновляет список заказов.
        /// </summary>
        private void RefreshOrdersList()
        {
            _orders.Clear();
            _priorityOrders.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.CustomerOrders.Count != 0)
                {
                    foreach (Order order in customer.CustomerOrders)
                    {
                        _orders.Add(order);
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет таблицу с заказами.
        /// </summary>
        private void RefreshDataGrid()
        {
            OrdersDataGridView.Rows.Clear();
            foreach (Order order in _orders)
            {
                if (order is PriorityOrder)
                {
                    _priorityOrders.Add(order as PriorityOrder);
                }

            }
            foreach (PriorityOrder order in _priorityOrders)
            {
                OrdersDataGridView.Rows.Add(order.ID, order.CreationDate, order.Status, order.CustomerFullName,
                $"{order.CustomerAddress.Country},{order.CustomerAddress.City}{order.CustomerAddress.Street},{order.CustomerAddress.Building},{order.CustomerAddress.Apartment}",
                order.Amount);
            }
        }

        /// <summary>
        /// Меняет значения в текстбоксах при выборе заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedOrderIndex = OrdersDataGridView.SelectedRows[0].Index;
                _selectedorder = _priorityOrders[_selectedOrderIndex];
                AddressControl1.OurAddress = _orders[_selectedOrderIndex].CustomerAddress;
                AddressControl1.UpdateTextBoxs();
                IdTextBox.Text = _selectedorder.ID.ToString();
                CreatedDateTextBox.Text = _selectedorder.CreationDate.ToString();
                StatusComboBox.SelectedItem = _selectedorder.Status;
                TotalCostLabel.Text = _selectedorder.Amount.ToString();
                DeliverytimeComboBox.SelectedIndex = ((int)_selectedorder.DesiredDeliveryTime - 1);
                FillOrderItemsListBox();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Заполняет листбокс товарами заказа.
        /// </summary>
        private void FillOrderItemsListBox()
        {
            OrderItemsListBox.Items.Clear();
            foreach (Item item in _priorityOrders[_selectedOrderIndex].Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }


        }

        /// <summary>
        /// Изменяет статус заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ourStatus = StatusComboBox.Text;
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), ourStatus);
                _selectedorder.Status = orderStatus;
                OrdersDataGridView.SelectedRows[0].Cells[2].Value = orderStatus;
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Изменяет время доставки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliverytimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedDeliveryTime = DeliverytimeComboBox.Text;
                switch (_selectedDeliveryTime)
                {
                    case "9:00 - 11:00":
                        _selectedorder.DesiredDeliveryTime = DeliveryTime.Morning;
                        break;
                    case "11:00 - 13:00":
                        _selectedorder.DesiredDeliveryTime = DeliveryTime.Lunch;
                        break;
                    case "13:00 - 15:00":
                        _selectedorder.DesiredDeliveryTime = DeliveryTime.Afternoon;
                        break;
                    case "15:00 - 17:00":
                        _selectedorder.DesiredDeliveryTime = DeliveryTime.Evening;
                        break;
                    case "17:00 - 19:00":
                        _selectedorder.DesiredDeliveryTime = DeliveryTime.LateEvening;
                        break;
                    case "19:00 - 21:00":
                        _selectedorder.DesiredDeliveryTime = DeliveryTime.Night;
                        break;
                }
            }
            catch (Exception) { }
            
        }

        /// <summary>
        /// Добавляет случайный товар в заказ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdditemButton_Click(object sender, EventArgs e)
        {
            _selectedorder.Items.Add(Items[rand.Next(Items.Count)]);
            RefreshData();
        }

        /// <summary>
        /// Удаляет выбранный товар из заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _selectedorder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            RefreshData();
        }

        /// <summary>
        /// Пересоздааёт заказ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            DateTime deliveryDate = DateTime.Now.Date;
            _selectedCustomerId = _selectedorder.CustomerId;
            
            foreach (var customer in Customers)
            {
                if (customer.ID == _selectedCustomerId)
                {
                    foreach (var order in customer.CustomerOrders)
                    {
                        if (order.ID == _selectedorder.ID)
                        {
                            customer.CustomerOrders.Remove(order);
                            break;
                        }
                    }
                    customer.CustomerOrders.Add(new PriorityOrder(customer.CustomerCart.Items, customer.CustomerAddress, customer.FullName, customer.CustomerCart.Amount, customer.ID, DeliveryTime.Morning, deliveryDate));
                    RefreshData();
                    break;
                }
            }
            
            
        }
    }
}
