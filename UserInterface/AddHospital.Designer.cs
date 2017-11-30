namespace EAS.UserInterface
{
    partial class AddHospital
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
            this.AddHospital1 = new System.Windows.Forms.Panel();
            this.R1BackB = new MetroFramework.Controls.MetroButton();
            this.R1NextB = new MetroFramework.Controls.MetroButton();
            this.GeneralL = new MetroFramework.Controls.MetroLink();
            this.CountryTB = new MetroFramework.Controls.MetroTextBox();
            this.CountryL = new MetroFramework.Controls.MetroLink();
            this.LocationL = new MetroFramework.Controls.MetroLink();
            this.CityTB = new MetroFramework.Controls.MetroTextBox();
            this.CityL = new MetroFramework.Controls.MetroLink();
            this.HNameTB = new MetroFramework.Controls.MetroTextBox();
            this.HNameLabel = new MetroFramework.Controls.MetroLink();
            this.AddHospital2 = new System.Windows.Forms.Panel();
            this.R2BackB = new MetroFramework.Controls.MetroButton();
            this.R2CompleteB = new MetroFramework.Controls.MetroButton();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.AddTB = new MetroFramework.Controls.MetroTextBox();
            this.AddL = new MetroFramework.Controls.MetroLink();
            this.LngTB = new MetroFramework.Controls.MetroTextBox();
            this.LngL = new MetroFramework.Controls.MetroLink();
            this.LatTB = new MetroFramework.Controls.MetroTextBox();
            this.LatL = new MetroFramework.Controls.MetroLink();
            this.LocationCL = new MetroFramework.Controls.MetroLink();
            this.AddHospital1.SuspendLayout();
            this.AddHospital2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddHospital1
            // 
            this.AddHospital1.Controls.Add(this.R1BackB);
            this.AddHospital1.Controls.Add(this.R1NextB);
            this.AddHospital1.Controls.Add(this.GeneralL);
            this.AddHospital1.Controls.Add(this.CountryTB);
            this.AddHospital1.Controls.Add(this.CountryL);
            this.AddHospital1.Controls.Add(this.LocationL);
            this.AddHospital1.Controls.Add(this.CityTB);
            this.AddHospital1.Controls.Add(this.CityL);
            this.AddHospital1.Controls.Add(this.HNameTB);
            this.AddHospital1.Controls.Add(this.HNameLabel);
            this.AddHospital1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHospital1.Location = new System.Drawing.Point(20, 60);
            this.AddHospital1.Name = "AddHospital1";
            this.AddHospital1.Size = new System.Drawing.Size(580, 367);
            this.AddHospital1.TabIndex = 0;
            // 
            // R1BackB
            // 
            this.R1BackB.Location = new System.Drawing.Point(61, 265);
            this.R1BackB.Name = "R1BackB";
            this.R1BackB.Size = new System.Drawing.Size(140, 90);
            this.R1BackB.TabIndex = 36;
            this.R1BackB.Text = "Back";
            this.R1BackB.Click += new System.EventHandler(this.R1BackB_Click);
            // 
            // R1NextB
            // 
            this.R1NextB.Location = new System.Drawing.Point(425, 295);
            this.R1NextB.Name = "R1NextB";
            this.R1NextB.Size = new System.Drawing.Size(140, 60);
            this.R1NextB.TabIndex = 35;
            this.R1NextB.Text = "NEXT";
            this.R1NextB.Click += new System.EventHandler(this.R1NextB_Click);
            // 
            // GeneralL
            // 
            this.GeneralL.Location = new System.Drawing.Point(61, 41);
            this.GeneralL.Name = "GeneralL";
            this.GeneralL.Size = new System.Drawing.Size(460, 30);
            this.GeneralL.TabIndex = 34;
            this.GeneralL.Text = "General";
            // 
            // CountryTB
            // 
            this.CountryTB.Location = new System.Drawing.Point(402, 197);
            this.CountryTB.Name = "CountryTB";
            this.CountryTB.Size = new System.Drawing.Size(119, 31);
            this.CountryTB.TabIndex = 33;
            // 
            // CountryL
            // 
            this.CountryL.Location = new System.Drawing.Point(323, 198);
            this.CountryL.Name = "CountryL";
            this.CountryL.Size = new System.Drawing.Size(73, 30);
            this.CountryL.TabIndex = 32;
            this.CountryL.Text = "Country";
            this.CountryL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocationL
            // 
            this.LocationL.Location = new System.Drawing.Point(60, 162);
            this.LocationL.Name = "LocationL";
            this.LocationL.Size = new System.Drawing.Size(461, 30);
            this.LocationL.TabIndex = 31;
            this.LocationL.Text = "Location";
            // 
            // CityTB
            // 
            this.CityTB.Location = new System.Drawing.Point(139, 197);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(119, 31);
            this.CityTB.TabIndex = 30;
            // 
            // CityL
            // 
            this.CityL.Location = new System.Drawing.Point(60, 198);
            this.CityL.Name = "CityL";
            this.CityL.Size = new System.Drawing.Size(73, 30);
            this.CityL.TabIndex = 29;
            this.CityL.Text = "City";
            this.CityL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HNameTB
            // 
            this.HNameTB.Location = new System.Drawing.Point(207, 75);
            this.HNameTB.Name = "HNameTB";
            this.HNameTB.Size = new System.Drawing.Size(314, 31);
            this.HNameTB.TabIndex = 28;
            // 
            // HNameLabel
            // 
            this.HNameLabel.Location = new System.Drawing.Point(60, 77);
            this.HNameLabel.Name = "HNameLabel";
            this.HNameLabel.Size = new System.Drawing.Size(140, 30);
            this.HNameLabel.TabIndex = 27;
            this.HNameLabel.Text = "Name of the Hospital";
            this.HNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddHospital2
            // 
            this.AddHospital2.Controls.Add(this.R2BackB);
            this.AddHospital2.Controls.Add(this.R2CompleteB);
            this.AddHospital2.Controls.Add(this.gMapControl1);
            this.AddHospital2.Controls.Add(this.AddTB);
            this.AddHospital2.Controls.Add(this.AddL);
            this.AddHospital2.Controls.Add(this.LngTB);
            this.AddHospital2.Controls.Add(this.LngL);
            this.AddHospital2.Controls.Add(this.LatTB);
            this.AddHospital2.Controls.Add(this.LatL);
            this.AddHospital2.Controls.Add(this.LocationCL);
            this.AddHospital2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHospital2.Location = new System.Drawing.Point(20, 60);
            this.AddHospital2.Name = "AddHospital2";
            this.AddHospital2.Size = new System.Drawing.Size(580, 367);
            this.AddHospital2.TabIndex = 37;
            // 
            // R2BackB
            // 
            this.R2BackB.Location = new System.Drawing.Point(60, 265);
            this.R2BackB.Name = "R2BackB";
            this.R2BackB.Size = new System.Drawing.Size(140, 90);
            this.R2BackB.TabIndex = 49;
            this.R2BackB.Text = "Back";
            this.R2BackB.Click += new System.EventHandler(this.R2BackB_Click);
            // 
            // R2CompleteB
            // 
            this.R2CompleteB.Location = new System.Drawing.Point(384, 295);
            this.R2CompleteB.Name = "R2CompleteB";
            this.R2CompleteB.Size = new System.Drawing.Size(180, 60);
            this.R2CompleteB.TabIndex = 48;
            this.R2CompleteB.Text = "Complete";
            this.R2CompleteB.Click += new System.EventHandler(this.R2CompleteB_Click);
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
            this.gMapControl1.Location = new System.Drawing.Point(285, 114);
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
            this.gMapControl1.TabIndex = 47;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // AddTB
            // 
            this.AddTB.Location = new System.Drawing.Point(139, 76);
            this.AddTB.Name = "AddTB";
            this.AddTB.Size = new System.Drawing.Size(425, 31);
            this.AddTB.TabIndex = 46;
            // 
            // AddL
            // 
            this.AddL.Location = new System.Drawing.Point(60, 77);
            this.AddL.Name = "AddL";
            this.AddL.Size = new System.Drawing.Size(73, 30);
            this.AddL.TabIndex = 45;
            this.AddL.Text = "Address ";
            this.AddL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LngTB
            // 
            this.LngTB.Location = new System.Drawing.Point(139, 150);
            this.LngTB.Name = "LngTB";
            this.LngTB.Size = new System.Drawing.Size(119, 31);
            this.LngTB.TabIndex = 44;
            // 
            // LngL
            // 
            this.LngL.Location = new System.Drawing.Point(60, 151);
            this.LngL.Name = "LngL";
            this.LngL.Size = new System.Drawing.Size(73, 30);
            this.LngL.TabIndex = 43;
            this.LngL.Text = "Longitude";
            this.LngL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LatTB
            // 
            this.LatTB.Location = new System.Drawing.Point(139, 113);
            this.LatTB.Name = "LatTB";
            this.LatTB.Size = new System.Drawing.Size(119, 31);
            this.LatTB.TabIndex = 42;
            // 
            // LatL
            // 
            this.LatL.Location = new System.Drawing.Point(60, 114);
            this.LatL.Name = "LatL";
            this.LatL.Size = new System.Drawing.Size(73, 30);
            this.LatL.TabIndex = 41;
            this.LatL.Text = "Latitude";
            this.LatL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LocationCL
            // 
            this.LocationCL.Location = new System.Drawing.Point(60, 41);
            this.LocationCL.Name = "LocationCL";
            this.LocationCL.Size = new System.Drawing.Size(504, 30);
            this.LocationCL.TabIndex = 40;
            this.LocationCL.Text = "Location Continued";
            // 
            // AddHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 447);
            this.Controls.Add(this.AddHospital2);
            this.Controls.Add(this.AddHospital1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddHospital";
            this.Text = "MetroForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddHospital_FormClosed);
            this.AddHospital1.ResumeLayout(false);
            this.AddHospital2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddHospital1;
        private MetroFramework.Controls.MetroButton R1BackB;
        private MetroFramework.Controls.MetroButton R1NextB;
        private MetroFramework.Controls.MetroLink GeneralL;
        private MetroFramework.Controls.MetroTextBox CountryTB;
        private MetroFramework.Controls.MetroLink CountryL;
        private MetroFramework.Controls.MetroLink LocationL;
        private MetroFramework.Controls.MetroTextBox CityTB;
        private MetroFramework.Controls.MetroLink CityL;
        private MetroFramework.Controls.MetroTextBox HNameTB;
        private MetroFramework.Controls.MetroLink HNameLabel;
        private System.Windows.Forms.Panel AddHospital2;
        private MetroFramework.Controls.MetroButton R2BackB;
        private MetroFramework.Controls.MetroButton R2CompleteB;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private MetroFramework.Controls.MetroTextBox AddTB;
        private MetroFramework.Controls.MetroLink AddL;
        private MetroFramework.Controls.MetroTextBox LngTB;
        private MetroFramework.Controls.MetroLink LngL;
        private MetroFramework.Controls.MetroTextBox LatTB;
        private MetroFramework.Controls.MetroLink LatL;
        private MetroFramework.Controls.MetroLink LocationCL;
    }
}