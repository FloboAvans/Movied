using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.TMDb;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Image = Windows.UI.Xaml.Controls.Image;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MoviePage : Page
    {
        public MoviePage()
        {
            this.InitializeComponent();

            ButtonGrid.Background = new SolidColorBrush(Color.FromArgb(150, 0, 0, 0));
            FillPage();
        }

        public void FillPage()
        {
            CoverImage.Source = new BitmapImage(new Uri(Path.Combine("https://image.tmdb.org/t/p/w500" + MovieData.movie.Poster)));

            WebView v = new WebView();
            v.NavigateToString(@"<iframe height=""100%"" width=""100%"" src=""https://www.youtube.com/embed/" + MovieData.movie.Videos.Results.First().Key + @"?rel=0&controls=0&?showinfo=0"" frameborder=""0""></iframe>");
            MediaViewer.Items.Add(v);

            foreach (System.Net.TMDb.Image img in MovieData.movie.Images.Backdrops)
            {
                Image i = new Image();
                i.Source = new BitmapImage(new Uri(Path.Combine("https://image.tmdb.org/t/p/w500" + img.FilePath)));
                MediaViewer.Items.Add(i);
            }

            foreach (Genre g in MovieData.movie.Genres)
            {
                GenreText.Text = GenreText.Text + ", " + g.Name;
            }
            TimeText.Text = (MovieData.movie.Runtime + " min.") ?? "-";
            DateText.Text = String.Format("{0:MMMM dd, yyyy}", MovieData.movie.ReleaseDate) ?? "-";
            LanguageText.Text = MovieData.movie.Languages.First().Name ?? "-";
            OverviewText.Text = MovieData.movie.Overview;

            List<MediaCast> cast = new List<MediaCast>();
            foreach (MediaCast c in MovieData.movie.Credits.Cast.Take(3))
            {
                cast.Add(c);
            }
            Actor1.Text = cast[0].Name ?? "-";
            Actor2.Text = cast[1].Name ?? "-";
            Actor3.Text = cast[2].Name ?? "-";
            Role1.Text = cast[0].Character ?? "-";
            Role2.Text = cast[1].Character ?? "-";
            Role3.Text = cast[2].Character ?? "-";

            List<MediaCrew> crew = new List<MediaCrew>();
            foreach (MediaCrew c in MovieData.movie.Credits.Crew.Take(3))
            {
                crew.Add(c);
            }
            Crew1.Text = crew[0].Name ?? "-";
            Crew2.Text = crew[1].Name ?? "-";
            Crew3.Text = crew[2].Name ?? "-";
            Job1.Text = crew[0].Job ?? "-";
            Job2.Text = crew[1].Job ?? "-";
            Job3.Text = crew[2].Job ?? "-";
        }
    }
}
