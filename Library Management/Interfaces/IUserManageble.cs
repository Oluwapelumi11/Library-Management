using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Interfaces
{
    internal interface IUserManageble
    {
        public void AddUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(User user);
        public void UpdateUser(int id);
        public void DeleteUser(int id);
    }
}
