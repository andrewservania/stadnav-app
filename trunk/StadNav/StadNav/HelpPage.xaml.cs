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
    public partial class HelpPage : PhoneApplicationPage
    {
        public HelpPage()
        {
            InitializeComponent();
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
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void updateLanguage()
        {
            if (!(bool)PhoneApplicationService.Current.State["language"])
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/eng.jpg", UriKind.Relative));
                textBlock1.Text = "When the application starts you will see a map." +
                    "To load a route onto the map, press the route button." +
                    "On the next page you will see a list of routes which you can choose by pressing on it." +
                    "After choosing a route you will be sent back to the main page." +
                    "The route will now be loaded onto the map and your own position will be showed by an arrow sign." +
                    "You can now follow the route on the map. If you would like to change the language of the application, press the flag in the top right corner.";
            }
            else
            {
                ((Image)button5.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));
                textBlock1.Text = "Wanneer de applicatie gestart wordt ziet u een kaart." +
                    " Om een route op deze kaart te laden klikt u op de knop route." +
                    " Hierna wordt u naar een andere pagina geleid waar u kunt kiezen uit een van de beschikbare routes door er op de drukken." +
                    " Als u een route heeft gekozen wordt u weer terug geleid naar de hoofdpagina." +
                    " Nu is de route op de kaart geladen en ziet u uw positie aangegeven met een pijl." +
                    " U kunt nu de route volgen met de kaart. Als u de taal van de applicatie wilt veranderen klikt u op het vlaggetje in de rechterboven hoek";
            }
        }
    }
}