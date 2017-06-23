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
            this.mlContent = new MaterialSkin.Controls.MaterialLabel();
            this.mrbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.mcbEnvoiDoc = new MaterialSkin.Controls.MaterialCheckBox();
            this.tfInputEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mrbExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mcbOuvrir = new MaterialSkin.Controls.MaterialCheckBox();
            this.mlTitle = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrbPDF
            // 
            this.mrbPDF.AutoSize = true;
            this.mrbPDF.Depth = 0;
            this.mrbPDF.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbPDF.Location = new System.Drawing.Point(19, 151);
            this.mrbPDF.Margin = new System.Windows.Forms.Padding(0);
            this.mrbPDF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbPDF.Name = "mrbPDF";
            this.mrbPDF.Ripple = true;
            this.mrbPDF.Size = new System.Drawing.Size(62, 30);
            this.mrbPDF.TabIndex = 2;
            this.mrbPDF.TabStop = true;
            this.mrbPDF.Text = "PDF";
            this.mrbPDF.UseVisualStyleBackColor = true;
            // 
            // mlContent
            // 
            this.mlContent.AutoSize = true;
            this.mlContent.Depth = 0;
            this.mlContent.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlContent.Location = new System.Drawing.Point(16, 69);
            this.mlContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlContent.Name = "mlContent";
            this.mlContent.Size = new System.Drawing.Size(629, 72);
            this.mlContent.TabIndex = 3;
            this.mlContent.Text = "Veuillez saisir un format d\'export parmi les formats proposés ci-dessous.\n\n Forma" +
    "t de l\'export : ";
            // 
            // mrbExcel
            // 
            this.mrbExcel.AutoSize = true;
            this.mrbExcel.Depth = 0;
            this.mrbExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.mrbExcel.Location = new System.Drawing.Point(119, 151);
            this.mrbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.mrbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mrbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbExcel.Name = "mrbExcel";
            this.mrbExcel.Ripple = true;
            this.mrbExcel.Size = new System.Drawing.Size(71, 30);
            this.mrbExcel.TabIndex = 4;
            this.mrbExcel.TabStop = true;
            this.mrbExcel.Text = "Excel";
            this.mrbExcel.UseVisualStyleBackColor = true;
            // 
            // mcbEnvoiDoc
            // 
            this.mcbEnvoiDoc.AutoSize = true;
            this.mcbEnvoiDoc.Depth = 0;
            this.mcbEnvoiDoc.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbEnvoiDoc.Location = new System.Drawing.Point(21, 202);
            this.mcbEnvoiDoc.Margin = new System.Windows.Forms.Padding(0);
            this.mcbEnvoiDoc.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbEnvoiDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbEnvoiDoc.Name = "mcbEnvoiDoc";
            this.mcbEnvoiDoc.Ripple = true;
            this.mcbEnvoiDoc.Size = new System.Drawing.Size(276, 30);
            this.mcbEnvoiDoc.TabIndex = 5;
            this.mcbEnvoiDoc.Text = "Envoi du document par email à :";
            this.mcbEnvoiDoc.UseVisualStyleBackColor = true;
            // 
            // tfInputEmail
            // 
            this.tfInputEmail.Depth = 0;
            this.tfInputEmail.Hint = "";
            this.tfInputEmail.Location = new System.Drawing.Point(336, 208);
            this.tfInputEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tfInputEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.tfInputEmail.Name = "tfInputEmail";
            this.tfInputEmail.PasswordChar = '\0';
            this.tfInputEmail.SelectedText = "";
            this.tfInputEmail.SelectionLength = 0;
            this.tfInputEmail.SelectionStart = 0;
            this.tfInputEmail.Size = new System.Drawing.Size(227, 28);
            this.tfInputEmail.TabIndex = 6;
            this.tfInputEmail.Text = "saisir adresse mail";
            this.tfInputEmail.UseSystemPasswordChar = false;
            this.tfInputEmail.Click += new System.EventHandler(this.tfInputEmail_Click);
            // 
            // mrbExport
            // 
            this.mrbExport.Depth = 0;
            this.mrbExport.Location = new System.Drawing.Point(19, 321);
            this.mrbExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrbExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbExport.Name = "mrbExport";
            this.mrbExport.Primary = true;
            this.mrbExport.Size = new System.Drawing.Size(249, 48);
            this.mrbExport.TabIndex = 7;
            this.mrbExport.Text = "Exporter";
            this.mrbExport.UseVisualStyleBackColor = true;
            this.mrbExport.Click += new System.EventHandler(this.mrbExport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mcbOuvrir);
            this.panel1.Controls.Add(this.mlTitle);
            this.panel1.Controls.Add(this.mlContent);
            this.panel1.Controls.Add(this.mrbExport);
            this.panel1.Controls.Add(this.mrbExcel);
            this.panel1.Controls.Add(this.tfInputEmail);
            this.panel1.Controls.Add(this.mrbPDF);
            this.panel1.Controls.Add(this.mcbEnvoiDoc);
            this.panel1.Location = new System.Drawing.Point(36, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 436);
            this.panel1.TabIndex = 8;
            // 
            // mcbOuvrir
            // 
            this.mcbOuvrir.AutoSize = true;
            this.mcbOuvrir.Depth = 0;
            this.mcbOuvrir.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbOuvrir.Location = new System.Drawing.Point(21, 256);
            this.mcbOuvrir.Margin = new System.Windows.Forms.Padding(0);
            this.mcbOuvrir.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbOuvrir.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbOuvrir.Name = "mcbOuvrir";
            this.mcbOuvrir.Ripple = true;
            this.mcbOuvrir.Size = new System.Drawing.Size(211, 30);
            this.mcbOuvrir.TabIndex = 9;
            this.mcbOuvrir.Text = "Ouvrir après génération";
            this.mcbOuvrir.UseVisualStyleBackColor = true;
            // 
            // mlTitle
            // 
            this.mlTitle.AutoSize = true;
            this.mlTitle.Depth = 0;
            this.mlTitle.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlTitle.Location = new System.Drawing.Point(15, 20);
            this.mlTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlTitle.Name = "mlTitle";
            this.mlTitle.Size = new System.Drawing.Size(74, 24);
            this.mlTitle.TabIndex = 8;
            this.mlTitle.Text = "Exports";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1067, 738);
            this.MinimumSize = new System.Drawing.Size(1067, 738);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRadioButton mrbPDF;
        private MaterialSkin.Controls.MaterialLabel mlContent;
        private MaterialSkin.Controls.MaterialRadioButton mrbExcel;
        private MaterialSkin.Controls.MaterialCheckBox mcbEnvoiDoc;
        private MaterialSkin.Controls.MaterialSingleLineTextField tfInputEmail;
        private MaterialSkin.Controls.MaterialRaisedButton mrbExport;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel mlTitle;
        private MaterialSkin.Controls.MaterialCheckBox mcbOuvrir;
    }
}