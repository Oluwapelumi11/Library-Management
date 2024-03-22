using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management.Models;

namespace Library_Management.Interfaces
{
    internal interface IBookManageable
    {
       
        public void AddBook(User user ,Book book);
        public void RemoveBook(User user,Book book);
        public void UpdateBook(User user,Book book,Book Updatedbook);
        //public void Delete(Book book);


        
        
    }
}
