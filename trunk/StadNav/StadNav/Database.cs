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
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Collections.Generic;
using System.ComponentModel;
using System.Device.Location;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Resources;
using System.Reflection;

namespace StadNav
{
    [Table]
    public class Database : INotifyPropertyChanged, INotifyPropertyChanging
    {
        static ObservableCollection<Route> routeDB;
        static ObservableCollection<Waypoint> waypointDB;

        static Database()
        {
            routeDB = new ObservableCollection<Route>();
            waypointDB = new ObservableCollection<Waypoint>();

            Route standardVVVRoute = new Route();

            #region Waypoint variables

            Waypoint w1 = new Waypoint();
            Waypoint w2 = new Waypoint();
            Waypoint w3 = new Waypoint();
            Waypoint w4 = new Waypoint();
            Waypoint w5 = new Waypoint();
            Waypoint w6 = new Waypoint();
            Waypoint w7 = new Waypoint();
            Waypoint w8 = new Waypoint();
            Waypoint w9 = new Waypoint();
            Waypoint w10 = new Waypoint();

            Waypoint w11 = new Waypoint();
            Waypoint w12 = new Waypoint();
            Waypoint w13 = new Waypoint();
            Waypoint w14 = new Waypoint();
            Waypoint w15 = new Waypoint();
            Waypoint w16 = new Waypoint();
            Waypoint w17 = new Waypoint();
            Waypoint w18 = new Waypoint();
            Waypoint w19 = new Waypoint();
            Waypoint w20 = new Waypoint();

            Waypoint w21 = new Waypoint();
            Waypoint w22 = new Waypoint();
            Waypoint w23 = new Waypoint();
            Waypoint w24 = new Waypoint();
            Waypoint w25 = new Waypoint();
            Waypoint w26 = new Waypoint();
            Waypoint w27 = new Waypoint();
            Waypoint w28 = new Waypoint();
            Waypoint w29 = new Waypoint();
            Waypoint w30 = new Waypoint();

            Waypoint w31 = new Waypoint();
            Waypoint w32 = new Waypoint();
            Waypoint w33 = new Waypoint();
            Waypoint w34 = new Waypoint();
            Waypoint w35 = new Waypoint();
            Waypoint w36 = new Waypoint();
            Waypoint w37 = new Waypoint();
            Waypoint w38 = new Waypoint();
            Waypoint w39 = new Waypoint();
            Waypoint w40 = new Waypoint();

            Waypoint w41 = new Waypoint();
            Waypoint w42 = new Waypoint();
            Waypoint w43 = new Waypoint();
            Waypoint w44 = new Waypoint();
            Waypoint w45 = new Waypoint();
            Waypoint w46 = new Waypoint();
            Waypoint w47 = new Waypoint();
            Waypoint w48 = new Waypoint();
            Waypoint w49 = new Waypoint();
            Waypoint w50 = new Waypoint();

            #endregion

            #region Waypoints
            w1.ID = 1;
            w1.Name = "VVV Breda";
            w1.Latitude = 51.59380;
            w1.Longitude = 4.77963;
            w1.Images.Add(new BitmapImage(new Uri("images/Image1.jpg", UriKind.Relative)));
            w1.Images.Add(new BitmapImage(new Uri("images/Image2.jpg", UriKind.Relative)));
            w1.Description = "Beginpunt";
            w1.InformationNL = "";
            w1.InformationEN = "";
           
            w2.ID = 2;
            w2.Name = "Liefdeszuster";
            w2.Latitude = 51.59307;
            w2.Longitude = 4.77969;
            w2.Images.Add(new BitmapImage(new Uri("images/Image3.jpg", UriKind.Relative)));
            w2.Description = "";
            w2.InformationNL = "";
            w2.InformationEN = "";

            w3.ID = 3;
            w3.Name = "Valkenberg";
            w3.Latitude = 51.59250;
            w3.Longitude = 4.77969;
            w3.Images.Add(new BitmapImage(new Uri("images/Image4.jpg", UriKind.Relative)));
            w3.Description = "";
            w3.InformationNL = "";
            w3.InformationEN = "";

            w4.ID = 4;
            w4.Name = "Nassau Baronie Monument";
            w4.Latitude = 51.59250;
            w4.Longitude = 4.77969;
            w4.Images.Add(null);
            w4.Description = "";
            w4.InformationNL = getText("texts/T4NassauMonumentNL.txt"); 
            w4.InformationEN = getText("texts/T4NassauMonumentENG.txt");

            w5.ID = 5;
            w5.Name = "The Light House";
            w5.Latitude = 51.59256;
            w5.Longitude = 4.77889;
            w5.Images.Add(new BitmapImage(new Uri("images/Image5.jpg", UriKind.Relative)));
            w5.Description = "";
            w5.InformationNL = getText("texts/T5ValkenbergNL.txt");
            w5.InformationEN = getText("texts/T5ValkenbergENG.txt");
            w5.InformationNL = "";
            w5.InformationEN = "";

            w6.ID = 6;
            w6.Name = "";
            w6.Latitude = 51.59265;
            w6.Longitude = 4.77844;
            w6.Images.Add(null);
            w6.Description = "1e bocht Valkenberg";
            w6.InformationNL = getText("texts/T6kasteelNL.txt");
            w6.InformationEN = getText("texts/T6kasteelENG.txt");

            w7.ID = 7;
            w7.Name = "";
            w7.Latitude = 51.59258;
            w7.Longitude = 4.77806;
            w7.Images.Add(null);
            w7.Description = "2e bocht Valkenberg";
            w7.InformationNL = "";
            w7.InformationEN = "";

            w8.ID = 8;
            w8.Name = "";
            w8.Latitude = 51.59059;
            w8.Longitude = 4.77707;
            w8.Images.Add(new BitmapImage(new Uri("images/Image9.jpg", UriKind.Relative)));
            w8.Description = "Einde Park";
            w8.InformationNL = "";
            w8.InformationEN = "";

            w9.ID = 9;
            w9.Name = "Kasteel van Breda";
            w9.Latitude = 51.59061;
            w9.Longitude = 4.77624;
            w9.Images.Add(new BitmapImage(new Uri("images/Image11.jpg", UriKind.Relative)));
            w9.Description = "";
            w9.InformationNL = "";
            w9.InformationEN = "";

            w10.ID = 10;
            w10.Name = "Stadhouderspoort";
            w10.Latitude = 51.58992;
            w10.Longitude = 4.77634;
            w10.Images.Add(new BitmapImage(new Uri("images/Image12.jpg", UriKind.Relative)));
            w10.InformationNL = getText("texts/T10vishalNL.txt");
            w10.InformationEN = getText("texts/T10vishalENG.txt");

            w11.ID = 11;
            w11.Name = "";
            w11.Latitude = 51.59033;
            w11.Longitude = 4.77623;
            w11.Images.Add(new BitmapImage(new Uri("images/Image8.jpg", UriKind.Relative)));
            w11.Description = "Kruising Kasteelplein/Cingelstraat";
            w11.InformationNL = getText("texts/T11TorenstraatNL.txt");
            w11.InformationEN = getText("texts/T11TorenstraatENG.txt");

            w12.ID = 12;
            w12.Name = "Huis van Brecht (rechter zijde)";
            w12.Latitude = 51.59043;
            w12.Longitude = 4.77518;
            w12.Images.Add(new BitmapImage(new Uri("images/Image7.jpg", UriKind.Relative)));
            w12.Description = "1e bocht Cingelstraat";
            w12.InformationNL = "";
            w12.InformationEN = "";

            w13.ID = 13;
            w13.Name = "";
            w13.Latitude = 51.59000;
            w13.Longitude = 4.77429;
            w13.Images.Add(new BitmapImage(new Uri("images/Image6.jpg", UriKind.Relative)));
            w13.Images.Add(new BitmapImage(new Uri("images/Image14.jpg", UriKind.Relative)));
            w13.Images.Add(new BitmapImage(new Uri("images/Image22.jpg", UriKind.Relative)));
            w13.Images.Add(new BitmapImage(new Uri("images/Image21.jpg", UriKind.Relative)));
            w13.Description = "2e bocht Cingelstraat";
            w13.InformationNL = "";
            w13.InformationEN = "";

            w14.ID = 14;
            w14.Name = "Spanjaardsgat (rechter zijde)";
            w14.Latitude = 51.59010;
            w14.Longitude = 4.77336;
            w14.Images.Add(new BitmapImage(new Uri("images/Image20.jpg", UriKind.Relative)));
            w14.Description = "";
            w14.InformationNL = "";
            w14.InformationEN = "";

            w15.ID = 15;
            w15.Name = "Begin Vismarkt";
            w15.Latitude = 51.58982;
            w15.Longitude = 4.77321;
            w15.Images.Add(new BitmapImage(new Uri("images/Image19.jpg", UriKind.Relative)));
            w15.Description = "";
            w15.InformationNL = "";
            w15.InformationEN = "";
           
            w16.ID = 16;
            w16.Name = "Begin Havermarkt";
            w16.Latitude = 51.58932;
            w16.Longitude = 4.77444;
            w16.Images.Add(null);
            w16.Description = "";
            w16.InformationNL = "";
            w17.InformationEN = "";

            w17.ID = 17;
            w17.Name = "";
            w17.Latitude = 51.58872;
            w17.Longitude = 4.77501;
            w17.Images.Add(new BitmapImage(new Uri("images/Image10.jpg", UriKind.Relative)));
            w17.Description = "Driehoek Kerkplein 1";
            w17.InformationNL = getText("texts/T17stadhuisNL.txt");
            w17.InformationEN = getText("texts/T17stadhuisENG.txt");

            w18.ID = 18;
            w18.Name = "Grote Kerk";
            w18.Latitude = 51.58878;
            w18.Longitude = 4.77549;
            w18.Images.Add(null);
            w18.Description = "Driehoek Kerkplein 2";
            w18.InformationNL = getText("texts/T18AntoniusKerkNL.txt");
            w18.InformationEN = getText("texts/T18AntoniusKerkENG.txt");

            w19.ID = 19;
            w19.Name = "";
            w19.Latitude = 51.58864;
            w19.Longitude = 4.77501;
            w19.Images.Add(null);
            w19.Description = "Driehoek Kerkplein 3";
            w19.InformationNL = getText("texts/T19BibliotheekNL.txt");
            w19.InformationEN = getText("texts/T19BibliotheekENG.txt");

            w20.ID = 20;
            w20.Name = "Het poortje";
            w20.Latitude = 51.58822;
            w20.Longitude = 4.77525;
            w20.Images.Add(null);
            w20.Description = "";
            w20.InformationNL = getText("texts/T20kloosterkazerneNL.txt");
            w20.InformationEN = getText("texts/T20kloosterkazerneENG.txt");

            w21.ID = 21;
            w21.Name = "Ridderstraat";
            w21.Latitude = 51.58716;
            w21.Longitude = 4.77582;
            w21.Images.Add(new BitmapImage(new Uri("images/Image17.jpg", UriKind.Relative)));
            w21.Description = "";
            w21.InformationNL = "";
            w21.InformationEN = "";

            w22.ID = 22;
            w22.Name = "Grote Markt";
            w22.Latitude = 51.58747;
            w22.Longitude = 4.77662;
            w22.Images.Add(new BitmapImage(new Uri("images/Image24.jpg", UriKind.Relative)));
            w22.Images.Add(new BitmapImage(new Uri("images/Image25.jpg", UriKind.Relative)));
            w22.Description = "";
            w23.InformationNL = "";
            w23.InformationEN = "";

            w23.ID = 23;
            w23.Name = "Het Wit Lam";
            w23.Latitude = 51.58771;
            w23.Longitude = 4.77652;
            w23.Images.Add(null);
            w23.Description = "";
            w23.InformationNL = "";
            w23.InformationEN = "";

            w24.ID = 24;
            w24.Name = "Bevrijdingsmonument";
            w24.Latitude = 51.58797;
            w24.Longitude = 4.77638;
            w24.Images.Add(null);
            w24.Description = "";
            w24.InformationNL = "";
            w24.InformationEN = "";

            w25.ID = 25;
            w25.Name = "";
            w25.Latitude = 51.58885;
            w25.Longitude = 4.77616;
            w25.Images.Add(null);
            w25.Description = "";
            w25.InformationNL = "";
            w25.InformationEN = "";

            w26.ID = 26;
            w26.Name = "";
            w26.Latitude = 51.58883;
            w26.Longitude = 4.77617;
            w26.Images.Add(null);
            w26.Description = "Kruising Grote Markt/Stadserf";
            w26.InformationNL = "";
            w26.InformationEN = "";

            w27.ID = 27;
            w27.Name = "";
            w27.Latitude = 51.58889;
            w27.Longitude = 4.77659;
            w27.Images.Add(null);
            w27.Description = "Achterkant stadshuis";
            w27.InformationNL = "";
            w27.InformationEN = "";

            w28.ID = 28;
            w28.Name = "";
            w28.Latitude = 51.58883;
            w28.Longitude = 4.77617;
            w28.Images.Add(null);
            w28.Description = "Kruising Grote Markt/Stadserf(je gaat weer terug)";
            w28.InformationNL = "";
            w28.InformationEN = "";

            w29.ID = 29;
            w29.Name = "";
            w29.Latitude = 51.58747;
            w29.Longitude = 4.77662;
            w29.Images.Add(null);
            w29.Description = "terug naar begin Grote Markt";
            w29.InformationNL = "";
            w29.InformationEN = "";

            w30.ID = 30;
            w30.Name = "Antonius van Paduakerk";
            w30.Latitude = 51.58761;
            w30.Longitude = 4.77712;
            w30.Images.Add(null);
            w30.Description = "";
            w30.InformationNL = "";
            w30.InformationEN = "";

            w31.ID = 31;
            w31.Name = "";           
            w31.Latitude = 51.58828;
            w31.Longitude = 4.77858;
            w31.Images.Add(null);
            w31.Description = "Kruising St. Jansstraat / Molenstraat";
            w31.InformationNL = "";
            w31.InformationEN = "";

            w32.ID = 32;
            w32.Name = "Bibliotheek";
            w32.Latitude = 51.58773;
            w32.Longitude = 4.77948;
            w32.Images.Add(null);
            w32.Description = "";
            w32.InformationNL = "";
            w32.InformationEN = "";

            w33.ID = 33;
            w33.Name = "";
            w33.Latitude = 51.58752;
            w33.Longitude = 4.77994;
            w33.Images.Add(null);
            w33.Description = "Kruising Molenstraat / Kloosterplein";
            w33.InformationNL = "";
            w33.InformationEN = "";

            w34.ID = 34;
            w34.Name = "Kloosterkazerne";
            w34.Latitude = 51.58794;
            w34.Longitude = 4.78105;
            w34.Images.Add(null);
            w34.Description = "1e bocht Kloosterplein";
            w34.InformationNL = "";
            w34.InformationEN = "";

            w35.ID = 35;
            w35.Name = "Chasse theater";
            w35.Latitude = 51.58794;
            w35.Longitude = 4.78218;
            w35.Images.Add(null);
            w35.Description = "2e bocht Kloosterplein";
            w35.InformationNL = "";
            w35.InformationEN = "";

            w36.ID = 36;
            w36.Name = "";
            w36.Latitude = 51.58794;
            w36.Longitude = 4.78105;
            w36.Images.Add(null);
            w36.Description = "1e bocht Kloosterplein/ Begin Vlaszak";
            w36.InformationNL = "";
            w36.InformationEN = "";
            
            w37.ID = 37;
            w37.Name = "Binding van Isaäc";
            w37.Latitude = 51.58862;
            w37.Longitude = 4.78079;
            w37.Images.Add(null);
            w37.Description = "";
            w37.InformationNL = "";
            w38.InformationEN = "";

            w38.ID = 38;
            w38.Name = "";
            w38.Latitude = 51.58955;
            w38.Longitude = 4.78038;
            w38.Images.Add(null);
            w38.Description = "Einde Vlaszak / Begin Boschstraat";
            w38.InformationNL = "";
            w38.InformationEN = "";

            w39.ID = 39;
            w39.Name = "Beyerd";
            w39.Latitude = 51.58966;
            w39.Longitude = 4.78076;
            w39.Images.Add(null);
            w39.Description = "";
            w39.InformationNL = "";
            w39.InformationEN = "";

            w40.ID = 40;
            w40.Name = "Gasthuispoort";
            w40.Latitude = 51.58939;
            w40.Longitude = 4.77982;
            w40.Images.Add(null);
            w40.Description = "1e bocht Catharinastraat / Veemarktstraat";
            w40.InformationNL = "";
            w40.InformationEN = "";

            w41.ID = 41;
            w41.Name = "";            
            w41.Latitude = 51.58905;
            w41.Longitude = 4.77981;
            w41.Images.Add(null);
            w41.Description = "2e bocht Veemarktstraat";
            w41.InformationNL = "";
            w41.InformationEN = "";

            w42.ID = 42;
            w42.Name = "";
            w42.Latitude = 51.58846;
            w42.Longitude = 4.77830;
            w42.Images.Add(null);
            w42.Description = "Kruising St. Annastraat / Veemarktstraat";
            w42.InformationNL = "";
            w42.InformationEN = "";

            w43.ID = 43;
            w43.Name = "Willem Merkxtuin";
            w43.Latitude = 51.58905;
            w43.Longitude = 4.77801;
            w43.Images.Add(null);
            w43.Description = "De ingang";
            w43.InformationNL = "";
            w43.InformationEN = "";

            w44.ID = 44;
            w44.Name = "";
            w44.Latitude = 51.58918;
            w44.Longitude = 4.77841;
            w44.Images.Add(null);
            w44.Description = "Binnen Willem Merkxtuin";
            w44.InformationNL = "";
            w44.InformationEN = "";

            w45.ID = 45;
            w45.Name = "";
            w45.Latitude = 51.58905;
            w45.Longitude = 4.77801;
            w45.Images.Add(null);
            w45.Description = "Uitgang Willem Merkxtuin";
            w45.InformationNL = "";
            w45.InformationEN = "";

            w46.ID = 46;
            w46.Name = "";
            w46.Latitude = 51.58960;
            w46.Longitude = 4.77770;
            w46.Images.Add(null);
            w46.Description = "Kruising Catharinastraat / St. Annastraat";
            w46.InformationNL = "";
            w46.InformationEN = "";

            w47.ID = 47;
            w47.Name = "";
            w47.Latitude = 51.58965;
            w47.Longitude = 4.77830;
            w47.Images.Add(null);
            w47.Description = "De ingang";
            w47.InformationNL = "";
            w48.InformationEN = "";

            w48.ID = 48;
            w48.Name = "";
            w48.Latitude = 51.58997;
            w48.Longitude = 4.77810;
            w48.Images.Add(null);
            w48.Description = "Binnen Begijnenhof";
            w48.InformationNL = "";
            w48.InformationEN = "";

            w49.ID = 49;
            w49.Name = "";
            w49.Latitude = 51.58965;
            w49.Longitude = 4.77830;
            w49.Images.Add(null);
            w49.Description = "Uitgang Begijnenhof";
            w49.InformationNL = "";
            w49.InformationEN = "";

            w50.ID = 50;
            w50.Name = "Eindpunt stadswandeling";
            w50.Latitude = 51.58950;
            w50.Longitude = 4.77649;
            w50.Images.Add(null);
            w50.Description = "Eindpunt";
            w50.InformationNL = "";
            w50.InformationEN = "";

            #endregion

            standardVVVRoute.ID = 0;
            standardVVVRoute.Name = "Standaard VVV Route";

            #region Add all waypoints to standard VVVroute

            standardVVVRoute.Waypoints.Add(w1);
            standardVVVRoute.Waypoints.Add(w2);
            standardVVVRoute.Waypoints.Add(w3);
            standardVVVRoute.Waypoints.Add(w4);
            standardVVVRoute.Waypoints.Add(w5);
            standardVVVRoute.Waypoints.Add(w6);
            standardVVVRoute.Waypoints.Add(w7);
            standardVVVRoute.Waypoints.Add(w8);
            standardVVVRoute.Waypoints.Add(w9);
            standardVVVRoute.Waypoints.Add(w10);

            standardVVVRoute.Waypoints.Add(w11);
            standardVVVRoute.Waypoints.Add(w12);
            standardVVVRoute.Waypoints.Add(w13);
            standardVVVRoute.Waypoints.Add(w14);
            standardVVVRoute.Waypoints.Add(w15);
            standardVVVRoute.Waypoints.Add(w16);
            standardVVVRoute.Waypoints.Add(w17);
            standardVVVRoute.Waypoints.Add(w18);
            standardVVVRoute.Waypoints.Add(w19);
            standardVVVRoute.Waypoints.Add(w20);

            standardVVVRoute.Waypoints.Add(w21);
            standardVVVRoute.Waypoints.Add(w22);
            standardVVVRoute.Waypoints.Add(w23);
            standardVVVRoute.Waypoints.Add(w24);
            standardVVVRoute.Waypoints.Add(w25);
            standardVVVRoute.Waypoints.Add(w26);
            standardVVVRoute.Waypoints.Add(w27);
            standardVVVRoute.Waypoints.Add(w28);
            standardVVVRoute.Waypoints.Add(w29);
            standardVVVRoute.Waypoints.Add(w30);

            standardVVVRoute.Waypoints.Add(w31);
            standardVVVRoute.Waypoints.Add(w32);
            standardVVVRoute.Waypoints.Add(w33);
            standardVVVRoute.Waypoints.Add(w34);
            standardVVVRoute.Waypoints.Add(w35);
            standardVVVRoute.Waypoints.Add(w36);
            standardVVVRoute.Waypoints.Add(w37);
            standardVVVRoute.Waypoints.Add(w38);
            standardVVVRoute.Waypoints.Add(w39);
            standardVVVRoute.Waypoints.Add(w40);

            standardVVVRoute.Waypoints.Add(w41);
            standardVVVRoute.Waypoints.Add(w42);
            standardVVVRoute.Waypoints.Add(w43);
            standardVVVRoute.Waypoints.Add(w44);
            standardVVVRoute.Waypoints.Add(w45);
            standardVVVRoute.Waypoints.Add(w46);
            standardVVVRoute.Waypoints.Add(w47);
            standardVVVRoute.Waypoints.Add(w48);
            standardVVVRoute.Waypoints.Add(w49);
            standardVVVRoute.Waypoints.Add(w50);


            waypointDB.Add(w1);
            waypointDB.Add(w2);
            waypointDB.Add(w3);
            waypointDB.Add(w4);
            waypointDB.Add(w5);
            waypointDB.Add(w6);
            waypointDB.Add(w7);
            waypointDB.Add(w8);
            waypointDB.Add(w9);
            waypointDB.Add(w10);

            waypointDB.Add(w1);
            waypointDB.Add(w2);
            waypointDB.Add(w3);
            waypointDB.Add(w4);
            waypointDB.Add(w5);
            waypointDB.Add(w6);
            waypointDB.Add(w7);
            waypointDB.Add(w8);
            waypointDB.Add(w9);
            waypointDB.Add(w10);

            waypointDB.Add(w11);
            waypointDB.Add(w12);
            waypointDB.Add(w13);
            waypointDB.Add(w14);
            waypointDB.Add(w15);
            waypointDB.Add(w16);
            waypointDB.Add(w17);
            waypointDB.Add(w18);
            waypointDB.Add(w19);
            waypointDB.Add(w20);

            waypointDB.Add(w21);
            waypointDB.Add(w22);
            waypointDB.Add(w23);
            waypointDB.Add(w24);
            waypointDB.Add(w25);
            waypointDB.Add(w26);
            waypointDB.Add(w27);
            waypointDB.Add(w28);
            waypointDB.Add(w29);
            waypointDB.Add(w30);

            waypointDB.Add(w31);
            waypointDB.Add(w32);
            waypointDB.Add(w33);
            waypointDB.Add(w34);
            waypointDB.Add(w35);
            waypointDB.Add(w36);
            waypointDB.Add(w37);
            waypointDB.Add(w38);
            waypointDB.Add(w39);
            waypointDB.Add(w40);

            waypointDB.Add(w41);
            waypointDB.Add(w42);
            waypointDB.Add(w43);
            waypointDB.Add(w44);
            waypointDB.Add(w45);
            waypointDB.Add(w46);
            waypointDB.Add(w47);
            waypointDB.Add(w48);
            waypointDB.Add(w49);
            waypointDB.Add(w50);

            #endregion

            routeDB.Add(standardVVVRoute);
        }

