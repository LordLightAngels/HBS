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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SynthesisForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tfLabel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lLabel = new System.Windows.Forms.Label();
            this.chHumid = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.chTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chHumid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlRecapTemp.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tfLabel);
            this.pnlMain.Controls.Add(this.lLabel);
            this.pnlMain.Controls.Add(this.chHumid);
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
            this.pnlMain.Controls.Add(this.chTemp);
            this.pnlMain.Location = new System.Drawing.Point(24, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(623, 415);
            this.pnlMain.TabIndex = 0;
            // 
            // tfLabel
            // 
            this.tfLabel.Depth = 0;
            this.tfLabel.Hint = "";
            this.tfLabel.Location = new System.Drawing.Point(259, 148);
            this.tfLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfLabel.Name = "tfLabel";
            this.tfLabel.PasswordChar = '\0';
            this.tfLabel.SelectedText = "";
            this.tfLabel.SelectionLength = 0;
            this.tfLabel.SelectionStart = 0;
            this.tfLabel.Size = new System.Drawing.Size(129, 23);
            this.tfLabel.TabIndex = 14;
            this.tfLabel.Text = "materialSingleLineTextField1";
            this.tfLabel.UseSystemPasswordChar = false;
            // 
            // lLabel
            // 
            this.lLabel.AutoSize = true;
            this.lLabel.Location = new System.Drawing.Point(216, 156);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(37, 13);
            this.lLabel.TabIndex = 13;
            this.lLabel.Text = "Libelle";
            // 
            // chHumid
            // 
            chartArea1.Name = "ChartArea1";
            this.chHumid.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chHumid.Legends.Add(legend1);
            this.chHumid.Location = new System.Drawing.Point(315, 193);
            this.chHumid.Name = "chHumid";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chHumid.Series.Add(series1);
            this.chHumid.Size = new System.Drawing.Size(286, 207);
            this.chHumid.TabIndex = 1;
            this.chHumid.Text = "graph Humid";
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
            this.panel1.Location = new System.Drawing.Point(405, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 97);
            this.panel1.TabIndex = 6;
            // 
            // mlMedHumidData
            // 
            this.mlMedHumidData.AutoSize = true;
            this.mlMedHumidData.Depth = 0;
            this.mlMedHumidData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedHumidData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedHumidData.Location = new System.Drawing.Point(133, 62);
            this.mlMedHumidData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedHumidData.Name = "mlMedHumidData";
            this.mlMedHumidData.Size = new System.Drawing.Size(0, 19);
            this.mlMedHumidData.TabIndex = 7;
            // 
            // mlMaxHumidData
            // 
            this.mlMaxHumidData.AutoSize = true;
            this.mlMaxHumidData.Depth = 0;
            this.mlMaxHumidData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxHumidData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxHumidData.Location = new System.Drawing.Point(78, 62);
            this.mlMaxHumidData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxHumidData.Name = "mlMaxHumidData";
            this.mlMaxHumidData.Size = new System.Drawing.Size(0, 19);
            this.mlMaxHumidData.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.mlHumid);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 34);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 34);
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
            this.mlHumid.Location = new System.Drawing.Point(69, 6);
            this.mlHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlHumid.Name = "mlHumid";
            this.mlHumid.Size = new System.Drawing.Size(70, 19);
            this.mlHumid.TabIndex = 0;
            this.mlHumid.Text = "Humidite";
            // 
            // mlMinHumidData
            // 
            this.mlMinHumidData.AutoSize = true;
            this.mlMinHumidData.Depth = 0;
            this.mlMinHumidData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinHumidData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinHumidData.Location = new System.Drawing.Point(15, 62);
            this.mlMinHumidData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinHumidData.Name = "mlMinHumidData";
            this.mlMinHumidData.Size = new System.Drawing.Size(0, 19);
            this.mlMinHumidData.TabIndex = 4;
            // 
            // mlMedHumid
            // 
            this.mlMedHumid.AutoSize = true;
            this.mlMedHumid.Depth = 0;
            this.mlMedHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedHumid.Location = new System.Drawing.Point(133, 37);
            this.mlMedHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedHumid.Name = "mlMedHumid";
            this.mlMedHumid.Size = new System.Drawing.Size(38, 19);
            this.mlMedHumid.TabIndex = 3;
            this.mlMedHumid.Text = "Moy";
            // 
            // mlMaxHumid
            // 
            this.mlMaxHumid.AutoSize = true;
            this.mlMaxHumid.Depth = 0;
            this.mlMaxHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxHumid.Location = new System.Drawing.Point(78, 37);
            this.mlMaxHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxHumid.Name = "mlMaxHumid";
            this.mlMaxHumid.Size = new System.Drawing.Size(37, 19);
            this.mlMaxHumid.TabIndex = 2;
            this.mlMaxHumid.Text = "Max";
            // 
            // mlMinHumid
            // 
            this.mlMinHumid.AutoSize = true;
            this.mlMinHumid.Depth = 0;
            this.mlMinHumid.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMinHumid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMinHumid.Location = new System.Drawing.Point(15, 37);
            this.mlMinHumid.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMinHumid.Name = "mlMinHumid";
            this.mlMinHumid.Size = new System.Drawing.Size(34, 19);
            this.mlMinHumid.TabIndex = 1;
            this.mlMinHumid.Text = "Min";
            // 
            // tfNbr
            // 
            this.tfNbr.Depth = 0;
            this.tfNbr.Hint = "";
            this.tfNbr.Location = new System.Drawing.Point(259, 45);
            this.tfNbr.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfNbr.Name = "tfNbr";
            this.tfNbr.PasswordChar = '\0';
            this.tfNbr.SelectedText = "";
            this.tfNbr.SelectionLength = 0;
            this.tfNbr.SelectionStart = 0;
            this.tfNbr.Size = new System.Drawing.Size(50, 23);
            this.tfNbr.TabIndex = 12;
            this.tfNbr.Text = "materialSingleLineTextField4";
            this.tfNbr.UseSystemPasswordChar = false;
            // 
            // tfdtEnd
            // 
            this.tfdtEnd.Depth = 0;
            this.tfdtEnd.Hint = "";
            this.tfdtEnd.Location = new System.Drawing.Point(405, 45);
            this.tfdtEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfdtEnd.Name = "tfdtEnd";
            this.tfdtEnd.PasswordChar = '\0';
            this.tfdtEnd.SelectedText = "";
            this.tfdtEnd.SelectionLength = 0;
            this.tfdtEnd.SelectionStart = 0;
            this.tfdtEnd.Size = new System.Drawing.Size(194, 23);
            this.tfdtEnd.TabIndex = 11;
            this.tfdtEnd.Text = "materialSingleLineTextField3";
            this.tfdtEnd.UseSystemPasswordChar = false;
            // 
            // tfdtStart
            // 
            this.tfdtStart.Depth = 0;
            this.tfdtStart.Hint = "";
            this.tfdtStart.Location = new System.Drawing.Point(16, 45);
            this.tfdtStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfdtStart.Name = "tfdtStart";
            this.tfdtStart.PasswordChar = '\0';
            this.tfdtStart.SelectedText = "";
            this.tfdtStart.SelectionLength = 0;
            this.tfdtStart.SelectionStart = 0;
            this.tfdtStart.Size = new System.Drawing.Size(194, 23);
            this.tfdtStart.TabIndex = 10;
            this.tfdtStart.Text = "materialSingleLineTextField2";
            this.tfdtStart.UseSystemPasswordChar = false;
            // 
            // tfUID
            // 
            this.tfUID.Depth = 0;
            this.tfUID.Hint = "";
            this.tfUID.Location = new System.Drawing.Point(259, 86);
            this.tfUID.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfUID.Name = "tfUID";
            this.tfUID.PasswordChar = '\0';
            this.tfUID.SelectedText = "";
            this.tfUID.SelectionLength = 0;
            this.tfUID.SelectionStart = 0;
            this.tfUID.Size = new System.Drawing.Size(129, 23);
            this.tfUID.TabIndex = 9;
            this.tfUID.Text = "materialSingleLineTextField1";
            this.tfUID.UseSystemPasswordChar = false;
            // 
            // lNbr
            // 
            this.lNbr.AutoSize = true;
            this.lNbr.Location = new System.Drawing.Point(256, 16);
            this.lNbr.Name = "lNbr";
            this.lNbr.Size = new System.Drawing.Size(53, 13);
            this.lNbr.TabIndex = 8;
            this.lNbr.Text = "NbrImport";
            // 
            // ldtEnd
            // 
            this.ldtEnd.AutoSize = true;
            this.ldtEnd.Location = new System.Drawing.Point(402, 16);
            this.ldtEnd.Name = "ldtEnd";
            this.ldtEnd.Size = new System.Drawing.Size(94, 13);
            this.ldtEnd.TabIndex = 7;
            this.ldtEnd.Text = "DateImportRecent";
            // 
            // ldtStart
            // 
            this.ldtStart.AutoSize = true;
            this.ldtStart.Location = new System.Drawing.Point(13, 16);
            this.ldtStart.Name = "ldtStart";
            this.ldtStart.Size = new System.Drawing.Size(92, 13);
            this.ldtStart.TabIndex = 6;
            this.ldtStart.Text = "DateImportAncien";
            // 
            // lUID
            // 
            this.lUID.AutoSize = true;
            this.lUID.Location = new System.Drawing.Point(216, 96);
            this.lUID.Name = "lUID";
            this.lUID.Size = new System.Drawing.Size(26, 13);
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
            this.pnlRecapTemp.Location = new System.Drawing.Point(16, 90);
            this.pnlRecapTemp.Name = "pnlRecapTemp";
            this.pnlRecapTemp.Size = new System.Drawing.Size(194, 97);
            this.pnlRecapTemp.TabIndex = 2;
            // 
            // mlMedTempData
            // 
            this.mlMedTempData.AutoSize = true;
            this.mlMedTempData.Depth = 0;
            this.mlMedTempData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMedTempData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMedTempData.Location = new System.Drawing.Point(133, 62);
            this.mlMedTempData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMedTempData.Name = "mlMedTempData";
            this.mlMedTempData.Size = new System.Drawing.Size(0, 19);
            this.mlMedTempData.TabIndex = 7;
            // 
            // mlMaxTempData
            // 
            this.mlMaxTempData.AutoSize = true;
            this.mlMaxTempData.Depth = 0;
            this.mlMaxTempData.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlMaxTempData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlMaxTempData.Location = new System.Drawing.Point(78, 62);
            this.mlMaxTempData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlMaxTempData.Name = "mlMaxTempData";
            this.mlMaxTempData.Size = new System.Drawing.Size(0, 19);
            this.mlMaxTempData.TabIndex = 6;
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
            this.mlMinTempData.Size = new System.Drawing.Size(0, 19);
            this.mlMinTempData.TabIndex = 4;
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
            chartArea2.Name = "ChartArea1";
            this.chTemp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chTemp.Legends.Add(legend2);
            this.chTemp.Location = new System.Drawing.Point(16, 193);
            this.chTemp.Name = "chTemp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chTemp.Series.Add(series2);
            this.chTemp.Size = new System.Drawing.Size(286, 207);
            this.chTemp.TabIndex = 1;
            this.chTemp.Text = "graph Temp";
            // 
            // SynthesisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 439);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SynthesisForm";
            this.Text = "SynthesisForm";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chHumid)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel mlMedHumidData;
        private MaterialSkin.Controls.MaterialLabel mlMaxHumidData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel mlHumid;
        private MaterialSkin.Controls.MaterialLabel mlMinHumidData;
        private MaterialSkin.Controls.MaterialLabel mlMedHumid;
        private MaterialSkin.Controls.MaterialLabel mlMaxHumid;
        private MaterialSkin.Controls.MaterialLabel mlMinHumid;
        private MaterialSkin.Controls.MaterialLabel mlMedTempData;
        private MaterialSkin.Controls.MaterialLabel mlMaxTempData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHumid;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfLabel;
        private System.Windows.Forms.Label lLabel;
    }
}