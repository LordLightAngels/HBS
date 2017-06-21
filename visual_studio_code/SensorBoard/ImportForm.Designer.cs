namespace SensorBoard
{
    partial class ImportForm
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
            this.pnlImport = new System.Windows.Forms.Panel();
            this.mrbImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mlFormat = new MaterialSkin.Controls.MaterialLabel();
            this.mlContent = new MaterialSkin.Controls.MaterialLabel();
            this.mlTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pnlImport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImport
            // 
            this.pnlImport.Controls.Add(this.mrbImport);
            this.pnlImport.Controls.Add(this.mlFormat);
            this.pnlImport.Controls.Add(this.mlContent);
            this.pnlImport.Controls.Add(this.mlTitle);
            this.pnlImport.Location = new System.Drawing.Point(27, 22);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(453, 196);
            this.pnlImport.TabIndex = 0;
            // 
            // mrbImport
            // 
            this.mrbImport.Depth = 0;
            this.mrbImport.Location = new System.Drawing.Point(19, 131);
            this.mrbImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbImport.Name = "mrbImport";
            this.mrbImport.Primary = true;
            this.mrbImport.Size = new System.Drawing.Size(188, 39);
            this.mrbImport.TabIndex = 3;
            this.mrbImport.Text = "Import";
            this.mrbImport.UseVisualStyleBackColor = true;
            this.mrbImport.Click += new System.EventHandler(this.btnClick_Import);
            // 
            // mlFormat
            // 
            this.mlFormat.AutoSize = true;
            this.mlFormat.Depth = 0;
            this.mlFormat.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlFormat.Location = new System.Drawing.Point(15, 90);
            this.mlFormat.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlFormat.Name = "mlFormat";
            this.mlFormat.Size = new System.Drawing.Size(169, 19);
            this.mlFormat.TabIndex = 2;
            this.mlFormat.Text = "AAAA-MM-JJ-hh-mm-ss";
            // 
            // mlContent
            // 
            this.mlContent.AutoSize = true;
            this.mlContent.Depth = 0;
            this.mlContent.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlContent.Location = new System.Drawing.Point(15, 61);
            this.mlContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlContent.Name = "mlContent";
            this.mlContent.Size = new System.Drawing.Size(411, 19);
            this.mlContent.TabIndex = 1;
            this.mlContent.Text = "Vous pouvez importer des données au format texte suivant :\n";
            // 
            // mlTitle
            // 
            this.mlTitle.AutoSize = true;
            this.mlTitle.Depth = 0;
            this.mlTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlTitle.Location = new System.Drawing.Point(15, 28);
            this.mlTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlTitle.Name = "mlTitle";
            this.mlTitle.Size = new System.Drawing.Size(61, 19);
            this.mlTitle.TabIndex = 0;
            this.mlTitle.Text = "Imports";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 261);
            this.Controls.Add(this.pnlImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImport;
        private MaterialSkin.Controls.MaterialLabel mlTitle;
        private MaterialSkin.Controls.MaterialLabel mlContent;
        private MaterialSkin.Controls.MaterialLabel mlFormat;
        private MaterialSkin.Controls.MaterialRaisedButton mrbImport;
    }
}