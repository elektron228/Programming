using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Содержит логику VM.
    /// </summary>
    public partial class MainVM : ObservableObject
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
        [ObservableProperty]
        private bool _isEdit;

        /// <summary>
        /// Показывает, добавляется ли сейчас контакт.
        /// </summary>
        [ObservableProperty]
        private bool _isCreate;

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
                    AddCommand.NotifyCanExecuteChanged();
                    EditCommand.NotifyCanExecuteChanged();
                    RemoveCommand.NotifyCanExecuteChanged();
                    ApplyCommand.NotifyCanExecuteChanged();

                }
            }
        }


        /// <summary>
        /// Определяет, редактируется ли контакт.
        /// </summary>
        public bool IsEditing => IsCreate || IsEdit;

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
            LoadContactsFromSerializer();

        }

        /// <summary>
        /// Загружает контакты с помощью сериалайзера и преобразует их в ContactVM.
        /// </summary>
        private void LoadContactsFromSerializer()
        {
            var contacts = _serializer.LoadContacts();

            Contacts = new ObservableCollection<ContactVM>(
                contacts.Select(c => new ContactVM(c)) 
            );
        }

        /// <summary>
        /// Преобразует контакты из ContactVM в Contact и сохраняет их.
        /// </summary>
        private void SaveContacts()
        {
            ObservableCollection<Contact> contactsToSave = new ObservableCollection<Contact>(
            Contacts.Select(cvm => cvm.ConvertToContact()));

            // 2. Сохраняем контакты
            _serializer.SaveContacts(contactsToSave);

        }

        /// <summary>
        /// Обрабатывает изменение флага, указывающего на создание нового контакта.
        /// </summary>
        /// <param name="value"></param>
        partial void OnIsCreateChanged(bool value)
        {
            if (value)
            {
                // Если создаем новый контакт, то IsEditing должно быть true
                if (CurrentContact != null)
                {
                    CurrentContact.IsEditing = true;
                }
            }
            OnPropertyChanged(nameof(IsEditing));
            ApplyCommand.NotifyCanExecuteChanged();
            AddCommand.NotifyCanExecuteChanged();
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Обрабатывает изменение флага, указывающего на редактирование существующего контакта.
        /// </summary>
        /// <param name="value"></param>
        partial void OnIsEditChanged(bool value)
        {
            if (value)
            {
                // Если редактируем, то IsEditing должно быть true
                if (CurrentContact != null)
                {
                    CurrentContact.IsEditing = true;
                }
            }
            OnPropertyChanged(nameof(IsEditing));
            ApplyCommand.NotifyCanExecuteChanged();
            AddCommand.NotifyCanExecuteChanged();
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Выполняет логику добавления нового контакта.
        /// </summary>
        /// <param name="obj"></param>
        [RelayCommand(CanExecute = nameof(IsAddEnabled))]
        public void Add()
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
        /// Выполняет логику редактирования существующего контакта.
        /// </summary>
        /// <param name="obj"></param>
        [RelayCommand(CanExecute = nameof(IsEditOrRemoveEnabled))]
        public void Edit()
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
        /// Выполняет логику удаления выбранного контакта.
        /// </summary>
        /// <param name="obj"></param>
        [RelayCommand(CanExecute = nameof(IsEditOrRemoveEnabled))]
        private void Remove()
        {
            if (CurrentContact != null)
            {
                int index = Contacts.IndexOf(CurrentContact);
                Contacts.Remove(CurrentContact);
                _originalContact = null;
                SaveContacts();
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
        /// Выполняет логику применения изменений к контакту.
        /// </summary>
        /// <param name="obj"></param>
        [RelayCommand(CanExecute = nameof(IsApplyEnabled))]
        public void Apply()
        {
            if (_isCreate)
            {
                Contacts.Add(CurrentContact);
                IsCreate = false;
            }
            IsEdit = false;
            SaveContacts();
            
            _originalContact = null;
            OnPropertyChanged(nameof(IsApplyEnabled));
        }
    }
}
