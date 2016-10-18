using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBasicStudyProgram.DataModel
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
            books.Add(new Book { BookId = 1, Title = "Date", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 2, Title = "Animation", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 3, Title = "FacebookPage", Author = "ago", CoverImage = "/Assets/03.jpg" });
            books.Add(new Book { BookId = 4, Title = "AutoLayoutPage", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 5, Title = "WeatherPage", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 6, Title = "Book6", Author = "ago", CoverImage = "/Assets/03.jpg" });
            books.Add(new Book { BookId = 7, Title = "Book7", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 8, Title = "Book8", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 9, Title = "Book9", Author = "ago", CoverImage = "/Assets/03.jpg" });
            books.Add(new Book { BookId = 10, Title = "Book10", Author = "future", CoverImage = "/Assets/01.jpg" });
            books.Add(new Book { BookId = 11, Title = "Book11", Author = "now", CoverImage = "/Assets/02.jpg" });
            books.Add(new Book { BookId = 12, Title = "Book12", Author = "ago", CoverImage = "/Assets/03.jpg" });
            return books;
        }
    }
}
