using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoModernizacion
{
    public class Registro
    {
        string id;
        DateTime horario;
        string nombre;
        string estado;
        TimeSpan horas;
        string observacion = "";

        public Registro(string id, string nombre, DateTime horario, string estado)
        {
            this.id = id;
            this.horario = horario;
            this.nombre = nombre;
            this.estado = estado;
        }

        public Registro(string id, string nombre, DateTime horario, TimeSpan horas)
        {
            this.id = id;
            this.horario = horario;
            this.nombre = nombre;
            this.horas = horas;
        }

        public string ID { get => id; }
        public DateTime Horario { get => horario; }
        public string Nombre { get => nombre; }
        public string Estado { get => estado; }
        public TimeSpan Horas { get => horas; set => horas = value; }
        public string Observacion { get => observacion; set => observacion = value; }
    }
}
