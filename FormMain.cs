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
            btnRestaurar.Visible = false;
        }

        //PANEL PARA MOVER FORM
        private void topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                recursos.MoverForm.MoverFrm(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }

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
        FormTabla moduloTabla = new FormTabla();

        //OCULTA LOS SUBMENUS
        private void hideSubMenu()
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;
            if (subMenuTabla.Visible == true)
                subMenuTabla.Visible = false;
            if (subMenu2.Visible == true)
                subMenu2.Visible = false;
        }

        //DESPLIEGA LOS SUBMENUS
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
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
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //MENSAJE DE ADVERTENCIA
            MessageBox.Show("IMPORTANTE: Al momento de importar el EXCEL, Asegurese que las COLUMNAS se encuentran en la FILA 1 y no hay ESPACIOS en blanco entre las FILAS");

            //ABRIMOS LA VENTANA DE BUSQUEDA PARA IMPORTAR EL EXCEL
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //GUARDAMOS LA DIRECCIÓN DEL EXCEL A IMPORTAR
                moduloTabla.FilePath = openFileDialog1.FileName;
                //REALIZAMOS LA LECTURA DEL EXCEL
                moduloTabla.importarExcel();
                moduloTabla.crearCopia();
            }
            else
            {
                //EN CASO DE NO REALIZAR LA IMPORTACIÓN
            }
        }

        //FUNCIÓN PARA PASAR EN MAYUSCULAS LOS NOMBRES Y APELLIDOS (SIN USO)
        private string pasarMayuscula(String nombreApellido)
        {
            nombreApellido = nombreApellido.UpperFirstChar();

            return nombreApellido;
        }

        //DESENCADENA TODO EL PROCESO DE EXPORTACIÓN DEL EXCEL PRINCIPAL
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                moduloTabla.SavePath = saveFileDialog1.FileName;
                moduloTabla.exportarExcel();
                MessageBox.Show("Se guardó con exito!");
            }
            else
            {
                //EN CASO DE NO REALIZAR EL GUARDADO
            }

            
        }

        //DESPLIEGA SUBMENU Y ABRE EL MODULO TABLA
        private void btnTabla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(moduloTabla);
            showSubMenu(subMenuTabla);
        }
        


        private void btnBuscador_Click(object sender, EventArgs e)
        {
            recursos.frmBuscadorPersonal frmbusc = new recursos.frmBuscadorPersonal();
            frmbusc.Show();
        }
    }
}
