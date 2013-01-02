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

namespace StadNav
{
    public partial class InformationPage : PhoneApplicationPage
    {
        Waypoint selectedWaypoint;
        public InformationPage()
        {
            InitializeComponent();
            selectedWaypoint = (Waypoint)PhoneApplicationService.Current.State["selectedWaypoint"];
            addWaypointImage();
            updateLanguage();
        }

        private void addWaypointImage()
        {
            if(selectedWaypoint.Images.Count >= 1)
            image1.Source = selectedWaypoint.Images.First() as BitmapImage;
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
            if ((bool)PhoneApplicationService.Current.State["language"])
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/eng.jpg", UriKind.Relative));
                title.Text = "Informatie";
                textBlock1.Text = "Naam: " + selectedWaypoint.Name + "\n" +
                                  "Toelichting: " + selectedWaypoint.Description + "\n" +
                                  "Informatie: " + selectedWaypoint.Information + " \n";                            
            }
            else
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));
                title.Text = "Information";
                textBlock1.Text = "Name: " + selectedWaypoint.Name + "\n" +
                                  "Description: " + selectedWaypoint.Description + "\n" +
                                  "Information: " + selectedWaypoint.Information + "\n";
                                   
            }            
        }
    }
}