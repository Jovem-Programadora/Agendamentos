using Agendamentos.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Agendamentos.API;

public class Program
{
	public static void Main(string[] args)
	{
		// Configurando o construtor
		var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
		string connectionString = builder.Configuration["MYSQL_URI"] ?? string.Empty;
        builder.Services.AddControllers();
		builder.Services.AddDbContext<APIContext>(optionsBuilder => optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
		// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

		builder.Services.AddSwaggerGen(options =>
		{
			options.MapType<DateOnly>(() => new OpenApiSchema
			{
				Type = "string",
				Format = "date"
			});
		});

		// Configuramos o APP já criado
		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();

		app.UseAuthorization();


		app.MapControllers();

		app.Run();
	}
}
