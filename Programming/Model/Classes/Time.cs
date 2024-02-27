using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о времени.
    /// </summary>
    public class Time
    {
        private int _seconds;
        private int _minutes;
        private int _hours;

        /// <summary>
        /// Возвращает и задет время в часах. Должно быть от нуля до 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 && value > 23)
                {
                    throw new ArgumentException();
                }
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время в минутах. Должно быть от нуля до 59.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 && value > 59)
                {
                    throw new ArgumentException();
                }
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время в секундах. Должно быть от нуля до 59.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 && value > 59)
                {
                    throw new ArgumentException();
                }
                _seconds = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="seconds">Время в секундах. Должно быть от 0 до 59.</param>
        /// <param name="minutes">Время в минутах. Должно быть от 0 до 59.</param>
        /// <param name="hours">Время в часах. Должно быть от 0 до 23.</param>
        public Time(int seconds, int minutes, int hours)
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time() { }
    }
}
