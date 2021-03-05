using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class CheckoutForm
    {
        public int FormId { get; set; }

        public int CopyId {get; set;}

        public int MemberId {get; set;}

    }
  
}
