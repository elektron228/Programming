using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        private string _name;
        private string _surname;
        private string _number;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (AssertStringContainsOnlyLetters(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect Name.");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (AssertStringContainsOnlyLetters(value))
                {
                    _surname = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect Surname.");
                }
            }
        }
        
        /// <summary>
        /// Возвращает и задает номер контакта.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="number">Телефонный номер контакта.</param>
        /// <param name="surname">Фамилия контакта.</param>
        public Contact(string name, string surname, string number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Проверяет, состоит ли строка только из сомволов английского алфавита.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool AssertStringContainsOnlyLetters(string value)
        {
            return Regex.IsMatch(value, @"^[a-zA-Z]+$");
        }
    }
}
