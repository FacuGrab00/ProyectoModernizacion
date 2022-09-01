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

        


        
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /*
            Form1 frmPpal = new Form1();
            DataTable dt;
            dt = frmPpal.llenar_fill_DGV();
            
            //frmPpal.Show();
            int bandfbus=0;


            string busDni = txtDni.Text;

            for (int i = 0; i < dt.Rows.Count-1; i++)
            {
                if (busDni == dt.Rows[i]["DNI"].ToString())
                {
                    txtNombre.Text = dt.Rows[i]["Nombre"].ToString();
                    //txtHoras.Text = frmPpal.dgvDatos.Rows[i].Cells[3].Value.ToString();
                    bandfbus = 1;
                    break;
                }
                
                    
            }
            if (bandfbus == 0)
            {
                MessageBox.Show("NO SE ENCUENTRA ESA PERSONA");
            }*/







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
