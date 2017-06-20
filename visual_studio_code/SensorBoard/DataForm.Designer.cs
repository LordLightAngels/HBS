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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBase
            // 
            this.dgBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColDate,
            this.colHour,
            this.colTemp,
            this.colHumid,
            this.colUID,
            this.colDelete});
            this.dgBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBase.Location = new System.Drawing.Point(0, 0);
            this.dgBase.Name = "dgBase";
            this.dgBase.ReadOnly = true;
            this.dgBase.Size = new System.Drawing.Size(566, 336);
            this.dgBase.TabIndex = 0;
            this.dgBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBase_CellContentClick);
            this.dgBase.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgBase_UserDeletingRow);
            // 
            // colID
            // 
            this.colID.HeaderText = "Nom Capteur";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // colHour
            // 
            this.colHour.HeaderText = "Heure";
            this.colHour.Name = "colHour";
            this.colHour.ReadOnly = true;
            // 
            // colTemp
            // 
            this.colTemp.HeaderText = "Temperature";
            this.colTemp.Name = "colTemp";
            this.colTemp.ReadOnly = true;
            // 
            // colHumid
            // 
            this.colHumid.HeaderText = "Humidité";
            this.colHumid.Name = "colHumid";
            this.colHumid.ReadOnly = true;
            // 
            // colUID
            // 
            this.colUID.HeaderText = "UID";
            this.colUID.Name = "colUID";
            this.colUID.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Suppression";
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 336);
            this.Controls.Add(this.dgBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataForm";
            this.Text = "Data";
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUID;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}