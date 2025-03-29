namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name {  get; set; }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает и задаёт Номер телефона.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Создаёт экзкмпляр класса <see cref="Contact"/>.
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

    }
}
