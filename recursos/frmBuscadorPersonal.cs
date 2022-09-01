using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoModernizacion.recursos
{
    public partial class frmBuscadorPersonal : Form
    {
        public frmBuscadorPersonal()
        {
            InitializeComponent();
        }




        FormRegistros buscarId;
        List<Registro> registros = new List<Registro>();

        public void setBuscarId(FormRegistros busId)
        {
            buscarId = busId;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            registros = buscarId.getRegistros();


            ////////////////////////////////
            FormTabla tablaE = new FormTabla();
            
            string busDni = txtDni.Text;
            for (int i = 0; i < tablaE.dgvExcel.RowCount; i++)
            {
                if (busDni == tablaE.dgvExcel.Rows[i].Cells[1].Value.ToString())
                {
                    txtNombre.Text = tablaE.dgvExcel.Rows[i].Cells[2].Value.ToString();
                    txtHoras.Text = tablaE.dgvExcel.Rows[i].Cells[3].Value.ToString();
                }
            }
            /*
            (tablaE.dgvExcel.DataSource as DataTable).DefaultView.RowFilter = string.Format("Dni='{0}'", txtDni.Text);
            */


         }
            

            


    }

}
