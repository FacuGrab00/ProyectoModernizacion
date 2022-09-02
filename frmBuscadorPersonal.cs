using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoModernizacion
{
    public partial class frmBuscadorPersonal : Form
    {
        public frmBuscadorPersonal()
        {
            InitializeComponent();
            //dgvBusqId.DataSource = registros;
        }




        FormRegistros buscarId;
        List<Registro> registros = new List<Registro>();

        List<Registro> registrosUnID = new List<Registro>();

        public void setBuscarId(FormRegistros busId)
        {
            buscarId = busId;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            registros = buscarId.getRegistros();

            string busId = txtID.Text;

            //string [] vector = new string[3];

            //dgvBusqId.ColumnCount=3;
            for (int i = 0; i < registros.Count; i++)
            {
                if (busId == registros[i].ID)
                {
                    registrosUnID.Add(registros[i]);
                    /*vector[0] = registros[i].ID;
                    vector[1] = registros[i].Nombre;
                    vector[2] = registros[i].Horas.ToString();*/

                    //dgvBusqId.DataSource = registros[i].ToString();
                    //dgvBusqId.Rows.Add(vector);
                }

            }
            //cargo la lista nueva solo con los reg del id buscado
            dgvBusqId.DataSource = null;
            dgvBusqId.DataSource = registrosUnID;

            btnBuscar.Enabled = false;

            btnBuscarNew.Enabled = true;
            //registrosUnID.Clear();

            //dgvBusqId.DataSource = registros;


        }


        //De esta forma se va actualizando el dgv cuando se esta buscando
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            /*dgvBusqId.CurrentCell = null;
            foreach (DataGridViewRow fila in dgvBusqId.Rows)
            {
                fila.Visible = fila.Cells["ID"].Value.ToString().ToUpper().Contains(txtID.Text.ToUpper());
            }*/
        }

        

        private void btnBuscarNew_Click(object sender, EventArgs e)
        {

            txtID.Clear();
            btnBuscar.Enabled = true;
            btnBuscarNew.Enabled = false;
            dgvBusqId.Columns.Clear();
            registrosUnID.Clear();
        }
    }

}
