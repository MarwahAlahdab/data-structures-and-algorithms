using System;
using System.Collections.Generic;
using System.Linq;
using Sorting;

public class Program
{
  public static void Main()
  {


    // Sample data
    List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "Movie 1", Year = 1999, Genres = new List<string> { "Action", "Crime" } },
            new Movie { Title = "The Dreamseller", Year = 2016, Genres = new List<string> { "Action", "Adventure" } },
            new Movie { Title = "A Anyhting", Year = 2010, Genres = new List<string> { "Action", "Adventure" } },
            new Movie { Title = "An Movie", Year = 1994, Genres = new List<string> { "Crime", "Drama" } }
        };




    List<Movie> sortedByYear = SortMoviesByYear(movies);
    Console.WriteLine("Sorted by Year:");
    foreach (var movie in sortedByYear)
    {
      Console.WriteLine($"{movie.Title} ({movie.Year})");
    }



    List<Movie> sortedByTitle = SortMoviesByTitle(movies);
    Console.WriteLine("Sorted by Title:");
    foreach (var movie in sortedByTitle)
    {
      Console.WriteLine(movie.Title);
    }



  }





  public static List<Movie> SortMoviesByYear(List<Movie> movies)
  {
    return movies.OrderByDescending(movie => movie.Year).ToList();
  }



  // Sort movies alphabetically 
  
  public static List<Movie> SortMoviesByTitle(List<Movie> movies)
  {
    return movies.OrderBy(movie => RemoveLeadingArticlesAndTrim(movie.Title)).ToList();
  }



  public static string RemoveLeadingArticlesAndTrim(string title)
  {
    // Remove leading "A", "An", or "The" and trim spaces
    string[] articles = { "A ", "An ", "The " };
    string trimmedTitle = title.Trim();

    foreach (var article in articles)
    {
      if (trimmedTitle.StartsWith(article, StringComparison.OrdinalIgnoreCase))
      {
        trimmedTitle = trimmedTitle.Substring(article.Length).Trim();
        break;
      }
    }

    return trimmedTitle;
  }






}



