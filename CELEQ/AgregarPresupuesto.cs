using System;
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
    public partial class AgregarPresupuesto : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;

        public AgregarPresupuesto(DataGridViewRow dgvw = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
        }

        private void AgregarPresupuesto_Load(object sender, EventArgs e)
        {
            if (dgvRow != null)
            {
                codigoText.Text = dgvRow.Cells[0].Value.ToString();
                nombreText.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (codigoText.Text == "" || nombreText.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int error;
                if (dgvRow == null)
                {
                    error = bd.agregarPresupuesto(codigoText.Text, nombreText.Text);
                    if (error == 1)
                    {
                        MessageBox.Show("Presupuesto agregado de manera correcta", "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar presepuesto\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error = bd.modificarPresupuesto(dgvRow.Cells[0].Value.ToString(), codigoText.Text, nombreText.Text);
                    if (error == 0)
                    {
                        MessageBox.Show("Presupuesto modificado de manera correcta", "Presupuesto", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar presupuesto\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
