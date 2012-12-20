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
        private double windowHeight, windowWidth;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Content.UpdateLayout();
            //System.Diagnostics.Debug.WriteLine(System.Windows.Application.Current.Host.Content.ActualHeight);
            this.windowHeight = System.Windows.Application.Current.Host.Content.ActualHeight;
            this.windowHeight = System.Windows.Application.Current.Host.Content.ActualWidth;

            StackPanel topBar = new StackPanel();
            topBar.Orientation = System.Windows.Controls.Orientation.Horizontal;
            topBar.Name = "topBar";
            topBar.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            topBar.Orientation = System.Windows.Controls.Orientation.Horizontal;
            topBar.Margin = new System.Windows.Thickness { Left = 12, Top = 3, Right = 0, Bottom = 10 };

            TextBlock title = new TextBlock();
            title.Name = "title";
            title.Text = "StadNav";
            title.Width = 100;
            title.TextAlignment = TextAlignment.Left;
            title.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            title.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;

            //TODO: CHANGE THESE IMAGES
            Image flagButton = new Image();         //THIS IS GOING TO BE THE FLAG BUTTON
            flagButton.Source = new BitmapImage(new Uri("images/dummy.jpg", UriKind.Relative));
            flagButton.Width = 100;
            flagButton.Height = 30;
            flagButton.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            flagButton.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            flagButton.Margin = new System.Windows.Thickness { Left = 100 };
            //END FLAG BUTTON

            Image helpButton = new Image();         //THIS IS GOING TO BE THE HELP BUTTON
            helpButton.Source = new BitmapImage(new Uri("images/dummy.jpg", UriKind.Relative));
            helpButton.Width = 100;
            helpButton.Height = 30;
            helpButton.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            helpButton.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            helpButton.Margin = new System.Windows.Thickness { Left = 5 };
            //END HELP BUTTON

            topBar.Children.Add(title);
            topBar.Children.Add(flagButton);
            topBar.Children.Add(helpButton);

            this.Content = topBar;

            /*
            Button help = new Button();
            Button language = new Button();
             */
        }
    }
}