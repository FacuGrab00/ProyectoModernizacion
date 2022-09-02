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

            }else{
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


            this.WindowState = FormWindowState.Minimized;

        }

        //UNA SOLA INSTANCIA DEL MODULO TABLA QUE CONTIENE AL FORMULARIO
        private readonly FormTabla moduloTabla = new FormTabla();
        private readonly FormRegistros moduloRegistro = new FormRegistros();
        private readonly recursos.frmBuscadorPersonal moduloBuscarPersonal = new recursos.frmBuscadorPersonal();

        //OCULTA LOS SUBMENUS
        private void HideSubMenu()
        {
            if (subMenuProcesar.Visible == true)
                subMenuProcesar.Visible = false;
            if (subMenuTabla.Visible == true)
                subMenuTabla.Visible = false;
            if (subMenu2.Visible == true)
                subMenu2.Visible = false;
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
            //MENSAJE DE ADVERTENCIA
            MessageBox.Show("IMPORTANTE: Al momento de importar el EXCEL, Asegurese que las COLUMNAS se encuentran en la FILA 1 y no hay ESPACIOS en blanco entre las FILAS");

            //ABRIMOS LA VENTANA DE BUSQUEDA PARA IMPORTAR EL EXCEL
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //GUARDAMOS LA DIRECCIÓN DEL EXCEL A IMPORTAR
                moduloTabla.FilePath = openFileDialog1.FileName;
                //REALIZAMOS LA LECTURA DEL EXCEL
                moduloTabla.ImportarExcel();
                moduloTabla.CrearCopia();
            }
            else
            {
                //EN CASO DE NO REALIZAR LA IMPORTACIÓN
            }
        }

        //FUNCIÓN PARA PASAR EN MAYUSCULAS LOS NOMBRES Y APELLIDOS (SIN USO)
        private string PasarMayuscula(String nombreApellido)
        {
            nombreApellido = nombreApellido.UpperFirstChar();

            return nombreApellido;
        }

        //DESENCADENA TODO EL PROCESO DE EXPORTACIÓN DEL EXCEL PRINCIPAL
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                moduloTabla.SavePath = saveFileDialog1.FileName;
                moduloTabla.ExportarExcel();
                MessageBox.Show("Se guardó con exito!");
            }
            else
            {
                //EN CASO DE NO REALIZAR EL GUARDADO
            }
                        
        }
     
        //CIERRA LA APLICACIÓN
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //DESPLIEGA SUBMENU Y ABRE EL MODULO TABLA
        private void BtnTabla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(moduloTabla);
            ShowSubMenu(subMenuTabla);
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            //SE ENVIA LA INSTANCIA DEL MODULO TABLA AL MODULO REGISTROS PARA ACCEDER A SU INTERFAZ.
            moduloRegistro.Tabla = moduloTabla;
            //SI EXISTE UN ARCHIVO EXCEL PREVIO SE PROCESAN LOS REGISTROS.
            if (File.Exists(moduloTabla.MainPath))
                moduloRegistro.GenerarRegistros();
            
            AbrirFormHijo(moduloRegistro);
            ShowSubMenu(subMenuProcesar);
        }

       

        private void BtnBuscador_Click_1(object sender, EventArgs e)
        {
            AbrirFormHijo(moduloBuscarPersonal);
            moduloBuscarPersonal.setBuscarId(moduloRegistro);
        }

        

        private void BtnProcesarArchivo_Click_1(object sender, EventArgs e)
        {
            moduloRegistro.ProcesarRegistros();
            moduloRegistro.VolcarRegistros();
        }
    }
}
