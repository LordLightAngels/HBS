namespace SensorBoard
{
    partial class ExportForm
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
            this.mrbPDF = new MaterialSkin.Controls.MaterialRadioButton();
            this.mlExport = new MaterialSkin.Controls.MaterialLabel();
            this.mrbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.mcbEnvoiPDF = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mrbExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrbPDF
            // 
            this.mrbPDF.AutoSize = true;
            this.mrbPDF.Depth = 0;
            this.mrbPDF.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbPDF.Location = new System.Drawing.Point(14, 123);
            this.mrbPDF.Margin = new System.Windows.Forms.Padding(0);
            this.mrbPDF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbPDF.Name = "mrbPDF";
            this.mrbPDF.Ripple = true;
            this.mrbPDF.Size = new System.Drawing.Size(54, 30);
            this.mrbPDF.TabIndex = 2;
            this.mrbPDF.TabStop = true;
            this.mrbPDF.Text = "PDF";
            this.mrbPDF.UseVisualStyleBackColor = true;
            // 
            // mlExport
            // 
            this.mlExport.AutoSize = true;
            this.mlExport.Depth = 0;
            this.mlExport.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlExport.Location = new System.Drawing.Point(12, 9);
            this.mlExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlExport.Name = "mlExport";
            this.mlExport.Size = new System.Drawing.Size(504, 114);
            this.mlExport.TabIndex = 3;
            this.mlExport.Text = "Exports\n\n\n Veuillez saisir un format d\'export parmi les formats proposés ci-desso" +
    "us.\n\n Format de l\'export : ";
            this.mlExport.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // mrbExcel
            // 
            this.mrbExcel.AutoSize = true;
            this.mrbExcel.Depth = 0;
            this.mrbExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbExcel.Location = new System.Drawing.Point(89, 123);
            this.mrbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.mrbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbExcel.Name = "mrbExcel";
            this.mrbExcel.Ripple = true;
            this.mrbExcel.Size = new System.Drawing.Size(62, 30);
            this.mrbExcel.TabIndex = 4;
            this.mrbExcel.TabStop = true;
            this.mrbExcel.Text = "Excel";
            this.mrbExcel.UseVisualStyleBackColor = true;
            // 
            // mcbEnvoiPDF
            // 
            this.mcbEnvoiPDF.AutoSize = true;
            this.mcbEnvoiPDF.Depth = 0;
            this.mcbEnvoiPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mcbEnvoiPDF.Location = new System.Drawing.Point(16, 164);
            this.mcbEnvoiPDF.Margin = new System.Windows.Forms.Padding(0);
            this.mcbEnvoiPDF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbEnvoiPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbEnvoiPDF.Name = "mcbEnvoiPDF";
            this.mcbEnvoiPDF.Ripple = true;
            this.mcbEnvoiPDF.Size = new System.Drawing.Size(171, 30);
            this.mcbEnvoiPDF.TabIndex = 5;
            this.mcbEnvoiPDF.Text = "Envoi PDF par email à :";
            this.mcbEnvoiPDF.UseVisualStyleBackColor = true;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(208, 171);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(170, 23);
            this.materialSingleLineTextField1.TabIndex = 6;
            this.materialSingleLineTextField1.Text = "saisir adresse mail";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // mrbExport
            // 
            this.mrbExport.Depth = 0;
            this.mrbExport.Location = new System.Drawing.Point(14, 211);
            this.mrbExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbExport.Name = "mrbExport";
            this.mrbExport.Primary = true;
            this.mrbExport.Size = new System.Drawing.Size(187, 39);
            this.mrbExport.TabIndex = 7;
            this.mrbExport.Text = "Exporter";
            this.mrbExport.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mlExport);
            this.panel1.Controls.Add(this.mrbExport);
            this.panel1.Controls.Add(this.mrbExcel);
            this.panel1.Controls.Add(this.materialSingleLineTextField1);
            this.panel1.Controls.Add(this.mrbPDF);
            this.panel1.Controls.Add(this.mcbEnvoiPDF);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 264);
            this.panel1.TabIndex = 8;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton mrbPDF;
        private MaterialSkin.Controls.MaterialLabel mlExport;
        private MaterialSkin.Controls.MaterialRadioButton mrbExcel;
        private MaterialSkin.Controls.MaterialCheckBox mcbEnvoiPDF;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialRaisedButton mrbExport;
        private System.Windows.Forms.Panel panel1;
    }
}