using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProyectoModernizacion
{
    public partial class FormTabla : Form
    {
        public FormTabla()
        {
            InitializeComponent();
        }

        ManejadorExcel manejadorExcel = new ManejadorExcel();

        //GETTERS Y SETTERS
        public string FilePath { get; set; }
        public string SavePath { get; set; }
        

        //CARGADO DEL FORMULARIO
        private void FormTabla_Load(object sender, EventArgs e)
        {
            //CARGA EL EXCEL PRINCIPAL EN CASO DE HABER EXISTIDO UN PRIMER EXCEL IMPORTADO.
            if (File.Exists(manejadorExcel.MainPath))
            {
                CargarGrid();
            }
        }

        public void Importar()
        {
            manejadorExcel.ImportarExcel(FilePath);
            CargarGrid();
        }
        
        //REALIZA UN VOLCADO DE LOS REGISTROS AL DGV
        private void CargarGrid()
        {
            //GENERAMOS LAS COLUMNAS
            dgvExcel.ColumnCount = manejadorExcel.Columnas.Count;
            dgvExcel.Columns[0].HeaderText = "ID de persona";
            dgvExcel.Columns[1].HeaderText = "Nombre";
            dgvExcel.Columns[2].HeaderText = "Hora";
            dgvExcel.Columns[3].HeaderText = "Estado de asistencia";

            //CARGAMOS LOS REGISTROS
            foreach (Registro registro in manejadorExcel.Registros)
            {
                dgvExcel.Rows.Add(registro.ID, registro.Nombre, registro.Horario, registro.Estado);
            }
        }

        public void ExportarCambios()
        {
            manejadorExcel.ExportarExcel(SavePath, dgvExcel);
            MessageBox.Show("Se guardó con exito!");
        }

    }
}
