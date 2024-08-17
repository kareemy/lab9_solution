using Microsoft.EntityFrameworkCore;
using lab9_solution.Models;

using var db = new MovieContext();
db.Database.EnsureDeleted();
db.Database.EnsureCreated();

// Task 2: Create 20th Century Fox Studio Object with 4 movies
Studio fox = new Studio {
    Name = "20th Century Fox",
    Movies = new List<Movie>
    {
        new Movie { Title = "Avatar", Genre = "Action"},
        new Movie { Title = "Deadpool", Genre = "Action" },
        new Movie { Title = "Apollo 13", Genre = "Drama"},
        new Movie { Title = "The Martian", Genre = "Sci-Fi"}
    }
};

db.Add(fox);
db.SaveChanges();

// Task 3: Create Universal Pictures studio without any movies
Studio universal = new Studio { Name = "Universal Pictures" };
db.Add(universal);
db.SaveChanges();


// Task 4: Add Jurassic Park movie and place it in Universal Pictures
Movie jurassicPark = new Movie {Title = "Jurassic Park", Genre = "Action"};
// Find Universal Pictures in the database.
Studio universalInDatabase = db.Studios.Where(s => s.Name == "Universal Pictures").First();
jurassicPark.Studio = universalInDatabase;
db.Add(jurassicPark);
db.SaveChanges();

// Task 5: Move Apollo 13 to Universal Pictures
Movie apollo13 = db.Movies.Where(m => m.Title == "Apollo 13").First();
apollo13.Studio = db.Studios.Where(s => s.Name == "Universal Pictures").First();
db.SaveChanges();

// Task 6: Remove Deadpool
Movie deadpool = db.Movies.Where(m => m.Title == "Deadpool").First();
db.Remove(deadpool);
db.SaveChanges();

// Task 7: List all studios and their movies
foreach (var studio in db.Studios.Include(s => s.Movies))
{
    Console.WriteLine($"{studio} - {studio.Movies.Count} movies");
    foreach (var movie in studio.Movies)
    {
        Console.WriteLine($"\t{movie}");
    }
    Console.WriteLine();
}

// Task 8: List all movies from Z-A with their studio
foreach (var movie in db.Movies.Include(m => m.Studio).OrderByDescending(m => m.Title))
{
    Console.WriteLine($"{movie} - {movie.Studio.Name}");
}