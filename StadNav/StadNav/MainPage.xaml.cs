using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Controls.Maps;
using System.Device.Location;

namespace StadNav
{
    public partial class MainPage : PhoneApplicationPage
    {
        //private Route selectedRoute;

        static Route currentRoute = new Route();
        static MapPolyline routePolyLine;
        MapLayer pushPinLayer;
        Database db = new Database();
        bool checker = false;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);

            //Voorkomt dat de taal weer op nederlands wordt gezet na terug navigeren naar deze pagina.
            try
            {
                if (PhoneApplicationService.Current.State["language"] == null)
                    PhoneApplicationService.Current.State["language"] = true;
            }
            catch
            {
                PhoneApplicationService.Current.State["language"] = true;
            }
            // Draw  route line using its waypoints
            routePolyLine = new MapPolyline();
            routePolyLine.Stroke = new SolidColorBrush(Colors.Blue);
            routePolyLine.StrokeThickness = 5;
            routePolyLine.Opacity = 0.7;
            routePolyLine.Locations = new LocationCollection();
            map1.Children.Add(routePolyLine);
            pushPinLayer = new MapLayer();
            map1.Children.Add(pushPinLayer);
        }

        public void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
              //  loadRoute((Route)PhoneApplicationService.Current.State["selectedRoute"]);
            }
            catch(Exception) 
            { 
            }
            updateLanguage();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            //Changes language
            PhoneApplicationService.Current.State["language"] = !(bool)PhoneApplicationService.Current.State["language"];
            updateLanguage();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/RouteSelectionPage.xaml"), UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/HelpPage.xaml"), UriKind.Relative));
        }

        private void loadRoute(Route route)
        {
            //Hier moet de code komen om de geselecteerde route op de map te zetten.
            //button1.Content = route.name;
        }
        public static void setRoute(Route selectedRoute)
        {
            currentRoute = selectedRoute;
        }

        private void updateLanguage()
        {
            if (!(bool)PhoneApplicationService.Current.State["language"])
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/eng.jpg", UriKind.Relative));               
            }
            else
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));               
            }
        }

        //Temporary Refresh Button
        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
      
            if(checker == false) // To avoid redrawing the routeline and for performance improvement
            {
               
            foreach (Waypoint wp in currentRoute.Waypoints)
            {
                routePolyLine.Locations.Add(new GeoCoordinate(wp.Latitude, wp.Longitude));
                Pushpin pin = new Pushpin();
                pin.Content = wp.ID + "";
                pin.Background = new SolidColorBrush(Colors.Orange);
                pushPinLayer.AddChild(pin, new GeoCoordinate(wp.Latitude, wp.Longitude));
                System.Diagnostics.Debug.WriteLine("Coordinates added");
            }
            map1.Center = new GeoCoordinate(currentRoute.Waypoints.First().Latitude, currentRoute.Waypoints.First().Longitude);
            map1.ZoomLevel = 15;
              checker = true;
            }
            
        }


    }
}