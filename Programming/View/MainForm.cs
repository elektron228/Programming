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
            FillRectangleArray(_rectangles);
            FillRectListBox(_rectangles);

            //Создаем и инициализируем массив фильмов.
            FillMovieArray(_movies);
            FillMovieListBox(_movies);
        }
        //Объявляем массив прямоугольников.
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

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
        /// Заполняем листбокс с прямоугольниками.
        /// </summary>
        /// <param name="rectangles"></param>
        public void FillRectListBox(Rectangle[] rectangles)
        {
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectanglesListBox.Items.Add($"Rectangle {i + 1}");
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
        /// Заполняет массив прямоугольников значениями.
        /// </summary>
        /// <param name="rectangles"></param>
        public void FillRectangleArray(Rectangle[] rectangles)
        {
            Random random = new Random();
            Colour colour = (Colour)0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                //Получаем случайные значения длины и ширины.
                Double recLength = Math.Round(random.NextDouble() * (1.00 + 50.00), 2);
                Double recWide = Math.Round(random.NextDouble() * (1.00 + 50.00), 2);
                //Присваиваем значение длины и ширины.
                rectangles[i] = new Rectangle();
                rectangles[i].Length = recLength;
                rectangles[i].Wide = recWide;

                //Присваиваем случайное значение цвета из перечисления Colour.
                int randomIndex = ChooseRandomEnumIndex(colour);
                colour = (Colour)randomIndex;
                rectangles[i].Colour = colour.ToString();
            }
        }

        /// <summary>
        /// Выполняем поиск индекса прямоугольника с максимальной шириной. Возвращает целое число.
        /// </summary>
        /// <param name="rectangles"></param>
        /// <returns></returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxIndex = 0;
            Double maxWide = rectangles[0].Wide;
            for (int i = 0; i < rectangles.Length; i++)
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
        /// Выполняем поиск индекса фильма с максимальным рейтингом. Возвращает целое число.
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
        /// Меняем первую букву переданной строки на заглавную.
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
        /// Выполняем действие в зависимости от выбранного сезона.
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
        /// Заполняем текстбоксы значениями выбранного прямоугольника.
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
        }

        /// <summary>
        /// Проверяем введенное в colourTextBox значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colourTextBox_TextChanged(object sender, EventArgs e)
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

        /// <summary>
        /// Проверяем введенное в lengthTextBox значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            string currentText = lengthTextBox.Text;
            try
            {
                Double.Parse(currentText);
                lengthTextBox.BackColor = Color.White;
                _currentRectangle.Length = Double.Parse(currentText);
            }
            catch (Exception ex)
            {
                lengthTextBox.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Проверяем введенное в wideTextBox значение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wideTextBox_TextChanged(object sender, EventArgs e)
        {
            string currentText = wideTextBox.Text;
            try
            {
                Double.Parse(currentText);
                wideTextBox.BackColor = Color.White;
                _currentRectangle.Wide = Double.Parse(currentText);
            }
            catch (Exception ex)
            {
                wideTextBox.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Заполняем текстбоксы значениями выбранного фильма.
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
        /// Выполняем поиск прямоугольника с максимальной шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findRectangleButton_Click(object sender, EventArgs e)
        {
            rectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Выполняем поиск фильма с максимальым рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieFindButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        /// <summary>
        /// Проверяем введенное в movieRatingTextBox значение.
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
            catch (Exception ex)
            {
                movieRatingTextBox.BackColor = Color.Orange;
            }
        }
    }
}
