using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StadNavDesktopTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MakeTestValues();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Tool());
        }

        public static void MakeTestValues()
        {
            #region language
            LanguageManagement.AddLanguage(0, "Nederlands");
            LanguageManagement.AddLanguage(1, "English");
            #endregion

                        #region testwaypoints
            Waypoint testWaypointKerk = new Waypoint();
            testWaypointKerk.ID = 0;
            testWaypointKerk.Name = "Kerk";
            testWaypointKerk.Latitude = 12.3124;
            testWaypointKerk.Longitude = 13.1412;

            Waypoint testWaypointBerg = new Waypoint();
            testWaypointBerg.ID = 1;
            testWaypointBerg.Name = "Berg";
            testWaypointBerg.Latitude = 82.131;
            testWaypointBerg.Longitude = 41.312;

            WaypointManagement.AddWaypointImage(testWaypointBerg, "C:/hoofd.jpg");


            WaypointManagement.AddWaypoint(testWaypointBerg);
            WaypointManagement.AddWaypoint(testWaypointKerk);

            WaypointManagement.AddWaypointDescription(testWaypointBerg, LanguageManagement.GetAllLanguages()[0].ID, "Een berg");
            WaypointManagement.AddWaypointDescription(testWaypointBerg, LanguageManagement.GetAllLanguages()[1].ID, "A mountain");

            WaypointManagement.AddWaypointDescription(testWaypointKerk, LanguageManagement.GetAllLanguages()[0].ID, "Een kerk");
            WaypointManagement.AddWaypointDescription(testWaypointKerk, LanguageManagement.GetAllLanguages()[1].ID, "A Church");
            #endregion

            #region testroutes
            Route testRouteKroegentocht = new Route();
            testRouteKroegentocht.ID = 0;
            testRouteKroegentocht.Name = "Kroegentocht";
            testRouteKroegentocht.Waypoints.Add(testWaypointKerk);
            testRouteKroegentocht.Waypoints.Add(testWaypointBerg);
            testRouteKroegentocht.Waypoints.Add(testWaypointBerg);
            testRouteKroegentocht.Waypoints.Add(testWaypointBerg);
            testRouteKroegentocht.Waypoints.Add(testWaypointBerg);
            testRouteKroegentocht.Waypoints.Add(testWaypointBerg);
            testRouteKroegentocht.Waypoints.Add(testWaypointKerk);
            testRouteKroegentocht.Waypoints.Add(testWaypointKerk);
            testRouteKroegentocht.Waypoints.Add(testWaypointKerk);
            testRouteKroegentocht.Waypoints.Add(testWaypointKerk);
            RouteManagement.AddRoute(testRouteKroegentocht);
            #endregion

        }
    }
}
