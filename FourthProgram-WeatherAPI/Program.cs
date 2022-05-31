using FourthProgram_WeatherAPI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Define context object and the database connection string
builder.Services.AddDbContext<ApiContext>(options =>
  options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=WeatherForecast;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False;"));

var app = builder.Build();

// This will create the database for us.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ApiContext>();
    context.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

