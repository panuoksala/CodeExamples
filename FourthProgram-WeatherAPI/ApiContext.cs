using Microsoft.EntityFrameworkCore;

namespace FourthProgram_WeatherAPI
{
    // This class defines how our database looks like and what tables it contains
    public class ApiContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<RainDetection> RainDetections { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        // When this context is created for the first time, we will also create the database table, based on WeatherForecast class structure.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().ToTable("WeatherForecast");
            modelBuilder.Entity<RainDetection>().ToTable("RainDetection");
        }
    }
}
