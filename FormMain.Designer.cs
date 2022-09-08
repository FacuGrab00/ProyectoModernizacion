
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.topMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.Panel();
            this.BtnBuscador = new System.Windows.Forms.Button();
            this.subMenuProcesar = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnProcesarArchivo = new System.Windows.Forms.Button();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.subMenuTabla = new System.Windows.Forms.Panel();
            this.BtnTabla = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.topMenu.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.subMenuProcesar.SuspendLayout();
            this.subMenuTabla.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Archivo Excel";
            this.openFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            this.openFileDialog1.Title = "Abrir Archivo";
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.BtnAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAbrir.FlatAppearance.BorderSize = 0;
            this.BtnAbrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.BtnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAbrir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAbrir.Image = global::ProyectoModernizacion.Properties.Resources.file_import_solid_24;
            this.BtnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAbrir.Location = new System.Drawing.Point(0, 0);
            this.BtnAbrir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnAbrir.Size = new System.Drawing.Size(250, 50);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir Archivo";
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Registros";
            this.saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            this.saveFileDialog1.Title = "Guardar Archivo";
            // 
            // topMenu
            // 
            this.topMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.topMenu.Controls.Add(this.label1);
            this.topMenu.Controls.Add(this.btnMaximizar);
            this.topMenu.Controls.Add(this.btnRestaurar);
            this.topMenu.Controls.Add(this.btnMinimizar);
            this.topMenu.Controls.Add(this.btnCerrar);
            this.topMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1240, 40);
            this.topMenu.TabIndex = 3;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel Processor 1.0";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Image = global::ProyectoModernizacion.Properties.Resources.windows_regular_24;
            this.btnMaximizar.Location = new System.Drawing.Point(1164, 6);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 28);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Image = global::ProyectoModernizacion.Properties.Resources.window_regular_24;
            this.btnRestaurar.Location = new System.Drawing.Point(1164, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(34, 28);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = global::ProyectoModernizacion.Properties.Resources.minus_regular_24;
            this.btnMinimizar.Location = new System.Drawing.Point(1125, 6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 28);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::ProyectoModernizacion.Properties.Resources.x_regular_24__1_;
            this.btnCerrar.Location = new System.Drawing.Point(1203, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 28);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.sideBar.Controls.Add(this.BtnBuscador);
            this.sideBar.Controls.Add(this.subMenuProcesar);
            this.sideBar.Controls.Add(this.BtnProcesar);
            this.sideBar.Controls.Add(this.subMenuTabla);
            this.sideBar.Controls.Add(this.BtnTabla);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 40);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(250, 680);
            this.sideBar.TabIndex = 4;
            // 
            // BtnBuscador
            // 
            this.BtnBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.BtnBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnBuscador.FlatAppearance.BorderSize = 0;
            this.BtnBuscador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.BtnBuscador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.BtnBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscador.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBuscador.Image = global::ProyectoModernizacion.Properties.Resources.search_alt_2_regular_24;
            this.BtnBuscador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscador.Location = new System.Drawing.Point(0, 250);
            this.BtnBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscador.Name = "BtnBuscador";
            this.BtnBuscador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnBuscador.Size = new System.Drawing.Size(250, 50);
            this.BtnBuscador.TabIndex = 5;
            this.BtnBuscador.Text = "Buscar Personal";
            this.BtnBuscador.UseVisualStyleBackColor = false;
            this.BtnBuscador.Click += new System.EventHandler(this.BtnBuscador_Click);
            // 
            // subMenuProcesar
            // 
            this.subMenuProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenuProcesar.Controls.Add(this.btnGuardar);
            this.subMenuProcesar.Controls.Add(this.BtnProcesarArchivo);
            this.subMenuProcesar.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProcesar.Location = new System.Drawing.Point(0, 150);
            this.subMenuProcesar.Margin = new System.Windows.Forms.Padding(2);
            this.subMenuProcesar.Name = "subMenuProcesar";
            this.subMenuProcesar.Size = new System.Drawing.Size(250, 100);
            this.subMenuProcesar.TabIndex = 0;
            this.subMenuProcesar.Visible = false;
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
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(250, 50);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnProcesarArchivo
            // 
            this.BtnProcesarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.BtnProcesarArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProcesarArchivo.FlatAppearance.BorderSize = 0;
            this.BtnProcesarArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.BtnProcesarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.BtnProcesarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcesarArchivo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcesarArchivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProcesarArchivo.Image = global::ProyectoModernizacion.Properties.Resources.icons8_process_24;
            this.BtnProcesarArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcesarArchivo.Location = new System.Drawing.Point(0, 0);
            this.BtnProcesarArchivo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProcesarArchivo.Name = "BtnProcesarArchivo";
            this.BtnProcesarArchivo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnProcesarArchivo.Size = new System.Drawing.Size(250, 50);
            this.BtnProcesarArchivo.TabIndex = 3;
            this.BtnProcesarArchivo.Text = "Procesar";
            this.BtnProcesarArchivo.UseVisualStyleBackColor = false;
            this.BtnProcesarArchivo.Click += new System.EventHandler(this.BtnProcesarArchivo_Click);
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.BtnProcesar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProcesar.FlatAppearance.BorderSize = 0;
            this.BtnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.BtnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.BtnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcesar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcesar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProcesar.Image = global::ProyectoModernizacion.Properties.Resources.icons8_register_24;
            this.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcesar.Location = new System.Drawing.Point(0, 100);
            this.BtnProcesar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnProcesar.Size = new System.Drawing.Size(250, 50);
            this.BtnProcesar.TabIndex = 4;
            this.BtnProcesar.Text = "Procesar Registros";
            this.BtnProcesar.UseVisualStyleBackColor = false;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // subMenuTabla
            // 
            this.subMenuTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenuTabla.Controls.Add(this.BtnAbrir);
            this.subMenuTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuTabla.Location = new System.Drawing.Point(0, 50);
            this.subMenuTabla.Name = "subMenuTabla";
            this.subMenuTabla.Size = new System.Drawing.Size(250, 50);
            this.subMenuTabla.TabIndex = 0;
            this.subMenuTabla.Visible = false;
            // 
            // BtnTabla
            // 
            this.BtnTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.BtnTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTabla.FlatAppearance.BorderSize = 0;
            this.BtnTabla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.BtnTabla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.BtnTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTabla.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTabla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTabla.Image = global::ProyectoModernizacion.Properties.Resources.icons8_excel_24__2_;
            this.BtnTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabla.Location = new System.Drawing.Point(0, 0);
            this.BtnTabla.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTabla.Name = "BtnTabla";
            this.BtnTabla.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnTabla.Size = new System.Drawing.Size(250, 50);
            this.BtnTabla.TabIndex = 3;
            this.BtnTabla.Text = "Importar Excel";
            this.BtnTabla.UseVisualStyleBackColor = false;
            this.BtnTabla.Click += new System.EventHandler(this.BtnTabla_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.panelMain.Controls.Add(this.labelLogo);
            this.panelMain.Controls.Add(this.logo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(990, 680);
            this.panelMain.TabIndex = 5;
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(223, 583);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(582, 73);
            this.labelLogo.TabIndex = 8;
            this.labelLogo.Text = "Excel Processor 1.0";
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.logo.Image = global::ProyectoModernizacion.Properties.Resources.icons8_microsoft_excel_500;
            this.logo.Location = new System.Drawing.Point(260, 80);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(500, 500);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
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
            this.topMenu.PerformLayout();
            this.sideBar.ResumeLayout(false);
            this.subMenuProcesar.ResumeLayout(false);
            this.subMenuTabla.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button BtnBuscador;
        private System.Windows.Forms.Panel subMenuProcesar;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.Panel subMenuTabla;
        private System.Windows.Forms.Button BtnTabla;

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;

        private System.Windows.Forms.Button BtnProcesarArchivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelLogo;
    }
}

