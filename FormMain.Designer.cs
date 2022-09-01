
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
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.subMenu2 = new System.Windows.Forms.Panel();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.subMenu = new System.Windows.Forms.Panel();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.subMenuTabla = new System.Windows.Forms.Panel();
            this.btnTabla = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
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
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAbrir.Size = new System.Drawing.Size(300, 60);
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
            this.btnGuardar.Location = new System.Drawing.Point(0, 60);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(300, 60);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar Archivo";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.topMenu.Controls.Add(this.btnMaximizar);
            this.topMenu.Controls.Add(this.btnRestaurar);
            this.topMenu.Controls.Add(this.btnMinimizar);
            this.topMenu.Controls.Add(this.btnCerrar);
            this.topMenu.Controls.Add(this.btnClose);
            this.topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Margin = new System.Windows.Forms.Padding(4);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1488, 48);
            this.topMenu.TabIndex = 3;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(1350, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(41, 34);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.Text = "m";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(1397, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(41, 34);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.Text = "M";
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1444, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 34);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
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
            this.sideBar.Location = new System.Drawing.Point(0, 48);
            this.sideBar.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(300, 816);
            this.sideBar.TabIndex = 4;
            // 
            // subMenu2
            // 
            this.subMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu2.Location = new System.Drawing.Point(0, 420);
            this.subMenu2.Margin = new System.Windows.Forms.Padding(4);
            this.subMenu2.Name = "subMenu2";
            this.subMenu2.Size = new System.Drawing.Size(300, 120);
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
            this.btnBuscador.Location = new System.Drawing.Point(0, 360);
            this.btnBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBuscador.Size = new System.Drawing.Size(300, 60);
            this.btnBuscador.TabIndex = 5;
            this.btnBuscador.Text = "Modulo Buscador";
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // subMenu
            // 
            this.subMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenu.Location = new System.Drawing.Point(0, 240);
            this.subMenu.Margin = new System.Windows.Forms.Padding(4);
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(300, 120);
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
            this.btnProcesar.Location = new System.Drawing.Point(0, 180);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProcesar.Size = new System.Drawing.Size(300, 60);
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
            this.subMenuTabla.Location = new System.Drawing.Point(0, 60);
            this.subMenuTabla.Margin = new System.Windows.Forms.Padding(4);
            this.subMenuTabla.Name = "subMenuTabla";
            this.subMenuTabla.Size = new System.Drawing.Size(300, 120);
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
            this.btnTabla.Margin = new System.Windows.Forms.Padding(4);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTabla.Size = new System.Drawing.Size(300, 60);
            this.btnTabla.TabIndex = 3;
            this.btnTabla.Text = "Modulo Tabla";
            this.btnTabla.UseVisualStyleBackColor = false;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(300, 48);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1188, 816);
            this.panelMain.TabIndex = 5;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(1397, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(41, 34);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.Text = "R";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1488, 864);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.topMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;
    }
}

