﻿namespace SensorBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynthesisForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tfAmplitude = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lAmplitude = new System.Windows.Forms.Label();
            this.tfLabel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mlMedHumidData = new MaterialSkin.Controls.MaterialLabel();
            this.mlMaxHumidData = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mlHumid = new MaterialSkin.Controls.MaterialLabel();
            this.mlMinHumidData = new MaterialSkin.Controls.MaterialLabel();
            this.mlMedHumid = new MaterialSkin.Controls.MaterialLabel();
            this.mlMaxHumid = new MaterialSkin.Controls.MaterialLabel();
            this.mlMinHumid = new MaterialSkin.Controls.MaterialLabel();
            this.tfNbr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfdtEnd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfdtStart = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tfUID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lNbr = new System.Windows.Forms.Label();
            this.ldtEnd = new System.Windows.Forms.Label();
            this.ldtStart = new System.Windows.Forms.Label();
            this.lUID = new System.Windows.Forms.Label();
            this.pnlRecapTemp = new System.Windows.Forms.Panel();
            this.mlMedTempData = new MaterialSkin.Controls.MaterialLabel();
            this.mlMaxTempData = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mlTemp = new MaterialSkin.Controls.MaterialLabel();
            this.mlMinTempData = new MaterialSkin.Controls.MaterialLabel();
            this.mlMedTemp = new MaterialSkin.Controls.MaterialLabel();
            this.mlMaxTemp = new MaterialSkin.Controls.MaterialLabel();
            this.mlMinTemp = new MaterialSkin.Controls.MaterialLabel();
            this.chTempHumid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlRecapTemp.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTempHumid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tfAmplitude);
            this.pnlMain.Controls.Add(this.lAmplitude);
            this.pnlMain.Controls.Add(this.tfLabel);
            this.pnlMain.Controls.Add(this.lLabel);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.tfNbr);
            this.pnlMain.Controls.Add(this.tfdtEnd);
            this.pnlMain.Controls.Add(this.tfdtStart);
            this.pnlMain.Controls.Add(this.tfUID);
            this.pnlMain.Controls.Add(this.lNbr);
            this.pnlMain.Controls.Add(this.ldtEnd);
            this.pnlMain.Controls.Add(this.ldtStart);
            this.pnlMain.Controls.Add(this.lUID);
            this.pnlMain.Controls.Add(this.pnlRecapTemp);
            this.pnlMain.Controls.Add(this.chTempHumid);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(875, 661);
            this.pnlMain.TabIndex = 0;
            // 
            // tfAmplitude
            // 
            this.tfAmplitude.Depth = 0;
            this.tfAmplitude.Hint = "";
            this.tfAmplitude.Location = new System.Drawing.Point(424, 86);
            this.tfAmplitude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tfAmplitude.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfAmplitude.Name = "tfAmplitude";
            this.tfAmplitude.PasswordChar = '\0';
            this.tfAmplitude.SelectedText = "";
            this.tfAmplitude.SelectionLength = 0;
            this.tfAmplitude.SelectionStart = 0;
            this.tfAmplitude.Size = new System.Drawing.Size(227, 28);
            this.tfAmplitude.TabIndex = 16;
            this.tfAmplitude.UseSystemPasswordChar = false;
            // 
            // lAmplitude
            // 
            this.lAmplitude.AutoSize = true;
            this.lAmplitude.Location = new System.Drawing.Point(185, 91);
            this.lAmplitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmplitude.Name = "lAmplitude";
            this.lAmplitude.Size = new System.Drawing.Size(217, 17);
            this.lAmplitude.TabIndex = 15;
            this.lAmplitude.Text = "Amplitude temporelle des relevés";
            // 
            // tfLabel
            // 
            this.tfLabel.Depth = 0;
            this.tfLabel.Hint = "";
            this.tfLabel.Location = new System.Drawing.Point(79, 11);
            this.tfLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tfLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfLabel.Name = "tfLabel";
            this.tfLabel.PasswordChar = '\0';
            this.tfLabel.SelectedText = "";
            this.tfLabel.SelectionLength = 0;
            this.tfLabel.SelectionStart = 0;
            this.tfLabel.Size = new System.Drawing.Size(172, 28);
            this.tfLabel.TabIndex = 14;
            this.tfLabel.Text = "materialSingleLineTextField1";
            this.tfLabel.UseSystemPasswordChar = false;
            // 
            // lLabel
            // 
            this.lLabel.AutoSize = true;
            this.lLabel.Location = new System.Drawing.Point(21, 16);
            this.lLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(49, 17);
            this.lLabel.TabIndex = 13;
            this.lLabel.Text = "Libelle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.mlMedHumidData);
            this.panel1.Controls.Add(this.mlMaxHumidData);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.mlMinHumidData);
            this.panel1.Controls.Add(this.mlMedHumid);
            this.panel1.Controls.Add(this.mlMaxHumid);
            this.panel1.Controls.Add(this.mlMinHumid);
            this.panel1.Location = new System.Drawing.Point(465, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 119);
            this.panel1.TabIndex = 6;
            // 
            // mlMedHumidData
            // 
            this.mlMedHumidData.AutoSize = true;
            this.mlMedHumidData.Depth = 0;
            this.mlMedHumidData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedHumidData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedHumidData.Location = new System.Drawing.Point(177, 76);
            this.mlMedHumidData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMedHumidData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedHumidData.Name = "mlMedHumidData";
            this.mlMedHumidData.Size = new System.Drawing.Size(0, 24);
            this.mlMedHumidData.TabIndex = 7;
            // 
            // mlMaxHumidData
            // 
            this.mlMaxHumidData.AutoSize = true;
            this.mlMaxHumidData.Depth = 0;
            this.mlMaxHumidData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxHumidData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxHumidData.Location = new System.Drawing.Point(104, 76);
            this.mlMaxHumidData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMaxHumidData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxHumidData.Name = "mlMaxHumidData";
            this.mlMaxHumidData.Size = new System.Drawing.Size(0, 24);
            this.mlMaxHumidData.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.mlHumid);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 42);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // mlHumid
            // 
            this.mlHumid.AutoSize = true;
            this.mlHumid.Depth = 0;
            this.mlHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlHumid.Location = new System.Drawing.Point(92, 7);
            this.mlHumid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlHumid.Name = "mlHumid";
            this.mlHumid.Size = new System.Drawing.Size(88, 24);
            this.mlHumid.TabIndex = 0;
            this.mlHumid.Text = "Humidite";
            // 
            // mlMinHumidData
            // 
            this.mlMinHumidData.AutoSize = true;
            this.mlMinHumidData.Depth = 0;
            this.mlMinHumidData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinHumidData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinHumidData.Location = new System.Drawing.Point(20, 76);
            this.mlMinHumidData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMinHumidData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinHumidData.Name = "mlMinHumidData";
            this.mlMinHumidData.Size = new System.Drawing.Size(0, 24);
            this.mlMinHumidData.TabIndex = 4;
            // 
            // mlMedHumid
            // 
            this.mlMedHumid.AutoSize = true;
            this.mlMedHumid.Depth = 0;
            this.mlMedHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedHumid.Location = new System.Drawing.Point(177, 46);
            this.mlMedHumid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMedHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedHumid.Name = "mlMedHumid";
            this.mlMedHumid.Size = new System.Drawing.Size(47, 24);
            this.mlMedHumid.TabIndex = 3;
            this.mlMedHumid.Text = "Moy";
            // 
            // mlMaxHumid
            // 
            this.mlMaxHumid.AutoSize = true;
            this.mlMaxHumid.Depth = 0;
            this.mlMaxHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxHumid.Location = new System.Drawing.Point(104, 46);
            this.mlMaxHumid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMaxHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxHumid.Name = "mlMaxHumid";
            this.mlMaxHumid.Size = new System.Drawing.Size(46, 24);
            this.mlMaxHumid.TabIndex = 2;
            this.mlMaxHumid.Text = "Max";
            // 
            // mlMinHumid
            // 
            this.mlMinHumid.AutoSize = true;
            this.mlMinHumid.Depth = 0;
            this.mlMinHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinHumid.Location = new System.Drawing.Point(20, 46);
            this.mlMinHumid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMinHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinHumid.Name = "mlMinHumid";
            this.mlMinHumid.Size = new System.Drawing.Size(42, 24);
            this.mlMinHumid.TabIndex = 1;
            this.mlMinHumid.Text = "Min";
            // 
            // tfNbr
            // 
            this.tfNbr.Depth = 0;
            this.tfNbr.Hint = "";
            this.tfNbr.Location = new System.Drawing.Point(753, 10);
            this.tfNbr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tfNbr.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfNbr.Name = "tfNbr";
            this.tfNbr.PasswordChar = '\0';
            this.tfNbr.SelectedText = "";
            this.tfNbr.SelectionLength = 0;
            this.tfNbr.SelectionStart = 0;
            this.tfNbr.Size = new System.Drawing.Size(67, 28);
            this.tfNbr.TabIndex = 12;
            this.tfNbr.Text = "materialSingleLineTextField4";
            this.tfNbr.UseSystemPasswordChar = false;
            // 
            // tfdtEnd
            // 
            this.tfdtEnd.Depth = 0;
            this.tfdtEnd.Hint = "";
            this.tfdtEnd.Location = new System.Drawing.Point(612, 47);
            this.tfdtEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tfdtEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfdtEnd.Name = "tfdtEnd";
            this.tfdtEnd.PasswordChar = '\0';
            this.tfdtEnd.SelectedText = "";
            this.tfdtEnd.SelectionLength = 0;
            this.tfdtEnd.SelectionStart = 0;
            this.tfdtEnd.Size = new System.Drawing.Size(259, 28);
            this.tfdtEnd.TabIndex = 11;
            this.tfdtEnd.Text = "materialSingleLineTextField3";
            this.tfdtEnd.UseSystemPasswordChar = false;
            // 
            // tfdtStart
            // 
            this.tfdtStart.Depth = 0;
            this.tfdtStart.Hint = "";
            this.tfdtStart.Location = new System.Drawing.Point(165, 47);
            this.tfdtStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tfdtStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfdtStart.Name = "tfdtStart";
            this.tfdtStart.PasswordChar = '\0';
            this.tfdtStart.SelectedText = "";
            this.tfdtStart.SelectionLength = 0;
            this.tfdtStart.SelectionStart = 0;
            this.tfdtStart.Size = new System.Drawing.Size(259, 28);
            this.tfdtStart.TabIndex = 10;
            this.tfdtStart.Text = "materialSingleLineTextField2";
            this.tfdtStart.UseSystemPasswordChar = false;
            // 
            // tfUID
            // 
            this.tfUID.Depth = 0;
            this.tfUID.Hint = "";
            this.tfUID.Location = new System.Drawing.Point(392, 11);
            this.tfUID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tfUID.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfUID.Name = "tfUID";
            this.tfUID.PasswordChar = '\0';
            this.tfUID.SelectedText = "";
            this.tfUID.SelectionLength = 0;
            this.tfUID.SelectionStart = 0;
            this.tfUID.Size = new System.Drawing.Size(172, 28);
            this.tfUID.TabIndex = 9;
            this.tfUID.Text = "materialSingleLineTextField1";
            this.tfUID.UseSystemPasswordChar = false;
            // 
            // lNbr
            // 
            this.lNbr.AutoSize = true;
            this.lNbr.Location = new System.Drawing.Point(640, 16);
            this.lNbr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNbr.Name = "lNbr";
            this.lNbr.Size = new System.Drawing.Size(81, 17);
            this.lNbr.TabIndex = 8;
            this.lNbr.Text = "Nb Relevés";
            // 
            // ldtEnd
            // 
            this.ldtEnd.AutoSize = true;
            this.ldtEnd.Location = new System.Drawing.Point(441, 50);
            this.ldtEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldtEnd.Name = "ldtEnd";
            this.ldtEnd.Size = new System.Drawing.Size(174, 17);
            this.ldtEnd.TabIndex = 7;
            this.ldtEnd.Text = "Date-Heure dernier relevé";
            // 
            // ldtStart
            // 
            this.ldtStart.AutoSize = true;
            this.ldtStart.Location = new System.Drawing.Point(12, 50);
            this.ldtStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ldtStart.Name = "ldtStart";
            this.ldtStart.Size = new System.Drawing.Size(150, 17);
            this.ldtStart.TabIndex = 6;
            this.ldtStart.Text = "Date-Heure 1er relevé";
            // 
            // lUID
            // 
            this.lUID.AutoSize = true;
            this.lUID.Location = new System.Drawing.Point(335, 16);
            this.lUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUID.Name = "lUID";
            this.lUID.Size = new System.Drawing.Size(31, 17);
            this.lUID.TabIndex = 5;
            this.lUID.Text = "UID";
            // 
            // pnlRecapTemp
            // 
            this.pnlRecapTemp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlRecapTemp.Controls.Add(this.mlMedTempData);
            this.pnlRecapTemp.Controls.Add(this.mlMaxTempData);
            this.pnlRecapTemp.Controls.Add(this.panel2);
            this.pnlRecapTemp.Controls.Add(this.mlMinTempData);
            this.pnlRecapTemp.Controls.Add(this.mlMedTemp);
            this.pnlRecapTemp.Controls.Add(this.mlMaxTemp);
            this.pnlRecapTemp.Controls.Add(this.mlMinTemp);
            this.pnlRecapTemp.Location = new System.Drawing.Point(111, 133);
            this.pnlRecapTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRecapTemp.Name = "pnlRecapTemp";
            this.pnlRecapTemp.Size = new System.Drawing.Size(259, 119);
            this.pnlRecapTemp.TabIndex = 2;
            // 
            // mlMedTempData
            // 
            this.mlMedTempData.AutoSize = true;
            this.mlMedTempData.Depth = 0;
            this.mlMedTempData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedTempData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedTempData.Location = new System.Drawing.Point(177, 76);
            this.mlMedTempData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMedTempData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedTempData.Name = "mlMedTempData";
            this.mlMedTempData.Size = new System.Drawing.Size(0, 24);
            this.mlMedTempData.TabIndex = 7;
            // 
            // mlMaxTempData
            // 
            this.mlMaxTempData.AutoSize = true;
            this.mlMaxTempData.Depth = 0;
            this.mlMaxTempData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxTempData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxTempData.Location = new System.Drawing.Point(104, 76);
            this.mlMaxTempData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMaxTempData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxTempData.Name = "mlMaxTempData";
            this.mlMaxTempData.Size = new System.Drawing.Size(0, 24);
            this.mlMaxTempData.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.mlTemp);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 42);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 42);
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
            this.mlTemp.Location = new System.Drawing.Point(92, 7);
            this.mlTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlTemp.Name = "mlTemp";
            this.mlTemp.Size = new System.Drawing.Size(127, 24);
            this.mlTemp.TabIndex = 0;
            this.mlTemp.Text = "Temperatures";
            // 
            // mlMinTempData
            // 
            this.mlMinTempData.AutoSize = true;
            this.mlMinTempData.Depth = 0;
            this.mlMinTempData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinTempData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinTempData.Location = new System.Drawing.Point(20, 76);
            this.mlMinTempData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMinTempData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinTempData.Name = "mlMinTempData";
            this.mlMinTempData.Size = new System.Drawing.Size(0, 24);
            this.mlMinTempData.TabIndex = 4;
            // 
            // mlMedTemp
            // 
            this.mlMedTemp.AutoSize = true;
            this.mlMedTemp.Depth = 0;
            this.mlMedTemp.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedTemp.Location = new System.Drawing.Point(177, 46);
            this.mlMedTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMedTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedTemp.Name = "mlMedTemp";
            this.mlMedTemp.Size = new System.Drawing.Size(47, 24);
            this.mlMedTemp.TabIndex = 3;
            this.mlMedTemp.Text = "Moy";
            // 
            // mlMaxTemp
            // 
            this.mlMaxTemp.AutoSize = true;
            this.mlMaxTemp.Depth = 0;
            this.mlMaxTemp.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxTemp.Location = new System.Drawing.Point(104, 46);
            this.mlMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMaxTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxTemp.Name = "mlMaxTemp";
            this.mlMaxTemp.Size = new System.Drawing.Size(46, 24);
            this.mlMaxTemp.TabIndex = 2;
            this.mlMaxTemp.Text = "Max";
            // 
            // mlMinTemp
            // 
            this.mlMinTemp.AutoSize = true;
            this.mlMinTemp.Depth = 0;
            this.mlMinTemp.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinTemp.Location = new System.Drawing.Point(20, 46);
            this.mlMinTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlMinTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinTemp.Name = "mlMinTemp";
            this.mlMinTemp.Size = new System.Drawing.Size(42, 24);
            this.mlMinTemp.TabIndex = 1;
            this.mlMinTemp.Text = "Min";
            // 
            // chTempHumid
            // 
            chartArea1.Name = "ChartArea1";
            this.chTempHumid.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            this.chTempHumid.Legends.Add(legend1);
            this.chTempHumid.Location = new System.Drawing.Point(16, 260);
            this.chTempHumid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chTempHumid.Name = "chTempHumid";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Temperatures";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Humidité";
            this.chTempHumid.Series.Add(series1);
            this.chTempHumid.Series.Add(series2);
            this.chTempHumid.Size = new System.Drawing.Size(823, 398);
            this.chTempHumid.TabIndex = 1;
            this.chTempHumid.Text = "graph Temp";
            // 
            // SynthesisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 661);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SynthesisForm";
            this.Text = "SynthesisForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlRecapTemp.ResumeLayout(false);
            this.pnlRecapTemp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTempHumid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialSingleLineTextField tfAmplitude;
        public MaterialSkin.Controls.MaterialSingleLineTextField tfLabel;
        public System.Windows.Forms.DataVisualization.Charting.Chart chTempHumid;
        public MaterialSkin.Controls.MaterialSingleLineTextField tfNbr;
        public MaterialSkin.Controls.MaterialSingleLineTextField tfdtEnd;
        public MaterialSkin.Controls.MaterialSingleLineTextField tfdtStart;
        public MaterialSkin.Controls.MaterialSingleLineTextField tfUID;
        public MaterialSkin.Controls.MaterialLabel mlMedTempData;
        public MaterialSkin.Controls.MaterialLabel mlMaxTempData;
        public MaterialSkin.Controls.MaterialLabel mlMinTempData;
        public MaterialSkin.Controls.MaterialLabel mlMedHumidData;
        public MaterialSkin.Controls.MaterialLabel mlMaxHumidData;
        public MaterialSkin.Controls.MaterialLabel mlMinHumidData;

        private System.Windows.Forms.Panel pnlMain;
        private MaterialSkin.Controls.MaterialLabel mlTemp;
        private System.Windows.Forms.Panel pnlRecapTemp;
        private MaterialSkin.Controls.MaterialLabel mlMinTemp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lNbr;
        private System.Windows.Forms.Label ldtEnd;
        private System.Windows.Forms.Label ldtStart;
        private System.Windows.Forms.Label lUID;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel mlMedHumid;
        private MaterialSkin.Controls.MaterialLabel mlMaxHumid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel mlHumid;
        private MaterialSkin.Controls.MaterialLabel mlMinHumid;
        private MaterialSkin.Controls.MaterialLabel mlMedTemp;
        private MaterialSkin.Controls.MaterialLabel mlMaxTemp;
        private System.Windows.Forms.Label lLabel;
        private System.Windows.Forms.Label lAmplitude;
    }
}