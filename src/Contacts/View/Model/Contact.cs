using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email;
        /// <summary>
        /// Мобильный телефон контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Текст текущей ошибки для <see cref="Name"/>.
        /// </summary>
        private string _nameError;

        /// <summary>
        ///  Текст текущей ошибки для <see cref="Phone"/>.
        /// </summary>
        private string _phoneError;

        /// <summary>
        ///  Текст текущей ошибки для <see cref="Email"/>.
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Оповещает систему об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                if (_name != value)
                {
                    _name = value;
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
                return _email;
            }
            set
            {
                _email = value;
                ValidateEmail(value); 
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(Error)); 
            }
        }

        /// <summary>
        /// Возвращает и задаёт Номер телефона.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
                ValidatePhone(value); 
                OnPropertyChanged(nameof(Phone));
                OnPropertyChanged(nameof(Error)); 
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
        /// Создаёт экземпляр класса <see cref="Contact"/>.
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

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Отслеживает изменение значений свойства.
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                _phoneError = "Phone number can only contain digits and symbols + - () . Example: +7 (999) 111-22-33";
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
