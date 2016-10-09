using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBasicStudyProgram.NewFolder1
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
        public Book()
        {

        }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Book1", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 2, Title = "Book2", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 3, Title = "Book3", Author = "ago", CoverImage = "/Assets/03.jpg" });
            books.Add(new Book { BookId = 1, Title = "Book1", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 2, Title = "Book2", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 3, Title = "Book3", Author = "ago", CoverImage = "/Assets/03.jpg" });
            books.Add(new Book { BookId = 1, Title = "Book1", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 2, Title = "Book2", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 3, Title = "Book3", Author = "ago", CoverImage = "/Assets/03.jpg" });
            books.Add(new Book { BookId = 1, Title = "Book1", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 2, Title = "Book2", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 3, Title = "Book3", Author = "ago", CoverImage = "/Assets/03.jpg" });
            return books;
        }
    }
}
