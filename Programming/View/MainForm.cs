using System.Data;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            //Заполняем листбокс с перечислениями.
            FillEnumListBox();

            //Выбираем по умолчанию первый элемент перечисления.
            EnumerationListBox.SelectedIndex = 0;

            //Заполняем seasonComboBox элементами перечесления Season.
            var seasonValues = Enum.GetValues(typeof(Season));
            seasonComboBox.DataSource = seasonValues;

            //Создаем и инициализируем массив прямоугольников.
            FillRectangleArray(_rectangles, 5);

            //Создаем и инициализируем массив фильмов.
            FillMovieArray(_movies);
            FillMovieListBox(_movies);
        }
        //Объявляем список прямоугольников.
        private List<Rectangle> _rectangles = new List<Rectangle>(0);
        private Rectangle _currentRectangle;
        private Rectangle _selectedRectangle;

        //Объявляем список панелей.
        private List<Panel> _rectanglePanels = new List<Panel>(0);

        //Объявляем массив фильмов.
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

        /// <summary>
        /// Заполняем массив фильмов.
        /// </summary>
        /// <param name="movies"></param>
        public void FillMovieArray(Movie[] movies)
        {
            Random rand = new Random();
            Genre genre = (Genre)0;
            MovieNames movieNames = new MovieNames();
            string selectName = movieNames.GetMovieName();
            for (int i = 0; i < movies.Length; i++)
            {
                selectName = movieNames.GetMovieName();
                movies[i] = new Movie();
                movies[i].Name = selectName;
                movies[i].Duration = rand.Next(60, 180);
                movies[i].ReleaseYear = rand.Next(1900, 2024);
                int randomIndex = ChooseRandomEnumIndex(genre);
                genre = (Genre)randomIndex;
                movies[i].Genre = genre.ToString();
                movies[i].Rating = Math.Round(rand.NextDouble() * (0 + 10), 2);
            }
        }

        /// <summary>
        /// Заполняет MoviesListBox фильмами.
        /// </summary>
        /// <param name="movies"></param>
        public void FillMovieListBox(Movie[] movies)
        {
            foreach (Movie movie in movies)
            {
                MovieListBox.Items.Add(movie.Name.ToString());
            }
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
        /// Выполняет поиск индекса фильма с максимальным рейтингом. Возвращает целое число.
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxIndex = 0;
            Double maxRating = movies[0].Rating;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// Заполняем листбокс с прямоугольниками.
        /// </summary>
        /// <param name="rectangles"></param>
        public void FillRectListBoxs(List<Rectangle> rectangles)
        {
            rectanglesListBox.Items.Clear();
            RectanglesCollisionListBox.Items.Clear();
            string rectangle;
            for (int i = 0; i < rectangles.Count; i++)
            {
                rectangle = $"{rectangles[i].ID}. (X = {rectangles[i].Center.X}; Y = {rectangles[i].Center.Y}; W = {rectangles[i].Wide}; H = {rectangles[i].Length})";
                RectanglesCollisionListBox.Items.Add(rectangle);
                rectanglesListBox.Items.Add($"Rectangle {rectangles[i].ID}");
            }
            ClearRectangleInfo();
            FindCollisions();

        }

        /// <summary>
        /// Заполняет список прямоугольников значениями.
        /// </summary>
        /// <param name="rectangles"></param>
        public void FillRectangleArray(List<Rectangle> rectangles, int rectCount)
        {
            for (int i = 0; i < rectCount; i++)
            {
                //Создает прямоугольник.
                Rectangle rect = RectangleFactory.Randomize();
                rectangles.Add(rect);

                //Создает панель.
                Panel newPanel = RectangleFactory.PanelFactory(rect);
                _rectanglePanels.Add(newPanel);
                RectanglesPanel.Controls.Add(newPanel);
                RectangleCollisions.Add(false);
            }
            FillRectListBoxs(_rectangles);
        }

        /// <summary>
        /// Очищает все текстбоксы связанные с прямоугольниками.
        /// </summary>
        public void ClearRectangleInfo()
        {
            RectanglesHeigthTextBox.Text = "";
            RectanglesWidthTextBox.Text = "";
            RectanglesXTextBox.Text = "";
            RectanglesYTextBox.Text = "";
            RectanglesIDTextBox.Text = "";
            lengthTextBox.Text = "";
            wideTextBox.Text = "";
            colourTextBox.Text = "";
            textBoxCenterX.Text = "";
            textBoxCenterY.Text = "";
            idTextBox.Text = "";
        }

        /// <summary>
        /// Выполняет поиск индекса прямоугольника с максимальной шириной. Возвращает целое число.
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int maxIndex = 0;
            int maxWide = rectangles[0].Wide;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Wide > maxWide)
                {
                    maxWide = rectangles[i].Wide;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// Выбирает случайный индекс из переданного перечисления.
        /// </summary>
        /// <param name="myEnum"></param>
        /// <returns></returns>
        public static int ChooseRandomEnumIndex(Enum myEnum)
        {
            Random rand = new Random();
            Array values = Enum.GetValues(myEnum.GetType());
            return rand.Next(0, values.Length);
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

        /// <summary>
        /// Заполняем текстбоксы на 2 вкладке значениями выбранного прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRectIndex = rectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectIndex];
            lengthTextBox.Text = _currentRectangle.Length.ToString();
            wideTextBox.Text = _currentRectangle.Wide.ToString();
            colourTextBox.Text = _currentRectangle.Colour.ToString();
            textBoxCenterX.Text = _currentRectangle.Center.X.ToString();
            textBoxCenterY.Text = _currentRectangle.Center.Y.ToString();
            idTextBox.Text = _currentRectangle.ID.ToString();
        }

        /// <summary>
        /// Проверяет введенное в colourTextBox значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (colourTextBox.Text != "")
            {
                //Получаем текст из текстбокса.
                string changedColour = colourTextBox.Text;
                //Получаем массив цветов из перечисления Colour.
                string[] colours = Enum.GetNames(typeof(Colour));
                //Сравниваем.
                foreach (string colour in colours)
                {
                    if (colour != changedColour)
                    {
                        colourTextBox.BackColor = Color.Orange;
                    }
                    else
                    {
                        colourTextBox.BackColor = Color.White;
                        _currentRectangle.Colour = colour;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Проверяет введенное в lengthTextBox значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lengthTextBox.Text != "")
            {
                string currentText = lengthTextBox.Text;
                try
                {
                    Double.Parse(currentText);
                    lengthTextBox.BackColor = Color.White;
                    _currentRectangle.Length = int.Parse(currentText);
                }
                catch (Exception ex)
                {
                    lengthTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяет введенное в wideTextBox значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wideTextBox_TextChanged(object sender, EventArgs e)
        {
            if (wideTextBox.Text != "")
            {
                string currentText = wideTextBox.Text;
                try
                {
                    int.Parse(currentText);
                    wideTextBox.BackColor = Color.White;
                    _currentRectangle.Wide = int.Parse(currentText);
                }
                catch (Exception ex)
                {
                    wideTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Заполняет текстбоксы значениями выбранного фильма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMovieIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedMovieIndex];
            movieNameTextBox.Text = _currentMovie.Name.ToString();
            movieDurationTextBox.Text = _currentMovie.Duration.ToString();
            movieGenreTextBox.Text = _currentMovie.Genre.ToString();
            movieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            movieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        /// <summary>
        /// Выполняет поиск прямоугольника с максимальной шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findRectangleButton_Click(object sender, EventArgs e)
        {
            rectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Выполняет поиск фильма с максимальым рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieFindButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        /// <summary>
        /// Проверяет введенное в movieRatingTextBox значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            string currentText = movieRatingTextBox.Text;
            try
            {
                Double value = Double.Parse(currentText);
                if (value > 10 || value < 0)
                {
                    movieRatingTextBox.BackColor = Color.Orange;
                }
                else
                {
                    movieRatingTextBox.BackColor = Color.White;
                    _currentMovie.Rating = Double.Parse(currentText);
                }

            }
            catch (Exception)
            {
                movieRatingTextBox.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectPictBox_MouseMove(object sender, MouseEventArgs e)
        {
            AddRectPictBox.Size = new Size(42, 42);
            AddRectPictBox.Location = new Point(7, 200);
        }

        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectPictBox_MouseLeave(object sender, EventArgs e)
        {
            AddRectPictBox.Size = new Size(40, 40);
            AddRectPictBox.Location = new Point(8, 201);
        }
        
        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelRectPictBox_MouseMove(object sender, MouseEventArgs e)
        {
            DelRectPictBox.Size = new Size(42, 42);
            DelRectPictBox.Location = new Point(53, 200);
        }

        /// <summary>
        /// Анимируем кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelRectPictBox_MouseLeave(object sender, EventArgs e)
        {
            DelRectPictBox.Size = new Size(40, 40);
            DelRectPictBox.Location = new Point(54, 201);
        }

        /// <summary>
        /// Удаляет выбранный прямоугольник из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelRectPictBox_Click(object sender, EventArgs e)
        {
            try
            {
                _rectangles.Remove(_selectedRectangle);

                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                _rectanglePanels.RemoveAt(selectedIndex);
                RectanglesPanel.Controls.RemoveAt(selectedIndex);

                FillRectListBoxs(_rectangles);
            }
            catch (Exception ex) { }
        }

        /// <summary>
        /// Добавляет прямоугольник в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRectPictBox_Click(object sender, EventArgs e)
        {
            FillRectangleArray(_rectangles, 1);
        }

        /// <summary>
        /// Меняет значения текстбоксов в зависимости от выбранного прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesCollisionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int selectedRectIndex = RectanglesCollisionListBox.SelectedIndex;
                _selectedRectangle = _rectangles[selectedRectIndex];
                RectanglesHeigthTextBox.Text = _selectedRectangle.Length.ToString();
                RectanglesWidthTextBox.Text = _selectedRectangle.Wide.ToString();
                RectanglesXTextBox.Text = _selectedRectangle.Center.X.ToString();
                RectanglesYTextBox.Text = _selectedRectangle.Center.Y.ToString();
                RectanglesIDTextBox.Text = _selectedRectangle.ID.ToString();
            }
            catch (ArgumentOutOfRangeException) { }

        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesXTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesXTextBox.Text != "")
            {
                //Получаем текст из строки.
                string currentText = RectanglesXTextBox.Text;
                try
                {
                    //Получаем индекс выбранного элемента.
                    int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                    //Пробуем парсить.
                    int x = int.Parse(currentText);
                    //Проверяем, находится ли введенное число в заданном диапазоне.
                    Validator.AssertValueInRange(x, 50, 405);
                    RectanglesXTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Center = new Point2D(x, _selectedRectangle.Center.Y);
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Location = new Point(_selectedRectangle.Center.X, _selectedRectangle.Center.Y);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesXTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesYTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesYTextBox.Text != "")
            {
                //Получаем индекс выбранного элемента.
                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                //Получаем текст из строки.
                string currentText = RectanglesYTextBox.Text;
                try
                {
                    //Пробуем парсить.
                    int y = int.Parse(currentText);
                    //Проверяем, находится ли введенное число в заданном диапазоне.
                    Validator.AssertValueInRange(y, 50, 445);
                    RectanglesYTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Center = new Point2D(_selectedRectangle.Center.X, y);
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Location = new Point(_selectedRectangle.Center.X, _selectedRectangle.Center.Y);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesYTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesWidthTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {

            if (RectanglesWidthTextBox.Text != "")
            {
                //Получаем индекс выбранного элемента.
                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                //Получаем текст из строки.
                string currentText = RectanglesWidthTextBox.Text;
                try
                {
                    //Пробуем парсить.
                    int width = int.Parse(currentText);
                    //Проверяем, находится ли введенное число в заданном диапазоне.
                    Validator.AssertValueInRange(width, 1, 50);
                    RectanglesWidthTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Wide = width;
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Size = new Size(_selectedRectangle.Wide, _selectedRectangle.Length);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesWidthTextBox.BackColor = Color.Orange;
                }
            }
        }

        /// <summary>
        /// Проверяем введенное в <see cref="RectanglesHeigthTextBox"/> значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesHeigthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesHeigthTextBox.Text != "")
            {
                //Получаем индекс выбранного элемента.
                int selectedIndex = RectanglesCollisionListBox.SelectedIndex;
                //Получаем текст из строки.
                string currentText = RectanglesHeigthTextBox.Text;
                try
                {
                    //Пробуем парсить.
                    int heigth = int.Parse(currentText);
                    //Проверяем, находится ли введенное число в заданном диапазоне.
                    Validator.AssertValueInRange(heigth, 1, 50);
                    RectanglesHeigthTextBox.BackColor = Color.White;
                    //Меняем поля прямоугольника.
                    _selectedRectangle.Length = heigth;
                    RectanglesCollisionListBox.Items[selectedIndex] = $"{_selectedRectangle.ID}. (X = {_selectedRectangle.Center.X}; Y = {_selectedRectangle.Center.Y}; W = {_selectedRectangle.Wide}; H = {_selectedRectangle.Length})";
                    //Меняем соотвествующую панельку.
                    _rectanglePanels[selectedIndex].Size = new Size(_selectedRectangle.Wide, _selectedRectangle.Length);
                    FindCollisions();
                }
                catch (Exception ex)
                {
                    RectanglesHeigthTextBox.BackColor = Color.Orange;
                }
            }
        }

        //Список для хранения информации о пересечении прямоугольников.
        List<bool> RectangleCollisions = new List<bool>();

        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    bool isCollision = CollisionManager.IsCollision(_rectangles[i], _rectangles[j]);
                    if (isCollision && (i != j))
                    {
                        RectangleCollisions[i] = true;
                        break;
                    }
                    RectangleCollisions[i] = false;
                }
                //Если пересекаются то перекрашиваем.
                if (RectangleCollisions[i] && _rectanglePanels[i].BackColor == Color.FromArgb(127, 127, 255, 127))
                {
                    _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                }
                if (!RectangleCollisions[i] && _rectanglePanels[i].BackColor == Color.FromArgb(127, 255, 127, 127))
                {
                    _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                }
            }

        }

    }
}
