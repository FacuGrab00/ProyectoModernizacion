
namespace ProyectoModernizacion
{
    partial class frmBuscadorPersonal
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscarNew = new System.Windows.Forms.Button();
            this.dgvBusqId = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(668, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 31);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(195, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(249, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(402, 31);
            this.txtID.TabIndex = 3;
            // 
            // btnBuscarNew
            // 
            this.btnBuscarNew.Location = new System.Drawing.Point(782, 55);
            this.btnBuscarNew.Name = "btnBuscarNew";
            this.btnBuscarNew.Size = new System.Drawing.Size(187, 31);
            this.btnBuscarNew.TabIndex = 9;
            this.btnBuscarNew.Text = "Buscar Nuevo";
            this.btnBuscarNew.UseVisualStyleBackColor = true;
            this.btnBuscarNew.Click += new System.EventHandler(this.btnBuscarNew_Click);
            // 
            // dgvBusqId
            // 
            this.dgvBusqId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqId.Location = new System.Drawing.Point(12, 113);
            this.dgvBusqId.Name = "dgvBusqId";
            this.dgvBusqId.RowHeadersWidth = 62;
            this.dgvBusqId.RowTemplate.Height = 33;
            this.dgvBusqId.Size = new System.Drawing.Size(1206, 345);
            this.dgvBusqId.TabIndex = 10;
            // 
            // frmBuscadorPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1230, 470);
            this.Controls.Add(this.dgvBusqId);
            this.Controls.Add(this.btnBuscarNew);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscadorPersonal";
            this.Text = "frmBuscadorPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscarNew;
        private System.Windows.Forms.DataGridView dgvBusqId;
    }
}