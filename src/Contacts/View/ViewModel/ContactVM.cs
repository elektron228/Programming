using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using View.Model;
using Newtonsoft.Json;
using CommunityToolkit.Mvvm.ComponentModel;

namespace View.ViewModel
{
    /// <summary>
    /// Уведомляет об изменениях контакта и выполняет валидацию.
    /// </summary>
    public class ContactVM : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Текущий объект контакта.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Текст текущей ошибки для <see cref="Name"/>.
        /// </summary>
        private string _nameError;

        /// <summary>
        /// Текст текущей ошибки для <see cref="Phone"/>.
        /// </summary>
        private string _phoneError;

        /// <summary>
        /// Текст текущей ошибки для <see cref="Email"/>.
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Управляет доступностью текстбоксов.
        /// </summary>
        private bool _isEditing = false;

        /// <summary>
        /// Возвращает и задаёт флаг, определяющий доступность текстбоксов.
        /// </summary>
        public bool IsEditing
        {
            get { return _isEditing; }
            set
            {
                _isEditing = value;
                OnPropertyChanged(nameof(IsEditing));
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    ValidateName(value);
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(Error));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    ValidateEmail(value);
                    OnPropertyChanged(nameof(Email));
                    OnPropertyChanged(nameof(Error));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона.
        /// </summary>
        public string Phone
        {
            get
            {
                return _contact.Phone;
            }
            set
            {
                if (_contact.Phone != value)
                {
                    _contact.Phone = value;
                    ValidatePhone(value);
                    OnPropertyChanged(nameof(Phone));
                    OnPropertyChanged(nameof(Error));
                }
            }
        }

        /// <summary>
        /// Возвращает true если ошибок нет, иначе false.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return string.IsNullOrEmpty(Error);
            }
        }

        /// <summary>
        /// Проверяет наличие ошибок.
        /// </summary>
        public string Error
        {
            get
            {
                if (!string.IsNullOrEmpty(_nameError)) return _nameError;
                if (!string.IsNullOrEmpty(_phoneError)) return _phoneError;
                if (!string.IsNullOrEmpty(_emailError)) return _emailError;
                return null;
            }
        }

        /// <summary>
        /// Возвращает сообщение об ошибке валидации для указанного свойства.
        /// Если для свойства нет ошибки, возвращает null.
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Name):
                        return _nameError;
                    case nameof(Phone):
                        return _phoneError;
                    case nameof(Email):
                        return _emailError;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ContactVM(Contact contact)
        {
            _contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactVM"/> при десериализации.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="email">Почта контакта.</param>
        /// <param name="phone">Телефон контакта.</param>
        [JsonConstructor]
        public ContactVM(string name, string email, string phone)
        {
            _contact = new Contact
            {
                Name = name,
                Email = email,
                Phone = phone
            };
        }

        /// <summary>
        /// Проверяет <see cref="Name"/> на наличие ошибок.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                _nameError = "Name is required.";
                OnPropertyChanged(nameof(IsValid));
                return _nameError;
            }
            else if (name.Length > 100)
            {
                _nameError = "Name must be no longer than 100 characters.";
                OnPropertyChanged(nameof(IsValid));
                return _nameError;
            }
            _nameError = "";
            OnPropertyChanged(nameof(IsValid));
            return null;
        }

        /// <summary>
        /// Проверяет <see cref="Phone"/> на наличие ошибок.
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        private string ValidatePhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                _phoneError = "Phone number is required.";
                OnPropertyChanged(nameof(IsValid));
                return _phoneError;
            }
            else if (phone.Length > 100)
            {
                _phoneError = "Phone number must be no longer than 100 characters.";
                OnPropertyChanged(nameof(IsValid));
                return _phoneError;
            }
            else if (!Regex.IsMatch(phone, @"^[\d\+\-\(\)]+$"))
            {
                _phoneError = "Phone number can only contain digits and symbols + - ()." +
                    " Example: +7 (999) 111-22-33";
                OnPropertyChanged(nameof(IsValid));
                return _phoneError;
            }
            _phoneError = "";
            OnPropertyChanged(nameof(IsValid));
            return null;
        }

        /// <summary>
        /// Проверяет <see cref="Email"/> на наличие ошибок.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private string ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                _emailError = "Email is required.";
                OnPropertyChanged(nameof(IsValid));
                return _emailError;
            }

            if (email.Length > 100)
            {
                _emailError = "Email must be no longer than 100 characters.";
                OnPropertyChanged(nameof(IsValid));
                return _emailError;
            }

            if (!email.Contains("@"))
            {
                _emailError = "Email must contain the @ symbol.";
                OnPropertyChanged(nameof(IsValid));
                return _emailError;
            }
            _emailError = "";
            OnPropertyChanged(nameof(IsValid));
            return null;
        }
    }
}
