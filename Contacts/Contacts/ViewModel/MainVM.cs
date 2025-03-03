using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Contact CurrentContact;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name 
        { 
            get 
            { 
                return CurrentContact.Name; 
            } 
            set 
            {
                CurrentContact.Name = value; 
            } 
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email
        {
            get
            {
                return CurrentContact.Email;
            }
            set
            {
                CurrentContact.Email = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт Номер телефона.
        /// </summary>
        public string Phone
        {
            get
            {
                return CurrentContact.Phone;
            }
            set
            {
                CurrentContact.Phone = value;
            }
        }
    }
}
