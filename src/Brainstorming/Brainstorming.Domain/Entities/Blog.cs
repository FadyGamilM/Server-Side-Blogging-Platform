namespace Brainstorming.Domain.Entities;
public class Blog
{
    public int Id { get; set; }
    public string Name { get; set; } 
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    
    // blog can be created by one author
    public Author Author { get; set; }
    public int AuthorId { get; set; }

    // the blog contains one or more articles
    //public ICollection<Article> Articles { get; set; }

}
