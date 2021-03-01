using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title {get; set;}
       
    // public string Title = "Harry Potter";


        public string BookAuthor {get; set;}

        public int Year {get; set;}

        public int AvailableCopies {get; set;}
    }

   
}