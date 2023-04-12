using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Предоставляет реализацию интерфейса <see cref="ICommand"/> 
    /// </summary>
    internal class RelayCommand : ICommand
    {
        /// <summary>
        /// Определяет, может ли выполняться команда.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Возвращает истину.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Делегат для вызова команды.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Событие, предоставляющее информацию о возможности вызове команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Делегат для вызова команды.
        /// </summary>
        private Action<object> _execute;

        private Func<object, bool> _canExecute;
    }
}
