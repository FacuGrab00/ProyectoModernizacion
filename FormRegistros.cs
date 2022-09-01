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

        FormTabla tabla;
        List<Registro> registros = new List<Registro>();
        List<Registro> registrosProcesados = new List<Registro>();

        //RECIBIMOS LA INSTANCIA DE TABLA
        public FormTabla Tabla { set => tabla = value; }
        
        //GENERAMOS UNA LISTA CON LOS REGISTROS PARA MANIPULARLOS
        public void CargarDatos()
        {
            //INSTANCIAMOS EL EXCEL PRINCIPAL
            SLDocument excelPrincipal = tabla.ExcelPrincipal;
            Registro registro;
            int iRow = 2;
            if(excelPrincipal != null)
            {
                while (!String.IsNullOrEmpty(excelPrincipal.GetCellValueAsString(iRow, 1)))
                {
                    int id = excelPrincipal.GetCellValueAsInt32(iRow, 1);
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
            for (int i = 1; i < registros.Count; i++)
            {
                Registro regActual = registros[i];
                Registro regAnterior = registros[i-1];
                TimeSpan hora = TimeSpan.Zero;
                if (CasoComun(regActual, regAnterior))
                {
                    hora = regActual.Horario - regAnterior.Horario;
                }

                if(hora != TimeSpan.Zero)
                {
                    regActual.Horas = hora;
                    registrosProcesados.Add(regActual);
                }
            }
        }

        private void CargarRegistros()
        {

        }

        private bool CasoComun(Registro regActual, Registro regAnterior)
        {
            bool bandera = false;
            if (regActual.ID == regAnterior.ID)
            {
                if (regActual.Horario.Day == regAnterior.Horario.Day)
                {
                    if (regActual.Estado == "Registro de salida" && regAnterior.Estado == "Registro de entrada")
                    {
                        bandera = true;
                    }
                }
            }

            return bandera;
        }
    }

}
