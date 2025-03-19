﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Выполняет загрузку данных из файла.
    /// </summary>
    public class LoadCommand : ICommand
    {
        private ContactSerializer _serializer;
        private readonly MainVM _viewModel;

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
        /// Выполняет загрузку контакта из файла.
        /// </summary>
        /// <param name="parameter"></param>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="serializer">Класс, выполняюий десериализацию.</param>
        /// <param name="viewModel">Объект VM для передачи данных.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public LoadCommand(ContactSerializer serializer, MainVM viewModel)
        {
            _serializer = serializer ?? throw new ArgumentNullException(nameof(serializer));
            _viewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
    }
}
