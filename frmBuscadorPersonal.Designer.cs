
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscarNew = new System.Windows.Forms.Button();
            this.dgvBusqId = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxFechas = new System.Windows.Forms.ComboBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblHrsTrab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(654, 50);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 34);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(194, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(249, 50);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "Ingrese el ID buscado...";
            this.txtID.Size = new System.Drawing.Size(399, 34);
            this.txtID.TabIndex = 3;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged_1);
            // 
            // btnBuscarNew
            // 
            this.btnBuscarNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnBuscarNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.btnBuscarNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarNew.ForeColor = System.Drawing.Color.White;
            this.btnBuscarNew.Location = new System.Drawing.Point(771, 50);
            this.btnBuscarNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarNew.Name = "btnBuscarNew";
            this.btnBuscarNew.Size = new System.Drawing.Size(188, 34);
            this.btnBuscarNew.TabIndex = 9;
            this.btnBuscarNew.Text = "Buscar Nuevo";
            this.btnBuscarNew.UseVisualStyleBackColor = false;
            this.btnBuscarNew.Click += new System.EventHandler(this.btnBuscarNew_Click);
            // 
            // dgvBusqId
            // 
            this.dgvBusqId.AllowUserToAddRows = false;
            this.dgvBusqId.AllowUserToResizeRows = false;
            this.dgvBusqId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqId.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBusqId.BackgroundColor = System.Drawing.Color.White;
            this.dgvBusqId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBusqId.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvBusqId.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBusqId.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusqId.ColumnHeadersHeight = 29;
            this.dgvBusqId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBusqId.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBusqId.EnableHeadersVisualStyles = false;
            this.dgvBusqId.Location = new System.Drawing.Point(62, 168);
            this.dgvBusqId.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBusqId.Name = "dgvBusqId";
            this.dgvBusqId.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBusqId.RowHeadersVisible = false;
            this.dgvBusqId.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBusqId.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBusqId.RowTemplate.Height = 33;
            this.dgvBusqId.Size = new System.Drawing.Size(1112, 557);
            this.dgvBusqId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 746);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad de Horas Trabajadas:";
            // 
            // cBoxFechas
            // 
            this.cBoxFechas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFechas.FormatString = "G";
            this.cBoxFechas.FormattingEnabled = true;
            this.cBoxFechas.Location = new System.Drawing.Point(884, 746);
            this.cBoxFechas.Name = "cBoxFechas";
            this.cBoxFechas.Size = new System.Drawing.Size(290, 33);
            this.cBoxFechas.TabIndex = 12;
            this.cBoxFechas.TextChanged += new System.EventHandler(this.cBoxFechas_TextChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(163, 128);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(339, 31);
            this.dtpDesde.TabIndex = 13;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(62, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(517, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(618, 127);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(341, 31);
            this.dtpHasta.TabIndex = 15;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(988, 126);
            this.btnVer.Margin = new System.Windows.Forms.Padding(2);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(112, 31);
            this.btnVer.TabIndex = 17;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lblHrsTrab
            // 
            this.lblHrsTrab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHrsTrab.AutoSize = true;
            this.lblHrsTrab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHrsTrab.ForeColor = System.Drawing.Color.White;
            this.lblHrsTrab.Location = new System.Drawing.Point(437, 747);
            this.lblHrsTrab.Name = "lblHrsTrab";
            this.lblHrsTrab.Size = new System.Drawing.Size(33, 32);
            this.lblHrsTrab.TabIndex = 18;
            this.lblHrsTrab.Text = "N";
            this.lblHrsTrab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuscadorPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1238, 850);
            this.Controls.Add(this.lblHrsTrab);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.cBoxFechas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBusqId);
            this.Controls.Add(this.btnBuscarNew);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxFechas;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblHrsTrab;
    }
}