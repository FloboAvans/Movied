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
            // Map Token for testing purpose,   
            // otherwise you'll get an alart message in Map Control  
            MyMap.MapServiceToken = "abcdef-abcdefghijklmno";

            geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                // Getting Current Location  
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10));

                MapIcon mapIcon = new MapIcon();
                // Locate your MapIcon  
                mapIcon.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/my-position.png"));
                // Show above the MapIcon  
                mapIcon.Title = "Current Location";
                // Setting up MapIcon location  
                mapIcon.Location = new Geopoint(new BasicGeoposition()
                {
                    //Latitude = geoposition.Coordinate.Latitude, [Don't use]  
                    //Longitude = geoposition.Coordinate.Longitude [Don't use]  
                    Latitude = geoposition.Coordinate.Point.Position.Latitude,
                    Longitude = geoposition.Coordinate.Point.Position.Longitude
                });
                // Positon of the MapIcon  
                mapIcon.NormalizedAnchorPoint = new Point(0.5, 0.5);
                MyMap.MapElements.Add(mapIcon);
                // Showing in the Map  
                await MyMap.TrySetViewAsync(mapIcon.Location, 18D, 0, 0, MapAnimationKind.Bow);

                // Disable the ProgreesBar  
                progressBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                // Set the Zoom Level of the Slider Control  
                mySlider.Value = MyMap.ZoomLevel;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox("Location service is turned off!");
            }
            //base.OnNavigatedTo(e);
        }

        // Slider Control  
        private void ZoomValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (MyMap != null)
                MyMap.ZoomLevel = e.NewValue;
        }

        private void MyMap_ZoomLevelChanged(MapControl sender, object args)
        {
            if (MyMap != null)
                mySlider.Value = sender.ZoomLevel;
        }

        // Locate Me Bottom App Bar  
        private async void LocateMe_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Visibility = Windows.UI.Xaml.Visibility.Visible;
            geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 50;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                    maximumAge: TimeSpan.FromMinutes(5),
                    timeout: TimeSpan.FromSeconds(10));
                await MyMap.TrySetViewAsync(geoposition.Coordinate.Point, 18D);
                mySlider.Value = MyMap.ZoomLevel;
                progressBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox("Location service is turned off!");
            }
        }

        // Custom Message Dialog Box  
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
