using System;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Data {
 public class BookContext : DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookDB;user=ZOO/tatrutadmin;password=&inger_sn4p4263");
    }

    
    //entities
    public DbSet<Book> Books { get; set; }
    
} 

}