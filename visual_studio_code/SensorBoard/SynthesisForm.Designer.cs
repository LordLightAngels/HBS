namespace SensorBoard
{
    partial class SynthesisForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynthesisForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mlMinHumidData = new MaterialSkin.Controls.MaterialLabel();
            this.mlMoyHumid = new MaterialSkin.Controls.MaterialLabel();
            this.mlMaxHumid = new MaterialSkin.Controls.MaterialLabel();
            this.mlMinHumid = new MaterialSkin.Controls.MaterialLabel();
            this.mlHumidTitle = new MaterialSkin.Controls.MaterialLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlRecapTemp = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlTemp = new MaterialSkin.Controls.MaterialLabel();
            this.mlMinTempData = new MaterialSkin.Controls.MaterialLabel();
            this.mlMedTemp = new MaterialSkin.Controls.MaterialLabel();
            this.mlMaxTemp = new MaterialSkin.Controls.MaterialLabel();
            this.mlMinTemp = new MaterialSkin.Controls.MaterialLabel();
            this.chTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lUID = new System.Windows.Forms.Label();
            this.ldtStart = new System.Windows.Forms.Label();
            this.ldtEnd = new System.Windows.Forms.Label();
            this.lNbr = new System.Windows.Forms.Label();
            this.tfUID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfdtStart = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfdtEnd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfNbr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlRecapTemp.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tfNbr);
            this.pnlMain.Controls.Add(this.tfdtEnd);
            this.pnlMain.Controls.Add(this.tfdtStart);
            this.pnlMain.Controls.Add(this.tfUID);
            this.pnlMain.Controls.Add(this.lNbr);
            this.pnlMain.Controls.Add(this.ldtEnd);
            this.pnlMain.Controls.Add(this.ldtStart);
            this.pnlMain.Controls.Add(this.lUID);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.chart1);
            this.pnlMain.Controls.Add(this.pnlRecapTemp);
            this.pnlMain.Controls.Add(this.chTemp);
            this.pnlMain.Location = new System.Drawing.Point(24, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(665, 415);
            this.pnlMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mlMinHumidData);
            this.panel1.Controls.Add(this.mlMoyHumid);
            this.panel1.Controls.Add(this.mlMaxHumid);
            this.panel1.Controls.Add(this.mlMinHumid);
            this.panel1.Controls.Add(this.mlHumidTitle);
            this.panel1.Location = new System.Drawing.Point(366, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 96);
            this.panel1.TabIndex = 4;
            // 
            // mlMinHumidData
            // 
            this.mlMinHumidData.AutoSize = true;
            this.mlMinHumidData.Depth = 0;
            this.mlMinHumidData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinHumidData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinHumidData.Location = new System.Drawing.Point(7, 61);
            this.mlMinHumidData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinHumidData.Name = "mlMinHumidData";
            this.mlMinHumidData.Size = new System.Drawing.Size(41, 19);
            this.mlMinHumidData.TabIndex = 9;
            this.mlMinHumidData.Text = "18°C";
            // 
            // mlMoyHumid
            // 
            this.mlMoyHumid.AutoSize = true;
            this.mlMoyHumid.Depth = 0;
            this.mlMoyHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMoyHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMoyHumid.Location = new System.Drawing.Point(125, 36);
            this.mlMoyHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMoyHumid.Name = "mlMoyHumid";
            this.mlMoyHumid.Size = new System.Drawing.Size(38, 19);
            this.mlMoyHumid.TabIndex = 8;
            this.mlMoyHumid.Text = "Moy";
            // 
            // mlMaxHumid
            // 
            this.mlMaxHumid.AutoSize = true;
            this.mlMaxHumid.Depth = 0;
            this.mlMaxHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxHumid.Location = new System.Drawing.Point(70, 36);
            this.mlMaxHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxHumid.Name = "mlMaxHumid";
            this.mlMaxHumid.Size = new System.Drawing.Size(37, 19);
            this.mlMaxHumid.TabIndex = 7;
            this.mlMaxHumid.Text = "Max";
            // 
            // mlMinHumid
            // 
            this.mlMinHumid.AutoSize = true;
            this.mlMinHumid.Depth = 0;
            this.mlMinHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinHumid.Location = new System.Drawing.Point(7, 36);
            this.mlMinHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinHumid.Name = "mlMinHumid";
            this.mlMinHumid.Size = new System.Drawing.Size(34, 19);
            this.mlMinHumid.TabIndex = 6;
            this.mlMinHumid.Text = "Min";
            // 
            // mlHumidTitle
            // 
            this.mlHumidTitle.AutoSize = true;
            this.mlHumidTitle.Depth = 0;
            this.mlHumidTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlHumidTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlHumidTitle.Location = new System.Drawing.Point(32, 5);
            this.mlHumidTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlHumidTitle.Name = "mlHumidTitle";
            this.mlHumidTitle.Size = new System.Drawing.Size(70, 19);
            this.mlHumidTitle.TabIndex = 5;
            this.mlHumidTitle.Text = "Humidité";
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(336, 193);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(263, 205);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // pnlRecapTemp
            // 
            this.pnlRecapTemp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlRecapTemp.Controls.Add(this.panel2);
            this.pnlRecapTemp.Controls.Add(this.mlMinTempData);
            this.pnlRecapTemp.Controls.Add(this.mlMedTemp);
            this.pnlRecapTemp.Controls.Add(this.mlMaxTemp);
            this.pnlRecapTemp.Controls.Add(this.mlMinTemp);
            this.pnlRecapTemp.Location = new System.Drawing.Point(54, 90);
            this.pnlRecapTemp.Name = "pnlRecapTemp";
            this.pnlRecapTemp.Size = new System.Drawing.Size(194, 97);
            this.pnlRecapTemp.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.mlTemp);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 34);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mlTemp
            // 
            this.mlTemp.AutoSize = true;
            this.mlTemp.Depth = 0;
            this.mlTemp.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlTemp.Location = new System.Drawing.Point(69, 6);
            this.mlTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlTemp.Name = "mlTemp";
            this.mlTemp.Size = new System.Drawing.Size(102, 19);
            this.mlTemp.TabIndex = 0;
            this.mlTemp.Text = "Temperatures";
            // 
            // mlMinTempData
            // 
            this.mlMinTempData.AutoSize = true;
            this.mlMinTempData.Depth = 0;
            this.mlMinTempData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinTempData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinTempData.Location = new System.Drawing.Point(15, 62);
            this.mlMinTempData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinTempData.Name = "mlMinTempData";
            this.mlMinTempData.Size = new System.Drawing.Size(41, 19);
            this.mlMinTempData.TabIndex = 4;
            this.mlMinTempData.Text = "18°C";
            // 
            // mlMedTemp
            // 
            this.mlMedTemp.AutoSize = true;
            this.mlMedTemp.Depth = 0;
            this.mlMedTemp.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedTemp.Location = new System.Drawing.Point(133, 37);
            this.mlMedTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedTemp.Name = "mlMedTemp";
            this.mlMedTemp.Size = new System.Drawing.Size(38, 19);
            this.mlMedTemp.TabIndex = 3;
            this.mlMedTemp.Text = "Moy";
            // 
            // mlMaxTemp
            // 
            this.mlMaxTemp.AutoSize = true;
            this.mlMaxTemp.Depth = 0;
            this.mlMaxTemp.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxTemp.Location = new System.Drawing.Point(78, 37);
            this.mlMaxTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxTemp.Name = "mlMaxTemp";
            this.mlMaxTemp.Size = new System.Drawing.Size(37, 19);
            this.mlMaxTemp.TabIndex = 2;
            this.mlMaxTemp.Text = "Max";
            // 
            // mlMinTemp
            // 
            this.mlMinTemp.AutoSize = true;
            this.mlMinTemp.Depth = 0;
            this.mlMinTemp.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinTemp.Location = new System.Drawing.Point(15, 37);
            this.mlMinTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinTemp.Name = "mlMinTemp";
            this.mlMinTemp.Size = new System.Drawing.Size(34, 19);
            this.mlMinTemp.TabIndex = 1;
            this.mlMinTemp.Text = "Min";
            // 
            // chTemp
            // 
            chartArea10.Name = "ChartArea1";
            this.chTemp.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chTemp.Legends.Add(legend10);
            this.chTemp.Location = new System.Drawing.Point(31, 193);
            this.chTemp.Name = "chTemp";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chTemp.Series.Add(series10);
            this.chTemp.Size = new System.Drawing.Size(286, 207);
            this.chTemp.TabIndex = 1;
            this.chTemp.Text = "graph Temp";
            // 
            // lUID
            // 
            this.lUID.AutoSize = true;
            this.lUID.Location = new System.Drawing.Point(31, 16);
            this.lUID.Name = "lUID";
            this.lUID.Size = new System.Drawing.Size(35, 13);
            this.lUID.TabIndex = 5;
            this.lUID.Text = "label1";
            // 
            // ldtStart
            // 
            this.ldtStart.AutoSize = true;
            this.ldtStart.Location = new System.Drawing.Point(159, 16);
            this.ldtStart.Name = "ldtStart";
            this.ldtStart.Size = new System.Drawing.Size(35, 13);
            this.ldtStart.TabIndex = 6;
            this.ldtStart.Text = "label2";
            // 
            // ldtEnd
            // 
            this.ldtEnd.AutoSize = true;
            this.ldtEnd.Location = new System.Drawing.Point(312, 16);
            this.ldtEnd.Name = "ldtEnd";
            this.ldtEnd.Size = new System.Drawing.Size(35, 13);
            this.ldtEnd.TabIndex = 7;
            this.ldtEnd.Text = "label3";
            // 
            // lNbr
            // 
            this.lNbr.AutoSize = true;
            this.lNbr.Location = new System.Drawing.Point(492, 16);
            this.lNbr.Name = "lNbr";
            this.lNbr.Size = new System.Drawing.Size(35, 13);
            this.lNbr.TabIndex = 8;
            this.lNbr.Text = "label4";
            // 
            // tfUID
            // 
            this.tfUID.Depth = 0;
            this.tfUID.Hint = "";
            this.tfUID.Location = new System.Drawing.Point(34, 45);
            this.tfUID.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfUID.Name = "tfUID";
            this.tfUID.PasswordChar = '\0';
            this.tfUID.SelectedText = "";
            this.tfUID.SelectionLength = 0;
            this.tfUID.SelectionStart = 0;
            this.tfUID.Size = new System.Drawing.Size(75, 23);
            this.tfUID.TabIndex = 9;
            this.tfUID.Text = "materialSingleLineTextField1";
            this.tfUID.UseSystemPasswordChar = false;
            // 
            // tfdtStart
            // 
            this.tfdtStart.Depth = 0;
            this.tfdtStart.Hint = "";
            this.tfdtStart.Location = new System.Drawing.Point(162, 45);
            this.tfdtStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfdtStart.Name = "tfdtStart";
            this.tfdtStart.PasswordChar = '\0';
            this.tfdtStart.SelectedText = "";
            this.tfdtStart.SelectionLength = 0;
            this.tfdtStart.SelectionStart = 0;
            this.tfdtStart.Size = new System.Drawing.Size(75, 23);
            this.tfdtStart.TabIndex = 10;
            this.tfdtStart.Text = "materialSingleLineTextField2";
            this.tfdtStart.UseSystemPasswordChar = false;
            // 
            // tfdtEnd
            // 
            this.tfdtEnd.Depth = 0;
            this.tfdtEnd.Hint = "";
            this.tfdtEnd.Location = new System.Drawing.Point(315, 44);
            this.tfdtEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfdtEnd.Name = "tfdtEnd";
            this.tfdtEnd.PasswordChar = '\0';
            this.tfdtEnd.SelectedText = "";
            this.tfdtEnd.SelectionLength = 0;
            this.tfdtEnd.SelectionStart = 0;
            this.tfdtEnd.Size = new System.Drawing.Size(75, 23);
            this.tfdtEnd.TabIndex = 11;
            this.tfdtEnd.Text = "materialSingleLineTextField3";
            this.tfdtEnd.UseSystemPasswordChar = false;
            // 
            // tfNbr
            // 
            this.tfNbr.Depth = 0;
            this.tfNbr.Hint = "";
            this.tfNbr.Location = new System.Drawing.Point(495, 45);
            this.tfNbr.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfNbr.Name = "tfNbr";
            this.tfNbr.PasswordChar = '\0';
            this.tfNbr.SelectedText = "";
            this.tfNbr.SelectionLength = 0;
            this.tfNbr.SelectionStart = 0;
            this.tfNbr.Size = new System.Drawing.Size(75, 23);
            this.tfNbr.TabIndex = 12;
            this.tfNbr.Text = "materialSingleLineTextField4";
            this.tfNbr.UseSystemPasswordChar = false;
            // 
            // SynthesisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 439);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SynthesisForm";
            this.Text = "SynthesisForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlRecapTemp.ResumeLayout(false);
            this.pnlRecapTemp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart chTemp;
        private MaterialSkin.Controls.MaterialLabel mlTemp;
        private System.Windows.Forms.Panel pnlRecapTemp;
        private MaterialSkin.Controls.MaterialLabel mlMinTempData;
        private MaterialSkin.Controls.MaterialLabel mlMedTemp;
        private MaterialSkin.Controls.MaterialLabel mlMaxTemp;
        private MaterialSkin.Controls.MaterialLabel mlMinTemp;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel mlMinHumidData;
        private MaterialSkin.Controls.MaterialLabel mlMoyHumid;
        private MaterialSkin.Controls.MaterialLabel mlMaxHumid;
        private MaterialSkin.Controls.MaterialLabel mlMinHumid;
        private MaterialSkin.Controls.MaterialLabel mlHumidTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfNbr;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfdtEnd;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfdtStart;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfUID;
        private System.Windows.Forms.Label lNbr;
        private System.Windows.Forms.Label ldtEnd;
        private System.Windows.Forms.Label ldtStart;
        private System.Windows.Forms.Label lUID;
    }
}