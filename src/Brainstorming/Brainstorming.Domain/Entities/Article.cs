namespace Brainstorming.Domain.Entities;
public class Article
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string? SubTitle { get; set; } = "";
    public string Body { get; set; } = "";
    public int Likes { get; set; } = 0;
    public int Shares { get; set; } = 0;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;

    // one article can have one author
    public Author Author { get; set; }
    public int AuthorId { get; set; }
        
    // one article can be categorized under one or more category
    public ICollection<Category> Categories { get; set; }

    // one article belonged to one blog
    //public Blog Blog { get; set; }
    //public int BlogId { get; set; }
}
