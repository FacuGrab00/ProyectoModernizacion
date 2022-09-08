using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ProyectoModernizacion
{
    public partial class frmBuscadorPersonal : Form
    {
        public frmBuscadorPersonal()
        {
            InitializeComponent();
        }

        FormRegistros buscarId;

        //Lista de los registros
        List<Registro> registros = new List<Registro>();
        
        //Lista para guardar los registros de un registro buscado
        readonly List<Registro> registrosUnID = new List<Registro>();

        //creo una nueva lista para guardar los registros por una fecha
        readonly List<Registro> registrosPorFecha = new List<Registro>();

        //Lista para cargar todos los id para el combo box
        readonly List<string> ids = new List<string>();

        public FormRegistros BuscarId { set => buscarId = value; }

        private void marcarFecha()
        {
            DateTime[] fechasTrabajadas = new DateTime[registrosUnID.Count];
            for (int i = 0; i < registrosUnID.Count; i++)
            {
                fechasTrabajadas[i] = registrosUnID[i].Horario;
            }
            calendario.BoldedDates = fechasTrabajadas;
        }

        public int cantidadDiasTrab()
        {
            int contador=0;
            for (int i = 0; i < registrosUnID.Count; i++)
            {
                //Con combobox
                if (registrosUnID[i].ID == cBoxId.Text)
                    contador++;
            }
            return contador;
        }

        //busco el id cuando presiono el boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(dgvBusqId.DataSource != null)
                Limpiar();

            registros = buscarId.RegistrosProcesados;
            string busId = cBoxId.Text;

            for (int i = 0; i < registros.Count; i++)
            {
                if (busId == registros[i].ID)
                    registrosUnID.Add(registros[i]);
            }

            //si contiene elementos muestro en el DataGridview si no muestro un mensaje
            if (registrosUnID.Any())
            {
                //cargo la lista nueva solo con los reg del id buscado
                dgvBusqId.DataSource = null;
                dgvBusqId.DataSource = registrosUnID;

                //Variable para calcular total de horas de un trabajador
                TimeSpan hrsTotales = new TimeSpan();

                //recorro los registros de un id buscado y sumo la cantidad de horas
                for (int i = 0; i < registrosUnID.Count; i++)
                {
                    hrsTotales += registrosUnID[i].Horas;
                }

                string horas = ((int)hrsTotales.TotalHours).ToString();
                string minutos = hrsTotales.ToString("mm");
                string segundos = hrsTotales.ToString("ss");

                //Muestro los datos en los label`s
                lblHrsTrab.Text = horas + ":" + minutos + ":" + segundos;
                lblID.Text = cBoxId.Text;
                lblNomApe.Text = registrosUnID[0].Nombre.ToString();
                
            }
            else
            {
                //Si no encuentra una persona por su id da un msj
                MessageBox.Show("Esta Persona No Se Encuentra");
            }

            //Muestro la cantidad de dias trabajados
            lblDiasTrab.Text = Convert.ToString(cantidadDiasTrab());

            marcarFecha();
        }

        private void CargarRegistro()
        {
            if (dgvBusqId.DataSource != null)
                Limpiar();

            registros = buscarId.RegistrosProcesados;
            string busId = cBoxId.Text;

            for (int i = 0; i < registros.Count; i++)
            {
                if (busId == registros[i].ID)
                    registrosUnID.Add(registros[i]);
            }

            //si contiene elementos muestro en el DataGridview si no muestro un mensaje
            if (registrosUnID.Any())
            {
                //cargo la lista nueva solo con los reg del id buscado
                dgvBusqId.DataSource = null;
                dgvBusqId.DataSource = registrosUnID;

                //Variable para calcular total de horas de un trabajador
                TimeSpan hrsTotales = new TimeSpan();

                //recorro los registros de un id buscado y sumo la cantidad de horas
                for (int i = 0; i < registrosUnID.Count; i++)
                {
                    hrsTotales += registrosUnID[i].Horas;
                }

                string horas = ((int)hrsTotales.TotalHours).ToString();
                string minutos = hrsTotales.ToString("mm");
                string segundos = hrsTotales.ToString("ss");

                //Muestro los datos en los label`s
                lblHrsTrab.Text = horas + ":" + minutos + ":" + segundos;
                lblID.Text = cBoxId.Text;
                lblNomApe.Text = registrosUnID[0].Nombre.ToString();

            }
            else
            {
                //Si no encuentra una persona por su id da un msj
                MessageBox.Show("Esta Persona No Se Encuentra");
            }

            //Muestro la cantidad de dias trabajados
            lblDiasTrab.Text = Convert.ToString(cantidadDiasTrab());

            marcarFecha();
        }

        //Procedimiento para caragar comboBox
        public void cargarComboBox()
        {
            //guardo en result todos los id distintos
            registros = buscarId.RegistrosProcesados;
            List<Registro> listids = new List<Registro>();

            for (int i = 0; i < registros.Count; i++)
            {
                listids.Add(registros[i]);
            }

            var result = (from item in listids select item.ID).Distinct();

            //lleno el comboBox con los id`s
            cBoxId.DataSource = result.ToList();
        }

        private void Limpiar()
        {
            //limpio el DataGridView
            dgvBusqId.Columns.Clear();
            //limpio la lista 
            registrosUnID.Clear();
            //limpio los labels de Datos Personales
            lblDiasTrab.Text = "";
            lblNomApe.Text = "";
            lblID.Text = "";
            lblHrsTrab.Text = "";
            lblFaltas.Text = "";
            //limpio el calendario
            calendario.BoldedDates = null;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lblHrsTrab.Text = "";

            //variables para filtrar registros
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            TimeSpan hrsTotales = new TimeSpan();

            dgvBusqId.DataSource = null;
            dgvBusqId.DataSource = registrosUnID.Where(w => w.Horario > desde && w.Horario < hasta).ToList();

            foreach (DataGridViewRow row in dgvBusqId.Rows)
            {
                hrsTotales += (TimeSpan)row.Cells["Horas"].Value;
            }

            //PARA CALCULAR LAS INASISTENCIAS
            bool bandera = false;
            int inasistencias = 0;
            while (desde.Date <= hasta.Date)
            {
                foreach (Registro registro in registrosUnID)
                {
                    if (registro.Horario.Date == desde.Date)
                    {
                        bandera = false;
                        break;
                    }
                    else
                    {
                        if (desde.DayOfWeek != DayOfWeek.Sunday && desde.DayOfWeek != DayOfWeek.Saturday)
                            bandera = true;
                    }
                        
                }
                if (bandera)
                    inasistencias++;

                desde=desde.AddDays(1);
            }
            lblFaltas.Text = inasistencias.ToString();
            lblHrsTrab.Text = hrsTotales.ToString();
        }

        //Evento cuando se cambia la fecha del comboBox
        private void cBoxFechas_TextChanged(object sender, EventArgs e)
        {
            //se limpia la lista y el DGV cuando se cambia de fecha
            registrosPorFecha.Clear();
            dgvBusqId.Columns.Clear();
        }

        //cuando se cambia de fecha se limpia el label donde se muestra la hora 
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            lblHrsTrab.Text = "";
        }

        private void cBoxId_Click(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void cBoxId_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpiar();
            CargarRegistro();
        }
    }//FIN CLASE
}
