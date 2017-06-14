namespace SensorBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mrbSynthesis = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbConfiguration = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(147, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 531);
            this.panel1.TabIndex = 1;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 537);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(147, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(650, 30);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(219, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(435, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(212, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "text1",
            "text2"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 3;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "SensorBoard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton mrbConfiguration;
        private MaterialSkin.Controls.MaterialRaisedButton mrbData;
        private MaterialSkin.Controls.MaterialRaisedButton mrbReport;
        private MaterialSkin.Controls.MaterialRaisedButton mrbImport;
        private MaterialSkin.Controls.MaterialRaisedButton mrbExport;
        private MaterialSkin.Controls.MaterialRaisedButton mrbSynthesis;
    }
}

