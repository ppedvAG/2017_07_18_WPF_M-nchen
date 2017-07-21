using System;
using System.Windows.Input;

namespace HalloMVVM.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action _executeHandler;
        private readonly Func<bool> _canExecuteHandler;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action execute)
        {
            _executeHandler = execute ?? throw new ArgumentException("Exeucte must not be null.");
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
            : this(execute)
        {
            _canExecuteHandler = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecuteHandler?.Invoke() ?? true;
        public void Execute(object parameter) => _executeHandler();
    }
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _executeHandler;
        private readonly Func<T, bool> _canExecuteHandler;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<T> execute)
        {
            _executeHandler = execute ?? throw new ArgumentException("Exeucte must not be null.");
        }

        public RelayCommand(Action<T> execute, Func<T, bool> canExecute)
            : this(execute)
        {
            _canExecuteHandler = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecuteHandler?.Invoke((T)parameter) ?? true;
        public void Execute(object parameter) => _executeHandler((T)parameter);
    }
}
