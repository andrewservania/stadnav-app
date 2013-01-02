using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace StadNavDesktopTool
{
    class WaypointManagement
    {
        private static BindingList<Waypoint> waypoints = new BindingList<Waypoint>();

        public static void loadFromFile(string path)
        {
            Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            waypoints = bFormatter.Deserialize(stream) as BindingList<Waypoint>;
            stream.Flush();
            stream.Close();
        }

        public static void ClearWaypoints()
        {
            waypoints.Clear();
        }

        public static void AddWaypointDescription(Waypoint waypoint, int languageID, string description)
        {
            waypoint.Descriptions.Add(languageID, description);
        }

        public static void AddWaypointImage(Waypoint waypoint, string image)
        {
            waypoint.Images.Add(image);
        }

        public static void RemoveWaypoint(Waypoint wayPoint)
        {
            waypoints.Remove(wayPoint);
        }

        public static bool RemoveWaypoint(int id)
        {
            foreach (Waypoint waypoint in waypoints)
            {
                if (waypoint.ID == id)
                {
                    waypoints.Remove(waypoint);
                    return true;
                }
            }

            return false;
        }

        public static Waypoint GetWaypoint(int id)
        {
            foreach (Waypoint Waypoint in waypoints)
            {
                if (Waypoint.ID == id)
                    return Waypoint;
            }

            return null;
        }

        public static void SaveToFile(string path)
        {
            Stream stream = File.Open(path, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, waypoints);
            stream.Flush();
            stream.Close();
        }

        public static BindingList<Waypoint> GetAllWaypoints()
        {
            if (waypoints != null && waypoints.Count > 0)
                return waypoints;
            else
                return null;
        }

        public static void UpdateWaypoint(Waypoint Waypoint)
        {
            waypoints.Remove(Waypoint);
            waypoints.Add(Waypoint);
        }

        public static void SetAllWaypoints(BindingList<Waypoint> newWaypoints)
        {
            waypoints = newWaypoints;
        }

        public static bool AddWaypoint(int id, string name, double latitude, double longitude)
        {
            Waypoint newWaypoint;

            if (GetWaypoint(id) == null)
            {
                newWaypoint = new Waypoint();
                newWaypoint.ID = id;
                newWaypoint.Name = name;
                newWaypoint.Latitude = latitude;
                newWaypoint.Longitude = longitude;

                AddWaypoint(newWaypoint);
                return true;
            }
            else
                return false;

        }

        public static bool AddWaypoint(Waypoint waypoint)
        {
            if (GetWaypoint(waypoint.ID) == null)
            {
                waypoints.Add(waypoint);
                return true;
            }
            else
                return false;
        }
    }
}
