using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class ListOfBooks    {
        
        public  List<Book> BookList { get ; set ; }

           }
  
}
