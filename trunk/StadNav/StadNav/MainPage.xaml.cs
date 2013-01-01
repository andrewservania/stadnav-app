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

namespace StadNav
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Route selectedRoute { get; set; }

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
        }

        public void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                loadRoute((Route)PhoneApplicationService.Current.State["selectedRoute"]);
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
            button1.Content = route.name;
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
    }
}