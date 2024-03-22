using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal class Book
    {
        public Book() { }

        public Book(int id, string name) {
            Id = id;
            Title = name;
        }
        public Book(int id, string name, string description)
        {
            Id = id;
            Title = name;
            Description = description;
        }
        public int? Id {  get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public BookStatus Status { get; set; } = BookStatus.Active;
        public Categories? Category { get; set; } = Categories.HardCover;
        public virtual string PrintPrettily(string sep) => $"{Id}{sep}{Title}{sep}{Description}{sep}{Category}";
        
    }

    public enum Categories
    {
        PDF,
        EPUB,
        HardCover,
    }
    public enum BookStatus
    {
        Active,
        Inactive
    }
}
