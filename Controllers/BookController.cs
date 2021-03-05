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
                var allBooks = context.Books.OrderBy(o => o.BookAuthor).ToList(); //this is a List of books
                var displayedBooks = new ListOfBooks { BookList = allBooks };
                
               
            return View(displayedBooks);
        }
         public IActionResult Checkout()
         {
                              
            return View(); 
         }
         
         [HttpPost]
          public IActionResult Checkout(CheckoutForm checkoutForm)
         {
             using (var context = new BookContext())
            {
               var copy = context.Copy.Single(s=>s.CopyId == checkoutForm.CopyId);
               copy.MemberId = checkoutForm.MemberId;
               copy.IssueDate = DateTime.Now;
               copy.DueDate = DateTime.Now.AddDays(7);
               context.SaveChanges();
               
               var member = context.Members.Single(s=>s.MemberId == checkoutForm.MemberId);
                var displayCopies = new ListOfCopies { CopyList = member.Copies.ToList() };
               displayCopies.ToList().Add(copy);
               member.CopyId = checkoutForm.CopyId;
                     
                
               context.SaveChanges();

            }
 
            return RedirectToAction("CheckedOutBooks");
        } 
       
              
        [HttpPost]
        public IActionResult AddBookCopy(int id)
        {
            using (var context = new BookContext())
            {
                var newCopy = new Copy()
                    {
                      BookId = id,
                
                    };
                context.Copy.Add(newCopy);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
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
