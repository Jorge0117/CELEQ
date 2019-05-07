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
    public partial class AgregarEncargado : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;
        public AgregarEncargado(DataGridViewRow dgvw = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
        }

        private void AgregarEncargado_Load(object sender, EventArgs e)
        {
            if (dgvRow != null)
            {
                textNombre.Text = dgvRow.Cells[0].Value.ToString();
            }
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

                    error = bd.agregarResponsable(textNombre.Text);
                    if (error == 0)
                    {
                        MessageBox.Show("Responsable agregado de manera correcta", "Responsables", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar responsable\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error = bd.modificarResponsable(dgvRow.Cells[0].Value.ToString(), textNombre.Text);
                    if (error == 0)
                    {
                        MessageBox.Show("Responsable modificado de manera correcta", "Localizaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar responsable\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
