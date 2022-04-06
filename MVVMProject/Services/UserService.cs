using MVVMProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMProject.Services
{
    //this will do all the crud operations on the student 

    public class UserService
    {
        private ObservableCollection<User> users;

        public UserService(){
            users = new  ObservableCollection<User>() { 
                new User(){Id = 1 , Address = "Tanta", Name ="Ahmed Asal",Phone="01032224523"},
                new User(){Id = 2 , Address = "Tanta", Name ="Mostafa Mohamed",Phone="0154321223"},
                new User(){Id = 3 , Address = "Caio", Name ="Ayman Fathy",Phone="01122364523"},
                new User(){Id = 4 , Address = "Alex", Name ="Mohamed ayman",Phone="01032224523"},
                new User(){Id = 5 , Address = "Damnhour", Name ="Ahmed Asal",Phone="01032224523"},
                new User(){Id = 6 , Address = "Cairo", Name ="Ahmed Zaki",Phone="01032224523"},
                new User(){Id = 7 , Address = "Mansoura", Name ="Mona Fathalla",Phone="01032224523"},
                new User(){Id = 8 , Address = "Mansoura", Name ="Said Waleed",Phone="01032224523"}
            };            
        }

        public  ObservableCollection<User> GetAllUsers()
        {
            return users ?? new  ObservableCollection<User>(); // if the list is not set then return empty users
        }

        public User GetUserById(int id)
        {
            return users.SingleOrDefault((user) => user.Id == id);
        }

        public void InsertUser(User user)
        {
            if (user != null)
            {
                users.Add(user);
            }
        }

        public void UpdateUserData(User _user)
        {
            //find the user 
            User targetUser = users.SingleOrDefault((user) => user.Id == _user.Id);

            if (targetUser != null)
            {
                targetUser.Name = _user.Name;
                targetUser.Phone = _user.Phone;
                targetUser.Address = _user.Address;
            }

        }

        public void DeleteUser(User _user)
        {
            User targetUser = users.SingleOrDefault((user) => user.Id == _user.Id);

            users.Remove(targetUser);
        }
       

    }
}
