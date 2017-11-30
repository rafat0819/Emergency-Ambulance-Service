namespace EAS
{
    partial class AdminInterface
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
            this.ShowHT = new MetroFramework.Controls.MetroTile();
            this.ShowPT = new MetroFramework.Controls.MetroTile();
            this.ShowHospitalCB = new MetroFramework.Controls.MetroCheckBox();
            this.ShowPatientCB = new MetroFramework.Controls.MetroCheckBox();
            this.ALogoutB = new MetroFramework.Controls.MetroButton();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // ShowHT
            // 
            this.ShowHT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowHT.Location = new System.Drawing.Point(23, 63);
            this.ShowHT.Name = "ShowHT";
            this.ShowHT.Size = new System.Drawing.Size(197, 71);
            this.ShowHT.TabIndex = 1;
            this.ShowHT.Text = "Show Hospital List";
            this.ShowHT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowHT.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ShowHT.Click += new System.EventHandler(this.ShowHT_Click);
            // 
            // ShowPT
            // 
            this.ShowPT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowPT.Location = new System.Drawing.Point(23, 140);
            this.ShowPT.Name = "ShowPT";
            this.ShowPT.Size = new System.Drawing.Size(197, 71);
            this.ShowPT.TabIndex = 2;
            this.ShowPT.Text = "Show Patient List";
            this.ShowPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowPT.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ShowPT.Click += new System.EventHandler(this.ShowPT_Click);
            // 
            // ShowHospitalCB
            // 
            this.ShowHospitalCB.AutoSize = true;
            this.ShowHospitalCB.Location = new System.Drawing.Point(273, 284);
            this.ShowHospitalCB.Name = "ShowHospitalCB";
            this.ShowHospitalCB.Size = new System.Drawing.Size(104, 15);
            this.ShowHospitalCB.TabIndex = 3;
            this.ShowHospitalCB.Text = "Show Hospitals";
            this.ShowHospitalCB.UseVisualStyleBackColor = true;
            // 
            // ShowPatientCB
            // 
            this.ShowPatientCB.AutoSize = true;
            this.ShowPatientCB.Location = new System.Drawing.Point(383, 284);
            this.ShowPatientCB.Name = "ShowPatientCB";
            this.ShowPatientCB.Size = new System.Drawing.Size(97, 15);
            this.ShowPatientCB.TabIndex = 4;
            this.ShowPatientCB.Text = "Show Patients";
            this.ShowPatientCB.UseVisualStyleBackColor = true;
            // 
            // ALogoutB
            // 
            this.ALogoutB.Location = new System.Drawing.Point(452, 34);
            this.ALogoutB.Name = "ALogoutB";
            this.ALogoutB.Size = new System.Drawing.Size(75, 23);
            this.ALogoutB.TabIndex = 5;
            this.ALogoutB.Text = "Logout";
            this.ALogoutB.Click += new System.EventHandler(this.ALogoutB_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(237, 63);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 0;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(279, 173);
            this.gMapControl1.TabIndex = 48;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.ALogoutB);
            this.Controls.Add(this.ShowPatientCB);
            this.Controls.Add(this.ShowHospitalCB);
            this.Controls.Add(this.ShowPT);
            this.Controls.Add(this.ShowHT);
            this.Name = "AdminInterface";
            this.Text = "Admin Interface";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminInterface_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile ShowHT;
        private MetroFramework.Controls.MetroTile ShowPT;
        private MetroFramework.Controls.MetroCheckBox ShowHospitalCB;
        private MetroFramework.Controls.MetroCheckBox ShowPatientCB;
        private MetroFramework.Controls.MetroButton ALogoutB;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}