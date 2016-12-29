using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MoviedUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MenuGrid.Background = new SolidColorBrush(Color.FromArgb(245, 25, 35, 50));
        }

        private void MenuButton_OnClick(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void Menu_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null && e.AddedItems.Any())
            {
                ListViewItem listViewItem = Menu.ContainerFromItem(e.AddedItems[0]) as ListViewItem;
                listViewItem.FontWeight = FontWeights.ExtraBlack;
            }

            if (e.RemovedItems != null && e.RemovedItems.Any())
            {
                ListViewItem listViewItem = Menu.ContainerFromItem(e.RemovedItems[0]) as ListViewItem;
                listViewItem.FontWeight = FontWeights.Normal;
            }
        }
    }
}
