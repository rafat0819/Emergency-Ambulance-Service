using EAS.Controller;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EAS.UserInterface
{
    public partial class AddHospital :  MetroFramework.Forms.MetroForm
    {
        AddHospitalController AC;
        private GMapOverlay overlayOne;
        string str;

        public AddHospital()
        {
            InitializeComponent();

            AC = new AddHospitalController(this);

            AddHospital2.Visible = false;
            AddHospital1.Visible = true;
        }

        private void R1NextB_Click(object sender, EventArgs e)
        {
            if (HNameTB.Text != "" && CityTB.Text != "" & CountryTB.Text != "")
            {
                if (AC.Step1(HNameTB.Text, CityTB.Text, CountryTB.Text))
                {
                    AddHospital1.Visible = false;
                    AddHospital2.Visible = true;
                    str = CityTB.Text + ", " + CountryTB.Text;
                    AddTB.Text = str;

                }
            }
            else
            {
                MessageBox.Show("Please fill up all the fields");
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords(CityTB.Text+", "+CountryTB.Text);


            
                



            gMapControl1.MouseClick += new MouseEventHandler(gMapControl1_MouseClick);
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            double lat = 0.0;
            double lng = 0.0;
            if (e.Button == MouseButtons.Left)
            {
                lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

                overlayOne = new GMapOverlay("OverlayOne");

                gMapControl1.Overlays.Add(overlayOne);

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
            }
            LatTB.Text = lat.ToString();
            LngTB.Text = lng.ToString();
        }

        private void R1BackB_Click(object sender, EventArgs e)
        {
            new Show().Show();
            Hide();
        }

        private void R2CompleteB_Click(object sender, EventArgs e)
        {
            if (AC.Step2(double.Parse(LatTB.Text), double.Parse(LngTB.Text)))
            {
                AddHospital1.Visible = false;
                AddHospital2.Visible = true;
            }


        }

        private void R2BackB_Click(object sender, EventArgs e)
        {
            AddHospital2.Visible = false;
            AddHospital1.Visible = true;
        }

        private void AddHospital_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}