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
    public partial class AgregarPermiso : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;
        public AgregarPermiso(DataGridViewRow dgvw = null)
        {
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
            InitializeComponent();
        }

        private void AgregarPermiso_Load(object sender, EventArgs e)
        {
            if (dgvRow != null)
            {
                textNombre.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int error;
                if (dgvRow == null)
                {
                    error = bd.agregarPermiso(textNombre.Text);
                    if(error != -1)
                    {
                        MessageBox.Show("Permiso agregado de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error = bd.modificarPermiso(Convert.ToInt32(dgvRow.Cells[0].Value), textNombre.Text);
                    if (error != -1)
                    {
                        MessageBox.Show("Permiso modificado de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

    }
}
