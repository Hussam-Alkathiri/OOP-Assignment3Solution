using OOP_Assignment3.Model._4__Library_System_with_Book_Status_Tracking.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model._4__Library_System_with_Book_Status_Tracking
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }

        public Book(string title, string author, BookStatus status = BookStatus.Available)
        {
            Title = title;
            Author = author;
            Status = status;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Status: {Status}";
        }
    }
}
