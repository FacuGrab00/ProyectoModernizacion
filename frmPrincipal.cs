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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        string filePath = "";
        string savePath = "";
        SLDocument excelImportado;
        SLDocument excelPrincipal;

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //MENSAJE DE ADVERTENCIA
            MessageBox.Show("IMPORTANTE: Al momento de importar el EXCEL, Asegurese que las COLUMNAS se encuentran en la FILA 1 y no hay ESPACIOS en blanco entre las FILAS");

            //ABRIMOS LA VENTANA DE BUSQUEDA PARA IMPORTAR EL EXCEL
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //GUARDAMOS LA DIRECCIÓN DEL EXCEL A IMPORTAR
                    filePath = openFileDialog1.FileName;
                    //using (Stream str = openFileDialog1.OpenFile()){Process.Start("notepad.exe", filePath);}
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }

                //REALIZAMOS LA LECTURA DEL EXCEL
                leerExcel();
            }
        }

        //FUNCIÓN DE LECTURA DE EXCEL
        private void leerExcel()
        {
            //CREAMOS UNA INSTANCIA DE SLDOCUMENT (OBJETO DE LA LIBRERIA SPREADSHEETLIGHT)
            excelImportado = new SLDocument(filePath);

            //INDICE FILAS
            int iRow = 2;
            //INDICE COLUMNAS
            int iColumn = 1;

            //ATRIBUTO TIPO COLUMNA
            DataGridViewTextBoxColumn columna;

            //DETECTO LAS COLUMNAS DEL EXCEL Y LAS GENERO EN EL DTG
            while (!String.IsNullOrEmpty(excelImportado.GetCellValueAsString(1, iColumn)))
            {
                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = excelImportado.GetCellValueAsString(1, iColumn);
                dgvExcel.Columns.Add(columna);
                iColumn++;
            }
            
            //DETECTO LAS FILAS DEL EXCEL Y LAS CARGO AL DTG
            while (!String.IsNullOrEmpty(excelImportado.GetCellValueAsString(iRow, 1)))
            {
                string[] vector = new string[iColumn];
                for (int i = 0; i < iColumn; i++)
                {
                    vector[i] = excelImportado.GetCellValueAsString(iRow, i+1);
                }
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
            excelPrincipal = new SLDocument();
            int iR = 0;
            foreach (DataGridViewRow row in dgvExcel.Rows)
            {
                excelPrincipal.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                excelPrincipal.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                excelPrincipal.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
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
            excelPrincipal.SaveAs(savePath);
            MessageBox.Show("Se guardó con exito!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
