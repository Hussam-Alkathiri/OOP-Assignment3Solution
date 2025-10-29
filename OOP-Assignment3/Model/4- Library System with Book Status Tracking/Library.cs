using OOP_Assignment3.Model._4__Library_System_with_Book_Status_Tracking.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3.Model._4__Library_System_with_Book_Status_Tracking
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public Book this[string title]
        {
            get
            {
                {
                    foreach (Book b in books)
                    {
                        if (b.Title.ToLower() == title.ToLower())
                            return b;
                    }
                    return null;
                }

            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ChangeStatus(string title, BookStatus status)
        {
            Book book = this[title];
            if (book != null)
            {
                book.Status = status;
                Console.WriteLine($"Status of '{title}' changed to {status}");
            }
            else
            {
                Console.WriteLine($"Book '{title}' not found!");
            }
        }

        public void ShowBooksByStatus(BookStatus status)
        {
            var filteredBooks = books.Where(b => b.Status == status);
            Console.WriteLine($"Books with status {status}:");
            foreach (var book in filteredBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
