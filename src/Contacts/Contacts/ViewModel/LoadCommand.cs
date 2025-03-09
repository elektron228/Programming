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
        private readonly MainVM _viewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true; 
        }

        public void Execute(object parameter)
        {
            try
            {
                Contact loadedContact = _serializer.LoadContact();
                if (loadedContact != null)
                {
                    _viewModel.CurrentContact = loadedContact;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выполнении LoadCommand: {ex.Message}");
                throw;
            }
        }

        public LoadCommand(ContactSerializer serializer, MainVM viewModel)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
    }
}
