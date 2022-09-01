
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
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.topMenu = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.subMenu2 = new System.Windows.Forms.Panel();
            this.BtnBuscador = new System.Windows.Forms.Button();
            this.subMenuProcesar = new System.Windows.Forms.Panel();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.subMenuTabla = new System.Windows.Forms.Panel();
            this.BtnTabla = new System.Windows.Forms.Button();
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
            this.saveFileDialog1.FileName = "ExcelPrincipal";
            this.saveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx";
            this.saveFileDialog1.Title = "Guardar Archivo";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.BtnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(65)))), ((int)(((byte)(139)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(113)))), ((int)(((byte)(227)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Image = global::ProyectoModernizacion.Properties.Resources.file_export_solid_24;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(0, 50);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnGuardar.Size = new System.Drawing.Size(250, 50);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar Archivo";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
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
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1240, 40);
            this.topMenu.TabIndex = 3;
            this.topMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenu_MouseDown);
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 42);
            this.btnClose.TabIndex = 7;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(84)))));
            this.sideBar.Controls.Add(this.subMenu2);
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
            this.BtnBuscador.Location = new System.Drawing.Point(0, 300);
            this.BtnBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscador.Name = "BtnBuscador";
            this.BtnBuscador.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnBuscador.Size = new System.Drawing.Size(250, 50);
            this.BtnBuscador.TabIndex = 5;
            this.BtnBuscador.Text = "Buscar Personal";
            this.BtnBuscador.UseVisualStyleBackColor = false;
            this.BtnBuscador.Click += new System.EventHandler(this.BtnBuscador_Click_1);
            // 
            // subMenuProcesar
            // 
            this.subMenuProcesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenuProcesar.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProcesar.Location = new System.Drawing.Point(0, 200);
            this.subMenuProcesar.Margin = new System.Windows.Forms.Padding(2);
            this.subMenuProcesar.Name = "subMenuProcesar";
            this.subMenuProcesar.Size = new System.Drawing.Size(250, 100);
            this.subMenuProcesar.TabIndex = 0;
            this.subMenuProcesar.Visible = false;
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
            this.BtnProcesar.Image = global::ProyectoModernizacion.Properties.Resources.report_solid_24;
            this.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcesar.Location = new System.Drawing.Point(0, 150);
            this.BtnProcesar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnProcesar.Size = new System.Drawing.Size(250, 50);
            this.BtnProcesar.TabIndex = 4;
            this.BtnProcesar.Text = "Procesar";
            this.BtnProcesar.UseVisualStyleBackColor = false;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // subMenuTabla
            // 
            this.subMenuTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.subMenuTabla.Controls.Add(this.BtnGuardar);
            this.subMenuTabla.Controls.Add(this.BtnAbrir);
            this.subMenuTabla.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuTabla.Location = new System.Drawing.Point(0, 50);
            this.subMenuTabla.Name = "subMenuTabla";
            this.subMenuTabla.Size = new System.Drawing.Size(250, 100);
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
            this.BtnTabla.Image = global::ProyectoModernizacion.Properties.Resources.table_regular_24;
            this.BtnTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTabla.Location = new System.Drawing.Point(0, 0);
            this.BtnTabla.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTabla.Name = "BtnTabla";
            this.BtnTabla.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnTabla.Size = new System.Drawing.Size(250, 50);
            this.BtnTabla.TabIndex = 3;
            this.BtnTabla.Text = "Importar/Exportar";
            this.BtnTabla.UseVisualStyleBackColor = false;
            this.BtnTabla.Click += new System.EventHandler(this.BtnTabla_Click);
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
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Panel topMenu;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel subMenu2;
        private System.Windows.Forms.Button BtnBuscador;
        private System.Windows.Forms.Panel subMenuProcesar;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.Panel subMenuTabla;
        private System.Windows.Forms.Button BtnTabla;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmExpandirMenu;

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;

        private System.Windows.Forms.Button BtnProcesarRegistros;

    }
}

