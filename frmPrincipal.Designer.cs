
namespace ProyectoModernizacion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.topMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.mainMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.sideBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Archivo Excel";
            this.openFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            this.openFileDialog1.Title = "Abrir Archivo";
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.btnAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(254)))));
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrir.Location = new System.Drawing.Point(0, 0);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(250, 50);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // dgvExcel
            // 
            this.dgvExcel.AllowUserToAddRows = false;
            this.dgvExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(51, 71);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.RowHeadersWidth = 51;
            this.dgvExcel.RowTemplate.Height = 29;
            this.dgvExcel.Size = new System.Drawing.Size(729, 441);
            this.dgvExcel.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "ExcelPrincipal";
            this.saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            this.saveFileDialog1.Title = "Guardar Archivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(5)))));
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(133)))), ((int)(((byte)(254)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(0, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(250, 50);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Archivo";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // topMenu
            // 
            this.topMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.topMenu.Controls.Add(this.btnClose);
            this.topMenu.Location = new System.Drawing.Point(250, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(829, 40);
            this.topMenu.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ProyectoModernizacion.Properties.Resources.x_regular_24;
            this.btnClose.Location = new System.Drawing.Point(787, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.sideBar.Controls.Add(this.btnGuardar);
            this.sideBar.Controls.Add(this.btnAbrir);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(250, 664);
            this.sideBar.TabIndex = 4;
            // 
            // mainMenu
            // 
            this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.mainMenu.Controls.Add(this.dgvExcel);
            this.mainMenu.Location = new System.Drawing.Point(250, 40);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(829, 624);
            this.mainMenu.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1079, 664);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Control de Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.topMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.DataGridView dgvExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

