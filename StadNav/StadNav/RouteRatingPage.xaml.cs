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
using Microsoft.Phone.Shell;
using System.Windows.Media.Imaging;
using System.IO.IsolatedStorage;
using System.IO;

namespace StadNav
{
    public partial class RouteRatingPage : PhoneApplicationPage
    {
        public RouteRatingPage()
        {
            InitializeComponent();
            textBlock4.Text = MainPage.getCurrentRoute().Name;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            saveRating("routeRating.txt", " \n Route Name:" + MainPage.getCurrentRoute().Name + " \n Route Rating:" + textBlock2.Text + " Stars");
            NavigationService.Navigate(new Uri("/MainPage.XAML", UriKind.Relative));
        }

        private void saveRating(string filename, string text)
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication()) 
            { 
                using 
                (IsolatedStorageFileStream rawStream = isf.CreateFile(filename)) 
                { StreamWriter writer = new StreamWriter(rawStream); 
                writer.Write(text); writer.Close(); 
                } 
            }
        }

        private bool loadRatingFile(string filename, out string result)
        {
            result = "";
            using (IsolatedStorageFile isf =
                IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (isf.FileExists(filename))
                {
                    try
                    {
                        using (IsolatedStorageFileStream rawStream =
                            isf.OpenFile(filename, System.IO.FileMode.Open))
                        {
                            StreamReader reader = new StreamReader(rawStream);
                            result = reader.ReadToEnd();
                            reader.Close();
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "1";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "2";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "3";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "4";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            textBlock2.Text = "5";
        }

        private void updateLanguage()
        {
            if (!(bool)PhoneApplicationService.Current.State["language"])
            {
                ((Image)button7.Content).Source = new BitmapImage(new Uri("images/eng.jpg", UriKind.Relative));
                PageTitle.Text = "Rate route";
                textBlock1.Text = "Star route";
                button1.Content = "Rate!";
                textBlock3.Text = "Route Name:";
            }
            else
            {
                ((Image)button7.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));
                PageTitle.Text = "Route beoordelen";
                textBlock1.Text = "Ster route";
                button1.Content = "Beoordelen!";
                textBlock3.Text = "Route Naam:";
            }
        }

        #region Button images exception catching methods
        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_2(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_3(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_4(object sender, ExceptionRoutedEventArgs e)
        {

        }
        #endregion

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            PhoneApplicationService.Current.State["language"] = !(bool)PhoneApplicationService.Current.State["language"];
            updateLanguage();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HelpPage.xaml", UriKind.Relative));
        }

    }
}