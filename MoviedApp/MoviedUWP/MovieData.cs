using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.TMDb;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace MoviedUWP
{
    static class MovieData
    {
        public static Movies movies;
        public static Movie movie;

        public static string filter = "MOSTPOPULAR";

        public static string apiKey = "c84acd026332c3ab0c37200ff32e6f07";

        public static List<Tuple<int, double, string>> checkinsList = new List<Tuple<int, double, string>>();
        public static List<Movie> LibraryMovies = new List<Movie>();
        public static List<Movie> CheckinMovies = new List<Movie>();

        public static void downloadMovies()
        {
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(apiKey);
                switch (filter.ToUpper())
                {
                    case "MOST POPULAR":
                        movies = client.Movies.GetPopularAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "IN THEATER":
                        movies = client.Movies.GetNowPlayingAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "COMING SOON":
                        movies = client.Movies.GetUpcomingAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "HIGHEST RATED":
                        movies = client.Movies.GetTopRatedAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "NEWEST CHECKINS":
                        CheckinMovies.Clear();
                        checkinsList.Reverse();
                        foreach (Tuple<int, double, string> movie in checkinsList)
                        {
                            CheckinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        checkinsList.Reverse();
                        break;
                    case "TOP CHECKINS":
                        CheckinMovies.Clear();
                        List<Tuple<int, double, string>> topList = checkinsList.OrderByDescending(o => o.Item2).ToList();
                        
                        foreach (Tuple<int, double, string> movie in topList)
                        {
                            CheckinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        break;
                    case "LOWEST CHECKINS":
                        CheckinMovies.Clear();
                        List<Tuple<int, double, string>> lowList = checkinsList.OrderBy(o => o.Item2).ToList();
                        foreach (Tuple<int, double, string> movie in lowList)
                        {
                            CheckinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        break;
                    default:
                        if (filter != "")
                            movies = client.Movies.SearchAsync(filter, null, true, null, true, 1, new CancellationToken(false)).Result;
                        break;
                }

            });

            t.Wait();
        }

        public static List<Windows.UI.Xaml.Controls.Image> FillLibraryTable(Movies movies)
        {
            List<Windows.UI.Xaml.Controls.Image> images = new List<Windows.UI.Xaml.Controls.Image>();
            LibraryMovies.Clear();
            foreach (Movie m in movies.Results)
            {
                if (m.Poster == null)
                    continue;
                Windows.UI.Xaml.Controls.Image i = new Windows.UI.Xaml.Controls.Image();
                i.Source = new BitmapImage(new Uri(Path.Combine("https://image.tmdb.org/t/p/w500" + m.Poster)));
                i.Width = 100;
                images.Add(i);
                LibraryMovies.Add(m);
            }

            return images;
        }

        public static List<Windows.UI.Xaml.Controls.Image> FillCheckinsTable(List<Movie> movies)
        {
            List<Windows.UI.Xaml.Controls.Image> images = new List<Windows.UI.Xaml.Controls.Image>();
            //CheckinMovies.Clear();
            foreach (Movie m in movies)
            {
                if (m.Poster == null)
                    continue;
                Windows.UI.Xaml.Controls.Image i = new Windows.UI.Xaml.Controls.Image();
                i.Source = new BitmapImage(new Uri(Path.Combine("https://image.tmdb.org/t/p/w500" + m.Poster)));
                i.Width = 100;
                images.Add(i);
                //CheckinMovies.Add(m);
            }

            return images;
        }

        public static void SetMovieFormLibrary(int index)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(apiKey);
                movie = client.Movies.GetAsync(LibraryMovies[index].Id, null, true, new CancellationToken(false)).Result;
            });
            t.Wait();
        }

        public static void SetMovieFormCheckins(int index)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(apiKey);
                movie = client.Movies.GetAsync(CheckinMovies[index].Id, null, true, new CancellationToken(false)).Result;
            });

            t.Wait();
        }

    }
}
