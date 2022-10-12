using DemoModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CMP_1005_Fall_2022_Cors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private ICollection<Book> Books { get; set; }

        public BookController()
        {
            Books = new List<Book>();

            Books.Add(new Book() { Title = "Default Title", ISBN = "0123456789", Author = new Author() { FirstName = "Brent", LastName = "Ritchie", Email = "brent.ritchie@cambriancollege.ca" } });
        }

        [HttpGet]
        public Book? GetBooks()
        {
            return Books.FirstOrDefault();
        }

        [HttpPost]
        public Book? CreateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                return book;
            }
            else
            {
                return Books.FirstOrDefault();
            }
        }
    }
}
