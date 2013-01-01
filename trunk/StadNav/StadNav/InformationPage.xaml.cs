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
        public InformationPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(InformationPage_Loaded);
        }

        public void InformationPage_Loaded(object sender, RoutedEventArgs e)
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
                title.Text = "Informatie";
            }
            else
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));
                title.Text = "Information";
            }
        }
    }
}