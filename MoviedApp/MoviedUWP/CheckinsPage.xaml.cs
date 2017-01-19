﻿using System;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CheckinsPage : Page
    {
        public CheckinsPage()
        {
            this.InitializeComponent();
            Filter.SelectedIndex = 0;
            MovieData.downloadMovies();
            MovieGrid.ItemsSource = MovieData.FillCheckinsTable(MovieData.CheckinMovies);
            
        }

        private void MovieGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MovieData.SetMovieFormCheckins(MovieGrid.SelectedIndex);
            Frame.Navigate(typeof(MoviePage));
        }

        private void Filter_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MovieData.filter = ((TextBlock)Filter.SelectedItem).Text;
            MovieData.downloadMovies();
            MovieGrid.ItemsSource = MovieData.FillCheckinsTable(MovieData.CheckinMovies);
        }
    }
}
