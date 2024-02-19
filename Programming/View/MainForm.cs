namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillEnumListBox();
            EnumerationListBox.SelectedIndex = 0;
            var seasonValues = Enum.GetValues(typeof(Season));
            seasonComboBox.DataSource = seasonValues;
        }

        //Заполняем листбокс перечислениями
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

        //Заполняем листбокс при смене выбранного перечисления
        private void EnumerationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Получаем значение выбранного пункта (тип string)
            var selectedEnum = EnumerationListBox.SelectedItem;
            //Объявляем переменную для работы свитча
            var enumValues = Enum.GetValues(typeof(Genre));
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
        //Отображаем индекс в текстбокс
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
        //Парсим дни недели
        private void buttonParse_Click(object sender, EventArgs e)
        {
            //Получеам значение из текстбокса
            string parseTextBoxValue = ParseTextBox.Text;
            //Защита от дураков
            parseTextBoxValue = parseTextBoxValue.Trim().ToLower();
            parseTextBoxValue = FirstLetterToUpper(parseTextBoxValue);
            //Создаем переменную типа Weekday
            Weekday weekday;
            //Пробуем парсить и если да, то выводим значение в weekday
            if (Enum.TryParse(parseTextBoxValue, out weekday))
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
        //Переводим первую букву строки в верхний регистр
        public static string FirstLetterToUpper(string str)
        {
            if (str.Length > 0) { return Char.ToUpper(str[0]) + str.Substring(1); }
            return "";
        }
        //Делаем что-то при выборе сезона
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
