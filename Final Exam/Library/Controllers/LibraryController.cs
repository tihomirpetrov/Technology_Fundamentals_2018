namespace Library.Controllers
{
    using Library.Data;
    using Library.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    public class LibraryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                List<Book>books = db.Books.ToList();
                return View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string author, double price)
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

            using (LibraryDbContext db = new LibraryDbContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                Book oldBook = db.Books.FirstOrDefault(x => x.Id == id);
                if (oldBook == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldBook);
            }

        }

        [HttpPost]
        public IActionResult Edit(Book newBook)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            using (LibraryDbContext db = new LibraryDbContext())
            {
                Book oldBook = db.Books.FirstOrDefault(x => x.Id == newBook.Id);
                if (oldBook == null)
                {
                    return RedirectToAction("Index");
                }

                oldBook.Title = newBook.Title;
                oldBook.Author = newBook.Author;
                oldBook.Price = newBook.Price;

                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                Book oldBook = db.Books.FirstOrDefault(x => x.Id == id);
                if (oldBook == null)
                {
                    return RedirectToAction("Index");
                }

                return View(oldBook);
            }

        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            using (LibraryDbContext db = new LibraryDbContext())
            {
                if (book == null)
                {
                    return RedirectToAction("Index");
                }

                db.Books.Remove(book);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

        }
    }
}