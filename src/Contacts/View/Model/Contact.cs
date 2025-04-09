using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        private string _nameError;
        private string _phoneError;
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
                _name = value;
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
                return _email;
            }
            set
            {
                _email = value;
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
                return _phone;
            }
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }


        public string Error
        {
            get { return null; }
        }

        public string this[string columnName]
        {
            get
            {
                string error = null;

                switch (columnName)
                {
                    case nameof(Name):
                        if (string.IsNullOrEmpty(Name))
                        {
                            error = "Name is required.";
                        }
                        else if (Name.Length > 100)
                        {
                            error = "Name must be no longer than 100 characters.";
                        }
                        break;

                    case nameof(Phone):
                        if (string.IsNullOrEmpty(Phone))
                        {
                            error = "Phone number is required.";
                        }
                        else if (Phone.Length > 100)
                        {
                            error = "Phone number must be no longer than 100 characters.";
                        }
                        else if (!Regex.IsMatch(Phone, @"^[\d\+\-\(\)]+$")) // Regular expression to check for digits and + - ()
                        {
                            error = "Phone number can only contain digits and symbols + - () . Example: +7 (999) 111-22-33";
                        }
                        break;

                    case nameof(Email):
                        if (string.IsNullOrEmpty(Email))
                        {
                            error = "Email is required.";
                        }
                        else if (Email.Length > 100)
                        {
                            error = "Email must be no longer than 100 characters.";
                        }
                        else if (!Email.Contains("@"))
                        {
                            error = "Email must contain '@' character.";
                        }
                        break;
                
                    default:
                        return null;
                }
                return error;
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
        /// Создаёт пустой экземпляр класса <see cref="Contact"./>
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

        private string ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Name is required.";
            }
            else if (name.Length > 100)
            {
                return "Name must be no longer than 100 characters.";
            }
            return null;
        }

        private string ValidatePhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
            {
                return "Phone number is required.";
            }
            else if (phone.Length > 100)
            {
                return "Phone number must be no longer than 100 characters.";
            }
            else if (!Regex.IsMatch(phone, @"^[\d\+\-\(\)]+$"))
            {
                return "Phone number can only contain digits and symbols + - () . Example: +7 (999) 111-22-33";
            }
            return null;
        }

        private string ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return "Email is required."; // Email required
            }

            if (email.Length > 100)
            {
                return "Email must be no longer than 100 characters."; // Length limit
            }

            if (!email.Contains("@"))
            {
                return "Email must contain the @ symbol."; // Must contain @
            }

            return null; // Valid
        }
    }
}
