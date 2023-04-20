using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project.ViewModels
{
    public class ViewModelCommand : ICommand
    {
        // Fields
        private readonly Action<object> _executeAction; // Generate method that executes action.
        private readonly Predicate<object> _canExecuteAction; // Specifies criteria that allow action execution.

        // Constructors
        public ViewModelCommand(Action<object> executeAction)
        {
            // Actions that do not need validation.

            _executeAction = executeAction;
            _canExecuteAction = null;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            // Actions that require validation.
            // They need to meet set criteria.

            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        // Events
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // Methods
        public bool CanExecute(object parameter)
        {
            return _canExecuteAction == null ? true : _canExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            _canExecuteAction(parameter);
        }
    }
}
