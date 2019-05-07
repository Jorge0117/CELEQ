﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CELEQ
{
    public partial class Localizaciones : Form
    {
        AccesoBaseDatos bd;
        public Localizaciones()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvLocalizaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocalizaciones.MultiSelect = false;
            dgvLocalizaciones.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTabla()
        {
            
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select provincia as Provincia, canton as Cantón, localidad as Localidad, distancia as Distancia, hospedaje as Hospedaje from Localizaciones");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvLocalizaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvLocalizaciones.DataSource = bs;
            int tamCelda = dgvLocalizaciones.Width / 5;
            dgvLocalizaciones.Columns[0].Width = tamCelda + 10;
            dgvLocalizaciones.Columns[1].Width = tamCelda + 15;
            dgvLocalizaciones.Columns[2].Width = tamCelda + 15;
            dgvLocalizaciones.Columns[3].Width = tamCelda - 40;
            dgvLocalizaciones.Columns[4].Width = tamCelda - 2;

            if (dgvLocalizaciones.Rows.Count > 0)
            {
                butModificar.Enabled = true;
                butEliminar.Enabled = true;
            }
            else
            {
                butModificar.Enabled = false;
                butEliminar.Enabled = false;
            }
        }

        private void Localizaciones_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            string provincia = dgvLocalizaciones.SelectedRows[0].Cells[0].Value.ToString();
            string canton = dgvLocalizaciones.SelectedRows[0].Cells[1].Value.ToString();
            string localidad = dgvLocalizaciones.SelectedRows[0].Cells[2].Value.ToString();
            if (dgvLocalizaciones.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro que quiere borrar la localización?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bd.eliminarLocalizacion(provincia, canton, localidad) == 0)
                    {
                        MessageBox.Show("Localización eliminada de manera correcta", "Localizaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                        llenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar localización", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarLocalizacion ag = new AgregarLocalizacion();
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarLocalizacion ag = new AgregarLocalizacion(dgvLocalizaciones.SelectedRows[0]);
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }
    }
}