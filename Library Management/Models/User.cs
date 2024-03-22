using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal abstract class User
    {
        public User() { }
        public User(string name,string password ) {
            Name = name;
            Password = password;
        }

        public int? Id { get; set; }
        public string? Name { get;  set; }
        public string? Password { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public string? Email { get; set; }
        public UserTypes? UserType { get; protected set; } = UserTypes.NormalUser;
        public string? UserName { get;  set;}
    
        public bool CanManageBook()
        {
            if(this.UserType == UserTypes.AdminUser || this.UserType == UserTypes.LibrarianUser)
            {
                return true;
            }
            return false;
        }
        public bool CanManageUsers()
        {
            if (this.UserType == UserTypes.AdminUser)
            {
                return true;
            }
            return false;
        }
    }
    enum UserTypes
    {
        NormalUser,
        LibrarianUser,
        AdminUser,
    }

}
