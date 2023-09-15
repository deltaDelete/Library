using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

[Table("booked_books")]
public class BookedBook
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("client_id")]
    public int ClientId { get; set; }
    public Client? Client { get; set; }
    [Column("book_id")]
    public int BookId { get; set; }
    public Book? Book { get; set; }
    [Column("date")]
    public DateTime Date { get; set; }
    [Column("days")]
    public int Days { get; set; }
}