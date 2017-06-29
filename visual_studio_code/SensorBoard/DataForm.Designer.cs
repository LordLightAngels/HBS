namespace SensorBoard
{
    partial class DataForm
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
            this.dgBase = new System.Windows.Forms.DataGridView();
            this.lblDatas = new System.Windows.Forms.Label();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBase
            // 
            this.dgBase.AllowUserToAddRows = false;
            this.dgBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColDate,
            this.colTemp,
            this.colHumid,
            this.colUID,
            this.colDelete});
            this.dgBase.Location = new System.Drawing.Point(0, 37);
            this.dgBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgBase.Name = "dgBase";
            this.dgBase.ReadOnly = true;
            this.dgBase.Size = new System.Drawing.Size(875, 661);
            this.dgBase.TabIndex = 0;
            this.dgBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBase_CellContentClick);
            this.dgBase.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgBase_UserDeletingRow);
            this.dgBase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvData_KeyDown);
            // 
            // lblDatas
            // 
            this.lblDatas.AutoSize = true;
            this.lblDatas.Location = new System.Drawing.Point(17, 16);
            this.lblDatas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatas.Name = "lblDatas";
            this.lblDatas.Size = new System.Drawing.Size(133, 17);
            this.lblDatas.TabIndex = 1;
            this.lblDatas.Text = "Donnees Existantes";
            // 
            // colID
            // 
            this.colID.FillWeight = 31.7416F;
            this.colID.HeaderText = "Nom Capteur";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.FillWeight = 45F;
            this.ColDate.HeaderText = "Date et heure";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // colTemp
            // 
            this.colTemp.FillWeight = 31.7416F;
            this.colTemp.HeaderText = "Temperature";
            this.colTemp.Name = "colTemp";
            this.colTemp.ReadOnly = true;
            // 
            // colHumid
            // 
            this.colHumid.FillWeight = 31.7416F;
            this.colHumid.HeaderText = "Humidité";
            this.colHumid.Name = "colHumid";
            this.colHumid.ReadOnly = true;
            // 
            // colUID
            // 
            this.colUID.FillWeight = 31.7416F;
            this.colUID.HeaderText = "UID";
            this.colUID.Name = "colUID";
            this.colUID.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 31.7416F;
            this.colDelete.HeaderText = "Suppression";
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 661);
            this.Controls.Add(this.lblDatas);
            this.Controls.Add(this.dgBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataForm";
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBase;
        private System.Windows.Forms.Label lblDatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUID;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}