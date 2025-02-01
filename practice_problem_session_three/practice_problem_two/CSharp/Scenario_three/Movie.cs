public class Movie
{
    public string Title { get; }
    public Genre Genre { get; }
    public DateTime ReleaseDate { get; }

    private readonly List<MovieRating> ratings = new();

    public IReadOnlyCollection<MovieRating> Ratings => ratings.AsReadOnly();

    public void AddRating(MovieRating rating)
    {
        ratings.Add(rating);
    }
}

public record MovieRating(User User, double RatingValue, string? Review, DateTime RatedOn);
public enum Genre
{
    Action,
    Comedy,
    Drama,
    Fantasy,
    Horror,
    Romance,
    SciFi
}