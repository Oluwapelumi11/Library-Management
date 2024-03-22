using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Interfaces
{
    internal interface IBorrowable
    {

        public void Borrow(User user,Book book);

        public void Return(User user, Book book);

        public DateTime BorrowDate { get; set;}

    }
}
