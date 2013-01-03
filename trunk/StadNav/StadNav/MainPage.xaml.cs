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
using Microsoft.Phone.Tasks;

namespace StadNav
{
    public partial class MainPage : PhoneApplicationPage
    {
        //private Route selectedRoute;

        static Route currentRoute = new Route();
        static MapPolyline routePolyLine;
        MapLayer pushPinLayer;
        Database db = new Database();
        GeoCoordinateWatcher coordinateWatcher;
        bool checker = false;
        static bool trigger = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();          

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
            updateLanguage();

            // Draw  route line using its waypoints
            routePolyLine = new MapPolyline();
            routePolyLine.Stroke = new SolidColorBrush(Colors.Blue);
            routePolyLine.StrokeThickness = 5;
            routePolyLine.Opacity = 0.7;
            routePolyLine.Locations = new LocationCollection();
            map1.Children.Add(routePolyLine);
            pushPinLayer = new MapLayer();
            map1.Children.Add(pushPinLayer);
            coordinateWatcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            coordinateWatcher.PositionChanged += HandleGeoPositionChanged;
            coordinateWatcher.Start();
            if (trigger == true)
                refreshMap();
           
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

        public void refreshMap()
        {
            if (checker == false) // To avoid redrawing the routeline and for performance improvement
            {

                foreach (Waypoint wp in currentRoute.Waypoints)
                {
                    routePolyLine.Locations.Add(new GeoCoordinate(wp.Latitude, wp.Longitude));
                    Pushpin pin = new Pushpin();
                    pin.Content = wp.ID + "";
                    pin.Name = wp.ID.ToString();
                    pin.Background = new SolidColorBrush(Colors.Orange);
                    pin.MouseEnter += OnTapEnter;
                    pin.MouseLeave += OnTapLeave;
                    pushPinLayer.AddChild(pin, new GeoCoordinate(wp.Latitude, wp.Longitude));
                }
                map1.Center = new GeoCoordinate(currentRoute.Waypoints.First().Latitude, currentRoute.Waypoints.First().Longitude);
                map1.ZoomLevel = 15;
                checker = true;
            }           
        }
        private void OnTapEnter(object sender, MouseEventArgs e)
        {
            Pushpin pushpin = sender as Pushpin;
            ScaleTransform st = new ScaleTransform();
            st.ScaleX = 1.2;
            st.ScaleY = 1.2;
            st.CenterX = (pushpin as FrameworkElement).Height / 2;
            st.CenterY = (pushpin as FrameworkElement).Height / 2;
            pushpin.Background = new SolidColorBrush(Colors.Purple);
            pushpin.RenderTransform = st; 
        }

        private void OnTapLeave(object sender, MouseEventArgs e)
        {
            Pushpin pushpin = sender as Pushpin;
            ScaleTransform st = new ScaleTransform();
            string inputString = pushpin.Name;
            int numValue;
            bool parsed = Int32.TryParse(inputString, out numValue);
            Waypoint w = Database.getWaypointByID(numValue);
            if ((bool)PhoneApplicationService.Current.State["language"])
            {

                MessageBoxResult m = MessageBox.Show("Bestemmingspunt " + pushpin.Name + " is geselecteerd." +
                    "\n" + w.Name + "\n" + w.Description + "\nInformatie over dit bestemmingspunt tonen?",
                    "Bestemmingspunt", MessageBoxButton.OKCancel);
                if (m == MessageBoxResult.OK)
                {
                    if (!w.InformationNL.Equals(""))
                    {
                        NavigationService.Navigate(new Uri("/InformationPage.xaml", UriKind.Relative));
                        PhoneApplicationService.Current.State["selectedWaypoint"] = w;
                    }
                    else
                    {
                        MessageBox.Show("Er is geen informatie beschikbaar voor dit bestemmingspunt.");
                    }
                }
            }
            else
            {
                MessageBoxResult m = MessageBox.Show("Waypoint " + pushpin.Name + " has been selected." +
                    "\n" + w.Name + "\n" + w.Description + "\nShow information about this waypoint?",
                    "Waypoint", MessageBoxButton.OKCancel);
                if (m == MessageBoxResult.OK)
                {
                    if (!w.InformationEN.Equals(""))
                    {
                        NavigationService.Navigate(new Uri("/InformationPage.xaml", UriKind.Relative));
                        PhoneApplicationService.Current.State["selectedWaypoint"] = w;
                    }
                    else
                    {
                        MessageBox.Show("There is no information available for this waypoint.");
                    }
                }
            }
            
            st.ScaleX = 1.0;
            st.ScaleY = 1.0;
            st.CenterX = (pushpin as FrameworkElement).Height / 2;
            st.CenterY = (pushpin as FrameworkElement).Height / 2;
            pushpin.Background = new SolidColorBrush(Colors.Orange);
            pushpin.RenderTransform = st;
        }

        public void HandleGeoPositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            if (!e.Position.Location.IsUnknown)
            {
                Double Latitude = e.Position.Location.Latitude;
                Double Longitude = e.Position.Location.Longitude;
                map1.Center = new GeoCoordinate(Latitude, Longitude);
            }
            
        }

        internal static void triggerMapRefresh()
        { trigger = true; }
    }
}