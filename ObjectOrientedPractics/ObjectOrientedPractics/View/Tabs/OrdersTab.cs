using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Classes;
using ObjectOrientedPractics.Model.Classes.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public OrdersTab()
        {
            InitializeComponent();
        }

        
        private void OrdersTab_Load(object sender, EventArgs e)
        {
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            StatusComboBox.SelectedItem = null;
            PriorityOptionsPanel.Visible = false;

            DeliverytimeComboBox.DataSource = _desiredDeliveryTime;
            DeliverytimeComboBox.SelectedItem = null;
            AddressControl1.DisableTextBoxs();
        }

        private int _selectedOrderIndex;

        private string ourStatus;

        private string _selectedDeliveryTime;

        private string[] _desiredDeliveryTime = new string[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };

        private Order _selectedorder;

        private PriorityOrder _selectedPriorityOrder;

        private List<Order> _orders = new List<Order>();

        public List<Customer> Customers { get; set; }

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
            foreach(Customer customer in Customers)
            {
                if(customer.CustomerOrders.Count != 0)
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
            foreach(Order order in _orders)
            {
                OrdersDataGridView.Rows.Add(order.ID, order.CreationDate, order.Status, order.CustomerFullName, 
                    $"{order.CustomerAddress.Country},{order.CustomerAddress.City}{order.CustomerAddress.Street},{order.CustomerAddress.Building},{order.CustomerAddress.Apartment}", 
                    order.Amount, order.TotalPrice);
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
                _selectedorder = _orders[_selectedOrderIndex];
               
                if (_selectedorder is PriorityOrder)
                {
                    PriorityOptionsPanel.Visible = true;
                    _selectedPriorityOrder = _orders[_selectedOrderIndex] as PriorityOrder;
                    DeliverytimeComboBox.SelectedIndex = ((int)_selectedPriorityOrder.DesiredDeliveryTime - 1);
                }
                else if (_selectedorder is Order)
                {
                    PriorityOptionsPanel.Visible = false;
                    _selectedPriorityOrder = null;
                }

                AddressControl1.OurAddress = _orders[_selectedOrderIndex].CustomerAddress;
                AddressControl1.UpdateTextBoxs();
                IdTextBox.Text = _selectedorder.ID.ToString();
                CreatedDateTextBox.Text = _selectedorder.CreationDate.ToString();
                StatusComboBox.SelectedItem = _selectedorder.Status;
                TotalCostLabel.Text = _selectedorder.Amount.ToString();
                TotalPriceLabel.Text = _selectedorder.TotalPrice.ToString();
                FillOrderItemsListBox();
            }
            catch(Exception) { }
        }

        /// <summary>
        /// Заполняет листбокс товарами заказа.
        /// </summary>
        private void FillOrderItemsListBox()
        {
            OrderItemsListBox.Items.Clear();
            foreach (Item item in _orders[_selectedOrderIndex].Items)
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
                ourStatus = StatusComboBox.Text;
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
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Morning;
                        break;
                    case "11:00 - 13:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Lunch;
                        break;
                    case "13:00 - 15:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Afternoon;
                        break;
                    case "15:00 - 17:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Evening;
                        break;
                    case "17:00 - 19:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.LateEvening;
                        break;
                    case "19:00 - 21:00":
                        _selectedPriorityOrder.DesiredDeliveryTime = DeliveryTime.Night;
                        break;
                }
            }
            catch (Exception) { }
        }
    }
}

