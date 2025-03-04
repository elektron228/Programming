using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Имя не может быть пустым.");
                }

                if (!Regex.IsMatch(value, @"^[А-Я][а-я]+ [А-Я][а-я]+([А-Я][а-я]+)?$"))
                {
                    throw new ArgumentException("Имя должно содержать только буквы русского алфавита.");
                }

                _name = value;
            } 
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email 
        { 
            get 
            { 
                return _email; 
            } 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email не может быть пустым.");
                }

                if (!Regex.IsMatch(value, @"^[\w-\.]+@([\w-]+\.)+[\w]{2,4}$"))
                {
                    throw new ArgumentException("Некорректный формат email.");
                }

                _email = value;
            } 
        }

        /// <summary>
        /// Возвращает и задаёт Номер телефона.
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Номер телефона не может быть пустым.");
                }

                if (!Regex.IsMatch(value, @"^\+7\d{3}\d{7}$"))
                {
                    throw new ArgumentException("Некорректный формат номера телефона. Используйте формат: +7 XXXxxxxxxx");
                }

                _phone = value;
            }
        }

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
