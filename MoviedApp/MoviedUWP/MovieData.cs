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
using Shared_Code;

namespace MoviedUWP
{
    static class MovieData
    {
        public static Movies Movies;
        public static Movie Movie;

        public static string Filter = "MOSTPOPULAR";

        public static readonly string ApiKey = "c84acd026332c3ab0c37200ff32e6f07";

        public static List<Tuple<int, double, string>> CheckinsList = new List<Tuple<int, double, string>>();
        public static List<Movie> LibraryMovies = new List<Movie>();
        public static List<Movie> CheckinMovies = new List<Movie>();
        public static List<Movie> WatchlistMovies = new List<Movie>();

        //private static void checkIn()
        //{
        //    CheckIn a = default(CheckIn);

        //    a.Content |= CheckIn.ContentE.Description;
        //    a.description = "desription";

        //    a.Content ^= CheckIn.ContentE.Date;

        //}

        public static void downloadMovies()
        {
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(ApiKey);
                switch (Filter.ToUpper())
                {
                    case "MOST POPULAR":
                        Movies = client.Movies.GetPopularAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "IN THEATER":
                        Movies = client.Movies.GetNowPlayingAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "COMING SOON":
                        Movies = client.Movies.GetUpcomingAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "HIGHEST RATED":
                        Movies = client.Movies.GetTopRatedAsync(null, 1, new CancellationToken(false)).Result;
                        break;
                    case "NEWEST CHECKINS":
                        CheckinMovies.Clear();
                        CheckinsList.Reverse();
                        foreach (Tuple<int, double, string> movie in CheckinsList)
                        {
                            CheckinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        CheckinsList.Reverse();
                        break;
                    case "TOP CHECKINS":
                        CheckinMovies.Clear();
                        List<Tuple<int, double, string>> topList = CheckinsList.OrderByDescending(o => o.Item2).ToList();
                        
                        foreach (Tuple<int, double, string> movie in topList)
                        {
                            CheckinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        break;
                    case "LOWEST CHECKINS":
                        CheckinMovies.Clear();
                        List<Tuple<int, double, string>> lowList = CheckinsList.OrderBy(o => o.Item2).ToList();
                        foreach (Tuple<int, double, string> movie in lowList)
                        {
                            CheckinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        break;
                    default:
                        if (Filter != "")
                            Movies = client.Movies.SearchAsync(Filter, null, true, null, true, 1, new CancellationToken(false)).Result;
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

        public static List<Windows.UI.Xaml.Controls.Image> FillNormalTable(List<Movie> movies)
        {
            List<Windows.UI.Xaml.Controls.Image> images = new List<Windows.UI.Xaml.Controls.Image>();
            foreach (Movie m in movies)
            {
                if (m.Poster == null)
                    continue;
                Windows.UI.Xaml.Controls.Image i = new Windows.UI.Xaml.Controls.Image();
                i.Source = new BitmapImage(new Uri(Path.Combine("https://image.tmdb.org/t/p/w500" + m.Poster)));
                i.Width = 100;
                images.Add(i);
            }
            return images;
        }

        public static void SetMovieFromLibrary(int index)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(ApiKey);
                Movie = client.Movies.GetAsync(LibraryMovies[index].Id, null, true, new CancellationToken(false)).Result;
            });
            t.Wait();
        }

        public static void SetMovieFromCheckins(int index)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(ApiKey);
                Movie = client.Movies.GetAsync(CheckinMovies[index].Id, null, true, new CancellationToken(false)).Result;
            });

            t.Wait();
        }

        public static void SetMovieFromWatchlist(int index)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                var client = new ServiceClient(ApiKey);
                Movie = client.Movies.GetAsync(WatchlistMovies[index].Id, null, true, new CancellationToken(false)).Result;
            });

            t.Wait();
        }

    }
}
