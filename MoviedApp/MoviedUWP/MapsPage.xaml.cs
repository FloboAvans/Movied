using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Input;
using Windows.ApplicationModel.Core;
using Windows.Devices.Geolocation;
using Windows.Devices.Geolocation.Geofencing;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Proximity;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
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
    public sealed partial class MapsPage : Page
    {
        Geolocator geolocator;

        private IList<Geofence> geofences = GeofenceMonitor.Current.Geofences;
        public delegate void OnGeofenceTriggered(Geofence geofence);
        public event OnGeofenceTriggered GeofenceEnteredEventTriggered;
        public event OnGeofenceTriggered GeofenceExitedEventTriggered;

        public MapsPage()
        {
            this.InitializeComponent();
            BasicGeoposition b = new BasicGeoposition();
            b.Latitude = 51.586096;
            b.Longitude = 4.792252;
            addGeofence(b, 20, "Kinepolis");
            this.Loaded += MainPage_Loaded;
            GeofenceMonitor.Current.GeofenceStateChanged += OnGeofenceStateChanged;
        }

        private async void OnGeofenceStateChanged(GeofenceMonitor sender, object args)
        {
            var reports = sender.ReadReports();

            await CoreApplication.MainView.Dispatcher.RunAsync
            (CoreDispatcherPriority.Normal, () =>
            {
                foreach (GeofenceStateChangeReport report in reports)
                {
                    GeofenceState state = report.NewState;
                    Geofence geofence = report.Geofence;

                    if (state == GeofenceState.Entered)
                    {
                        GeofenceEnteredEventTriggered?.Invoke(geofence);
                        MessageBox("Yeah","Arrived");
                    }
                    else if (state == GeofenceState.Exited)
                    {
                        GeofenceExitedEventTriggered?.Invoke(geofence);
                    }
                }
            });
        }

        public void addGeofence(BasicGeoposition position, double radius, string geofenceName)
        {
            Geofence newGeofence = GenerateGeofence(position, radius, geofenceName);
            bool existingGeofence = false;
            foreach (Geofence g in geofences)
            {
                if (g.Id.Equals(newGeofence.Id))
                {
                    existingGeofence = true;
                }
            }
            if (!existingGeofence)
            {
                geofences.Add(newGeofence);
            }
        }

        private Geofence GenerateGeofence(BasicGeoposition position, double radius, string geofenceName)
        {
            string geofenceId = geofenceName;
            // the geofence is a circular region:
            Geocircle geocircle = new Geocircle(position, radius);

            bool singleUse = false;

            MonitoredGeofenceStates mask = MonitoredGeofenceStates.Entered | MonitoredGeofenceStates.Exited;

            TimeSpan dwellTime = new TimeSpan(0, 0, 1);

            return new Geofence(geofenceId, geocircle, mask, singleUse, dwellTime);
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

                MapIcon location = new MapIcon();

                location.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/my-position.png"));

                //mapIcon.Title = "Current Location";

                location.Location = new Geopoint(new BasicGeoposition()
                { 
                    Latitude = geoposition.Coordinate.Point.Position.Latitude,
                    Longitude = geoposition.Coordinate.Point.Position.Longitude
                });
                // Positon of the MapIcon  
                location.NormalizedAnchorPoint = new Point(0.5, 0.5);
                MyMap.MapElements.Add(location);

                MovieData.Cinemas.Add(new Cinema("Pathé Breda", new Geopoint(new BasicGeoposition()
                {
                    Latitude = 51.589715,
                    Longitude = 4.785032
                }), "Chasséveld 15, 4811 DH Breda", "pathe_breda.jpg"));

                MovieData.Cinemas.Add(new Cinema("Kinepolis Breda", new Geopoint(new BasicGeoposition()
                {
                    Latitude = 51.580753,
                    Longitude = 4.835116
                }), "Bavelseparklaan 4, 4817 ZX Breda", "kinepolis_breda.jpg"));
                
                foreach (Cinema cinema in MovieData.Cinemas)
                {
                    MapIcon mapIcon = new MapIcon();
                    mapIcon.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/cinema.png"));
                    mapIcon.Location = new Geopoint(new BasicGeoposition()
                    {
                        Latitude = cinema.Location.Position.Latitude,
                        Longitude = cinema.Location.Position.Longitude,
                    });
                    mapIcon.NormalizedAnchorPoint = new Point(0.5, 0.5);
                    MyMap.MapElements.Add(mapIcon);
                }

                // Showing in the Map  
                await MyMap.TrySetViewAsync(location.Location, 18D, 0, 0, MapAnimationKind.Bow);

                 
                progressBar.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                border.Visibility = Visibility.Collapsed;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox("Location service is turned off!", "Error");
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
                MessageBox("Location service is turned off!", "Error");
            }
        }
        private async void MessageBox(string message, string title)
        {
            var dialog = new MessageDialog(message.ToString(), title);
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => await dialog.ShowAsync());
        }

        private async void ContentBox(string message, string title, string image = null)
        {
            var dialog = new ContentDialog();
            dialog.FontFamily =  new FontFamily("ms-appx:///Assets/Quicksand-Light.ttf#Quicksand");
            dialog.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            dialog.Background = new SolidColorBrush(Color.FromArgb(200,18,31,31));
            dialog.Title = title;
            dialog.PrimaryButtonText = "Route";
            dialog.SecondaryButtonText = "Cancel";
            //dialog.Comm
            Grid g = new Grid();
            g.RowDefinitions.Add(new RowDefinition());
            g.RowDefinitions.Add(new RowDefinition());
            TextBlock t = new TextBlock();
            t.Text = message;
            Grid.SetRow(t, 0);
            Image i = new Image();
            i.Source = new BitmapImage(new Uri("ms-appx:///Assets/Cinemas/" + image));
            i.Width = 200;
            i.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(i,1);
            g.Children.Add(t);
            g.Children.Add(i);
            dialog.Content = g;
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () => await dialog.ShowAsync());
        }

        private void MyMap_OnMapElementClick(MapControl sender, MapElementClickEventArgs args)
        {
            MapIcon myClickedIcon = args.MapElements.FirstOrDefault(x => x is MapIcon) as MapIcon;
            Cinema c = MovieData.Cinemas.Find(x => (x.Location.Position.Latitude == myClickedIcon.Location.Position.Latitude && x.Location.Position.Longitude == myClickedIcon.Location.Position.Longitude));
            ContentBox(c.Adres, c.Title, c.Image);
        }

        private void MapIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
