using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Bookish.Models
{

public class Copy
{
    public int CopyId {get; set;}

    public int BookId { get; set; }
    public Book Book {get; set;}

    public int? MemberId {get; set; }
    public Member Member {get; set;}

    public DateTime? IssueDate {get; set;}
    public DateTime? DueDate {get; set;}
}
}