using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StadNavDesktopTool
{
    [Serializable]
    class Route
    {
        int idValue;
        string nameValue;
        BindingList<Waypoint> waypointsValue;

        public Route()
        {
            waypointsValue = new BindingList<Waypoint>();
        }

        public BindingList<Waypoint> Waypoints
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
