// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using Bookish.Data;
// using Bookish.Models;
// using System;
// using System.Linq;

// namespace Bookish.Models
// {
//     public static class SeedData
//     {
//         public static void Initialize(IServiceProvider serviceProvider)
//         {
//             using (var context = new BookContext(
//                 serviceProvider.GetRequiredService<
//                     DbContextOptions<BookContext>>()))
//             {
//                 // Look for any movies.
//                 if (context.Books.Any())
//                 {
//                     return;   // DB has been seeded
//                 }

//                 context.Books.AddRange(
                   
//                 var book1 = new Book()
//                 {
//                      BookId = 2,
//                      Title = "Gone With the Wind",
//                      BookAuthor = "M. Mitchell",
//                      Year = 1936,
//                      AvailableCopies = 30,
//                 };

//                 context.Books.Add(book1);
//                 context.SaveChanges();
//             }

//                 );
//                 context.SaveChanges();
//             }
//         }
//     }
// }