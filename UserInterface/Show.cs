using EAS.Controller;
using EAS.UserInterface;
using System;
using System.Windows.Forms;

namespace EAS
{
    public partial class Show : MetroFramework.Forms.MetroForm
    {
        ShowController SHC;

        bool redirectme;

        public Show()
        {
            InitializeComponent();

            SHC = new ShowController();


            dtableHospitals.DataSource = SHC.InitDataHospitals();
            dtGridViewPatient.DataSource = SHC.InitDataPatients();
        }


        public Show(bool readme)
        {
            InitializeComponent();

            SHC = new ShowController();


            dtableHospitals.DataSource = SHC.InitDataHospitals();
            dtGridViewPatient.DataSource = SHC.InitDataPatients();
            

            

            this.redirectme = readme;

            if (this.redirectme == true)
            {
                ShowTab.SelectedTab = ShowHospitalTab;
            }
            else
            {
                ShowTab.SelectedTab = ShowPatientTab;
            }

        }

        private void AddT_Click(object sender, EventArgs e)
        {
            new AddHospital().Show();
            Hide();
        }

        private void Show_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dtableHospitals_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteT_Click(object sender, EventArgs e)
        {
            if(dtableHospitals.SelectedRows.Count > 0)
            {
                int SelectedIndex = dtableHospitals.SelectedRows[0].Index;

                int RowID = int.Parse(dtableHospitals[0, SelectedIndex].Value.ToString());

                SHC.Delete(RowID);
            }
        }

        private void MBACK_Click(object sender, EventArgs e)
        {
            new AdminInterface().Show();
            Hide();
        }
    }
}
