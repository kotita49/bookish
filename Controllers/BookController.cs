using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bookish.Data;
using Bookish.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bookish.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var context = new BookContext();

            var top5books = context.Books.Take(5).ToList(); //this is a List of books
            var displayedBooks = new ListOfBooks { BookList = top5books };
            return View(displayedBooks);
        }

        public IActionResult AddBookForm()
        {
            return View("AddBookForm");
        }

        [HttpPost]
        public IActionResult AddBookForm(Book book)
        {
            using (var context = new BookContext())
            {
                var newBook =
                    new Book()
                    {
                        Title = book.Title,
                        BookAuthor = book.BookAuthor,
                        Year = book.Year,
                        AvailableCopies = book.AvailableCopies
                    };
                context.Books.Add (newBook);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult SearchResult(string SearchYear)
        {
            var context = new BookContext();
            var books = from b in context.Books select b;

            if (!String.IsNullOrEmpty(SearchYear))
            {
                books = books.Where(b => b.Year == Int32.Parse(SearchYear));
            }
            var resultBooks = new ListOfBooks { BookList = books.ToList() };
            return View(resultBooks);

            // var bookWithSameYear = context.Books
            //                                 .Where(b => b.Year == searchYear)
            //                                 .ToList();
            // var searchResult = new ListOfBooks {BookList = bookWithSameYear};
            // return View(searchResult);
        }

        // public static string GetYear() {
        //     return 1936;
        //        }
    }
}
