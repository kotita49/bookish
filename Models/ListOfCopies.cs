using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class ListOfCopies    {

    
        public  IEnumerable<Copy> CopyList { get ; set ; }
       

           }
  
}