        internal static string getText(string path)
        {
            var ResrouceStream = Application.GetResourceStream(new Uri(path, UriKind.Relative));
            if (ResrouceStream != null)
            {
                using (Stream myFileStream = ResrouceStream.Stream)
                {
                    if (myFileStream.CanRead)
                    {
                        StreamReader myStreamReader = new StreamReader(myFileStream);
                        //read the content here
                        return myStreamReader.ReadToEnd();
                    }
                }
            }
            return string.Empty;
        }

        public static Route getRouteByID(int routeID)
        {
            foreach (Route Route in routeDB)
            {
                if (Route.ID == routeID)
                { return Route; }
            }

            return null;
        }

        public static ObservableCollection<Waypoint> getAllRouteWaypoints(int routeID)
        {
            ObservableCollection<Waypoint> waypoints = new ObservableCollection<Waypoint>();

            foreach (Route Route in routeDB)
            {
                if (Route.ID == routeID)
                { waypoints = Route.Waypoints; }
            }
            return waypoints;
        }

        public static ObservableCollection<Route> GetAllRoutes()
        {
            if (routeDB != null && routeDB.Count > 0)
            { return routeDB; }
            else
            { return null; }
        }

        public static ObservableCollection<String> getAllRouteNames()
        {
            ObservableCollection<String> routeNames = new ObservableCollection<String>();
            foreach (Route route in routeDB)
            { routeNames.Add(route.Name); }

            return routeNames;
        }

        public static ObservableCollection<GeoCoordinate> getCoordinatesOfAllWaypointsFromRoute(int routeID)
        {
            ObservableCollection<Waypoint> waypointCollection = new ObservableCollection<Waypoint>();
            ObservableCollection<GeoCoordinate> waypointCoordinates = new ObservableCollection<GeoCoordinate>();

            foreach (Route route in routeDB)
            {
                if (route.ID == routeID)
                { waypointCollection = route.Waypoints; }
            }

            foreach (Waypoint waypoint in waypointCollection)
            {
                waypointCoordinates.Add(new GeoCoordinate(waypoint.Latitude, waypoint.Longitude));
            }

            return waypointCoordinates;
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }

        public static Waypoint getWaypointByID(int waypointID)
        {
            Waypoint requestedWaypoint = new Waypoint();
            foreach (Waypoint waypoint in waypointDB)
            {
                if (waypoint.ID == waypointID)
                { requestedWaypoint = waypoint; }
            }

            return requestedWaypoint;
        }

        private void NotifyPropertyChanging(string propertyName)
        {
            if (PropertyChanging != null)
            { PropertyChanging(this, new PropertyChangingEventArgs(propertyName)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
    }
}
