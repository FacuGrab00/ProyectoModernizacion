using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpreadsheetLight;
using System.IO;

namespace ProyectoModernizacion
{
    public partial class FormTabla : Form
    {
        public FormTabla()
        {
            InitializeComponent();
        }
        
        //INSTANCIA QUE MANEJA EL EXCEL PRINCIPAL
        SLDocument excelPrincipal;

        //DIRECCIONES
        string filePath = "";
        string savePath = "";
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "ExcelPrincipal.xlsx";
        bool loadedColumns = false;
        int iColumn = 1;

        //GETTERS Y SETTERS
        public string FilePath { get => filePath; set => filePath = value; }
        public string SavePath { get => savePath; set => savePath = value; }

        //CARGADO DEL FORMULARIO
        private void FormTabla_Load(object sender, EventArgs e)
        {
            //CARGA EL EXCEL PRINCIPAL EN CASO DE HABER EXISTIDO UN PRIMER EXCEL IMPORTADO.
            if (Directory.Exists(mainPath))
            {
                cargarExcel();
            }
        }

        public void importarExcel()
        {
            //CREAMOS UNA INSTANCIA PARA MANEJAR EL EXCEL IMPORTADO
            SLDocument excelImportado = new SLDocument(filePath);

            //INDICE FILAS
            int iRow = 2;

            //INSTANCIA PARA MANEJAR LAS COLUMNAS DE DGV
            DataGridViewTextBoxColumn columna;

            //DETECTA LAS COLUMNAS DEL EXCEL Y LAS GENERO EN EL DGV
            while (!String.IsNullOrEmpty(excelImportado.GetCellValueAsString(1, iColumn)) && loadedColumns == false)
            {
                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = excelImportado.GetCellValueAsString(1, iColumn);
                dgvExcel.Columns.Add(columna);
                iColumn++;
            }

            //SE HA IMPORTADO UN PRIMER EXCEL POR ENDE NO ES NECESARIO VOLVER A CARGAR LAS COLUMNAS
            loadedColumns = true;

            //DETECTA LAS FILAS DEL EXCEL Y LAS CARGO AL DGV
            while (!String.IsNullOrEmpty(excelImportado.GetCellValueAsString(iRow, 1)))
            {
                string[] vector = new string[iColumn];
                for (int i = 0; i < iColumn; i++)
                {
                    vector[i] = excelImportado.GetCellValueAsString(iRow, i + 1);
                }
                dgvExcel.Rows.Add(vector);
                iRow++;
            }
        }

        private void cargarExcel()
        {
            //INSTANCIAMOS EL EXCEL PRINCIPAL
            excelPrincipal = new SLDocument(mainPath);

            int iRow = 2;

            DataGridViewTextBoxColumn columna;

            while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(1, iColumn)) && loadedColumns == false)
            {
                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = excelPrincipal.GetCellValueAsString(1, iColumn);
                dgvExcel.Columns.Add(columna);
                iColumn++;
            }

            //SE HA IMPORTADO UN PRIMER EXCEL POR ENDE NO ES NECESARIO VOLVER A CARGAR LAS COLUMNAS
            loadedColumns = true;

            while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(iRow, 1)))
            {
                string[] vector = new string[iColumn];
                for (int i = 0; i < iColumn; i++)
                {
                    vector[i] = excelPrincipal.GetCellValueAsString(iRow, i + 1);
                }
                dgvExcel.Rows.Add(vector);
                iRow++;
            }
        }

        //CREA UNA COPIA DE LOS REGISTROS DEL EXCEL IMPORTADO AL EXCEL PRINCIPAL.
        public void crearCopia()
        {
            //GENERAMOS UNA INSTANCIA DEL EXCEL PRINCIPAL
            excelPrincipal = new SLDocument();
            int iR = 0;

            //RECORREMOS EL DGV PARA CARGAR LOS DATOS EN EL EXCEL PRINCIPAL
            foreach (DataGridViewRow row in dgvExcel.Rows)
            {
                excelPrincipal.SetCellValue(iR, 1, row.Cells[0].Value.ToString());
                excelPrincipal.SetCellValue(iR, 2, row.Cells[1].Value.ToString());
                excelPrincipal.SetCellValue(iR, 3, row.Cells[2].Value.ToString());
                iR++;
            }

            //AUTOGUARDA EL EXCEL PRINCIPAL EN LA UBICACIÓN DE ESTE PROYECTO
            excelPrincipal.SaveAs(mainPath);
        }

        //PERMITE GUARDAR EL EXCEL PRINCIPAL.
        public void exportarExcel()
        {
            excelPrincipal.SaveAs(savePath);    
        }

    }
}
