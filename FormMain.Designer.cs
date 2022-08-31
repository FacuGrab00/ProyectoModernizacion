
namespace ProyectoModernizacion
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.topMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.subMenu2 = new System.Windows.Forms.Panel();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.subMenu = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.subMenuTabla = new System.Windows.Forms.Panel();
            this.btnTabla = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.sideBar.SuspendLayout();
            this.subMenuTabla.SuspendLayout();
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
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbrir.Image = global::ProyectoModernizacion.Properties.Resources.file_import_solid_24;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.Location = new System.Drawing.Point(0, 0);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbrir.Size = new System.Drawing.Size(250, 50);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "ExcelPrincipal";
            this.saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            this.saveFileDialog1.Title = "Guardar Archivo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Image = global::ProyectoModernizacion.Properties.Resources.file_export_solid_24;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(0, 50);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(250, 50);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Archivo";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.topMenu.Controls.Add(this.btnClose);
            this.topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1240, 40);
            this.topMenu.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ProyectoModernizacion.Properties.Resources.x_regular_24__1_;
            this.btnClose.Location = new System.Drawing.Point(1198, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.sideBar.Controls.Add(this.subMenu2);
            this.sideBar.Controls.Add(this.btnBuscador);
            this.sideBar.Controls.Add(this.subMenu);
            this.sideBar.Controls.Add(this.btnProcesar);
            this.sideBar.Controls.Add(this.subMenuTabla);
            this.sideBar.Controls.Add(this.btnTabla);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 40);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(250, 680);
            this.sideBar.TabIndex = 4;
            // 
            // subMenu2
            // 
            this.subMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu2.Location = new System.Drawing.Point(0, 350);
            this.subMenu2.Name = "subMenu2";
            this.subMenu2.Size = new System.Drawing.Size(250, 100);
            this.subMenu2.TabIndex = 6;
            this.subMenu2.Visible = false;
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.btnBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscador.FlatAppearance.BorderSize = 0;
            this.btnBuscador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.btnBuscador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscador.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscador.Image = global::ProyectoModernizacion.Properties.Resources.search_alt_2_regular_24;
            this.btnBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscador.Location = new System.Drawing.Point(0, 300);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuscador.Size = new System.Drawing.Size(250, 50);
            this.btnBuscador.TabIndex = 5;
            this.btnBuscador.Text = "Modulo Buscador";
            this.btnBuscador.UseVisualStyleBackColor = false;
            // 
            // subMenu
            // 
            this.subMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu.Location = new System.Drawing.Point(0, 200);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(250, 100);
            this.subMenu.TabIndex = 0;
            this.subMenu.Visible = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.btnProcesar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcesar.Image = global::ProyectoModernizacion.Properties.Resources.report_solid_24;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(0, 150);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProcesar.Size = new System.Drawing.Size(250, 50);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Modulo Procesar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            // 
            // subMenuTabla
            // 
            this.subMenuTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenuTabla.Controls.Add(this.btnGuardar);
            this.subMenuTabla.Controls.Add(this.btnAbrir);
            this.subMenuTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuTabla.Location = new System.Drawing.Point(0, 50);
            this.subMenuTabla.Name = "subMenuTabla";
            this.subMenuTabla.Size = new System.Drawing.Size(250, 100);
            this.subMenuTabla.TabIndex = 0;
            this.subMenuTabla.Visible = false;
            // 
            // btnTabla
            // 
            this.btnTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.btnTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTabla.FlatAppearance.BorderSize = 0;
            this.btnTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.btnTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.btnTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabla.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTabla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTabla.Image = global::ProyectoModernizacion.Properties.Resources.table_regular_24;
            this.btnTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabla.Location = new System.Drawing.Point(0, 0);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTabla.Size = new System.Drawing.Size(250, 50);
            this.btnTabla.TabIndex = 3;
            this.btnTabla.Text = "Modulo Tabla";
            this.btnTabla.UseVisualStyleBackColor = false;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(990, 680);
            this.panelMain.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1240, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Sistema de Control de Personal";
            this.topMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.subMenuTabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel subMenu2;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Panel subMenu;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Panel subMenuTabla;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmExpandirMenu;
    }
}

