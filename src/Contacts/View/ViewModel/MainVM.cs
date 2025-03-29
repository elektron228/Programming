using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Содержит логику VM.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Класс, выполняющий сериализацию и дисериализацию.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Оповещает систему об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задаёт текущий контакт.
        /// </summary>
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

        /// <summary>
        /// Выполняет загрузку данных из файл.
        /// </summary>
        public LoadCommand LoadCommand { get; }

        /// <summary>
        /// Выполняет сохранение данных в файл.
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
        /// Возвращает и задаёт номер телефона.
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _currentContact = new Contact("Иванов Иван Иванович", "+79235678909", "ivanov1999@gmail.com");

            _serializer = new ContactSerializer();
            LoadCommand = new LoadCommand(this._serializer, this);
            SaveCommand = new SaveCommand(this._serializer, this._currentContact);
        }

        /// <summary>
        /// Отслеживает изменение значений свойства.
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
