using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models;

[Table("Category")]
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(80)]
    [Column("Name", TypeName = "NVARCHAR")]
    public required string Name { get; set; }

    [Required]
    [MaxLength(80)]
    [Column("Slug", TypeName = "VARCHAR")]
    public required string Slug { get; set; }
}