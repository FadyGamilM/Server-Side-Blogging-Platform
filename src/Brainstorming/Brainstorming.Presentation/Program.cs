using Brainstorming.DAL;
using Microsoft.EntityFrameworkCore;
using Brainstorming.Domain;
using Brainstorming.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);
// ==> inject all services
builder.Services.RegisterApplicationServices(builder);


var app = builder.Build();
// ==> inject all middlewares
app.RegisterMiddlewares();

app.Run();

