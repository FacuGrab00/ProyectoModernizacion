using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpreadsheetLight;

namespace ProyectoModernizacion
{
    public partial class FormRegistros : Form
    {
        public FormRegistros()
        {
            InitializeComponent();
        }

        FormTabla tabla = null;
        List<Registro> registros = new List<Registro>();
        List<Registro> registrosProcesados = new List<Registro>();
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "ExcelProcesado.xlsx";


        //RECIBIMOS LA INSTANCIA DE TABLA
        public FormTabla Tabla { set => tabla = value; }
        public List<Registro> getRegistros()
        {
            return registrosProcesados;
        }
       

        //GENERAMOS UNA LISTA CON LOS REGISTROS PARA MANIPULARLOS
        public void GenerarRegistros()
        {
            //INSTANCIAMOS EL EXCEL PRINCIPAL
            SLDocument excelPrincipal = new SLDocument(new ManejadorExcel().MainPath);
            Registro registro;
            int iRow = 2;
            if(excelPrincipal != null)
            {
                while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(iRow, 1)))
                {
                    string id = excelPrincipal.GetCellValueAsString(iRow, 1);
                    string nombre = excelPrincipal.GetCellValueAsString(iRow, 2);
                    DateTime hora = Convert.ToDateTime(excelPrincipal.GetCellValueAsString(iRow, 3));
                    string estado = excelPrincipal.GetCellValueAsString(iRow, 4);
                    registro = new Registro(id, nombre, hora, estado);
                    registros.Add(registro);
                    iRow++;
                }
            }
        }

        //PROCESAR REGISTROS
        public void ProcesarRegistros()
        {
            Registro regActual;
            Registro regAnterior;
            TimeSpan hora;
            for (int i = 1; i < registros.Count; i++)
            {
                regActual = registros[i];
                regAnterior = registros[i-1];
                if (CasoComun(regActual, regAnterior))
                {
                    hora = regActual.Horario - regAnterior.Horario;
                    regActual.Horas = hora;
                    registrosProcesados.Add(regActual);
                }
            }
        }

        //VOLCAMOS LOS REGISTROS AL DGV
        public void VolcarRegistros()
        {
            string[] vector = new string[3];
            dgvExcel.ColumnCount = 3;
            dgvExcel.Columns[0].HeaderText = "ID de persona";
            dgvExcel.Columns[1].HeaderText = "Nombre";
            dgvExcel.Columns[2].HeaderText = "Tiempo Trabajado";

            foreach (Registro registro in registrosProcesados)
            {
                vector[0] = registro.ID;
                vector[1] = registro.Nombre;
                vector[2] = registro.Horas.ToString();
                dgvExcel.Rows.Add(vector);
            }
        }

        private bool CasoComun(Registro regActual, Registro regAnterior)
        {
            bool bandera = false;
            if (regActual.ID.Equals(regAnterior.ID))
            {
                if (regActual.Horario.Day.Equals(regAnterior.Horario.Day))
                {
                    if (regActual.Estado == "Registro de salida" && regAnterior.Estado == "Registro de entrada")
                    {
                        bandera = true;
                    }
                }
            }

            return bandera;
        }

        public void GenerarExcelProcesado()
        {
            //GENERAMOS UNA INSTANCIA DEL EXCEL PRINCIPAL
            SLDocument excelProcesado = new SLDocument();

            //INDICES (RECORDAR: EXCEL EMPIEZA A CONTAR FILAS Y COLUMNAS A PARTIR DEL "1" Y NO DEL "0")
            int iR = 2;
            int iC = 1;

            //RECORREMOS LAS COLUMNAS DEL DGV Y LAS CARGARMOS EN EL EXCEL
            foreach (DataGridViewColumn column in dgvExcel.Columns)
            {
                excelProcesado.SetCellValue(1, iC, column.HeaderText.ToString());
                iC++;
            }

            //RECORREMOS EL DGV PARA CARGAR LOS DATOS EN EL EXCEL PRINCIPAL
            foreach (DataGridViewRow row in dgvExcel.Rows) //ARRANCAMOS RECORRIENDO POR FILAS
            {
                iC = 1;
                foreach (DataGridViewColumn column in dgvExcel.Columns) //RECORREMOS LAS COLUMNAS
                {
                    excelProcesado.SetCellValue(iR, iC, row.Cells[iC - 1].Value.ToString()); //CARGAMOS LOS REGISTROS EN EL EXCEL
                    iC++;
                }
                iR++;
            }

            //AUTOGUARDA EL EXCEL PRINCIPAL EN LA UBICACIÓN DE ESTE PROYECTO.
            excelProcesado.SaveAs(mainPath);
        }
    }

}
