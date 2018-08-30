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
        public FormReacCris()
        {
            InitializeComponent();
        }

        DataTable dtReactivos = new DataTable();
        DataTable dtCristaleria = new DataTable();
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
            DatosSolicitud datosSolicitud = new DatosSolicitud();
            datosSolicitud.ShowDialog();
            datosSolicitud.Dispose();
        }
    }
}
