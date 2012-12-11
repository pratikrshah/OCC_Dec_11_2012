using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace OCC_New_Approach
{
    public class myCommand : ICommand
    {
        public delegate void ICommandExecute(object parameter);
        public delegate bool ICommandCanExecute(object parameter);

        private ICommandExecute _execute;
        private ICommandCanExecute _canexecute;

        public myCommand(ICommandExecute onExecuteMethod, ICommandCanExecute onCanExecuteMethod)
        {
            _execute = onExecuteMethod;
            _canexecute = onCanExecuteMethod;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canexecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
