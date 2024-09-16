using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные о предмете.
    /// </summary>
    public class Subject
    {
        private string _name;
        private int _hours;
        private string _teacherName;
        private int _mark;

        /// <summary>
        /// Возвращает и задает название предмета. 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращет и задает количество часов. Должно быть не меньше нуля.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя преподавателя. Должно состоять только из букв.
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// Возвращает и задает оценку. Должно быть от 2 до 5.
        /// </summary>
        public int Mark
        {
            get { return _mark; }
            set
            {
                Validator.AssertValueInRange(value, 2, 5);
                _mark = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название предмета.</param>
        /// <param name="hours">Количество часок для изучения.</param>
        /// <param name="teacherName">Имя учителя.</param>
        /// <param name="mark">Итоговая оценка.</param>
        public Subject(string name, int hours, string teacherName, int mark)
        {
            Name = name;
            Hours = hours;
            TeacherName = teacherName;
            Mark = mark;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject() { }
    }
}
