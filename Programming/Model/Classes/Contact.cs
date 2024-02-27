using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        private string _name;
        private string _number;
        private string _email;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Возвращает и задает номер контакта.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Возвращает и задает email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="number">Телефонный номер контакта.</param>
        /// <param name="email">Адрес электронной почты контакта.</param>
        public Contact(string name, string number, string email)
        {
            Name = name;
            Number = number;
            Email = email;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }


    }
}
