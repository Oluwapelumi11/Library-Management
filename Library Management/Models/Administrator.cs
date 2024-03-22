using Library_Management.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal class Administrator : User
    {
        public Administrator() :base() {
            base.UserType = UserTypes.AdminUser;
        }
        public Administrator(string name, string password) :base(name, password) {
            base.UserType = UserTypes.AdminUser;
        }

    }
}
