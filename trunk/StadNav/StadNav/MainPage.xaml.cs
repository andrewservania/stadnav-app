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

namespace StadNav
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Boolean dutch;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            dutch = true;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            //Changes language
            /*Button button = sender as Button;
            Image content = button.Content as Image;
            if (content != null)
            {*/
                if (dutch)
                {
                    ((Image) button5.Content).Source = new BitmapImage(new Uri("images/eng.jpg", UriKind.Relative));
                    dutch = false;
                }
                else
                {
                    ((Image)button5.Content).Source = new BitmapImage(new Uri("images/ned.jpg", UriKind.Relative));
                    dutch = true;
                }
           // }
        }
    }
}