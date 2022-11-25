using System.ComponentModel.DataAnnotations;

namespace Brainstorming.Domain.Entities;
public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage ="Category name is a required field")]
    public string Name { get; set; }
    
    public string? Description { get; set; }

    // one category can be assigned to one or more articles
    public ICollection<Article> Articles { get; set; }
}
