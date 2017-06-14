﻿namespace SensorBoard
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.mrbConfiguration = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbSynthesis = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.cbSensor = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(147, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(650, 531);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.pnlMenu.Controls.Add(this.mrbConfiguration);
            this.pnlMenu.Controls.Add(this.mrbData);
            this.pnlMenu.Controls.Add(this.mrbReport);
            this.pnlMenu.Controls.Add(this.mrbImport);
            this.pnlMenu.Controls.Add(this.mrbExport);
            this.pnlMenu.Controls.Add(this.mrbSynthesis);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(3, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(138, 531);
            this.pnlMenu.TabIndex = 0;
            // 
            // mrbConfiguration
            // 
            this.mrbConfiguration.Depth = 0;
            this.mrbConfiguration.Location = new System.Drawing.Point(9, 389);
            this.mrbConfiguration.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbConfiguration.Name = "mrbConfiguration";
            this.mrbConfiguration.Primary = true;
            this.mrbConfiguration.Size = new System.Drawing.Size(120, 53);
            this.mrbConfiguration.TabIndex = 5;
            this.mrbConfiguration.Text = "Configuration";
            this.mrbConfiguration.UseVisualStyleBackColor = true;
            // 
            // mrbData
            // 
            this.mrbData.Depth = 0;
            this.mrbData.Location = new System.Drawing.Point(9, 85);
            this.mrbData.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbData.Name = "mrbData";
            this.mrbData.Primary = true;
            this.mrbData.Size = new System.Drawing.Size(120, 53);
            this.mrbData.TabIndex = 4;
            this.mrbData.Text = "Données";
            this.mrbData.UseVisualStyleBackColor = true;
            // 
            // mrbReport
            // 
            this.mrbReport.Depth = 0;
            this.mrbReport.Location = new System.Drawing.Point(9, 161);
            this.mrbReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbReport.Name = "mrbReport";
            this.mrbReport.Primary = true;
            this.mrbReport.Size = new System.Drawing.Size(120, 53);
            this.mrbReport.TabIndex = 3;
            this.mrbReport.Text = "Rapport";
            this.mrbReport.UseVisualStyleBackColor = true;
            // 
            // mrbImport
            // 
            this.mrbImport.Depth = 0;
            this.mrbImport.Location = new System.Drawing.Point(9, 237);
            this.mrbImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbImport.Name = "mrbImport";
            this.mrbImport.Primary = true;
            this.mrbImport.Size = new System.Drawing.Size(120, 53);
            this.mrbImport.TabIndex = 2;
            this.mrbImport.Text = "Import";
            this.mrbImport.UseVisualStyleBackColor = true;
            // 
            // mrbExport
            // 
            this.mrbExport.Depth = 0;
            this.mrbExport.Location = new System.Drawing.Point(9, 313);
            this.mrbExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbExport.Name = "mrbExport";
            this.mrbExport.Primary = true;
            this.mrbExport.Size = new System.Drawing.Size(120, 53);
            this.mrbExport.TabIndex = 1;
            this.mrbExport.Text = "Export";
            this.mrbExport.UseVisualStyleBackColor = true;
            // 
            // mrbSynthesis
            // 
            this.mrbSynthesis.Depth = 0;
            this.mrbSynthesis.Location = new System.Drawing.Point(9, 9);
            this.mrbSynthesis.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbSynthesis.Name = "mrbSynthesis";
            this.mrbSynthesis.Primary = true;
            this.mrbSynthesis.Size = new System.Drawing.Size(120, 53);
            this.mrbSynthesis.TabIndex = 0;
            this.mrbSynthesis.Text = "Synthèse";
            this.mrbSynthesis.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 537);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tlpFilter
            // 
            this.tlpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tlpFilter.ColumnCount = 3;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpFilter.Controls.Add(this.cbSensor, 2, 0);
            this.tlpFilter.Controls.Add(this.dtpStart, 0, 0);
            this.tlpFilter.Controls.Add(this.dtpEnd, 1, 0);
            this.tlpFilter.Location = new System.Drawing.Point(147, 30);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 1;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(650, 30);
            this.tlpFilter.TabIndex = 4;
            // 
            // cbSensor
            // 
            this.cbSensor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.cbSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSensor.FormattingEnabled = true;
            this.cbSensor.Location = new System.Drawing.Point(435, 3);
            this.cbSensor.Name = "cbSensor";
            this.cbSensor.Size = new System.Drawing.Size(212, 21);
            this.cbSensor.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStart.Location = new System.Drawing.Point(3, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(210, 20);
            this.dtpStart.TabIndex = 3;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnd.Location = new System.Drawing.Point(219, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(210, 20);
            this.dtpEnd.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tlpFilter);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "SensorBoard";
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.ComboBox cbSensor;
        private MaterialSkin.Controls.MaterialRaisedButton mrbConfiguration;
        private MaterialSkin.Controls.MaterialRaisedButton mrbData;
        private MaterialSkin.Controls.MaterialRaisedButton mrbReport;
        private MaterialSkin.Controls.MaterialRaisedButton mrbImport;
        private MaterialSkin.Controls.MaterialRaisedButton mrbExport;
        private MaterialSkin.Controls.MaterialRaisedButton mrbSynthesis;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ImageList imageList1;
    }
}
