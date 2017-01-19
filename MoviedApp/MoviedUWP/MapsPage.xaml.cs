using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class MapsPage : Page
    {
        Geolocator geolocator;

        public MapsPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;
            try
            { 
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10));

                MapIcon mapIcon = new MapIcon();
                 
                mapIcon.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/my-position.png"));

                //mapIcon.Title = "Current Location";

                mapIcon.Location = new Geopoint(new BasicGeoposition()
                { 
                    Latitude = geoposition.Coordinate.Point.Position.Latitude,
                    Longitude = geoposition.Coordinate.Point.Position.Longitude
                });
                // Positon of the MapIcon  
                mapIcon.NormalizedAnchorPoint = new Point(0.5, 0.5);
                MyMap.MapElements.Add(mapIcon);
                // Showing in the Map  
                await MyMap.TrySetViewAsync(mapIcon.Location, 18D, 0, 0, MapAnimationKind.Bow);

                 
                progressBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                border.Visibility = Visibility.Collapsed;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox("Location service is turned off!");
            }
        }
        
        private async void LocateMe_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Visibility = Windows.UI.Xaml.Visibility.Visible;
            border.Visibility = Visibility;
            geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10));
                await MyMap.TrySetViewAsync(geoposition.Coordinate.Point, 18D);
                progressBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                border.Visibility = Visibility.Collapsed;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox("Location service is turned off!");
            }
        }
        private async void MessageBox(string message)
        {
            var dialog = new MessageDialog(message.ToString());
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => await dialog.ShowAsync());
        }

        private async void MyMap_MapTapped(MapControl sender, MapInputEventArgs args)
        {
            Geopoint pointToReverseGeocode = new Geopoint(args.Location.Position);
            // Reverse geocode the specified geographic location.  
            MapLocationFinderResult result = await MapLocationFinder.FindLocationsAtAsync(pointToReverseGeocode);
            var resultText = new StringBuilder();
            if (result.Status == MapLocationFinderStatus.Success)
            {
                resultText.AppendLine(result.Locations[0].Address.District + ", " + result.Locations[0].Address.Town + ", " + result.Locations[0].Address.Country);
            }
            MessageBox(resultText.ToString());
        }
    }
}
