using Brainstorming.DAL;
using Microsoft.EntityFrameworkCore;
using Brainstorming.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// inject the Db Context
builder.Services.AddDbContext<BrainstormingDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

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

app.Run();

internal record AuthorEntitiy (string firstName, string lastName);