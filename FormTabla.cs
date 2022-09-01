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
        SLDocument excelPrincipal = null;

        //DIRECCIONES
        string filePath = "";
        string savePath = "";
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "ExcelPrincipal.xlsx";
        bool loadedColumns = false;
        int iColumn = 1;

        //GETTERS Y SETTERS
        public string FilePath { get => filePath; set => filePath = value; }
        public string SavePath { get => savePath; set => savePath = value; }
        public SLDocument ExcelPrincipal { get => excelPrincipal; set => excelPrincipal = value; }

        //CARGADO DEL FORMULARIO
        private void FormTabla_Load(object sender, EventArgs e)
        {
            //CARGA EL EXCEL PRINCIPAL EN CASO DE HABER EXISTIDO UN PRIMER EXCEL IMPORTADO.
            if (File.Exists(mainPath))
            {
                CargarExcel();
            }
        }

        //IMPORTA LOS EXCEL, EN CASO DE ESTAR TRABAJANDO CON UNO LO ADJUNTA EN LAS ULTIMAS FILAS.
        public void ImportarExcel()
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

        private void CargarExcel()
        {
            //INSTANCIAMOS EL EXCEL PRINCIPAL
            excelPrincipal = new SLDocument(mainPath);

            VolcarExcel(excelPrincipal);
            /*
            //INDICE DE LAS FILAS DEL EXCEL (FILA 1: TITULOS, FILA 2: REGISTROS)
            int iRow = 2;

            //OBJETO DE TIPO COLUMNAS DE DGV
            DataGridViewTextBoxColumn columna;

            //RECORREMOS EL EXCEL HASTA QUE ENCONTREMOS COLUMNAS VACIAS
            while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(1, iColumn)) && loadedColumns == false)
            {
                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = excelPrincipal.GetCellValueAsString(1, iColumn); //OBTENEMOS EL TITULO DE LA COLUMNA
                dgvExcel.Columns.Add(columna); //LA CARGAMOS EN EL GRID
                iColumn++;
            }

            //SE HA IMPORTADO UN PRIMER EXCEL POR ENDE NO ES NECESARIO VOLVER A CARGAR LAS COLUMNAS
            loadedColumns = true;

            //RECORREMOS EL EXCEL HASTA ENCONTRAR FILAS VACIAS
            while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(iRow, 1)))
            {
                //VECTOR SIMULA REGISTRO
                string[] vector = new string[iColumn];

                //RECORREMOS LOS DATOS DEL REGISTRO
                for (int i = 0; i < iColumn; i++)
                {
                    //ALMACENAMOS LOS DATOS
                    vector[i] = excelPrincipal.GetCellValueAsString(iRow, i + 1);
                }

                //CARGAMOS LOS DATOS EN EL DGV
                dgvExcel.Rows.Add(vector);
                iRow++;
            }
            */
        }

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
