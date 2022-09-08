using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Diagnostics;
using SpreadsheetLight;

namespace ProyectoModernizacion
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //PANEL PARA MOVER FORM
        private void topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MoverForm.MoverFrm(this);
        }

        //FUNCIONALIDADES DE VENTANA
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
            {
                this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                WindowState = FormWindowState.Maximized;
            }

            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //UNA SOLA INSTANCIA DEL MODULO TABLA QUE CONTIENE AL FORMULARIO
        private readonly FormTabla moduloTabla = new FormTabla();
        private readonly FormRegistros moduloRegistro = new FormRegistros();
        private readonly frmBuscadorPersonal moduloBuscarPersonal = new frmBuscadorPersonal();

        //OCULTA LOS SUBMENUS
        private void HideSubMenu()
        {
            if (subMenuProcesar.Visible == true)
                subMenuProcesar.Visible = false;
            if (subMenuTabla.Visible == true)
                subMenuTabla.Visible = false;
        }

        //DESPLIEGA LOS SUBMENUS
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //PROCEDIMIENTO ABRIR VENTANA HIJA
        private void AbrirFormHijo(object formhija)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(fh);
            this.panelMain.Tag = fh;
            fh.Show();
        }

        //DESENCADENA EL PROCESO PARA IMPORTAR UN EXCEL
        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            //ABRIMOS LA VENTANA DE BUSQUEDA PARA IMPORTAR EL EXCEL
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //GUARDAMOS LA DIRECCIÓN DEL EXCEL A IMPORTAR
                moduloTabla.FilePath = openFileDialog1.FileName;
                moduloTabla.Importar();
            }
            else{/*EN CASO DE NO REALIZAR LA IMPORTACIÓN*/}
        }

        //CIERRA LA APLICACIÓN
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //DESPLIEGA SUBMENU Y ABRE EL MODULO TABLA
        private void BtnTabla_Click(object sender, EventArgs e)
        {
            labelLogo.Visible = false;
            logo.Visible = false;
            AbrirFormHijo(moduloTabla);
            ShowSubMenu(subMenuTabla);
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            labelLogo.Visible = false;
            logo.Visible = false;
            AbrirFormHijo(moduloRegistro);
            ShowSubMenu(subMenuProcesar);
        }

        private void BtnProcesarArchivo_Click(object sender, EventArgs e)
        {
            moduloRegistro.VolcarRegistros();
        }

        private void BtnBuscador_Click(object sender, EventArgs e)
        {
            labelLogo.Visible = false;
            logo.Visible = false;
            AbrirFormHijo(moduloBuscarPersonal);
            moduloBuscarPersonal.BuscarId = moduloRegistro;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //ABRIMOS LA VENTANA DE BUSQUEDA PARA IMPORTAR EL EXCEL
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //GUARDAMOS LA DIRECCIÓN DEL EXCEL A IMPORTAR
                moduloRegistro.SavePath = saveFileDialog1.FileName;
                moduloRegistro.Exportar();
            }
            else {/*EN CASO DE NO REALIZAR LA IMPORTACIÓN*/}
        }
    }//FIN CLASE
}
