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

            Console.WriteLine(selectedWaypoint.Images.Count);
            for (int i = 0; i < selectedWaypoint.Images.Count ; i++)
            {
                switch (i)
                {
                    case 0: image1.Source = selectedWaypoint.Images[0] as BitmapImage; break;
                    case 1: image2.Source = selectedWaypoint.Images[1] as BitmapImage; break;
                    case 2: image3.Source = selectedWaypoint.Images[2] as BitmapImage; break;
                    case 3: image4.Source = selectedWaypoint.Images[3] as BitmapImage; break;
                }
            }
                
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
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));
                title.Text = "Informatie";
                textBlock1.Height = selectedWaypoint.InformationNL.Count();
                textBlock1.TextWrapping = TextWrapping.Wrap; 
                textBlock1.Text = "Naam: " + selectedWaypoint.Name + "\n" +
                                  "Toelichting: " + selectedWaypoint.Description + "\n" +
                                  "Informatie: " + selectedWaypoint.InformationNL + " \n";
                       
            }
            else
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/eng.jpg", UriKind.Relative));
                title.Text = "Information";
                textBlock1.Height = selectedWaypoint.InformationEN.Count();
                textBlock1.TextWrapping = TextWrapping.Wrap;
                textBlock1.Text = "Name: " + selectedWaypoint.Name + "\n" +
                                  "Description: " + selectedWaypoint.Description + "\n" +
                                  "Information: " + selectedWaypoint.InformationEN + "\n";
                                   
            }            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/HelpPage.xaml"), UriKind.Relative));
        }    
    }
}