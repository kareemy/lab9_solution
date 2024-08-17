namespace lab9_solution.Models;

public class Movie
{
    public int MovieID {get; set;}
    public string Title {get; set;} = string.Empty;
    public string Genre {get; set;} = string.Empty;
    public int StudioID {get; set;} // Foreign Key
    public Studio Studio {get; set;} = default!; // Navigation Property: A movie belongs to ONE studio

    public override string ToString()
    {
        return $"{Title} - {Genre}";
    }
}