using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация интерфейса <see cref="ICommand"/>, позволяющая 
    /// привязать команду к методу в ViewModel.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Метод, который будет выполняться при вызове команды.
        /// </summary>
        private Action<object> execute;

        /// <summary>
        /// Метод, определяющий возможность выполнения команды.
        /// </summary>
        private Func<object, bool> canExecute;

        /// <summary>
        /// Вызывается при изменении состояния команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Метод, выполняемый при вызове команды.</param>
        /// <param name="canExecute">Определяет возможность выполнения комманды.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Проверяет, возможно ли выполнить команду <see cref="Execute(object)"/>.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        /// <summary>
        /// Выполняет загрузку контакта из файла.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
