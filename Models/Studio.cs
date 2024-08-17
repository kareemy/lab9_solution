namespace lab9_solution.Models;

public class Studio
{
    public int StudioID {get; set;}
    public string Name {get; set;} = string.Empty;
    public List<Movie> Movies {get; set;} = default!; // Navigation Property. A studio has MANY movies so we represent that with a List of movies.

    public override string ToString()
    {
        return $"{Name}";
    }
}