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
    public partial class Form1 : Form
    {

        //Mover panel
        int m, mx, my;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileName = "Selecciona el archivo Excel";
            openFileDialog1.Filter = "Archivo (*.xlsx)|*.xlsx";
            openFileDialog1.Title = "Abrir Archivo";

            saveFileDialog1.FileName = "Nuevo Archivo Excel";
            saveFileDialog1.Filter = "Archivo (*.xlsx)|*.xlsx";
            saveFileDialog1.Title = "Guardar Archivo";

            dgvExcel.AllowUserToAddRows = false;
        }

        string filePath = "";
        string savePath = "";
        SLDocument excelOriginal;
        SLDocument excelCopia;

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openFileDialog1.FileName;
                    /*using (Stream str = openFileDialog1.OpenFile())
                    {
                        Process.Start("notepad.exe", filePath);
                    }
                    */
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
                leerExcel();
            }
        }

        private void leerExcel()
        {
            excelOriginal = new SLDocument(filePath);
            int iRow = 2;

            dgvExcel.ColumnCount = 3;
            dgvExcel.Columns[0].Name = excelOriginal.GetCellValueAsString(1, 1);
            dgvExcel.Columns[1].Name = excelOriginal.GetCellValueAsString(1, 2);
            dgvExcel.Columns[2].Name = excelOriginal.GetCellValueAsString(1, 3);
            while (!String.IsNullOrEmpty(excelOriginal.GetCellValueAsString(iRow, 1)))
            {
                string dni = excelOriginal.GetCellValueAsString(iRow, 1);
                string nombreApellido = excelOriginal.GetCellValueAsString(iRow, 2);
                double horas = excelOriginal.GetCellValueAsDouble(iRow, 3);

                //PASAJE A MAYUSCULAS DEL NOMBRE Y APELLIDO
                nombreApellido = pasarMayuscula(nombreApellido);

                string[] vector = { dni, nombreApellido, horas.ToString() };
                
                dgvExcel.Rows.Add(vector);
                iRow++;
            }
        }

        private string pasarMayuscula(String nombreApellido)
        {
            nombreApellido = nombreApellido.UpperFirstChar();

            return nombreApellido;
        }

        private void crearCopia()
        {
            excelCopia = new SLDocument();
            int iR = 0;
            foreach (DataGridViewRow row in dgvExcel.Rows)
            {
                excelCopia.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                excelCopia.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                excelCopia.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                iR++;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savePath = saveFileDialog1.FileName;
            }

            crearCopia();
            excelCopia.SaveAs(savePath);
            MessageBox.Show("Se guardó con exito!");
        }


        //PANEL PARA MOVER FORM
        private void topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                recursos.MoverForm.MoverFrm(this);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Boton Maximizar
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;
            }
            btnRest.Visible = true;
            btnMax.Visible = false;
        }

        

        //Boton Minimazar
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton Restaurar
        private void btnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMax.Visible = true;
        }  

        


    }
}
