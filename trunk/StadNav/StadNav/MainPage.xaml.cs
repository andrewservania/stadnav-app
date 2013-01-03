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
using System.Collections.ObjectModel;
using StadNav.RouteService;
using StadNav.GeocodeService;

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
        Pushpin userPushpin = new Pushpin();
        int defaultZoom = 15;
        List<GeoCoordinate> locations = new List<GeoCoordinate>();

        internal GeocodeService.GeocodeResult[] geocodeResults;

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
            map1.ZoomLevel = defaultZoom;

            //init user's pushpin
            userPushpin.Name = "User";
            userPushpin.Background = new SolidColorBrush(Colors.Blue);
            userPushpin.Content = "User";
            pushPinLayer.AddChild(userPushpin, new GeoCoordinate(0,0));

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

        private void CalculateRoute(List<GeoCoordinate> locations)
        {
            // Create the service variable and set the callback method using the CalculateRouteCompleted property.
            RouteService.RouteServiceClient routeService = new RouteService.RouteServiceClient("BasicHttpBinding_IRouteService");
            routeService.CalculateRouteCompleted += new EventHandler<RouteService.CalculateRouteCompletedEventArgs>(routeService_CalculateRouteCompleted);

            // Set the token.
            RouteService.RouteRequest routeRequest = new RouteService.RouteRequest();
            routeRequest.Credentials = new Credentials();
            routeRequest.Credentials.ApplicationId = ((ApplicationIdCredentialsProvider)map1.CredentialsProvider).ApplicationId;

            // Return the route points so the route can be drawn.
            routeRequest.Options = new RouteService.RouteOptions();
            routeRequest.Options.RoutePathType = RouteService.RoutePathType.Points;

            // Set the waypoints of the route to be calculated using the Geocode Service results stored in the geocodeResults variable.
            routeRequest.Waypoints = new System.Collections.ObjectModel.ObservableCollection<RouteService.Waypoint>();
            foreach (GeoCoordinate result in locations)
            {
                StadNav.RouteService.Waypoint wp = new StadNav.RouteService.Waypoint();
                GeoCoordinate loc = new GeoCoordinate(result.Latitude, result.Longitude);
                wp.Location = loc;

                String db;
                db = result.Latitude.ToString() + " " + result.Longitude.ToString();
                System.Diagnostics.Debug.WriteLine(db);
                
                wp.Location.Latitude = result.Latitude;
                wp.Location.Longitude = result.Longitude;
                routeRequest.Waypoints.Add(wp);
            }

            // Make the CalculateRoute asnychronous request.
            routeService.CalculateRouteAsync(routeRequest);
        }

        private void routeService_CalculateRouteCompleted(object sender, RouteService.CalculateRouteCompletedEventArgs e)
        {

            // If the route calculate was a success and contains a route, then draw the route on the map.
            if ((e.Result.ResponseSummary.StatusCode == RouteService.ResponseStatusCode.Success) & (e.Result.Result.Legs.Count != 0))
            {
                // Set properties of the route line you want to draw.
                Color routeColor = Colors.Blue;
                SolidColorBrush routeBrush = new SolidColorBrush(routeColor);
                MapPolyline routeLine = new MapPolyline();
                routeLine.Locations = new LocationCollection();
                routeLine.Stroke = routeBrush;
                routeLine.Opacity = 0.65;
                routeLine.StrokeThickness = 5.0;

                // Retrieve the route points that define the shape of the route.
                foreach (GeoCoordinate p in e.Result.Result.RoutePath.Points)
                {
                    routeLine.Locations.Add(new GeoCoordinate(p.Latitude, p.Longitude));
                }

                // Add a map layer in which to draw the route.
                MapLayer myRouteLayer = new MapLayer();
                map1.Children.Add(myRouteLayer);

                // Add the route line to the new layer.
                myRouteLayer.Children.Add(routeLine);

                // Figure the rectangle which encompasses the route. This is used later to set the map view.
                //LocationRect rect = new LocationRect(routeLine.Locations[0], routeLine.Locations[routeLine.Locations.Count - 1]);

                // For each geocode result (which are the waypoints of the route), draw a dot on the map.
                
                //foreach (GeocodeService.GeocodeResult gr in geocodeResults)
                foreach (GeoCoordinate gr in locations)
                {
                    Ellipse point = new Ellipse();
                    point.Width = 10;
                    point.Height = 10;
                    point.Fill = new SolidColorBrush(Colors.Red);
                    point.Opacity = 0.65;
                    GeoCoordinate location = new GeoCoordinate(gr.Latitude, gr.Longitude);
                    MapLayer.SetPosition(point, location);
                    MapLayer.SetPositionOrigin(point, PositionOrigin.Center);

                    // Add the drawn point to the route layer.                    
                    myRouteLayer.Children.Add(point);
                }

                // Set the map view using the rectangle which bounds the rendered route.
                //map1.SetView(rect);
            }
        }

        private RouteService.Waypoint GeocodeResultToWaypoint(GeocodeService.GeocodeResult result)
        {
            RouteService.Waypoint waypoint = new RouteService.Waypoint();
            waypoint.Description = result.DisplayName;
            waypoint.Location = new GeoCoordinate();
            waypoint.Location.Latitude = result.Locations[0].Latitude;
            waypoint.Location.Longitude = result.Locations[0].Longitude;
            return waypoint;
        }

        public void refreshMap()
        {
            if (checker == false) // To avoid redrawing the routeline and for performance improvement
            {
                //locations.Add(userPushpin.Location);
                int nextLocation = 0;
                
                foreach (Waypoint wp in currentRoute.Waypoints)
                {
                    routePolyLine.Locations.Add(new GeoCoordinate(wp.Latitude, wp.Longitude));
                    Pushpin pin = new Pushpin();
                    pin.Content = wp.ID + "";
                    pin.Name = wp.ID.ToString();
                    pin.Background = new SolidColorBrush(Colors.Orange);
                    pin.MouseEnter += OnTapEnter;
                    pin.MouseLeave += OnTapLeave;
                    GeoCoordinate waypointCoords = new GeoCoordinate(wp.Latitude, wp.Longitude);
                    pushPinLayer.AddChild(pin, waypointCoords);
                    if (nextLocation < 3)
                    {
                        locations.Add(waypointCoords);
                    }
                    nextLocation++;
                }
                CalculateRoute(locations);

                map1.SetView(LocationRect.CreateLocationRect(locations));

                //map1.Center = new GeoCoordinate(currentRoute.Waypoints.First().Latitude, currentRoute.Waypoints.First().Longitude);
                map1.ZoomLevel = defaultZoom;
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
                    if (w.InformationNL.Equals("") && w.Images[0] == null)
                    {
                        MessageBox.Show("Er is geen informatie beschikbaar voor dit bestemmingspunt.");
                    }
                    else
                    {                     
                        NavigationService.Navigate(new Uri("/InformationPage.xaml", UriKind.Relative));
                        PhoneApplicationService.Current.State["selectedWaypoint"] = w;
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

        //updates user's pushpin
        public void updateUserPushpin(Double Lat, Double Long)
        {
            GeoCoordinate location = new GeoCoordinate(Lat, Long);
            userPushpin.Location = location;
        }

        public void HandleGeoPositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            if (!e.Position.Location.IsUnknown)
            {
                Double Latitude = e.Position.Location.Latitude;
                Double Longitude = e.Position.Location.Longitude;
                map1.Center = new GeoCoordinate(Latitude, Longitude);
                updateUserPushpin(Latitude, Longitude);
            }
            
        }

        internal static void triggerMapRefresh()
        { trigger = true; }
    }
}