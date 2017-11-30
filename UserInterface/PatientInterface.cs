using EAS.Controller;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAS
{
    public partial class PatientInterface : MetroFramework.Forms.MetroForm
    {
        PatientInterfaceController PIC;
        AdminInterfaceController AIC;

        public PatientInterface()
        {
            InitializeComponent();

            PIC = new PatientInterfaceController();

            dataGridView1.DataSource = PIC.InitDataHospitals();

            //this.dataGridView1.Sort(this.Distance, ListSortDirection.Ascending);
        }

       

        private void EmergencyServiceT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Be Patient. The Ambulance is on its way.");
        }

        private void PatientInterface_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PlogoutB_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords("Dhaka, Bangladesh");

            gMapControl1.Overlays.Add(PIC.getMarkersH());
            gMapControl1.Overlays.Add(PIC.getMarkersP());



        }
    }
}
