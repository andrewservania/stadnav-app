using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using System.Device.Location;
//Backup
namespace StadNav
{
    public class Waypoint
    {
        int idValue;
        string nameValue;
        string descriptionValue;
        string informationNLValue;
        string informationENValue;

        double latitudeValue;
        double longitudeValue;

        ObservableCollection<BitmapImage> imagesValue;

        public Waypoint()
        {
            imagesValue = new ObservableCollection<BitmapImage>();
        }

        public ObservableCollection<BitmapImage> Images
        {
            get { return imagesValue; }
            set { imagesValue = value; }
        }

        public int ID
        {
            get { return idValue; }
            set { idValue = value; }
        }

        public string Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }

        public string Description
        {
            get { return descriptionValue; }
            set { descriptionValue = value; }
        }

        public string InformationNL
        {
            get { return informationNLValue; }
            set { informationNLValue = value; }
        }

        public string InformationEN
        {
            get { return informationENValue; }
            set { informationENValue = value; }
        }


        public double Longitude
        {
            get { return longitudeValue; }
            set { longitudeValue = value; }
        }

        public double Latitude
        {
            get { return latitudeValue; }
            set { latitudeValue = value; }
        }

        public override string ToString()
        {
            if (Description.Length > 50)
            { return "[" + ID + "] " + Name + ": " + Description.Substring(0, 50); }
            else
            { return "[" + ID + "] " + Name + ": " + Description; }
        }
    }
}
