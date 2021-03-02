using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Data;



namespace Bookish.Controllers
{
    [Route("Book")]
    public class BookController : Controller
    {
                // [HttpGet("Book")]
        public IActionResult Index()
        {
        var context = new BookContext();

        var top5books = context.Books.Take(5).ToList();//this is a List of books
        var displayedBooks = new ListOfBooks { BookList = top5books };
            return View(displayedBooks);

            // using (var context = new BookContext()) {

            //     var book = new Book()
            //     {
            //          Name = ""
            //          Title = ""
            //          BookAuthor = ""
            //          Year = 
            //          AvailableCopies =

            //     };

            //     context.Students.Add(std);
            //     context.SaveChanges();

            //    var exampleBook = new Book(){
            // BookId = 1,
            // Title = "Harry Potter",
            // BookAuthor = "J.K.Rowling",
            // Year = 2001,
            // AvailableCopies = 2
    //     };

    //   return View(exampleBook);

    //     }


        }

    }

}



