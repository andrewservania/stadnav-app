using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace StadNavDesktopTool
{
    class RouteManagement
    {
        private static BindingList<Route> routes = new BindingList<Route>();

        public static void loadFromFile(string path)
        {
            Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            routes = bFormatter.Deserialize(stream) as BindingList<Route>;
            stream.Flush();
            stream.Close();
        }

        public static void SetAllRoutes(BindingList<Route> newRoutes)
        {
            routes = newRoutes;
        }

        public static void ClearRoutes()
        {
            routes.Clear();
        }

        public static void RemoveRoute(Route route)
        {
            routes.Remove(route);
        }

        public static bool RemoveRoute(int id)
        {
            foreach (Route route in routes)
            {
                if (route.ID == id)
                {
                    routes.Remove(route);
                    return true;
                }
            }

            return false;
        }

        public static Route GetRoute(int id)
        {
            foreach (Route Route in routes)
            {
                if (Route.ID == id)
                    return Route;
            }

            return null;
        }

        public static void SaveToFile(string path)
        {
            Stream stream = File.Open(path, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, routes);
            stream.Flush();
            stream.Close();
        }

        public static BindingList<Route> GetAllRoutes()
        {
            if (routes != null && routes.Count > 0)
                return routes;
            else
                return null;
        }

        public static void UpdateRoute(Route Route)
        {
            routes.Remove(Route);
            routes.Add(Route);
        }

        public static bool AddRoute(int id, string name, string description, double latitude, double longitude)
        {
            Route newRoute;

            if (GetRoute(id) == null)
            {
                newRoute = new Route();
                newRoute.ID = id;
                newRoute.Name = name;

                AddRoute(newRoute);
                return true;
            }
            else
                return false;

        }

        public static bool AddRoute(Route route)
        {
            if (GetRoute(route.ID) == null)
            {
                routes.Add(route);
                return true;
            }
            else
                return false;
        }
    }
}
