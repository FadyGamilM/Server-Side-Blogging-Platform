using Brainstorming.DAL;
using Microsoft.EntityFrameworkCore;

namespace Brainstorming.Presentation.Extensions;
internal static class ServicesExtensions
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services, WebApplicationBuilder builder)
    {
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        // inject the Db Context
        builder.Services.AddDbContext<BrainstormingDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }
}
