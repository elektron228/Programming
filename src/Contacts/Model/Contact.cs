namespace Contacts.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact 
    {
        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Возвращает и задаёт Номер телефона.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }
    }
}
