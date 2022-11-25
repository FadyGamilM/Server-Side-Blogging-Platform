using Brainstorming.Domain.Entities;

using Microsoft.EntityFrameworkCore;
namespace Brainstorming.DAL;
public class BrainstormingDbContext : DbContext
{
    public BrainstormingDbContext(DbContextOptions<BrainstormingDbContext> options)
        : base(options) { }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Category> Categories { get; set; }
}
