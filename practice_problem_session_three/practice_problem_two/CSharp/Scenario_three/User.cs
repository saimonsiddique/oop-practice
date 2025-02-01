public class User
{
  public string Name { get; set; }
  public string Email { get; set; }
  private readonly List<WatchlistItem> watchlist;
  private readonly List<MovieRating> givenRating;
  private readonly List<Movie> watchHistory;

  public IReadOnlyCollection<WatchlistItem> Watchlist => watchlist.AsReadOnly();
  public IReadOnlyCollection<MovieRating> GivenRatings => givenRatings.AsReadOnly();
  public IReadOnlyCollection<Movie> WatchHistory => watchHistory.AsReadOnly();

  public void AddToWatchlist(Movie movie)
  {

  }

  public void RemoveFromWatchlist(Movie movie)
  {
  }

  public void AddToWatchHistory(Movie movie)
  {
  }

  // Method to rate a movie
  public void RateMovie(Movie movie, double ratingValue, string? review = null)
  {

  }
}

public record WatchlistItem(Movie Movie, DateTime AddedOn);