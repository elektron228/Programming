using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Заполняет комбобокс значениями перечисления.
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Categories));
            CategoryComboBox.SelectedItem = null;
            //Создает папку в appdata.
            Directory.CreateDirectory(Environment.ExpandEnvironmentVariables(@"%appdata%\Laba8"));
            //Если файл не существует, то создает его.
            CheckFileIsCreate();
            //Загружает товары из файла.
            LoadProductsFromFile();
            //Отключает возможность редактировать текстбоксы.
            ChangeEnabled();
        }
        
        //Список товаров.
        private List<Product> _products = new List<Product>();
        //Выбранный товар.
        private Product _currentProduct;
        //Путь сохранения.
        private string _filePath = Path.Combine(Environment.ExpandEnvironmentVariables(@"%appdata%\Laba8"), "data.txt");
        //Проверяет, включен ли режим редактирования.
        private bool _isChanged = true;

        /// <summary>
        /// Позволяет или запрещает редактировать текстбоксы.
        /// </summary>
        private void ChangeEnabled()
        {
            NameTextBox.Enabled = !NameTextBox.Enabled;
            ManufacturerTextBox.Enabled = !ManufacturerTextBox.Enabled;
            CategoryComboBox.Enabled = !CategoryComboBox.Enabled;
            CountTextBox.Enabled = !CountTextBox.Enabled;

        }

        /// <summary>
        /// Проверяет, существует ли файл.
        /// </summary>
        private void CheckFileIsCreate()
        {
            if (!File.Exists(_filePath))
            {
                FileStream fstream = File.Create(_filePath);
                fstream.Close();
            }
        }

        /// <summary>
        /// Сохраняет товары в файл.
        /// </summary>
        private void SaveProductsToFile()
        {
            File.WriteAllText(_filePath, string.Empty);

            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                foreach (Product product in _products)
                {
                    string line = $"{product.Name};{product.Manufacturer};{product.Category};{product.Count}";
                    writer.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// Загружает товары из файла.
        /// </summary>
        private void LoadProductsFromFile()
        {
            string[] lines = File.ReadAllLines(_filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] info = line.Split(';') ;
                if (info.Length >= 4)
                {
                    Product product = new Product(info[0], info[1], (Categories)Enum.Parse(typeof(Categories), info[2]), Convert.ToInt32(info[3]));

                    _products.Add(product);
                }
            }
            FillProductsListbox();
        }

        /// <summary>
        /// Заполняет листбокс товарами.
        /// </summary>
        private void FillProductsListbox()
        {
            //Очищает.
            ProductsListBox.Items.Clear();
            //Сортирует.
            _products.Sort((x, y) => String.Compare(x.Name, y.Name));
            //Заполняет.
            foreach (Product product in this._products)
            {
                ProductsListBox.Items.Add($"{product.Name}");
            }
            _isChanged = false;
            //Сохраняет.
            SaveProductsToFile();
        }

        /// <summary>
        /// Создает новый товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Categories category = Categories.NewCategory;
            Product newProduct = new Product("Название товара", "Производитель товара", category, 1);
            _products.Add(newProduct);
            FillProductsListbox();
        }

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        private void UpdateTextBoxs()
        {
            _currentProduct = _products[ ProductsListBox.SelectedIndex ];
            NameTextBox.Text = _currentProduct.Name;
            ManufacturerTextBox.Text = _currentProduct.Manufacturer;
            CountTextBox.Text = _currentProduct.Count.ToString();
            CategoryComboBox.SelectedItem = _currentProduct.Category;
        }

        /// <summary>
        /// Очищает текстбоксы.
        /// </summary>
        private void ClearTextBoxs()
        {
            NameTextBox.Clear();
            ManufacturerTextBox.Clear();
            CountTextBox.Clear();
            CategoryComboBox.SelectedItem = null;
        }

        /// <summary>
        /// Обновляет текстбоксы при изменении индекса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ProductsListBox.SelectedIndex != -1)
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
                Validator.AssertOnStringLength(NameTextBox.Text);
                _currentProduct.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                NameTextBox.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Изменяет производителя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManufacturerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Validator.AssertOnStringLength(ManufacturerTextBox.Text);
                _currentProduct.Manufacturer = ManufacturerTextBox.Text;
                ManufacturerTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                ManufacturerTextBox.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Изменяет количество товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int32.Parse(CountTextBox.Text);
                Validator.AssertOnPositiveValue(Int32.Parse(CountTextBox.Text));
                _currentProduct.Count = int.Parse(CountTextBox.Text);
                CountTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (CountTextBox.Text != "")
                {
                    CountTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Позволяет редактировать товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditProductPictureBox_Click(object sender, EventArgs e)
        {
            ChangeEnabled();
            if (_isChanged)
            {
                FillProductsListbox();
            }
            _isChanged = true;
        }

        /// <summary>
        /// Удаляет выбранный товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProductPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            _products.RemoveAt(ProductsListBox.SelectedIndex);
            FillProductsListbox();
            ClearTextBoxs() ;
        }

        private void CategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string ourCateg = CategoryComboBox.Text;
                Categories category = (Categories)Enum.Parse(typeof(Categories), ourCateg);
                _currentProduct.Category = category;
            }
            catch (Exception) { }
        }
    }
}
