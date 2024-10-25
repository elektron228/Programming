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
using ObjectOrientedPractics.Services;
using System.Net.NetworkInformation;

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
            _displayedItems = _items;
            SortByComboBox.DataSource = _sorts;
            SortByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items ;

        private List<Item> _displayedItems = new List<Item>();

        public event EventHandler ItemsChanged;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _selectedItem;

        private string[] _sorts = new string[] {"Name", "Cost (Ascending", "Cost (Descending)" };

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
            SortByComboBox_SelectedIndexChanged(sender, e);
            FillItemsListbox();
            OnItemsChanged();
        }

        /// <summary>
        /// Удаляет выбранный товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_selectedItem);
            SortByComboBox_SelectedIndexChanged(sender, e);
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
            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }

        }

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        private void UpdateTextBoxs()
        {
            _selectedItem = _displayedItems[ItemsListBox.SelectedIndex];
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

        /// <summary>
        /// Выполнет поиск по имени товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchStringTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = SearchStringTextBox.Text;
            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Фильтрация по подстроке в имени
                _displayedItems = new DataTools().Filter(_items, p => p.Name.Contains(searchTerm));
                FillItemsListbox();
            }
            else
            {
                _displayedItems = _items;
                // Отображение всех продуктов
                FillItemsListbox();
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTools dataTools = new DataTools();
            switch (SortByComboBox.SelectedIndex)
            {
                case 0:
                    if (!string.IsNullOrEmpty(SearchStringTextBox.Text))
                    {
                        _displayedItems = dataTools.Sort(_displayedItems, new DataTools.SortCriteria(dataTools.SortByName));
                        FillItemsListbox();
                    }
                    else
                    {
                        _displayedItems = dataTools.Sort(_items, new DataTools.SortCriteria(dataTools.SortByName));
                        FillItemsListbox();

                    }
                    
                    break;
                case 1:
                    if (!string.IsNullOrEmpty(SearchStringTextBox.Text))
                    {
                        _displayedItems = dataTools.Sort(_displayedItems, new DataTools.SortCriteria(dataTools.SortByPriceAscending));
                        FillItemsListbox();
                    }
                    else
                    {
                        _displayedItems = dataTools.Sort(_items, new DataTools.SortCriteria(dataTools.SortByPriceAscending));
                        FillItemsListbox();

                    }
                    break;
                case 2:
                    if (!string.IsNullOrEmpty(SearchStringTextBox.Text))
                    {
                        _displayedItems = dataTools.Sort(_displayedItems, new DataTools.SortCriteria(dataTools.SortByPriceDescending));
                        FillItemsListbox();
                    }
                    else
                    {
                        _displayedItems = dataTools.Sort(_items, new DataTools.SortCriteria(dataTools.SortByPriceDescending));
                        FillItemsListbox();

                    }
                    break;
                default:
                    _displayedItems = _items;
                    FillItemsListbox();
                    break;
            }
        }
        private void OnItemsChanged()
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
