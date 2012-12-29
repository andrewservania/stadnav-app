using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StadNavDesktopTool
{
    [Serializable]
    class Waypoint
    {
        int idValue;
        string nameValue;
        string descriptionValue;
        double latitudeValue;
        double longitudeValue;
        BindingList<Image> imagesValue;

        public Waypoint()
        {
            imagesValue = new BindingList<Image>();
        }

        public BindingList<Image> Images
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
                return "[" + ID + "] " + Name + ": " + Description.Substring(0, 50);
            else
                return "[" + ID + "] " + Name + ": " + Description;
        }
    }
}
