﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model.Services;
using View.Model;
using System.Windows.Input;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        private ContactSerializer _serializer;
        private Contact _contact;

        public SaveCommand(ContactSerializer serializer, Contact contact)
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
                _serializer.SaveContact(_contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выполнении SaveCommand: {ex.Message}");
                throw; 
            }
        }
    }
}
