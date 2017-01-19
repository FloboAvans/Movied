using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            //TODO CHECK WITH SERVER @FLOBO!!
            if (UsernameTextBox.Text != "good_username")
            {
                UsernameTextBox.Background = new SolidColorBrush(new Color());
            }
            if (PasswordTextBox.Text != "good_password")
            {
                PasswordTextBox.Background = new SolidColorBrush(new Color());
            }
            else
            {
                Frame.Navigate(typeof(MainPage));
            }
                
        }

        private void NewUser_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            //TODO CHECK WITH SERVER @FLOBO!!
            if (UsernameTextBox.Text == "" || UsernameTextBox.Text == "username")
            {
                UsernameTextBox.Background = new SolidColorBrush(new Color());
            }
            if (UsernameTextBox.Text == "" || UsernameTextBox.Text == "password")
            {
                PasswordTextBox.Background = new SolidColorBrush(new Color());
            }
            else
            {
                //TODO ADD NEW USER ON SERVER @FLOBO
                Frame.Navigate(typeof(MainPage));
            }
        }
    }
}
