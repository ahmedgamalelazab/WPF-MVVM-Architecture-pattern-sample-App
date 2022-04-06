using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMProject.Commands
{
    public class AddStudentCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public AddStudentCommand(Action<object> execute)
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
            _execute(parameter);
        }

        private readonly Action<object> _execute;
    }
}
