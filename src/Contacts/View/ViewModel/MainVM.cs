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
        private ContactVM _currentContact;

        /// <summary>
        /// Копия оригинального контакта.
        /// </summary>
        private Contact _originalContact;

        /// <summary>
        /// Класс, выполняющий сериализацию и десериализацию.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Показывает, редактируется ли сейчас контакт.
        /// </summary>
        private bool _isEdit = false;
        
        /// <summary>
        /// Показывает, добавляется ли сейчас контакт.
        /// </summary>
        private bool _isCreate = false;

        /// <summary>
        /// Оповещает систему об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }
            = new ObservableCollection<ContactVM>();

        /// <summary>
        /// Возвращает и задаёт текущий контакт.
        /// </summary>
        public ContactVM CurrentContact
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
                        CurrentContact.Name = _originalContact?.Name ?? string.Empty;
                        CurrentContact.Email = _originalContact?.Email ?? string.Empty;
                        CurrentContact.Phone = _originalContact?.Phone ?? string.Empty;

                        _isCreate = false;
                        _isEdit = false;
                        OnPropertyChanged(nameof(IsEditing));
                        OnPropertyChanged(nameof(IsApplyEnabled));
                    }
                    _currentContact = value;
                    OnPropertyChanged(nameof(CurrentContact));
                    if (_currentContact != null) 
                    {
                        _currentContact.IsEditing = IsEditing;
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт флаг редактирования контакта.
        /// </summary>
        public bool IsEdit
        {
            get 
            { 
                return _isEdit; 
            }
            set
            {
                if (_isEdit != value)
                {
                    _isEdit = value;
                    CurrentContact.IsEditing = value;
                    OnPropertyChanged(nameof(IsEditing));
                }

            }
        }

        /// <summary>
        /// Возвращает и задаёт флаг создания контакта.
        /// </summary>
        public bool IsCreate
        {
            get 
            { 
                return _isCreate; 
            }
            set
            {
                if (_isCreate != value)
                {
                    _isCreate = value;
                    CurrentContact.IsEditing = value;
                    OnPropertyChanged(nameof(IsEditing));
                }

            }
        }

        /// <summary>
        /// Определяет, редактируется ли контакт.
        /// </summary>
        public bool IsEditing => IsCreate || IsEdit;

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
        public bool IsAddEnabled => !IsEdit && !IsCreate;

        /// <summary>
        /// Показывет, возможно ли редактировать контакт.
        /// </summary>
        public bool IsEditOrRemoveEnabled => CurrentContact != null && !IsEdit && !IsCreate;

        /// <summary>
        /// Показывет, возможно ли применить изменения.
        /// </summary>
        public bool IsApplyEnabled => ((IsCreate) || (CurrentContact != null && IsEdit)) &&
                                      !string.IsNullOrEmpty(CurrentContact.Name) &&
                                      !string.IsNullOrEmpty(CurrentContact.Email) &&
                                      !string.IsNullOrEmpty(CurrentContact.Phone);

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
            CurrentContact = new ContactVM(new Contact());
            _originalContact = new Contact 
            {
                Name = CurrentContact.Name,
                Email = CurrentContact.Email,
                Phone = CurrentContact.Phone
            };

            CurrentContact.Name = string.Empty;
            CurrentContact.Email = string.Empty;
            CurrentContact.Phone = string.Empty;
            IsCreate = true;

            OnPropertyChanged(nameof(IsApplyEnabled));
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
            IsEdit = true;
            _originalContact = new Contact
            {
                Name = CurrentContact.Name,
                Email = CurrentContact.Email,
                Phone = CurrentContact.Phone
            };
            OnPropertyChanged(nameof(IsApplyEnabled));
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда редактирования контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool OnEditCommandCanExecute(object obj)
        {
            return IsEditOrRemoveEnabled;
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
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда удаления контакта.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool OnRemoveCommandCanExecute(object obj)
        {
            return IsEditOrRemoveEnabled;
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
                IsCreate = false;
            }
            IsEdit = false;
            _serializer.SaveContacts(Contacts);
            
            _originalContact = null;
            OnPropertyChanged(nameof(IsApplyEnabled));
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
