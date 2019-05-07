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
    public partial class AgregarFeriado : Form
    {
        AccesoBaseDatos bd;
        DataGridViewRow dgvRow;
        public AgregarFeriado(DataGridViewRow dgvw = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (dgvRow == null)
            {
                string feriado = textNombre.Text;
                string fechaInicio = dateTimePickerFecha.Value.ToShortDateString();
                if (bd.agregarFeriado(textNombre.Text, dateTimePickerFecha.Value.ToShortDateString(), dateTimePickerFecha.Value.ToShortDateString()) == 0)
                {
                    MessageBox.Show("Feriado agregado correctamente");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al eliminar feriado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (bd.modificarFeriado(Convert.ToInt32(dgvRow.Cells[0].Value.ToString()), textNombre.Text, dateTimePickerFecha.Value.ToShortDateString(), dateTimePickerFecha.Value.ToShortDateString()) == 0)
                {
                    MessageBox.Show("Feriado modificado correctamente");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al modificar feriado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarFeriado_Load(object sender, EventArgs e)
        {
            if (dgvRow != null)
            {
                textNombre.Text = dgvRow.Cells[1].Value.ToString();
                dateTimePickerFecha.Value = DateTime.Parse(dgvRow.Cells[2].Value.ToString());
            }
        }

    }
}
