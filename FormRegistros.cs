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

        ManejadorExcel manejadorExcel;
        List<Registro> registrosProcesados = new List<Registro>();
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "ExcelProcesado.xlsx";

        //RECIBIMOS LA INSTANCIA DE TABLA
        public List<Registro> getRegistros()
        {
            return registrosProcesados;
        }

        //PROCESAR REGISTROS
        public void ProcesarRegistros()
        {
            manejadorExcel = new ManejadorExcel();
            Registro regActual;
            Registro regAnterior;
            TimeSpan hora;
            for (int i = 1; i < manejadorExcel.Registros.Count; i++)
            {
                regActual = manejadorExcel.Registros[i];
                regAnterior = manejadorExcel.Registros[i-1];
                if (CasoComun(regActual, regAnterior))
                {
                    hora = regActual.Horario - regAnterior.Horario;
                    regActual.Horas = hora;
                    registrosProcesados.Add(regActual);
                }

                if (CasoDobleSalida(regActual, regAnterior))
                {
                    regActual.Observacion = "No se marcó la entrada";
                    regActual.Horas = TimeSpan.Zero;
                    registrosProcesados.Add(regActual);
                }

                if(CasoDobleEntrada(regActual, regAnterior))
                {
                    regActual = manejadorExcel.Registros[i+1];
                    if (CasoComun(regActual, regAnterior))
                    {
                        hora = regActual.Horario - regAnterior.Horario;
                        regActual.Horas = hora;
                        registrosProcesados.Add(regActual);
                        i++;
                    }
                    else
                    {
                        regActual.Observacion = "No se marcó la Salida";
                        regActual.Horas = TimeSpan.Zero;
                        registrosProcesados.Add(regActual);
                    }
                }
            }
        }
        
        //VOLCAMOS LOS REGISTROS AL DGV
        public void VolcarRegistros()
        {
            ProcesarRegistros();
            dgvExcel.DataSource = registrosProcesados;
            manejadorExcel.ExportarExcel(mainPath, dgvExcel);
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

        private bool CasoDobleEntrada(Registro regActual, Registro regAnterior)
        {
            bool bandera = false;
            if (regActual.ID.Equals(regAnterior.ID))
            {
                if (regActual.Horario.Day.Equals(regAnterior.Horario.Day))
                {
                    if (regActual.Estado == "Registro de entrada" && regAnterior.Estado == "Registro de entrada")
                    {
                        bandera = true;
                    }
                }
            }
            return bandera;
        }

        private bool CasoDobleSalida(Registro regActual, Registro regAnterior)
        {
            bool bandera = false;
            if (regActual.ID.Equals(regAnterior.ID))
            {
                if (!regActual.Horario.Day.Equals(regAnterior.Horario.Day))
                {
                    if (regActual.Estado == "Registro de salida" && regAnterior.Estado == "Registro de salida")
                    {
                        bandera = true;
                    }
                }
            }
            return bandera;
        }

        
    }

}
