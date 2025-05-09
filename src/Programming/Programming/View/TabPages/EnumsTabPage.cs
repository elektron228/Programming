using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.TabPages
{
    public partial class EnumsTabPage : UserControl
    {
        public EnumsTabPage()
        {
            InitializeComponent();
        }

        private void EnumsTabPage_Load(object sender, EventArgs e)
        {
            //Заполняем листбокс с перечислениями.
            FillEnumListBox();

            //Выбираем по умолчанию первый элемент перечисления.
            EnumerationListBox.SelectedIndex = 0;

            //Заполняем seasonComboBox элементами перечесления Season.
            var seasonValues = Enum.GetValues(typeof(Season));
            seasonComboBox.DataSource = seasonValues;
        }

        /// <summary>
        /// Функция заполняет листбокс с перечислениями. 
        /// Значения типа string.
        /// </summary>
        public void FillEnumListBox()
        {
            //Получаем все типы в проекте
            Type[] types = typeof(Program).Assembly.GetTypes();
            //Ищем перечисления
            var enumTypes = Array.FindAll(types, type => type.IsEnum);
            //Добавляем их в листбокс
            foreach (var type in enumTypes)
            {
                EnumerationListBox.Items.Add(type.Name);
            }
        }
       
        /// <summary>
        /// Заполняет листбокс при смене выбранного перечисления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumerationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Получаем значение выбранного пункта (тип string)
            var selectedEnum = EnumerationListBox.SelectedItem;
            //Объявляем переменную для работы свитча
            var enumValues = Enum.GetValues(typeof(Colour));
            //Очищаем ValuesListBox
            ValuesListBox.Items.Clear();
            //Заполняем ValuesListBox в зависимости от выбранного пункта
            switch (selectedEnum)
            {
                case "Colour":
                    enumValues = Enum.GetValues(typeof(Colour));
                    foreach (var value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "EducationForm":
                    enumValues = Enum.GetValues(typeof(EducationForm));
                    foreach (var value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Genre":
                    enumValues = Enum.GetValues(typeof(Genre));
                    foreach (var value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Manufacturers":
                    enumValues = Enum.GetValues(typeof(Manufacturers));
                    foreach (var value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Season":
                    enumValues = Enum.GetValues(typeof(Season));
                    foreach (var value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Weekday":
                    enumValues = Enum.GetValues(typeof(Weekday));
                    foreach (var value in enumValues)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
            }
        }
        
        /// <summary>
        /// Отображает индекс элемента перечисления в текстбокс.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
       
        /// <summary>
        /// Парсинг введенного в ParseTextBox значения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParse_Click(object sender, EventArgs e)
        {
            //Получеам значение из текстбокса
            string parseTextBoxValue = ParseTextBox.Text;
            //Защита от дураков
            double number;
            parseTextBoxValue = ChangeTheLine(parseTextBoxValue);
            //Создаем переменную типа Weekday
            Weekday weekday;
            //Пробуем парсить и если да, то выводим значение в weekday
            if (Enum.TryParse(parseTextBoxValue, out weekday) && !double.TryParse(parseTextBoxValue, out number))
            {
                //Получаем индекс элемента перечисления
                var weekdayIndex = (int)weekday;
                //Выводим результат
                ParseFinishLabel.Text = $"{parseTextBoxValue} is weekday! ({parseTextBoxValue} = {weekdayIndex + 1})";
            }
            else
            {
                ParseFinishLabel.Text = $"{parseTextBoxValue} not weekday.";
            }
        }

        /// <summary>
        /// Меняет первую букву переданной строки на заглавную.
        /// </summary>
        /// <param name="str">Передаем изменяемую строку.</param>
        /// <returns>Возвращает изменённую строку.</returns>
        public string ChangeTheLine(string str)
        {
            str = str.Trim().ToLower();
            if (str.Length > 0) { return Char.ToUpper(str[0]) + str.Substring(1); }
            return "";
        }

        /// <summary>
        /// Выполняет действие в зависимости от выбранного сезона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goButton_Click(object sender, EventArgs e)
        {
            //Получаем выбранное значение
            string seasonComboBoxValue = seasonComboBox.Text;
            //Реализуем логику
            switch (seasonComboBoxValue)
            {
                case "Winter":
                    MessageBox.Show("Brrr. So cold.-_-");
                    break;
                case "Spring":
                    seasonPictureBox.BackColor = Color.GreenYellow;
                    break;
                case "Summer":
                    MessageBox.Show("Mmm. Summer is so good ^_^");
                    break;
                case "Autumn":
                    seasonPictureBox.BackColor = Color.Orange;
                    break;
            }
        }


    }
}
