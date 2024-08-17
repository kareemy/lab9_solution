using Microsoft.EntityFrameworkCore;

namespace lab9_solution.Models;

public class MovieContext : DbContext
{
    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = database.db");
    }

    // Two entity classes, so we should have Two DbSet objects. One for each class
    public DbSet<Studio> Studios {get; set;}
    public DbSet<Movie> Movies {get; set;}
}