using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        public string Name {get; set;} 

        public string Address {get; set;}

        public ICollection<Copy> Copies {get; set;}

        public int? CopyId {get; set; }
    
    }
  
}
