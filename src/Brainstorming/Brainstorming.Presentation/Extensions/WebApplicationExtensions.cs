using Brainstorming.DAL;
using Brainstorming.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Brainstorming.Presentation.Extensions;


internal record AuthorEntitiy(string firstName, string lastName);

internal static class WebApplicationExtensions
{
    public static WebApplication RegisterMiddlewares(this WebApplication app)
    {

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();


        app.MapGet("/api/authors", async (BrainstormingDbContext _context) =>
        {
            var authors = await _context.Authors.ToListAsync();
            return authors;
        })
        .WithName("GetWeatherForecast");


        app.MapPost("/api/authors", async (BrainstormingDbContext _context, AuthorEntitiy entity) => {
            var author = new Brainstorming.Domain.Entities.Author();
            author.FirstName = entity.firstName;
            author.LastName = entity.lastName;
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return author;
        });

        return app;
    }
}
