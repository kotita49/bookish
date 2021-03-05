using System;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Data {
 public class BookContext : DbContext
{
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookDB;Trusted_Connection=True");
    }

    
    //entities
    public DbSet<Book> Books { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Copy> Copy {get; set; }
    
    
    
    
    
} 

}