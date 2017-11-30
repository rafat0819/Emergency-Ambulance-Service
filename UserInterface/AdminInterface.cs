using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using EAS.Controller;

namespace EAS
{
    public partial class AdminInterface : MetroFramework.Forms.MetroForm
    {
        AdminInterfaceController AIC = new AdminInterfaceController();
        bool redirectme = false;
        GMapOverlay a = new GMapOverlay();
        GMapOverlay b = new GMapOverlay();
      

        public IEnumerable<Hospital> Hospitals { get; private set; }

        public AdminInterface()
        {
            InitializeComponent();
        }

        private void ShowHT_Click(object sender, EventArgs e)
        {
            redirectme = true;

            new Show(redirectme).Show();
            Hide();
        }

        private void AdminInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ALogoutB_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }

        

        private void ShowPT_Click(object sender, EventArgs e)
        {
            redirectme = false;

            new Show(redirectme).Show();
            Hide();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords("Dhaka, Bangladesh");


            gMapControl1.Overlays.Add(AIC.getMarkersH());
            
           // gMapControl1.Overlays.Insert(0, AIC.getMarkersH());
            //gMapControl1.Overlays.Insert(1, AIC.getMarkersP());
            gMapControl1.Overlays.Add(AIC.getMarkersP());
        }
      
    }
}
