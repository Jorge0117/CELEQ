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
    public partial class ListaMaestra : Form
    {
        AccesoBaseDatos bd;
        public ListaMaestra()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvListaM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaM.MultiSelect = false;
            dgvListaM.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
            comboOpcionMostrar.Text = "Vigentes";
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTabla(string categoria = "Vigentes", string filtro = "")
        {

            DataTable tabla = null;

            try
            {
                if(categoria == "Todos" && filtro == "")
                    tabla = bd.ejecutarConsultaTabla("select Codigo as Código, ver as Versión, Nombre, FechaEntV as 'Entrada en vigencia' from ListaMaestra");
                else if(categoria == "Todos" && filtro != "")
					tabla = bd.ejecutarConsultaTabla("select Codigo as Código, ver as Versión, Nombre, FechaEntV as 'Entrada en vigencia' from ListaMaestra where " +
					"Codigo like '%" + filtro + "%' or ver like '%" + filtro + "%' or Nombre like '%" + filtro + "%'");
				else if(categoria == "Vigentes" && filtro == "")
					tabla = bd.ejecutarConsultaTabla("select Codigo as Código, ver as Versión, Nombre, FechaEntV as 'Entrada en vigencia' from ListaMaestra where masNuevo = 1");
				else if (categoria == "Vigentes" && filtro != "")
					tabla = bd.ejecutarConsultaTabla("select Codigo as Código, ver as Versión, Nombre, FechaEntV as 'Entrada en vigencia' from ListaMaestra where masNuevo = 1 and (" +
					"Codigo like '%" + filtro + "%' or ver like '%" + filtro + "%' or Nombre like '%" + filtro + "%')");
			}
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvListaM.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvListaM.DataSource = bs;
            int tamCelda = dgvListaM.Width / 4;
            dgvListaM.Columns[0].Width = tamCelda -48;
            dgvListaM.Columns[1].Width = tamCelda -120;
            dgvListaM.Columns[2].Width = tamCelda + 253;
            dgvListaM.Columns[3].Width = tamCelda - 85;

            if (dgvListaM.Rows.Count > 0 && comboOpcionMostrar.Text == "Vigentes")
            {
                butModificar.Enabled = true;
                butActualizar.Enabled = true;
            }
            else
            {
                butModificar.Enabled = false;
                butActualizar.Enabled = false;
            }
        }

        private void ListaMaestra_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarListaMaestra alm = new AgregarListaMaestra();
            alm.ShowDialog();
            alm.Dispose();
            llenarTabla(comboOpcionMostrar.Text);
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarListaMaestra alm = new AgregarListaMaestra(dgvListaM.SelectedRows[0]);
            alm.ShowDialog();
            alm.Dispose();
            llenarTabla(comboOpcionMostrar.Text);
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            AgregarListaMaestra alm = new AgregarListaMaestra(dgvListaM.SelectedRows[0],true);
            alm.ShowDialog();
            alm.Dispose();
            llenarTabla(comboOpcionMostrar.Text);
        }

        private void comboOpcionMostrar_TextChanged(object sender, EventArgs e)
        {
            llenarTabla(comboOpcionMostrar.Text, textBuscar.Text);
        }

		private void textBuscar_KeyUp(object sender, KeyEventArgs e)
		{
			llenarTabla(comboOpcionMostrar.Text, textBuscar.Text);
		}
	}
}
