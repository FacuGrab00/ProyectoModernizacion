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
        List<Registro> registros = new List<Registro>();

        List<Registro> registrosUnID = new List<Registro>();

        public void setBuscarId(FormRegistros busId)
        {
            buscarId = busId;
        }
        //busco el id cuando presiono el boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            registros = buscarId.getRegistros();
            //variable para almacenar el id del texbox
            string busId = txtID.Text;

            //string [] vector = new string[3];

            //dgvBusqId.ColumnCount=3;
            
            //recorro la lista de datos procesados
            for (int i = 0; i < registros.Count; i++)
            {
                //si lo encuentra lo guarda en una nueva lista
                if (busId == registros[i].ID)
                {
                    //en esta lista se guardan los registros encontrados
                    registrosUnID.Add(registros[i]);


                    /*vector[0] = registros[i].ID;
                    vector[1] = registros[i].Nombre;
                    vector[2] = registros[i].Horas.ToString();*/

                    //dgvBusqId.DataSource = registros[i].ToString();
                    //dgvBusqId.Rows.Add(vector);
                }

            }

            if (registrosUnID.Any())
            {
                //cargo la lista nueva solo con los reg del id buscado
                dgvBusqId.DataSource = null;
                dgvBusqId.DataSource = registrosUnID;
            }
            else
            {
                MessageBox.Show("Esta Persona No Se Encuentra");
            }


            //deshabilito el boton buscar
            btnBuscar.Enabled = false;

            //habilito el boton buscar nuevo
            btnBuscarNew.Enabled = true;
            
            
            
            //registrosUnID.Clear();
            //dgvBusqId.DataSource = registros;
        }

        private void btnBuscarNew_Click(object sender, EventArgs e)
        {
            //limpio el textbox
            txtID.Clear();
            //habilito el boton buscar
            btnBuscar.Enabled = true;
            //deshabilito el boton buscar nuevo
            btnBuscarNew.Enabled = false;
            //limpio el DataGridView
            dgvBusqId.Columns.Clear();
            //limpio la lista 
            registrosUnID.Clear();
        }

        //De esta forma se va actualizando el dgv cuando se esta buscando
        private void txtID_TextChanged_1(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }

            /*dgvBusqId.CurrentCell = null;
            foreach (DataGridViewRow fila in dgvBusqId.Rows)
            {
                fila.Visible = fila.Cells["ID"].Value.ToString().ToUpper().Contains(txtID.Text.ToUpper());
            }*/
        }
    }

}
