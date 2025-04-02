using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
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
        /// Копия оригинального контакта.
        /// </summary>
        private Contact _originalContact;

        /// <summary>
        /// Класс, выполняющий сериализацию и дисериализацию.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Показывает, реадктируется ли сйечас контакт.
        /// </summary>
        private bool _isEdit = false;
        
        /// <summary>
        /// Показывает, добавляется ли сйечас контакт.
        /// </summary>
        private bool _isCreate = false;

        /// <summary>
        /// Оповещает систему об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }
            = new ObservableCollection<Contact>();

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
                if (_currentContact != value)
                {
                    // Сбрасываем изменения, если они не были применены
                    if (_isEdit || _isCreate)
                    {
                        Name = _originalContact?.Name ?? string.Empty;
                        Email = _originalContact?.Email ?? string.Empty;
                        Phone = _originalContact?.Phone ?? string.Empty;

                        _isCreate = false;
                        _isEdit = false;
                        OnPropertyChanged(nameof(IsEditing));
                        OnPropertyChanged(nameof(IsApplyVisible));
                        OnPropertyChanged(nameof(IsApplyEnabled));

                    }

                    _currentContact = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Email));
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }

        public Contact NewContact { get; set; }

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
                OnPropertyChanged(nameof(IsApplyEnabled));
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
                OnPropertyChanged(nameof(IsApplyEnabled));
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
                OnPropertyChanged(nameof(IsApplyEnabled));
            }
        }

        /// <summary>
        /// Определяет, редактируется ли контакт.
        /// </summary>
        public bool IsEditing
        {
            get { return _isCreate || _isEdit; }
        }

        /// <summary>
        /// Команда для добавления контакта.
        /// </summary>
        public ICommand AddCommand { get; private set; }

        /// <summary>
        /// Команда для редактирования контакта.
        /// </summary>
        public ICommand EditCommand { get; private set; }

        /// <summary>
        /// Команда для удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; private set; }

        /// <summary>
        /// Команда для сохранения изменений.
        /// </summary>
        public ICommand ApplyCommand { get; private set; }

        /// <summary>
        /// Показывет, возможно ли добавить новый контакт.
        /// </summary>
        public bool IsAddEnabled => !_isEdit && !_isCreate;

        /// <summary>
        /// Показывет, возможно ли редактировать контакт.
        /// </summary>
        public bool IsEditEnabled => CurrentContact != null && !_isEdit && !_isCreate;

        /// <summary>
        /// Показывет, возможно ли удалить контакт.
        /// </summary>
        public bool IsRemoveEnabled => CurrentContact != null && !_isEdit && !_isCreate;

        /// <summary>
        /// Показывет, возможно ли применить изменения.
        /// </summary>
        public bool IsApplyEnabled => (_isCreate && (!string.IsNullOrEmpty(Name) &&
            !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Phone))) || 
            (CurrentContact != null && _isEdit &&(!string.IsNullOrEmpty(Name) 
            && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Phone))); 

        public bool IsApplyVisible => _isEdit || _isCreate;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
            Contacts = _serializer.LoadContacts();

            AddCommand = new RelayCommand(OnAddCommandExecute, OnAddCommandCanExecute);
            EditCommand = new RelayCommand(OnEditCommandExecute, OnEditCommandCanExecute);
            RemoveCommand = new RelayCommand(OnRemoveCommandExecute, OnRemoveCommandCanExecute);
            ApplyCommand = new RelayCommand(OnApplyCommandExecute, OnApplyCommandCanExecute);
        }

        /// <summary>
        /// Выполняет логику добавления нового контакта.
        /// </summary>
        /// <param name="obj"></param>
        private void OnAddCommandExecute(object obj)
        {
            CurrentContact = null;
            CurrentContact = new Contact();
            _originalContact = new Contact 
            {
                Name = CurrentContact.Name,
                Email = CurrentContact.Email,
                Phone = CurrentContact.Phone
            };

            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            _isCreate = true;

            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(IsApplyEnabled));
            OnPropertyChanged(nameof(IsEditing));
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда добавления контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool OnAddCommandCanExecute(object obj)
        {
            return IsAddEnabled;
        }

        /// <summary>
        /// Выполняет логику редактирования существующего контакта.
        /// </summary>
        /// <param name="obj"></param>
        private void OnEditCommandExecute(object obj)
        {

            _isEdit = true;
            _originalContact = new Contact
            {
                Name = CurrentContact.Name,
                Email = CurrentContact.Email,
                Phone = CurrentContact.Phone
            };
            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(IsApplyEnabled));
            OnPropertyChanged(nameof(IsEditing));
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда редактирования контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool OnEditCommandCanExecute(object obj)
        {
            return IsEditEnabled;
        }

        /// <summary>
        /// Выполняет логику удаления выбранного контакта.
        /// </summary>
        /// <param name="obj"></param>
        private void OnRemoveCommandExecute(object obj)
        {
            if (CurrentContact != null)
            {
                int index = Contacts.IndexOf(CurrentContact);
                Contacts.Remove(CurrentContact);
                _originalContact = null;
                _serializer.SaveContacts(Contacts);
                if (Contacts.Count > 0) 
                {
                    if (index < Contacts.Count) 
                    {
                        CurrentContact = Contacts[index];
                    }
                    else 
                    {
                        CurrentContact = Contacts.LastOrDefault(); 
                    }
                }
                else 
                {
                    CurrentContact = null; 
                }
            }

            OnPropertyChanged(nameof(IsApplyEnabled));
            OnPropertyChanged(nameof(IsEditing));
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда удаления контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool OnRemoveCommandCanExecute(object obj)
        {
            return IsRemoveEnabled;
        }

        /// <summary>
        /// Выполняет логику применения изменений к контакту.
        /// </summary>
        /// <param name="obj"></param>
        private void OnApplyCommandExecute(object obj)
        {
            if (_isCreate)
            {
                Contacts.Add(CurrentContact);
                _isCreate = false;
            }
            _isEdit = false;
            _serializer.SaveContacts(Contacts);
            
            _originalContact = null;
            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(IsApplyEnabled));
            OnPropertyChanged(nameof(IsEditing));
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда применения изменений.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool OnApplyCommandCanExecute(object obj)
        {
            return IsApplyEnabled;
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
