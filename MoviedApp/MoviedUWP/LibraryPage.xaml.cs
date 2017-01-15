using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net.TMDb;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LibraryPage : Page
    {
        private Movies movies;
        private Movie movie;

        private string filter = "MOSTPOPULAR";

        private static string apiKey = "c84acd026332c3ab0c37200ff32e6f07";

        private List<Tuple<int, int, string>> checkinsList = new List<Tuple<int, int, string>>();
        private List<Movie> checkinMovies = new List<Movie>();

        public LibraryPage()
        {
            this.InitializeComponent();
            filter = "MOST POPULAR";
            downloadMovies();
            FillLibraryTable(movies);
        }

        private void downloadMovies()
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
                        checkinMovies.Clear();
                        checkinsList.Reverse();
                        foreach (Tuple<int, int, string> movie in checkinsList)
                        {
                            checkinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        checkinsList.Reverse();
                        break;
                    case "TOP CHECKINS":
                        checkinMovies.Clear();
                        List<Tuple<int, int, string>> topList = checkinsList.OrderBy(o => o.Item2).ToList();
                        checkinsList.Reverse();
                        foreach (Tuple<int, int, string> movie in topList)
                        {
                            checkinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
                        }
                        break;
                    case "LOWEST CHECKINS":
                        checkinMovies.Clear();
                        List<Tuple<int, int, string>> lowList = checkinsList.OrderBy(o => o.Item2).ToList();
                        foreach (Tuple<int, int, string> movie in lowList)
                        {
                            checkinMovies.Add(client.Movies.GetAsync(movie.Item1, null, true, new CancellationToken(false)).Result);
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

        private void FillLibraryTable(Movies movies)
        {
            List<Windows.UI.Xaml.Controls.Image> images = new List<Windows.UI.Xaml.Controls.Image>();
            foreach (Movie m in movies.Results)
            {
                if (m.Poster == null)
                    continue;
                Windows.UI.Xaml.Controls.Image i = new Windows.UI.Xaml.Controls.Image();
                i.Source = new BitmapImage(new Uri(Path.Combine("https://image.tmdb.org/t/p/w500" + m.Poster)));
                i.Width = 100;
                images.Add(i);
            }

            MovieGrid.ItemsSource = images;
        }

        private void Filter_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filter = ((TextBlock)Filter.SelectedItem).Text;
            downloadMovies();
            FillLibraryTable(movies);
        }
    }
}
