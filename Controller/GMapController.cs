using EAS.Controller;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using EAS.UserInterface;

namespace EAS.Controller
{
    class GMapControl
    {
        private GMapOverlay overlayOne;



        public void MapInit(GMapControl a, string C)
        {
           


        }

        /*public void ClickMap(GMapControl a, MouseEventArgs e)
        {
            double lat = 0.0;
            double lng = 0.0;
            if (e.Button == MouseButtons.Left)
            {
                lat = a.FromLocalToLatLng(e.X, e.Y).Lat;
                lng = a.FromLocalToLatLng(e.X, e.Y).Lng;

                overlayOne = new GMapOverlay("OverlayOne");

                a.Overlays.Add(overlayOne);

                 List<Placemark> plc = null;
                var st = GMapProviders.GoogleMap.GetPlacemarks(new PointLatLng(54.6961334816182, 25.2985095977782), out plc);
                if (st == GeoCoderStatusCode.G_GEO_SUCCESS && plc != null)
                {
                    foreach (var pl in plc)
                    {
                        if (!string.IsNullOrEmpty(pl.PostalCodeNumber))
                        {
                            Debug.WriteLine("Accuracy: " + pl.Accuracy + ", " + pl.Address + ", PostalCodeNumber: " + pl.PostalCodeNumber);
                        }
                    }
                }
                */
            }


        }

