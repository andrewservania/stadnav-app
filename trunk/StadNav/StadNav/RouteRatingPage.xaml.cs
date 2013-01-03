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

namespace StadNav
{
    public partial class RouteRatingPage : PhoneApplicationPage
    {
        public RouteRatingPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new Uri("/MainPage.XAML", UriKind.Relative));
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

    }
}