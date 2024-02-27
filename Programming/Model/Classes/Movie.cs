using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    public class Movie
    {
        private string _name;
        private int _duration;
        private int _releaseYear;
        private string _genre;
        private Double _rating;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма (в минутах). Должно быть не меньше нуля.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма. Должно быть от 1900 до 2024.
        /// </summary>
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value < 1900 && value > 2024)
                {
                    throw new ArgumentException();
                }
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должно быть от 0 до 10.
        /// </summary>
        public Double Rating
        {
            get { return _rating; }
            set
            {
                if (value > 10.0 && value < 0)
                {
                    throw new ArgumentException();
                }
                _rating = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Длительность в минутах.</param>
        /// <param name="releaseYear">Год выпуска. От 1900 до 2024.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтин фильма. От 0 до 10.</param>
        public Movie(string name, int duration, int releaseYear, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie() { }
    }
}
