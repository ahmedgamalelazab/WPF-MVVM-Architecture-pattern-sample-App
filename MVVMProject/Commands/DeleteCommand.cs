using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMProject.Commands
{
    public class DeleteCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public DeleteCommand(Action<object> execute)
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
            throw new NotImplementedException();
        }

        private readonly Action<object> _execute;
    }
}
