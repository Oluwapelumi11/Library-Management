using Library_Management.Interfaces;
using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Repository
{
    internal class Library : IBookManageable
    {
        private Dictionary<User,List<Book>> _books;
        

        public Library() {
            _books = new Dictionary<User, List<Book>>();
        }

        public void AddBook(User user, Book book)
        {
            if (user.CanManageBook())
            {
                if (_books.ContainsKey(user))
                {
                    _books[user].Add(book);
                    Console.WriteLine($"Book added by {user.Name}");
                }
                else
                {
                    _books.Add(user, new List<Book>() { book});
                    Console.WriteLine($"First Book added by {user.Name}");

                }
            }
            else
            {
                Console.WriteLine("User does not have the permision to add a book");
            } 
        }

        public void RemoveBook(User user, Book book)
        {
            if (user.CanManageBook())
            {
                foreach(List<Book> bk in _books.Values)
                {
                    if (bk.Contains(book))
                    {
                        bk.Remove(book);
                        Console.WriteLine($"{book.Title} removed by {user.Name}");
                        return;
                    }
                        
                }
            }
            else
            {
                Console.WriteLine($"{user.Name} does not have the permision to remove a book");
            }
        }

        public void UpdateBook(User user, Book book, Book Updatedbook)
        {
            if (user.CanManageBook())
            {
                IEnumerable<Book> bk = _books.Values.SelectMany(booklist => booklist);
                if (bk.Contains(book))
                    {
                        book = Updatedbook;
                        Console.WriteLine($"{book.Title} updated by {user.Name}");
                        return;
                    }

                
            }
            else
            {
                Console.WriteLine($"{user.Name} does not have the permision to remove a book");
            }
        }


        public IEnumerable<Book> ListBooks()
        {
            IEnumerable<Book> books = _books.Values.Where(booklist => booklist
            .Any(book => book.Status == BookStatus.Active))
            .SelectMany(booklist => booklist);

            return books;
        }

        public IEnumerable<Book> ListBooks(Categories category)
        {
            IEnumerable<Book> books = _books.Values
                .Where(booklist=> booklist
                .Any(book => book.Category == category && book.Status == BookStatus.Active))
                .SelectMany(booklist => booklist);

            return books;
        }

        public void BorrowBook(User user, Book book)
        {
            if (book.Status == BookStatus.Inactive)
            {
                Console.WriteLine("This book has been borrowed");
                return;
            }
            foreach( List<Book> booklist in _books.Values)
            {
                if (booklist.Contains(book)) {
                    user.BorrowedBooks.Add(book);
                    book.Status = BookStatus.Inactive;
                    Console.WriteLine($"{book.Title} borrowed by {user.Name}");

                }
               
            }
        }

        public void ReturnBook(User user, Book book)
        {
            foreach (List<Book> booklist in _books.Values)
            {
                if (booklist.Contains(book))
                {
                    book.Status = BookStatus.Active;
                    user.BorrowedBooks.Remove(book);
                    Console.WriteLine($"{book.Title} returned by {user.Name}");
                }

            }
        }
    }
}
