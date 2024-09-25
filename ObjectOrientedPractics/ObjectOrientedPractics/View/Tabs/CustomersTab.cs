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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            FillCustomersListbox();
        }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _selectedCustomer;

        /// <summary>
        /// Заполняет листбокс покупателями.
        /// </summary>
        private void FillCustomersListbox()
        {
            //Очищает.
            CustomersListBox.Items.Clear();

            //Заполняет.
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.FullName}");
            }

        }

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        private void UpdateTextBoxs()
        {
            _selectedCustomer = _customers[CustomersListBox.SelectedIndex];
            CustomerAddressControl.OurAddress = _selectedCustomer.CustomerAddress;
            FullNameTextBox.Text = _selectedCustomer.FullName;
            IDTextBox.Text = _selectedCustomer.ID.ToString();
            CustomerAddressControl.UpdateTextBoxs();

        }

        /// <summary>
        /// Очищает текстбоксы.
        /// </summary>
        private void ClearTextBoxs()
        {
            FullNameTextBox.Clear();
            IDTextBox.Clear();
            CustomerAddressControl.ClearTextBoxs();
        }

        /// <summary>
        /// Добавляет покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Customer("Example full name", new Address()));
            FillCustomersListbox();
        }

        /// <summary>
        /// Удаляет покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_selectedCustomer);
            FillCustomersListbox();
            ClearTextBoxs();
        }

        /// <summary>
        /// Обновляет текстбоксы при изменении индекса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                UpdateTextBoxs();
            }
            else
            {
                ClearTextBoxs();
            }
        }

        /// <summary>
        /// Изменяет имя покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedCustomer.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                FullNameTextBox.BackColor = Color.Orange;
            }
        }

        
    }
}