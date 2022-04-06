using System;
using System.Windows.Input;

namespace MVVMProject.Commands
{
    public class UpdateDataCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public UpdateDataCommand(Action<object> execute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
        }

        private readonly Action<object> _execute;
    }
}
