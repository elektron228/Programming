using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Содержит логику VM.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Contact _currentContact;

        public Contact CurrentContact
        {
            get 
            {
                return _currentContact; 
            }
            set
            { 
                _currentContact = value;
                OnPropertyChanged(nameof(CurrentContact));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(Phone));
            }
        }

        public ContactSerializer Serializer;

        /// <summary>
        /// Выподняет загрузку данных из файл.
        /// </summary>
        public LoadCommand LoadCommand { get; }

        /// <summary>
        /// Выполняет сохоанение данных в файл.
        /// </summary>
        public SaveCommand SaveCommand {  get; }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name 
        { 
            get 
            { 
                return _currentContact.Name; 
            } 
            set 
            {
                _currentContact.Name = value; 
                OnPropertyChanged(nameof(Name));
            } 
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email
        {
            get
            {
                return _currentContact.Email;
            }
            set
            {
                _currentContact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возвращает и задаёт Номер телефона.
        /// </summary>
        public string Phone
        {
            get
            {
                return _currentContact.Phone;
            }
            set
            {
                _currentContact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
           _currentContact = new Contact("Иванов Иван Иванович", "+79235678909", "ivanov1999@gmail.com");
            
            Serializer = new ContactSerializer();
            LoadCommand = new LoadCommand(this.Serializer, this);
            SaveCommand = new SaveCommand(this.Serializer, this._currentContact);
        }
    }
}
