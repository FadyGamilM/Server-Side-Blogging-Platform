using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Brainstorming.Domain.Entities;
public class Author
{
    [Column("authorId")]
    public int Id { get; set; }
        
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string FullName => this.FirstName + " " + this.LastName;
    public DateTime? DateOfBirth { get; set; }
    public string? Bio { get; set; }

    // one author can authorize one or more articles
    public ICollection<Article> Articles { get; set; }


}
