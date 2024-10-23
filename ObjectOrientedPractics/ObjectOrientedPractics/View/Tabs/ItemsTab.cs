using ObjectOrientedPractics.Model;
using ObjectOrientedPractics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Classes;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            CategoryComboBox.SelectedItem = null;
        }

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items ;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _selectedItem;

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Создаёт новый товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item("Example name", "Example description", 100));
            FillItemsListbox();
        }

        /// <summary>
        /// Удаляет выбранный товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_selectedItem);
            FillItemsListbox();
            ClearTextBoxs();
        }

        /// <summary>
        /// Заполняет листбокс товарами.
        /// </summary>
        private void FillItemsListbox()
        {
            //Очищает.
            ItemsListBox.Items.Clear();

            //Заполняет.
            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }

        }

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        private void UpdateTextBoxs()
        {
            _selectedItem = _items[ItemsListBox.SelectedIndex];
            NameTextBox.Text = _selectedItem.Name.ToString();
            IDTextBox.Text = _selectedItem.ID.ToString();
            CostTextBox.Text = _selectedItem.Cost.ToString();
            DescriptionTextBox.Text = _selectedItem.Info.ToString();
            CategoryComboBox.SelectedItem = _selectedItem.Category;
        }

        /// <summary>
        /// Очищает текстбоксы.
        /// </summary>
        private void ClearTextBoxs()
        {
            NameTextBox.Clear();
            CostTextBox.Clear();
            IDTextBox.Clear();
            DescriptionTextBox.Clear();
            CategoryComboBox.SelectedItem = null;
        }

        /// <summary>
        /// Обновляет текстбоксы при изменении индекса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                UpdateTextBoxs();

            }
            else
            {
                ClearTextBoxs();
            }
        }

        /// <summary>
        /// Изменяет название товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                FillItemsListbox();
            }
            catch (Exception)
            {
                NameTextBox.BackColor = Color.Orange;
            }

        }

        /// <summary>
        /// Изменяет стоимость товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedItem.Cost = float.Parse(CostTextBox.Text);
                CostTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (CostTextBox.Text != "")
                {
                    CostTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Изменяеи описание товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedItem.Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                DescriptionTextBox.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Изменяет категорию товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ourCateg = CategoryComboBox.Text;
                Category category = (Category)Enum.Parse(typeof(Category), ourCateg);
                _selectedItem.Category = category;
            }
            catch (Exception) { }
        }
    }
}
