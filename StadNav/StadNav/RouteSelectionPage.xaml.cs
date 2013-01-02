using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace StadNav
{
    public partial class RouteSelectionPage : PhoneApplicationPage
    {
        //private ObservableCollection<Route> routeNames;
 
        public RouteSelectionPage()
        {
            InitializeComponent();
            //routeNames = new ObservableCollection<Route>();
            //routeNames.Add(new Route("Test"));
            listBox1.ItemsSource = Database.GetAllRoutes();
            //this.Loaded += new RoutedEventHandler(RouteSelectionPage_Loaded);
        }

        public void RouteSelectionPage_Loaded(object sender, RoutedEventArgs e)
        {
            updateLanguage();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            //Changes language      
            PhoneApplicationService.Current.State["language"] = !(bool)PhoneApplicationService.Current.State["language"];
            updateLanguage();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/MainPage.xaml"), UriKind.Relative));
        }

        private void updateLanguage()
        {
            if (!(bool)PhoneApplicationService.Current.State["language"])
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/eng.jpg", UriKind.Relative));
                title.Text = "Choose route";
            }
            else
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));
                title.Text = "Kies een route";
            }
        }

        private void listBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Route selectedRoute = listBox1.SelectedItem as Route;
            MessageBox.Show(selectedRoute.Name + " is selected");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.RelativeOrAbsolute));
            MainPage.setRoute(selectedRoute);
            MainPage.triggerMapRefresh();
        }

        //private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    PhoneApplicationService.Current.State["selectedRoute"] = listBox1.SelectedItem;
        //    NavigationService.Navigate(new Uri(string.Format("/MainPage.xaml"), UriKind.Relative));
        //}
    }
}