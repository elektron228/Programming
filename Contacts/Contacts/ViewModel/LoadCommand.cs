using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        private ContactSerializer _serializer;
        private Contact _contact;

        public LoadCommand(ContactSerializer serializer, Contact contact)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true; 
        }

        public void Execute(object parameter)
        {
            try
            {
                Contact loadedContact = _serializer.LoadContact(_contact);
                if (loadedContact != null)
                {
                    _contact.Name = loadedContact.Name;
                    _contact.Email = loadedContact.Email;
                    _contact.Phone = loadedContact.Phone;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выполнении LoadCommand: {ex.Message}");
                throw;
            }
        }
    }
}
