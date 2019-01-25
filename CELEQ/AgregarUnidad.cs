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
    public partial class AgregarUnidad : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;
        public AgregarUnidad(DataGridViewRow dgvw = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
        }

        private void AgregarUnidad_Load(object sender, EventArgs e)
        {
            SqlDataReader encargados = bd.ejecutarConsulta("select CONCAT(nombre , ' ' , apellido1 , ' ' , apellido2) as Encargado from Usuarios");
            while (encargados.Read())
            {
                comboEncargado.Items.Add(encargados[0].ToString());
            }

            if (dgvRow != null)
            {
                textUnidad.Text = dgvRow.Cells[0].Value.ToString();
                comboEncargado.Text = dgvRow.Cells[3].Value.ToString();
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (textUnidad.Text == "" || comboEncargado.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int error;
                if (dgvRow == null)
                {
                    error = bd.agregarUnidad(textUnidad.Text, comboEncargado.Text);
                    if (error == 1)
                    {
                        MessageBox.Show("Unidad agregada de manera correcta", "Unidades", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar unidad\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error = bd.modificarUnidad(textUnidad.Text, comboEncargado.Text);
                    if (error == 0)
                    {
                        MessageBox.Show("Unidad modificada de manera correcta", "Unidades", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar usuario\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboEncargado_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombreUnidad_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
