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
         [HttpGet("Book")]
        public IActionResult Book()
        {
            return View();
        }
        // [HttpGet("book-title")]
        // public IActionResult Book()

       
        //     }
}
}

