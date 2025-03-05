using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainVM()
        {
            CurrentContact = new Contact("Иванов Иван Иванович", "+79235678909", "ivanov1999@gmail.com");
            Name = "Петров Иван Иванович";
            Phone = "+79235678909";
            Email = "ivanov1999@gmail.com";
        }
    }
}
