using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

[Table("genders")]
public class Gender
{
    [Key]
    [Column("gender_id")]
    public int GenderId { get; set; }
    [Column("name")] 
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}