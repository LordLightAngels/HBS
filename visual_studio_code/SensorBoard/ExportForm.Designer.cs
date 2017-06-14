﻿namespace SensorBoard
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
            this.mcbEnvoiPDF = new MaterialSkin.Controls.MaterialCheckBox();
            this.msltfInputEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mrbExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mlTitle = new MaterialSkin.Controls.MaterialLabel();
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
            // mlContent
            // 
            this.mlContent.AutoSize = true;
            this.mlContent.Depth = 0;
            this.mlContent.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlContent.Location = new System.Drawing.Point(12, 56);
            this.mlContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlContent.Name = "mlContent";
            this.mlContent.Size = new System.Drawing.Size(500, 57);
            this.mlContent.TabIndex = 3;
            this.mlContent.Text = "Veuillez saisir un format d\'export parmi les formats proposés ci-dessous.\n\n Forma" +
    "t de l\'export : ";
            this.mlContent.Click += new System.EventHandler(this.materialLabel1_Click);
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
            this.mcbEnvoiPDF.Font = new System.Drawing.Font("Roboto", 10F);
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
            // msltfInputEmail
            // 
            this.msltfInputEmail.Depth = 0;
            this.msltfInputEmail.Hint = "";
            this.msltfInputEmail.Location = new System.Drawing.Point(208, 171);
            this.msltfInputEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfInputEmail.Name = "msltfInputEmail";
            this.msltfInputEmail.PasswordChar = '\0';
            this.msltfInputEmail.SelectedText = "";
            this.msltfInputEmail.SelectionLength = 0;
            this.msltfInputEmail.SelectionStart = 0;
            this.msltfInputEmail.Size = new System.Drawing.Size(170, 23);
            this.msltfInputEmail.TabIndex = 6;
            this.msltfInputEmail.Text = "saisir adresse mail";
            this.msltfInputEmail.UseSystemPasswordChar = false;
            this.msltfInputEmail.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
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
            this.panel1.Controls.Add(this.mlTitle);
            this.panel1.Controls.Add(this.mlContent);
            this.panel1.Controls.Add(this.mrbExport);
            this.panel1.Controls.Add(this.mrbExcel);
            this.panel1.Controls.Add(this.msltfInputEmail);
            this.panel1.Controls.Add(this.mrbPDF);
            this.panel1.Controls.Add(this.mcbEnvoiPDF);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 264);
            this.panel1.TabIndex = 8;
            // 
            // mlTitle
            // 
            this.mlTitle.AutoSize = true;
            this.mlTitle.Depth = 0;
            this.mlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.mlTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlTitle.Location = new System.Drawing.Point(11, 16);
            this.mlTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlTitle.Name = "mlTitle";
            this.mlTitle.Size = new System.Drawing.Size(85, 25);
            this.mlTitle.TabIndex = 8;
            this.mlTitle.Text = "Exports";
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
        private MaterialSkin.Controls.MaterialLabel mlContent;
        private MaterialSkin.Controls.MaterialRadioButton mrbExcel;
        private MaterialSkin.Controls.MaterialCheckBox mcbEnvoiPDF;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfInputEmail;
        private MaterialSkin.Controls.MaterialRaisedButton mrbExport;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel mlTitle;
    }
}