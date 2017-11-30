namespace EAS
{
    partial class Show
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowTab = new MetroFramework.Controls.MetroTabControl();
            this.ShowHospitalTab = new MetroFramework.Controls.MetroTabPage();
            this.DeleteT = new MetroFramework.Controls.MetroTile();
            this.AddT = new MetroFramework.Controls.MetroTile();
            this.dtableHospitals = new System.Windows.Forms.DataGridView();
            this.ShowPatientTab = new MetroFramework.Controls.MetroTabPage();
            this.dtGridViewPatient = new System.Windows.Forms.DataGridView();
            this.MBACK = new MetroFramework.Controls.MetroTile();
            this.ShowTab.SuspendLayout();
            this.ShowHospitalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtableHospitals)).BeginInit();
            this.ShowPatientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowTab
            // 
            this.ShowTab.Controls.Add(this.ShowHospitalTab);
            this.ShowTab.Controls.Add(this.ShowPatientTab);
            this.ShowTab.Location = new System.Drawing.Point(23, 63);
            this.ShowTab.Name = "ShowTab";
            this.ShowTab.SelectedIndex = 0;
            this.ShowTab.Size = new System.Drawing.Size(504, 314);
            this.ShowTab.TabIndex = 0;
            // 
            // ShowHospitalTab
            // 
            this.ShowHospitalTab.Controls.Add(this.DeleteT);
            this.ShowHospitalTab.Controls.Add(this.AddT);
            this.ShowHospitalTab.Controls.Add(this.dtableHospitals);
            this.ShowHospitalTab.HorizontalScrollbarBarColor = true;
            this.ShowHospitalTab.Location = new System.Drawing.Point(4, 35);
            this.ShowHospitalTab.Name = "ShowHospitalTab";
            this.ShowHospitalTab.Size = new System.Drawing.Size(496, 275);
            this.ShowHospitalTab.TabIndex = 0;
            this.ShowHospitalTab.Text = "Hospitals";
            this.ShowHospitalTab.VerticalScrollbarBarColor = true;
            // 
            // DeleteT
            // 
            this.DeleteT.Location = new System.Drawing.Point(428, 51);
            this.DeleteT.Name = "DeleteT";
            this.DeleteT.Size = new System.Drawing.Size(65, 42);
            this.DeleteT.TabIndex = 4;
            this.DeleteT.Text = "Delete";
            this.DeleteT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteT.Click += new System.EventHandler(this.DeleteT_Click);
            // 
            // AddT
            // 
            this.AddT.Location = new System.Drawing.Point(428, 3);
            this.AddT.Name = "AddT";
            this.AddT.Size = new System.Drawing.Size(65, 42);
            this.AddT.TabIndex = 3;
            this.AddT.Text = "Add";
            this.AddT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddT.Click += new System.EventHandler(this.AddT_Click);
            // 
            // dtableHospitals
            // 
            this.dtableHospitals.AllowUserToAddRows = false;
            this.dtableHospitals.AllowUserToDeleteRows = false;
            this.dtableHospitals.AllowUserToOrderColumns = true;
            this.dtableHospitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtableHospitals.Location = new System.Drawing.Point(0, 0);
            this.dtableHospitals.Name = "dtableHospitals";
            this.dtableHospitals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtableHospitals.Size = new System.Drawing.Size(422, 279);
            this.dtableHospitals.TabIndex = 2;
            this.dtableHospitals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtableHospitals_CellClick);
            // 
            // ShowPatientTab
            // 
            this.ShowPatientTab.Controls.Add(this.dtGridViewPatient);
            this.ShowPatientTab.HorizontalScrollbarBarColor = true;
            this.ShowPatientTab.Location = new System.Drawing.Point(4, 35);
            this.ShowPatientTab.Name = "ShowPatientTab";
            this.ShowPatientTab.Size = new System.Drawing.Size(496, 275);
            this.ShowPatientTab.TabIndex = 1;
            this.ShowPatientTab.Text = "Patients";
            this.ShowPatientTab.VerticalScrollbarBarColor = true;
            // 
            // dtGridViewPatient
            // 
            this.dtGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridViewPatient.Location = new System.Drawing.Point(0, 0);
            this.dtGridViewPatient.Name = "dtGridViewPatient";
            this.dtGridViewPatient.Size = new System.Drawing.Size(496, 275);
            this.dtGridViewPatient.TabIndex = 3;
            // 
            // MBACK
            // 
            this.MBACK.Location = new System.Drawing.Point(455, 40);
            this.MBACK.Name = "MBACK";
            this.MBACK.Size = new System.Drawing.Size(65, 42);
            this.MBACK.TabIndex = 4;
            this.MBACK.Text = "Back";
            this.MBACK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MBACK.Click += new System.EventHandler(this.MBACK_Click);
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.MBACK);
            this.Controls.Add(this.ShowTab);
            this.Name = "Show";
            this.Text = "Show";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Show_FormClosed);
            this.ShowTab.ResumeLayout(false);
            this.ShowHospitalTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtableHospitals)).EndInit();
            this.ShowPatientTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl ShowTab;
        private MetroFramework.Controls.MetroTabPage ShowHospitalTab;
        private MetroFramework.Controls.MetroTabPage ShowPatientTab;
        private MetroFramework.Controls.MetroTile DeleteT;
        private MetroFramework.Controls.MetroTile AddT;
        private System.Windows.Forms.DataGridView dtableHospitals;
        private System.Windows.Forms.DataGridView dtGridViewPatient;
        private MetroFramework.Controls.MetroTile MBACK;
    }
}