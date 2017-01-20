using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls;

namespace MoviedUWP
{
    public class Cinema
    {
        public string Title;
        public Geopoint Location;
        public string Image;
        public string Adres;

        public Cinema(string title, Geopoint location, string adres = null, string image = null)
        {
            this.Title = title;
            this.Location = location;
            this.Adres = adres;
            this.Image = image;
        }
    }
}
