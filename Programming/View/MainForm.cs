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

        //��������� �������� ��������������
        public void FillEnumListBox()
        {
            //�������� ��� ���� � �������
            Type[] types = typeof(Program).Assembly.GetTypes();
            //���� ������������
            var enumTypes = Array.FindAll(types, type => type.IsEnum);
            //��������� �� � ��������
            foreach (var type in enumTypes)
            {
                EnumerationListBox.Items.Add(type.Name);
            }
        }

        //��������� �������� ��� ����� ���������� ������������
        private void EnumerationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //�������� �������� ���������� ������ (��� string)
            var selectedEnum = EnumerationListBox.SelectedItem;
            //��������� ���������� ��� ������ ������
            var enumValues = Enum.GetValues(typeof(Genre));
            //������� ValuesListBox
            ValuesListBox.Items.Clear();
            //��������� ValuesListBox � ����������� �� ���������� ������
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
        //���������� ������ � ���������
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
        //������ ��� ������
        private void buttonParse_Click(object sender, EventArgs e)
        {
            //�������� �������� �� ����������
            string parseTextBoxValue = ParseTextBox.Text;
            //������ �� �������
            parseTextBoxValue = parseTextBoxValue.Trim().ToLower();
            parseTextBoxValue = FirstLetterToUpper(parseTextBoxValue);
            //������� ���������� ���� Weekday
            Weekday weekday;
            //������� ������� � ���� ��, �� ������� �������� � weekday
            if (Enum.TryParse(parseTextBoxValue, out weekday))
            {
                //�������� ������ �������� ������������
                var weekdayIndex = (int)weekday;
                //������� ���������
                ParseFinishLabel.Text = $"{parseTextBoxValue} is weekday! ({parseTextBoxValue} = {weekdayIndex + 1})";
            }
            else
            {
                ParseFinishLabel.Text = $"{parseTextBoxValue} not weekday.";
            }
        }
        //��������� ������ ����� ������ � ������� �������
        public static string FirstLetterToUpper(string str)
        {
            if (str.Length > 0) { return Char.ToUpper(str[0]) + str.Substring(1); }
            return "";
        }
        //������ ���-�� ��� ������ ������
        private void goButton_Click(object sender, EventArgs e)
        {
            //�������� ��������� ��������
            string seasonComboBoxValue = seasonComboBox.Text;
            //��������� ������
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
