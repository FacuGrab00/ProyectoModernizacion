﻿using System;
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
            string idAbuscar = txtID.Text;

            registros = buscarId.getRegistros();

            dgvIdBusq.DataSource = null;
            dgvIdBusq.DataSource = registros;

            for (int i = 0; i < registros.Count; i++)
            {
                //dgvIdBusq.Rows[i].Cells[0] = registros.ToString();
                /*
                dgvIdBusq.DataSource = registros;
                if (registros[i].ToString() == idAbuscar)
                {
                    //
                }*/
            }




        }
            

            


    }

}
