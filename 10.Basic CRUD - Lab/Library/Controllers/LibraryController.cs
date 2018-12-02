namespace Library.Controllers
{
    using System.Linq;
    using Library.Data;
    using Library.Models;
    using Microsoft.AspNetCore.Mvc;
    public class LibraryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new LibraryDbContext())
            {
                var allBooks = db.Books.ToList();
                return View(allBooks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(string title, string author, decimal price)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                return RedirectToAction("Index");
            }

            Book book = new Book
            {
                Title = title,
                Author = author,
                Price = price
            };

            using (var db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(t => t.Id == id);
                if (bookToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (var db = new LibraryDbContext())
            {
                var bookToEdit = db.Books.FirstOrDefault(t => t.Id == book.Id);
                bookToEdit.Title = book.Title;
                bookToEdit.Author = book.Author;
                bookToEdit.Price = book.Price;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var db = new LibraryDbContext())
            {
                Book bookDetails = db.Books.FirstOrDefault(t => t.Id == id);
                if (bookDetails == null)
                {
                    RedirectToAction("Index");
                }
                return View(bookDetails);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (var db = new LibraryDbContext())
            {
                if (book == null)
                {
                    RedirectToAction("Index");
                }
                db.Books.Remove(book);
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}