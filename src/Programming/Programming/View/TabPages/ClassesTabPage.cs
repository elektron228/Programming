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
    public partial class ClassesTabPage : UserControl
    {
        public ClassesTabPage()
        {
            InitializeComponent();
        }
        private void ClassesTabPage_Load(object sender, EventArgs e)
        {
            FillRectangleArray(_rectangles);
            FillRectListBox(_rectangles);

            //Создаем и инициализируем массив фильмов.
            FillMovieArray(_movies);
            FillMovieListBox(_movies);
        }

        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        //Объявляем массив фильмов.
        private Movie[] _movies = new Movie[5];
        private Movie _currentMovie;

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
                int recLength = random.Next(20, 100);
                int recWide = random.Next(20, 100);
                //Присваиваем значение длины и ширины.

                //Присваиваем случайное значение цвета из перечисления Colour.
                int randomIndex = ChooseRandomEnumIndex(colour);
                colour = (Colour)randomIndex;
                
                
                rectangles[i] = new Rectangle(recWide, recLength, colour.ToString());
            }
        }


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
        /// Очищает все текстбоксы связанные с прямоугольниками.
        /// </summary>
        public void ClearRectangleInfo()
        {
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
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxIndex = 0;
            int maxWide = rectangles[0].Wide;
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
        /// Выполняет поиск прямоугольника с максимальной шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findRectangleButton_Click(object sender, EventArgs e)
        {
            rectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Заполняем листбокс с прямоугольниками.
        /// </summary>
        /// <param name="rectangles"></param>
        public void FillRectListBox(Rectangle[] rectangles)
        {
            rectanglesListBox.Items.Clear();
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectanglesListBox.Items.Add($"Rectangle {rectangles[i].ID}");
            }
        }
    }
}
