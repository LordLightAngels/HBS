namespace SensorBoard
{
    partial class SensorForm
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
            this.pnlSensor = new System.Windows.Forms.Panel();
            this.mlblWebServiceSensor = new MaterialSkin.Controls.MaterialLabel();
            this.mlblLabelSensor = new MaterialSkin.Controls.MaterialLabel();
            this.mlblUIDSensor = new MaterialSkin.Controls.MaterialLabel();
            this.msltfWebServiceSensor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.msltfLabelSensor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.msltfUIDSensor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mrbSensorCreate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgvSensor = new System.Windows.Forms.DataGridView();
            this.UIDSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebServiceSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateSensor = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteSensor = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlSensor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSensor
            // 
            this.pnlSensor.Controls.Add(this.mlblWebServiceSensor);
            this.pnlSensor.Controls.Add(this.mlblLabelSensor);
            this.pnlSensor.Controls.Add(this.mlblUIDSensor);
            this.pnlSensor.Controls.Add(this.msltfWebServiceSensor);
            this.pnlSensor.Controls.Add(this.msltfLabelSensor);
            this.pnlSensor.Controls.Add(this.msltfUIDSensor);
            this.pnlSensor.Controls.Add(this.mrbSensorCreate);
            this.pnlSensor.Controls.Add(this.dgvSensor);
            this.pnlSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSensor.Location = new System.Drawing.Point(0, 0);
            this.pnlSensor.Name = "pnlSensor";
            this.pnlSensor.Size = new System.Drawing.Size(614, 318);
            this.pnlSensor.TabIndex = 0;
            // 
            // mlblWebServiceSensor
            // 
            this.mlblWebServiceSensor.AutoSize = true;
            this.mlblWebServiceSensor.Depth = 0;
            this.mlblWebServiceSensor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblWebServiceSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblWebServiceSensor.Location = new System.Drawing.Point(473, 178);
            this.mlblWebServiceSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblWebServiceSensor.Name = "mlblWebServiceSensor";
            this.mlblWebServiceSensor.Size = new System.Drawing.Size(87, 19);
            this.mlblWebServiceSensor.TabIndex = 12;
            this.mlblWebServiceSensor.Text = "WebService";
            // 
            // mlblLabelSensor
            // 
            this.mlblLabelSensor.AutoSize = true;
            this.mlblLabelSensor.Depth = 0;
            this.mlblLabelSensor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblLabelSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblLabelSensor.Location = new System.Drawing.Point(262, 178);
            this.mlblLabelSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblLabelSensor.Name = "mlblLabelSensor";
            this.mlblLabelSensor.Size = new System.Drawing.Size(45, 19);
            this.mlblLabelSensor.TabIndex = 11;
            this.mlblLabelSensor.Text = "Label";
            // 
            // mlblUIDSensor
            // 
            this.mlblUIDSensor.AutoSize = true;
            this.mlblUIDSensor.Depth = 0;
            this.mlblUIDSensor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblUIDSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblUIDSensor.Location = new System.Drawing.Point(51, 178);
            this.mlblUIDSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblUIDSensor.Name = "mlblUIDSensor";
            this.mlblUIDSensor.Size = new System.Drawing.Size(33, 19);
            this.mlblUIDSensor.TabIndex = 10;
            this.mlblUIDSensor.Text = "UID";
            // 
            // msltfWebServiceSensor
            // 
            this.msltfWebServiceSensor.Depth = 0;
            this.msltfWebServiceSensor.Hint = "";
            this.msltfWebServiceSensor.Location = new System.Drawing.Point(477, 217);
            this.msltfWebServiceSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfWebServiceSensor.Name = "msltfWebServiceSensor";
            this.msltfWebServiceSensor.PasswordChar = '\0';
            this.msltfWebServiceSensor.SelectedText = "";
            this.msltfWebServiceSensor.SelectionLength = 0;
            this.msltfWebServiceSensor.SelectionStart = 0;
            this.msltfWebServiceSensor.Size = new System.Drawing.Size(95, 23);
            this.msltfWebServiceSensor.TabIndex = 9;
            this.msltfWebServiceSensor.UseSystemPasswordChar = false;
            // 
            // msltfLabelSensor
            // 
            this.msltfLabelSensor.Depth = 0;
            this.msltfLabelSensor.Hint = "";
            this.msltfLabelSensor.Location = new System.Drawing.Point(266, 217);
            this.msltfLabelSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfLabelSensor.Name = "msltfLabelSensor";
            this.msltfLabelSensor.PasswordChar = '\0';
            this.msltfLabelSensor.SelectedText = "";
            this.msltfLabelSensor.SelectionLength = 0;
            this.msltfLabelSensor.SelectionStart = 0;
            this.msltfLabelSensor.Size = new System.Drawing.Size(95, 23);
            this.msltfLabelSensor.TabIndex = 8;
            this.msltfLabelSensor.UseSystemPasswordChar = false;
            // 
            // msltfUIDSensor
            // 
            this.msltfUIDSensor.Depth = 0;
            this.msltfUIDSensor.Hint = "";
            this.msltfUIDSensor.Location = new System.Drawing.Point(55, 217);
            this.msltfUIDSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltfUIDSensor.Name = "msltfUIDSensor";
            this.msltfUIDSensor.PasswordChar = '\0';
            this.msltfUIDSensor.SelectedText = "";
            this.msltfUIDSensor.SelectionLength = 0;
            this.msltfUIDSensor.SelectionStart = 0;
            this.msltfUIDSensor.Size = new System.Drawing.Size(95, 23);
            this.msltfUIDSensor.TabIndex = 7;
            this.msltfUIDSensor.UseSystemPasswordChar = false;
            // 
            // mrbSensorCreate
            // 
            this.mrbSensorCreate.Depth = 0;
            this.mrbSensorCreate.Location = new System.Drawing.Point(55, 269);
            this.mrbSensorCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbSensorCreate.Name = "mrbSensorCreate";
            this.mrbSensorCreate.Primary = true;
            this.mrbSensorCreate.Size = new System.Drawing.Size(95, 37);
            this.mrbSensorCreate.TabIndex = 1;
            this.mrbSensorCreate.Text = "Creer";
            this.mrbSensorCreate.UseVisualStyleBackColor = true;
            this.mrbSensorCreate.Click += new System.EventHandler(this.mrbSensorCreate_Click);
            // 
            // dgvSensor
            // 
            this.dgvSensor.AllowUserToAddRows = false;
            this.dgvSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UIDSensor,
            this.LabelSensor,
            this.WebServiceSensor,
            this.UpdateSensor,
            this.DeleteSensor});
            this.dgvSensor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSensor.Location = new System.Drawing.Point(0, 0);
            this.dgvSensor.Name = "dgvSensor";
            this.dgvSensor.Size = new System.Drawing.Size(614, 160);
            this.dgvSensor.TabIndex = 0;
            // 
            // UIDSensor
            // 
            this.UIDSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UIDSensor.HeaderText = "UID";
            this.UIDSensor.Name = "UIDSensor";
            // 
            // LabelSensor
            // 
            this.LabelSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LabelSensor.HeaderText = "Label";
            this.LabelSensor.Name = "LabelSensor";
            // 
            // WebServiceSensor
            // 
            this.WebServiceSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WebServiceSensor.HeaderText = "WebService";
            this.WebServiceSensor.Name = "WebServiceSensor";
            // 
            // UpdateSensor
            // 
            this.UpdateSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UpdateSensor.HeaderText = "Modifier";
            this.UpdateSensor.Image = global::SensorBoard.Properties.Resources.pencil;
            this.UpdateSensor.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UpdateSensor.Name = "UpdateSensor";
            // 
            // DeleteSensor
            // 
            this.DeleteSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteSensor.HeaderText = "Supprimer";
            this.DeleteSensor.Image = global::SensorBoard.Properties.Resources.pbelle;
            this.DeleteSensor.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DeleteSensor.Name = "DeleteSensor";
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 318);
            this.Controls.Add(this.pnlSensor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SensorForm";
            this.Text = "SensorForm";
            this.pnlSensor.ResumeLayout(false);
            this.pnlSensor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSensor;
        private MaterialSkin.Controls.MaterialRaisedButton mrbSensorCreate;
        private System.Windows.Forms.DataGridView dgvSensor;
        private MaterialSkin.Controls.MaterialLabel mlblWebServiceSensor;
        private MaterialSkin.Controls.MaterialLabel mlblLabelSensor;
        private MaterialSkin.Controls.MaterialLabel mlblUIDSensor;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfWebServiceSensor;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfLabelSensor;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltfUIDSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn UIDSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebServiceSensor;
        private System.Windows.Forms.DataGridViewImageColumn UpdateSensor;
        private System.Windows.Forms.DataGridViewImageColumn DeleteSensor;
    }
}