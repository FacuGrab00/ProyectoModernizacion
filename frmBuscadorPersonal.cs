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
            //dgvBusqId.DataSource = registros;
            btnBuscar.Enabled = false;
            btnBuscarNew.Enabled = false;
        }

        FormRegistros buscarId;
        //Lista de los registros
        List<Registro> registros = new List<Registro>();
        
        //Lista para guardar los registros de un registro buscado
        List<Registro> registrosUnID = new List<Registro>();

        //Lista para cargar todos los id para el combo box
        List<string> ids = new List<string>();


        private void marcarFecha()
        {
            DateTime [] fechasTrabajadas = new DateTime[registrosUnID.Count];

            for (int i = 0; i < registrosUnID.Count; i++)
            {
                fechasTrabajadas[i] = registrosUnID[i].Horario;
                
            }

            calendario.BoldedDates = fechasTrabajadas;
            
        }

        //creo una nueva lista para guardar los registros por una fecha
        List<Registro> registrosPorFecha = new List<Registro>();

        public int cantidadDiasTrab()
        {
            int contador=0;
            for (int i = 0; i < registrosUnID.Count; i++)
            {
                //Con textBox
                /*if (registrosUnID[i].ID == txtID.Text)
                {
                    contador++;   
                }*/
                //Con combobox
                if (registrosUnID[i].ID == cBoxId.Text)
                {
                    contador++;
                }

            }

            return contador;
        }
       

        public void setBuscarId(FormRegistros busId)
        {
            buscarId = busId;
        }
        //busco el id cuando presiono el boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            registros = buscarId.getRegistros();
            //variable para almacenar el id del texbox
            //string busId = txtID.Text;

            string busId = cBoxId.Text;

            //Con ConboBox
            //string busId = cBoxId.Text;

            //recorro la lista de datos procesados
            for (int i = 0; i < registros.Count; i++)
            {
                //si lo encuentra lo guarda en una nueva lista
                if (busId == registros[i].ID)
                {
                    //en esta lista se guardan los registros encontrados
                    registrosUnID.Add(registros[i]);
   
                }
            }

            //////////////////////////////////////////////////////
            //cargarComboBox();
            ////////////////////////////////////////////////////
           
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
                //Muestro los datos en los label`s
                lblHrsTrab.Text = hrsTotales.ToString();
                //lblID.Text = txtID.Text;
                lblID.Text = cBoxId.Text;
                lblNomApe.Text = registrosUnID[0].Nombre.ToString();
                
            }
            else
            {
                //Si no encuentra una persona por su id da un msj
                MessageBox.Show("Esta Persona No Se Encuentra");
            }

            //deshabilito el boton buscar
            btnBuscar.Enabled = false;

            //habilito el boton buscar nuevo
            btnBuscarNew.Enabled = true;

            //Muestro la cantidad de dias trabajados
            lblDiasTrab.Text = Convert.ToString(cantidadDiasTrab());


            

            marcarFecha();

            //calendario.;
            //registrosUnID.Clear();
            //dgvBusqId.DataSource = registros;
        }

        //Procedimiento para caragar comboBox
        public void cargarComboBox()
        {
            //guardo en result todos los id distintos
            registros = buscarId.getRegistros();
            List<Registro> listids = new List<Registro>();

            for (int i = 0; i < registros.Count; i++)
            {
                listids.Add(registros[i]);
            }

            var result = (from item in listids select item.ID).Distinct();

            //lleno el comboBox con los id`s
            cBoxId.DataSource = result.ToList();
        }


        //Cuando se quiere buscar una nueva persona
        private void btnBuscarNew_Click(object sender, EventArgs e)
        {
            

            //limpio el combobox
            cBoxId.Text = "";
            //habilito el boton buscar
            btnBuscar.Enabled = true;
            //deshabilito el boton buscar nuevo
            btnBuscarNew.Enabled = false;
            //limpio el DataGridView
            dgvBusqId.Columns.Clear();
            //limpio la lista 
            registrosUnID.Clear();
            //limpio los labels de Datos Personales
            lblDiasTrab.Text = "";
            lblNomApe.Text = "";
            lblID.Text = "";
            lblHrsTrab.Text = "";

            //limpio el calendario
            calendario.BoldedDates = null;
            
        }

        
        private void txtID_TextChanged_1(object sender, EventArgs e)
        {

            /* if (txtID.Text == "")
             {
                 btnBuscar.Enabled = false;
             }
             else
             {
                 btnBuscar.Enabled = true;
             }*/

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            lblHrsTrab.Text = "";

            //variables para filtrar registros
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            
            dgvBusqId.DataSource = null;
            dgvBusqId.DataSource = registrosUnID.Where(w => w.Horario > desde && w.Horario < hasta).ToList();


            TimeSpan hrsTotales = new TimeSpan();
            
            foreach (DataGridViewRow row in dgvBusqId.Rows)
            {

                //string codigo = Convert.ToString(row.Cells["Codigo"].Value);
                hrsTotales += (TimeSpan)row.Cells["Horas"].Value;
            }


           lblHrsTrab.Text = hrsTotales.ToString();

        }

        //Evento cuando se cambia la fecha del comboBox
        private void cBoxFechas_TextChanged(object sender, EventArgs e)
        {
            //se limpia la lista y el DGV cuando se cambia de fecha
            registrosPorFecha.Clear();
            dgvBusqId.Columns.Clear();

        }

        //se limpia el label donde se muestra la hora 
        //cuando se cambia de fecha
        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            lblHrsTrab.Text = "";
        }

        

        

        private void cBoxId_Click(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void cBoxId_TextChanged(object sender, EventArgs e)
        {
            if (cBoxId.Text == "")
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }
        }
    }

}
