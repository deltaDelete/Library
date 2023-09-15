using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

[Table("books")]
public class Book
{
    [Key]
    [Column("book_id")]
    public int BookId { get; set; }
    [Column("title")]
    public string Title { get; set; }
    [Column("author")]
    public string Author { get; set; }
    [Column("year")]
    public int Year { get; set; }
    [Column("publisher")]
    public string Publisher { get; set; }
}