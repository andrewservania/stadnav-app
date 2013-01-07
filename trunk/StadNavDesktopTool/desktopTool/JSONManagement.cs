using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace StadNavDesktopTool
{
    class JSONManagement
    {
        public static string RoutesToJSON()
        {
            string json = JsonConvert.SerializeObject(RouteManagement.GetAllRoutes(), Formatting.Indented);
            return json;
        }

        public static string WaypointsToJSON()
        {
            string json = JsonConvert.SerializeObject(WaypointManagement.GetAllWaypoints(), Formatting.Indented);
            return json;
        }

        public static string LanguagesToJSON()
        {
            string json = JsonConvert.SerializeObject(LanguageManagement.GetAllLanguages(), Formatting.Indented);
            return json;
        }

        public static BindingList<Route> RoutesFromJSON(string json)
        {
            BindingList<Route> routes = null;
            routes = JsonConvert.DeserializeObject<BindingList<Route>>(json);
            return routes;
        }

        public static BindingList<Waypoint> WaypointsFromJSON(string json)
        {
            BindingList<Waypoint> waypoints = null;
            waypoints = JsonConvert.DeserializeObject<BindingList<Waypoint>>(json);
            return waypoints;
        }

        public static BindingList<Language> LanguagesFromJSON(string json)
        {
            BindingList<Language> languages = null;
            languages = JsonConvert.DeserializeObject<BindingList<Language>>(json);
            return languages;
        }
    }
}
