using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELEQ
{
    public partial class FormReacCris : Form
    {


        DataTable dtReactivos = new DataTable();
        DataTable dtCristaleria = new DataTable();

        public FormReacCris()
        {
            InitializeComponent();

            //Solo permite seleccionar filas en los dgv
            dgvReactivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReactivos.MultiSelect = false;
            dgvReactivos.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
            dgvCristaleria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCristaleria.MultiSelect = false;
            dgvCristaleria.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void FormReacCris_Load(object sender, EventArgs e)
        {
            dtReactivos.Columns.Add("Nombre");
            dtReactivos.Columns.Add("Pureza");
            dtReactivos.Columns.Add("Estante");
            dtReactivos.Columns.Add("Cantidad Solicitada");

            dgvReactivos.DataSource = dtReactivos;
            for(int i = 0; i<4; ++i)
            {
                dgvReactivos.Columns[i].Width = dgvReactivos.Width / 4 - 1;
            }

            dtCristaleria.Columns.Add("Artículo");
            dtCristaleria.Columns.Add("Material");
            dtCristaleria.Columns.Add("Capacidad");
            dtCristaleria.Columns.Add("Cantidad Solicitada");

            dgvCristaleria.DataSource = dtCristaleria;
            for(int i=0; i<4; ++i)
            {
                dgvCristaleria.Columns[i].Width = dgvCristaleria.Width / 4 - 1;
            }
        }

        private void FormReacCris_FormClosing(object sender, FormClosingEventArgs e) {
            if (dgvReactivos.Rows.Count != 0 || dgvCristaleria.Rows.Count != 0)
            {
                if (MessageBox.Show("¿Seguro que quieres salir?\nNo se realizará la solicitud", "Alerta", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void butAgRe_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario(0, this);
            inv.ShowDialog();
            inv.Dispose();
        }

        private void butAgCr_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario(1, this);
            inv.ShowDialog();
            inv.Dispose();
        }

        private void butRealizarSolicutud_Click(object sender, EventArgs e)
        {
            if(dgvCristaleria.Rows.Count != 0 || dgvReactivos.Rows.Count != 0)
            {
                DatosSolicitud datosSolicitud = new DatosSolicitud(this);
                datosSolicitud.ShowDialog();
                datosSolicitud.Dispose();
            }
            else
            {
                MessageBox.Show("Por favor seleccione reactivos o cristalería", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butElimReac_Click(object sender, EventArgs e)
        {
            dgvReactivos.Rows.Remove(dgvReactivos.SelectedRows[0]);
        }

        private void butElimCri_Click(object sender, EventArgs e)
        {
            dgvCristaleria.Rows.Remove(dgvCristaleria.SelectedRows[0]);
        }
    }
}
