using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о песне.
    /// </summary>
    public class Song
    {
        private string _name;
        private string _singer;
        private int _duration;

        /// <summary>
        /// Возращает и задает название песни.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        ///Возвращает и задает имя певца. 
        /// </summary>
        public string Singer { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность песни (в секундах). Должно быть больше нуля.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название песни.</param>
        /// <param name="singer">Имя исполнителя.</param>
        /// <param name="duration">Длительность. В секундах.</param>
        public Song(string name, string singer, int duration)
        {
            Name = name;
            Singer = singer;
            Duration = duration;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song() { }
    }
}
