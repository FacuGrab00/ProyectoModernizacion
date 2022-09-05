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
            Procesar_Registros();
        }

        ManejadorExcel manejadorExcel;
        List<Registro> registrosProcesados;
        string mainPath = AppDomain.CurrentDomain.BaseDirectory + "ExcelProcesado.xlsx";

        //RECIBIMOS LA INSTANCIA DE TABLA
        public List<Registro> getRegistros()
        {
            return registrosProcesados;
        }

        //PROCESAR REGISTROS ALGORTIMO 1: ESTE ALGORITMO UTILIZA UN SOLO INDICE "i" QUE EMPIEZA A RECORRER DESDE EL SEGUNDO INDICE, CONTROLANDOSE CON SU ANTERIOR "i-1"
        //NO HAY CERTEZA DE QUE CONTEMPLE TODOS LOS CASOS
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ProcesarRegistros()
        {
            manejadorExcel = new ManejadorExcel();
            Registro regActual;
            Registro regAnterior;
            for (int i = 1; i < manejadorExcel.Registros.Count; i++)
            {
                regActual = manejadorExcel.Registros[i];
                regAnterior = manejadorExcel.Registros[i-1];
                if (CasoComun(regActual, regAnterior))
                {
                    regActual.Horas = regActual.Horario - regAnterior.Horario;
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
                        regActual.Horas = regActual.Horario - regAnterior.Horario;
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
        
        //EL USUARIO MARCO CORRECTAMENTE LA ENTRADA Y LA SALIDA
        private bool CasoComun(Registro regActual, Registro regAnterior)
        {
            bool bandera = false;
            if (regActual.ID.Equals(regAnterior.ID))
                if (regActual.Horario.Day.Equals(regAnterior.Horario.Day))
                    if (regActual.Estado == "Registro de salida" && regAnterior.Estado == "Registro de entrada")
                        bandera = true;
            return bandera;
        }

        //EL USUARIO MARCÓ DOS VECES LA ENTRADA
        private bool CasoDobleEntrada(Registro regActual, Registro regAnterior)
        {
            bool bandera = false;
            if (regActual.ID.Equals(regAnterior.ID))
                if (regActual.Horario.Day.Equals(regAnterior.Horario.Day))
                    if (regActual.Estado == "Registro de entrada" && regAnterior.Estado == "Registro de entrada")
                        bandera = true;
            return bandera;
        }

        //EL USUARIO MARCÓ LA SALIDA
        private bool CasoDobleSalida(Registro regActual, Registro regAnterior)
        {
            bool bandera = false;
            if (regActual.ID.Equals(regAnterior.ID))
                if (!regActual.Horario.Day.Equals(regAnterior.Horario.Day))
                    if (regActual.Estado == "Registro de salida" && regAnterior.Estado == "Registro de salida")
                        bandera = true;
            return bandera;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //PROCESAR REGISTROS ALGORITMO 2: ESTE ALGORITMO UTILIZA DOS INDICES "i" QUE EMPIEZA EN EL PRIMER REGISTRO Y "j" QUE APUNTA AL SIGUIENTE REGISTRO
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Procesar_Registros()
        {
            manejadorExcel = new ManejadorExcel();
            registrosProcesados = new List<Registro>();
            int i = 0;
            int j = i + 1;
            Registro regActual;
            Registro regSiguiente;

            while(i < manejadorExcel.Registros.Count)
            {
                regActual = manejadorExcel.Registros[i];    //regActual ARRANCA SIENDO EL PRIMER REGISTRO DE LA LISTA

                if (j >= manejadorExcel.Registros.Count)
                {
                    //EL regSiguiente APUNTA AL ULTIMO REGISTRO DE LA LISTA
                    regActual.Observacion = "No se marcó  la salida";
                    registrosProcesados.Add(regActual);
                    i++;
                }

                while (j < manejadorExcel.Registros.Count)
                {
                    regSiguiente = manejadorExcel.Registros[j];     //regSiguiente ES EL REGISTRO SIGUIENTE DE regActual

                    //EL USUARIO MARCÓ ENTRADA Y SALIDA
                    if (CasoCorrecto(regActual, regSiguiente))
                    {
                        regActual.Horas = regSiguiente.Horario - regActual.Horario;
                        registrosProcesados.Add(regActual);
                        i = j + 1; j = i + 1;
                        break;
                    }

                    //EL USUARIO NO REGISTRÓ LA ENTRADA
                    if (SinMarcarEntrada(regActual))
                    {
                        regActual.Observacion = "No se marcó la entrada";
                        registrosProcesados.Add(regActual);
                        i++; j++;
                        break;
                    }

                    //EL USUARIO REGISTRÓ MAS DE UNA ENTRADA
                    if (DobleEntrada(regActual, regSiguiente))
                    {
                        j++;
                        break;
                    }

                    //EL USUARIO NO MARCÓ LA SALIDA
                    if (SinMarcarSalida(regActual, regSiguiente))
                    {
                        regActual.Observacion = "No se marcó la salida";
                        registrosProcesados.Add(regActual);
                        i = j; j++;
                        break;
                    }
                }
            }
        }

        private bool CasoCorrecto(Registro regActual, Registro regSiguiente)
        {
            bool bandera = false;
            //EN CASO DE QUE EL USUARIO MARCÓ LA ENTRADA Y SALIDA SE DEBE CUMPLIR QUE
            if (regActual.ID.Equals(regSiguiente.ID))   //EL ID REGISTRANTE ES IGUAL AL SIGUIENTE ID REGISTRANTE
                if (regActual.Horario.Day.Equals(regSiguiente.Horario.Day))     //LOS DIAS COINCIDEN
                    if (regActual.Estado == "Registro de entrada" && regSiguiente.Estado == "Registro de salida")   //EL USUARIO MARCÓ PRIMERO ENTRADA Y LUEGO SALIDA
                        bandera = true;
            return bandera;
        }

        private bool SinMarcarEntrada(Registro regActual)
        {
            bool bandera = false;
            //EN CASO DE QUE EL USUARIO NO MARCÓ LA SALIDA SE DEBE CUMPLIR QUE
            if(regActual.Estado == "Registro de salida") //EL ID REGISTRANTE MARCÓ SALIDA (EL RECORRIDO SIEMPRE ARRANCA CON UNA MARCA DE ENTRADA)
                bandera = true;
            return bandera;
        }

        private bool DobleEntrada(Registro regActual, Registro regSiguiente)
        {
            bool bandera = false;
            //EN CASO DE QUE EL USUARIO MARCÓ DOS VECES LA ENTRADA SE DEBE CUMPLIR QUE
            if (regActual.ID.Equals(regSiguiente.ID))   //EL ID REGISTRANTE ES IGUAL AL SIGUIENTE ID REGISTRANTE
                if (regActual.Horario.Day.Equals(regSiguiente.Horario.Day))     //LOS DIAS COINCIDEN
                    if (regActual.Estado == "Registro de entrada" && regSiguiente.Estado == "Registro de entrada")  //EL USUARIO MARCÓ PRIMERO ENTRADA Y LUEGO ENTRADA NUEVAMENTE
                        bandera = true;
            return bandera;
        }

        private bool SinMarcarSalida(Registro regActual, Registro regSiguiente)
        {
            bool bandera = false;
            //EN CASO DE QUE EL USUARIO NO HAYA MARCADO LA SALIDA SE DEBE CUMPLIR UNO DE LOS SIGUIENTES CASOS

            //EL ID REGISTRANTE NO COINCIDE CON EL ID REGISTRANTE SIGUIENTE, ES DECIR LA SIGUIENTE MARCA CORRESPONDE A OTRA PERSONA
            if (!regActual.ID.Equals(regSiguiente.ID))
                bandera = true;

            //EL ID REGISTRANTE COINCIDE CON EL ID REGISTRANTE SIGUIENTE
            if (regActual.ID.Equals(regSiguiente.ID))
                if (!regActual.Horario.Day.Equals(regSiguiente.Horario.Day)) //LOS DIAS NO COINCIDEN
                    bandera = true;
            return bandera;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //VOLCAMOS LOS REGISTROS PROCESADOS AL DGV
        public void VolcarRegistros()
        {
            Procesar_Registros();
            dgvExcel.DataSource = registrosProcesados;
            manejadorExcel.ExportarExcel(mainPath, dgvExcel);
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            dgvExcel.DataSource = registrosProcesados;
        }
    }//FIN CLASE

}
