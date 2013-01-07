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
        double latitudeValue;
        double longitudeValue;
        BindingList<string> mediaValue;
        Dictionary<int, string> descriptionsValue;

        public Waypoint()
        {
            mediaValue = new BindingList<string>();
            descriptionsValue = new Dictionary<int, string>();
        }

        /// <summary>
        /// IMPORTANT: 
        /// int -> language ID
        /// string -> description
        /// </summary>
        public Dictionary<int, string> Descriptions
        {
            get { return descriptionsValue; }
            set { descriptionsValue = value; } 
        }

        /// <summary>
        /// IMPORTANT: THIS LIST USES 'PATHS' or 'FILENAMES'
        /// </summary>
        public BindingList<string> Media
        {
            get { return mediaValue; }
            set { mediaValue = value; } 
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
                return "[" + ID + "] " + Name;
        }
    }
}
