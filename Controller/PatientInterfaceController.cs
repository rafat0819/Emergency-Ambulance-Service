using System.Linq;
using System.Data;
using GMap.NET;
using System.Collections.Generic;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace EAS.Controller
{
    class PatientInterfaceController
    {
        HDBDataContext Database = new HDBDataContext();

        GMapOverlay markersH = new GMapOverlay("markersH");
        GMapOverlay markersP = new GMapOverlay("markersP");
        PointLatLng p;
        PointLatLng q;
        PointLatLng userLoc;
        PointLatLng hosLoc;



        GMapRoute r = null;




        public PatientInterfaceController()
        {

        }

        public object InitDataHospitals()
        {
            User oneUser = Database.Users.SingleOrDefault(x => x.Uid == Properties.Settings.Default.uid);

            this.userLoc = new PointLatLng(oneUser.PLat, oneUser.PLng);
            setRouteDistance();
            var str = from x in Database.Hospitals
                      select new { Name = x.HName, Distance = x.HDistance };
            return str;
        }

        public GMapOverlay getMarkersH()
        {


            // database theke nibo
            foreach (var onehost in Database.Hospitals)
            {
                this.p.Lat = onehost.HLat;
                this.p.Lng = onehost.HLng;
                GMapMarker x = new GMarkerGoogle(p, GMarkerGoogleType.blue_pushpin);
                this.markersH.Markers.Add(x);
                x.ToolTipText = onehost.HName;
            }



            return this.markersH;

        }
        public GMapOverlay getMarkersP()
        {

            // database theke nibo
            User oneUser  = Database.Users.SingleOrDefault(x => x.Uid == Properties.Settings.Default.uid);
            GMapMarker y = new GMarkerGoogle(userLoc, GMarkerGoogleType.red_pushpin);
            this.markersP.Markers.Add(y);
            y.ToolTipText = oneUser.PName;
            



            return this.markersP;

        }

        public void setRouteDistance()
        {
            GDirections ss;
            foreach (var oneHos in Database.Hospitals)
            {
                // Settings host location
                this.hosLoc.Lat = oneHos.HLat;
                this.hosLoc.Lng = oneHos.HLng;
                
                // calculating
                object xx = GMapProviders.GoogleMap.GetDirections(out ss, this.userLoc, this.hosLoc, false, false, false, false, false);

                // now update the database with distance
                Hospital host = Database.Hospitals.SingleOrDefault(x => x.Hid == oneHos.Hid);

                host.HDistance = new GMapRoute(ss.Route, "My route").Distance;

                Database.SubmitChanges();
            }
        }

        
            
        }


    }

