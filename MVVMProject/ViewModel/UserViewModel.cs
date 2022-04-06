using MVVMProject.Commands;
using MVVMProject.Model;
using MVVMProject.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMProject.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private UserService service;

        private ObservableCollection<User> _users;

        private User _current;

        private ICommand _AddCommand;

        private ICommand _UpdateCommand;

        private ICommand _DeleteCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public User User
        {
            get { return _current; }
            set 
            {
                _current = value;
                NotifyPropertyChanged("User");
            }
        }

        public UserViewModel()
        {
            service = new UserService();
            _users = service.GetAllUsers();
            _current = new User();
        }

        //properties to bind on 


        public ObservableCollection<User> Users
        { 
            get
            {
                return _users; 
            }

            set
            {
                _users = value;
                NotifyPropertyChanged("Users");
            }
        }

        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new AddStudentCommand(param => this.Submit());
                }
                return _AddCommand;
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                if (_UpdateCommand == null)
                {
                    _UpdateCommand = new AddStudentCommand(param => this.Update());
                }
                return _UpdateCommand;
            }
        }


        public ICommand DeleteCommand
        {
            get
            {
                if (_DeleteCommand == null)
                {
                    _DeleteCommand = new AddStudentCommand(param => this.Delete());
                }
                return _DeleteCommand;
            }
        }


        private void Submit()
        {
            service.InsertUser(User);
            User = new User();
        }

        private void Update()
        {
            foreach(var user in Users)
            {
                MessageBox.Show(user.Name);
            }
        }

        private void Delete()
        {
            service.DeleteUser(User);
        }


    }
}
