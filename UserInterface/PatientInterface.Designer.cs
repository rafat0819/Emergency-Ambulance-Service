namespace EAS
{
    partial class PatientInterface
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmergencyServiceT = new MetroFramework.Controls.MetroTile();
            this.PlogoutB = new MetroFramework.Controls.MetroButton();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(197, 259);
            this.dataGridView1.TabIndex = 2;
            // 
            // EmergencyServiceT
            // 
            this.EmergencyServiceT.Location = new System.Drawing.Point(226, 287);
            this.EmergencyServiceT.Name = "EmergencyServiceT";
            this.EmergencyServiceT.Size = new System.Drawing.Size(245, 71);
            this.EmergencyServiceT.TabIndex = 3;
            this.EmergencyServiceT.Text = "Call for Emergency Service";
            this.EmergencyServiceT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EmergencyServiceT.Click += new System.EventHandler(this.EmergencyServiceT_Click);
            // 
            // PlogoutB
            // 
            this.PlogoutB.Location = new System.Drawing.Point(452, 34);
            this.PlogoutB.Name = "PlogoutB";
            this.PlogoutB.Size = new System.Drawing.Size(75, 23);
            this.PlogoutB.TabIndex = 6;
            this.PlogoutB.Text = "Logout";
            this.PlogoutB.Click += new System.EventHandler(this.PlogoutB_Click);
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
            this.gMapControl1.Location = new System.Drawing.Point(248, 63);
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
            this.gMapControl1.TabIndex = 49;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // PatientInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.PlogoutB);
            this.Controls.Add(this.EmergencyServiceT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientInterface";
            this.Text = "PatientInterface";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientInterface_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTile EmergencyServiceT;
        private MetroFramework.Controls.MetroButton PlogoutB;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}