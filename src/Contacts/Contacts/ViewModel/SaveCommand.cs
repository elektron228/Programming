using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model.Services;
using View.Model;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Выполняет сохранение данных в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        private ContactSerializer _serializer;
        private Contact _contact;

        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Проверяет, возможно ли выполнить команду <see cref="Execute(object)"/>.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет сохранение контакта в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            try
            {
                _serializer.SaveContact(_contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выполнении SaveCommand: {ex.Message}");
                throw; 
            }
        }

        /// <summary>
        /// Сздаёт объект каласса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="serializer">Класс ,выполняющий сериализацию.</param>
        /// <param name="contact">Объект контакта для сохранения.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SaveCommand(ContactSerializer serializer, Contact contact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }
    }
}
