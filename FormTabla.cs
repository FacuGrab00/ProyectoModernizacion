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

            if (File.Exists(mainPath))
                excelPrincipal = new SLDocument(mainPath);
        }
        
        //INSTANCIA QUE MANEJA EL EXCEL PRINCIPAL
        SLDocument excelPrincipal = null;

        //DIRECCIONES
        string filePath = "";
        string savePath = "";
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "ExcelPrincipal.xlsx";

        //BANDERA: CONTROLA SI LAS COLUMNAS DEL GRID YA FUERON CARGADAS
        bool loadedColumns = false;

        //ME INDICA LA CANTIDAD DE COLUMNAS QUE MANEJA EL ARCHIVO EXCEL
        int iColumn = 1;

        //GETTERS Y SETTERS
        public string FilePath { get => filePath; set => filePath = value; }
        public string SavePath { get => savePath; set => savePath = value; }
        public string MainPath { get => mainPath;}
        public SLDocument ExcelPrincipal { get => excelPrincipal; set => excelPrincipal = value; }
        public SLDocument getExcelPrincipal()
        {
            return excelPrincipal;
        }

        //CARGADO DEL FORMULARIO
        private void FormTabla_Load(object sender, EventArgs e)
        {
            //CARGA EL EXCEL PRINCIPAL EN CASO DE HABER EXISTIDO UN PRIMER EXCEL IMPORTADO.
            if (File.Exists(mainPath))
                CargarExcel();
        }

        //IMPORTA LOS EXCEL, EN CASO DE ESTAR TRABAJANDO CON UNO LO ADJUNTA EN LAS ULTIMAS FILAS.
        public void ImportarExcel()
        {
            //CREAMOS UNA INSTANCIA PARA MANEJAR EL EXCEL IMPORTADO
            SLDocument excelImportado = new SLDocument(filePath);
            VolcarExcel(excelImportado);
        }

        private void CargarExcel()
        {
            //INSTANCIAMOS EL EXCEL PRINCIPAL
            excelPrincipal = new SLDocument(mainPath);
            VolcarExcel(excelPrincipal);
        }

        //REALIZA UN VOLCADO DE LOS DATOS DEL EXCEL AL DGV
        private void VolcarExcel(SLDocument excel)
        {
            //INDICE FILAS
            int iRow = 2;

            //INSTANCIA PARA MANEJAR LAS COLUMNAS DE DGV
            DataGridViewTextBoxColumn columna;

            //DETECTA LAS COLUMNAS DEL EXCEL Y LAS GENERO EN EL DGV
            while (!String.IsNullOrEmpty(excel.GetCellValueAsString(1, iColumn)) && loadedColumns == false)
            {
                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = excel.GetCellValueAsString(1, iColumn);
                dgvExcel.Columns.Add(columna);
                iColumn++;
            }

            //SE HA IMPORTADO UN PRIMER EXCEL POR ENDE NO ES NECESARIO VOLVER A CARGAR LAS COLUMNAS
            loadedColumns = true;

            //DETECTA LAS FILAS DEL EXCEL Y LAS CARGO AL DGV
            while (!String.IsNullOrEmpty(excel.GetCellValueAsString(iRow, 1)))
            {
                string[] vector = new string[iColumn];
                for (int i = 0; i < iColumn; i++)
                {
                    vector[i] = excel.GetCellValueAsString(iRow, i + 1);
                }
                dgvExcel.Rows.Add(vector);
                iRow++;
            }
        }

        //CREA UNA COPIA DE LOS REGISTROS DEL EXCEL IMPORTADO AL EXCEL PRINCIPAL.
        public void CrearCopia()
        {
            //GENERAMOS UNA INSTANCIA DEL EXCEL PRINCIPAL
            excelPrincipal = new SLDocument();

            //INDICES (RECORDAR: EXCEL EMPIEZA A CONTAR FILAS Y COLUMNAS A PARTIR DEL "1" Y NO DEL "0")
            int iR = 2;
            int iC = 1;

            //RECORREMOS LAS COLUMNAS DEL DGV Y LAS CARGARMOS EN EL EXCEL
            foreach (DataGridViewColumn column in dgvExcel.Columns)
            {
                excelPrincipal.SetCellValue(1, iC, column.HeaderText.ToString());
                iC++;
            }

            //RECORREMOS EL DGV PARA CARGAR LOS DATOS EN EL EXCEL PRINCIPAL
            foreach (DataGridViewRow row in dgvExcel.Rows) //ARRANCAMOS RECORRIENDO POR FILAS
            {
                iC = 1;
                foreach (DataGridViewColumn column in dgvExcel.Columns) //RECORREMOS LAS COLUMNAS
                {
                    excelPrincipal.SetCellValue(iR, iC, row.Cells[iC-1].Value.ToString()); //CARGAMOS LOS REGISTROS EN EL EXCEL
                    iC++;
                }
                iR++;
            }

            //AUTOGUARDA EL EXCEL PRINCIPAL EN LA UBICACIÓN DE ESTE PROYECTO.
            excelPrincipal.SaveAs(mainPath);
        }

        //PERMITE GUARDAR EL EXCEL PRINCIPAL.
        public void ExportarExcel()
        {
            excelPrincipal.SaveAs(savePath);    
        }


    }
}
