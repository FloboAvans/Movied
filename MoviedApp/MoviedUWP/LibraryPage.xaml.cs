﻿using System;
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
using Windows.System.Threading;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LibraryPage : Page
    {
        public static Action OnSearching;
        public LibraryPage()
        {
            OnSearching = () => MovieGrid.ItemsSource = MovieData.FillLibraryTable(MovieData.Movies);
            this.InitializeComponent();
            MovieData.downloadMovies();
            MovieGrid.ItemsSource = MovieData.FillLibraryTable(MovieData.Movies);
            Filter.SelectedIndex = 0;

        }

       

        private void Filter_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MovieData.Filter = ((TextBlock)Filter.SelectedItem).Text;
            MovieData.downloadMovies();
            MovieGrid.ItemsSource = MovieData.FillLibraryTable(MovieData.Movies);
            MainPage.HideSearchbar();
        }

        private void MovieGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            MovieData.SetMovieFromLibrary(MovieGrid.SelectedIndex);
            Frame.Navigate(typeof(MoviePage));
            MainPage.HideSearchbar();
        }
    }
}
