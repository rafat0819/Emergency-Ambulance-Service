using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace EAS.Controller
{
    class AdminInterfaceController
    {
        HDBDataContext Database = new HDBDataContext();
        GMapOverlay markersH =new GMapOverlay("markersH");
        GMapOverlay markersP = new GMapOverlay("markersP");
        PointLatLng p;
        PointLatLng q;

        public AdminInterfaceController()
        {
            

        }

        public GMapOverlay getMarkersH()
        {
            
            
            // database theke nibo
            foreach (var onehost in Database.Hospitals)
            {
                this.p.Lat = onehost.HLat;
                this.p.Lng = onehost.HLng;
                GMapMarker m = new GMarkerGoogle(p, GMarkerGoogleType.blue_pushpin);
                this.markersH.Markers.Add(m);
                m.ToolTipText = onehost.HName;
            }



            return this.markersH;

        }

        public GMapOverlay getMarkersP()
        {
            
            // database theke nibo
            foreach (var oneUser in Database.Users)
            {
                this.q.Lat = oneUser.PLat;
                this.q.Lng = oneUser.PLng;
                GMapMarker n = new GMarkerGoogle(p, GMarkerGoogleType.red_pushpin);
                this.markersP.Markers.Add(n);
                n.ToolTipText = oneUser.PName;

            }



            return this.markersP;

        }
    }
}
