using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class Book
    {
        public int MemberId { get; set; }

        public string Name {get; set;}
       
        public ListOfBooks BorrowedBooks {get; set;}

        public string Address {get; set;}

    
    }
  
}
