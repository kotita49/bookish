using System;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Data {
 public class BookContext : DbContext
{
    public BookContext()
    {
  
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\WOODPECKER;Database=BookDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    //entities
    public DbSet<Book> Students { get; set; }
    
} 

}