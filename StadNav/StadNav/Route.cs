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

namespace StadNav
{
    public class Route
    {
        int idValue;
        string nameValue;
        ObservableCollection<Waypoint> waypointsValue;

        public Route()
        {
            waypointsValue = new ObservableCollection<Waypoint>();
        }

        public ObservableCollection<Waypoint> Waypoints
        {
            get { return waypointsValue; }
            set { waypointsValue = value; }
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

        public override string ToString()
        {
            return "[" + ID + "] " + Name;
        }
    }
}
