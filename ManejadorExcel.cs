using System;
using System.Collections.Generic;
using System.Text;
using SpreadsheetLight;
using System.Windows.Forms;
using System.IO;

namespace ProyectoModernizacion
{
    class ManejadorExcel
    {
        //ATRIBUTOS
        SLDocument excelPrincipal = null;   //INSTANCIA QUE MANEJA EL EXCEL PRINCIPAL.
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "ExcelPrincipal.xlsx"; //DIRECCION DEL HISTORIAL DE TRABAJO.
        int iColumn = 1;    //INDICE DE LA CANTIDAD DE COLUMNAS QUE MANEJA EL ARCHIVO EXCEL.
        List<Registro> registros = new List<Registro>();    //LISTA DE REGISTROS PARA MANIPULAR.
        List<String> columnas = new List<string>();     //LISTA DE COLUMNAS
        bool loadedColumns = false; //BANDERA ME INDICA SI YA SE CARGARON LAS COLUMNAS

        public ManejadorExcel()
        {
            //CARGA EL EXCEL PRINCIPAL EN CASO DE HABER EXISTIDO UN PRIMER EXCEL IMPORTADO.
            if (File.Exists(mainPath))
                ImportarExcel();
        }

        
        //GETTERS Y SETTERS
        public string MainPath { get => mainPath; }
        public List<Registro> Registros { get => registros; }
        public List<String> Columnas { get => columnas; }

        //METODOS
        public void ImportarExcel(string filePath)
        {
            //CREAMOS UNA INSTANCIA PARA MANEJAR EL EXCEL IMPORTADO
            excelPrincipal = new SLDocument(filePath);
            GenerarRegistros(1);
            AutoGuardado();
        }

        private void ImportarExcel()
        {
            //CREAMOS UNA INSTANCIA PARA MANEJAR EL EXCEL IMPORTADO
            excelPrincipal = new SLDocument(mainPath);
            GenerarRegistros(1);
        }

        public void ExportarExcel(string savePath, DataGridView dgvExcel)
        {
            VolcarGridAlExcel(dgvExcel);
            excelPrincipal.SaveAs(savePath);
        }

        //REALIZA UN VOLCADO DE LOS DATOS DEL EXCEL A LOS REGISTROS.
        private void GenerarRegistros(int inicioDeExcel)
        {
            //INDICE FILAS
            int iRow = 2;

            //DETECTA LAS COLUMNAS DEL EXCEL Y LAS CARGA EN LA LISTA DE COLUMNAS
            while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(inicioDeExcel, iColumn)) && loadedColumns == false)
            {
                columnas.Add(excelPrincipal.GetCellValueAsString(inicioDeExcel, iColumn));
                iColumn++;
            }

            //SE HA IMPORTADO UN PRIMER EXCEL POR ENDE NO ES NECESARIO VOLVER A CARGAR LAS COLUMNAS
            loadedColumns = true;

            Registro registro;

            //DETECTA LAS FILAS DEL EXCEL Y LAS CARGO A LA LISTA DE REGISTROS
            while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(iRow, 1)))
            {
                string id = excelPrincipal.GetCellValueAsString(iRow, 1);
                string nombre = excelPrincipal.GetCellValueAsString(iRow, 2);
<<<<<<< HEAD
                DateTime horario = Convert.ToDateTime(excelPrincipal.GetCellValueAsDateTime(iRow, 3));
=======
                DateTime horario = excelPrincipal.GetCellValueAsDateTime(iRow, 3);
>>>>>>> 912f8b597eed97f15eabd4b73e3d832862a97e1a
                string estado = excelPrincipal.GetCellValueAsString(iRow, 4);
                registro = new Registro(id, nombre, horario, estado);
                registros.Add(registro);
                iRow++;
            }
        }

        //ESTE MÉTODO DEBE EXISTIR DEBIDO A UN ERROR EN LA LIBRERIA SPREEDSHEETLIGHT, EL CUAL NO ME PERMITE IMPORTAR Y GUARDAR UNA MISMA INSTANCIA.
        public void AutoGuardado()
        {
            //GENERAMOS UNA INSTANCIA DEL EXCEL PRINCIPAL
            excelPrincipal = new SLDocument();

            //INDICES (RECORDAR: EXCEL EMPIEZA A CONTAR FILAS Y COLUMNAS A PARTIR DEL "1" Y NO DEL "0")
            int iR = 2;
            int iC = 1;

            //RECORREMOS LAS COLUMNAS DE LA LISTA Y LAS CARGARMOS EN EL EXCEL
            foreach (string columna in columnas)
            {
                excelPrincipal.SetCellValue(1, iC, columna);
                iC++;
            }

            //RECORREMOS LOS REGISTROS DE LA LISTA DE REGISTROS PARA CARGAR LOS DATOS EN EL EXCEL
            foreach (Registro registro in registros)
            {
                excelPrincipal.SetCellValue(iR,1, registro.ID);
                excelPrincipal.SetCellValue(iR, 2, registro.Nombre);
                excelPrincipal.SetCellValue(iR, 3, registro.Horario.ToString("yyyy/MM/dd HH:mm:ss"));
                excelPrincipal.SetCellValue(iR, 4, registro.Estado);

                iR++;
            }

            excelPrincipal.SaveAs(mainPath);
        }

        private void VolcarGridAlExcel(DataGridView dgvExcel)
        {
            //INDICES (RECORDAR: EXCEL EMPIEZA A CONTAR FILAS Y COLUMNAS A PARTIR DEL "1" Y NO DEL "0")
            int iR = 2;
            int iC = 1;

            excelPrincipal = new SLDocument();

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
                    excelPrincipal.SetCellValue(iR, iC, row.Cells[iC - 1].Value.ToString()); //CARGAMOS LOS REGISTROS EN EL EXCEL
                    iC++;
                }
                iR++;
            }
        }

    }//FIN CLASE
}
