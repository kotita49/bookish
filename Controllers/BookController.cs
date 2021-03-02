using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using System.Web;



namespace Bookish.Controllers
{
    [Route("Book")]
     public class BookController : Controller
    {
        // [HttpGet("Book")]
        public IActionResult Book()
        {
            var exampleBook = new Book(){
                BookId = 1,
                Title = "Harry Potter",
                BookAuthor = "J.K.Rowling",
                Year = 2001,
                AvailableCopies = 2
            };
            return View(exampleBook);
        }
        // [HttpGet("book-title")]
        // public IActionResult Book()

       
        //     }
}
}

