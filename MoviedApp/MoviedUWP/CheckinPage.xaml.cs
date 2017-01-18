using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CheckinPage : Page
    {
        private int? changingIndex = null;
        public CheckinPage()
        {
            this.InitializeComponent();
            

            foreach (System.Net.TMDb.Image img in MovieData.movie.Images.Backdrops)
            {
                Image i = new Image();
                i.Source = new BitmapImage(new Uri(Path.Combine("https://image.tmdb.org/t/p/w500" + img.FilePath)));
                MediaViewer.Items.Add(i);
            }
            TitleText.Text = MovieData.movie.Title;
            int x = 0;
            foreach (var tuple in MovieData.checkinsList)
            {
                if (tuple.Item1 == MovieData.movie.Id)
                {
                    Stars.Value = tuple.Item2;
                    CommentText.Text = tuple.Item3;
                    changingIndex = x;
                    break;
                }
                x++;
            }
            RatingText.Text = "Rating " + Stars.Value;
        }

        private void Stars_OnPointerReleased(object sender, PointerRoutedEventArgs e)
        {
            RatingText.Text = "Rating " + Stars.Value;
        }

        private void SaveCheckin_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            //TODO add checkin to the server
            if (changingIndex != null)
            {
                MovieData.checkinsList[changingIndex.Value] = new Tuple<int, double, string>(MovieData.movie.Id, Stars.Value, CommentText.Text);
            }
            else
            {
                MovieData.checkinsList.Add(new Tuple<int, double, string>(MovieData.movie.Id, Stars.Value, CommentText.Text));
            }
            MovieData.filter = "newest checkins";
            MovieData.downloadMovies();
            Frame.GoBack();
        }
    }
}
