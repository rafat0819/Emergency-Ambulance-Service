using EAS.Controller;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System;

namespace EAS.UserInterface
{
    public partial class Registration : DevComponents.DotNetBar.Metro.MetroForm
    {
        SignUpController SC;

        Controller.GMapControl GM;

        Hospital hs = new Hospital();

        bool Male = false;
        bool Diabetes = false;
        bool BP = false;
        private GMapOverlay overlayOne;

        public Registration()
        {
            InitializeComponent();

            SC = new SignUpController(this);

            GM = new Controller.GMapControl();

            Registration1.Visible = true;
            Registration2.Visible = false;
            Registration3.Visible = false;
            Registration4.Visible = false;
        }

        private void NextR1_Click(object sender, System.EventArgs e)
        {
            if (usernameTB.Text != "" && passwordTB1.Text != "" && passwordTB2.Text != "")
            {
                if (passwordTB1.Text == passwordTB2.Text)
                {
                    if (SC.Step1(usernameTB.Text, passwordTB1.Text))
                    {
                        Registration1.Visible = false;
                        Registration3.Visible = false;
                        Registration4.Visible = false;
                        Registration2.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Password doesnt match! Try again!");
                }
            }
            else
            {
                MessageBox.Show("Please fill up all the fields!");
            }        
        }

        private void BackR1_Click(object sender, System.EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void R1NextB_Click(object sender, System.EventArgs e)
        {
            if (PNameTB.Text != "" && ((MaleRB.Checked == true) || (FemaleRB.Checked == true)) && PMobileNo.Text != "" && PEmail.Text != "")
            {
                if (MaleRB.Checked == true)
                {
                    Male = true;
                }
                if (FemaleRB.Checked == true)
                {
                    Male = false;
                }
                if (SC.Step2(PNameTB.Text, PDOB, Male, PMobileNo.Text, PEmail.Text))
                {
                    Registration1.Visible = false;
                    Registration4.Visible = false;
                    Registration2.Visible = false;
                    Registration3.Visible = true;
                }
            }
        }

        private void R0BackB_Click(object sender, System.EventArgs e)
        {
            Registration2.Visible = false;
            Registration3.Visible = false;
            Registration4.Visible = false;
            Registration1.Visible = true;

            passwordTB1.Clear();
            passwordTB2.Clear();

        }

        private void gMapControl1_Load(object sender, System.EventArgs e)
        {
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords("Dhaka, Bangladesh");


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

        private void R2NextB_Click(object sender, System.EventArgs e)
        {
            if (AddTB.Text != "")
            {
                if (SC.Step3(AddTB.Text, double.Parse(LatTB.Text), double.Parse(LngTB.Text)))
                {
                    Registration1.Visible = false;
                    Registration3.Visible = false;
                    Registration2.Visible = false;
                    Registration4.Visible = true;
                }
            }
        }

        private void R2BackB_Click(object sender, System.EventArgs e)
        {
            Registration1.Visible = false;
            Registration4.Visible = false;
            Registration3.Visible = false;
            Registration2.Visible = true;
        }

        private void R3CompleteB_Click(object sender, System.EventArgs e)
        {
            
                if (DYRB.Checked == true)
                {
                    Diabetes = true;
                }
                else if (DNRB.Checked == true)
                {
                    Diabetes = false;
                }
                if (BloodPressureYRB.Checked == true)
                {
                    BP = true;
                }
                if (BloodPressureNRB.Checked == true)
                {
                    BP = false;
                }
                if (SC.Step4(BloodGroupCB.SelectedText, Diabetes, DiabetesYTB.Text, BP, BloodPressureYTB.Text))
                {
                    MessageBox.Show("JUIHBI");
                    Registration1.Visible = false;
                    Registration3.Visible = false;
                    Registration2.Visible = false;
                    Registration4.Visible = true;


                
            }
            
        }

        private void R3BackB_Click(object sender, System.EventArgs e)
        {
            Registration1.Visible = false;
            Registration2.Visible = false;
            Registration4.Visible = false;
            Registration3.Visible = true;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}