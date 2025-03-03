using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phone;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name { get { return _name; } set { _name = value; } }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email { get { return _email; } set { _email = value; } }

        /// <summary>
        /// Возвращает и задаёт Номер телефона.
        /// </summary>
        public string Phone { get { return _phone; } set { _phone = value; } }

        /// <summary>
        /// Создаёт экзкмпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="email">Адрес электронной почты контакта.</param>
        /// <param name="phone">Номер телефона контакта.</param>
        public Contact(string name, string email, string phone) 
        {
            Name = name;
            Email = email;  
            Phone = phone;  
        }
    }
}
