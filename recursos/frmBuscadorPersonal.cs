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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
           
            //string filterField = "DNI";
           // ((DataTable)dgvExcel.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, txtDni.Text);

        }

        
    }
}
