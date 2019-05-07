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

            SqlDataReader encargados = bd.ejecutarConsulta("select CONCAT(nombre , ' ' , apellido1 , ' ' , apellido2) as Encargado from Usuarios where categoria != 'Estudiante'");
            while (encargados.Read())
            {
                comboEncargado.Items.Add(encargados[0].ToString());
            }

            if (dgvRow != null)
            {
                textUnidad.Text = dgvRow.Cells[0].Value.ToString(); 
                comboEncargado.SelectedIndex = comboEncargado.FindStringExact(dgvRow.Cells[1].Value.ToString());
            }


        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            string[] nombre;
            SqlDataReader nombreUsuario;
            nombreUsuario = null;

            if (textUnidad.Text == "" || comboEncargado.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombreUsuario = bd.ejecutarConsulta("SELECT nombreUsuario FROM Usuarios U WHERE CONCAT(U.nombre, ' ', U.apellido1, ' ', U.apellido2) = '" + comboEncargado.Text + "' AND categoria != 'Estudiante'");
                nombreUsuario.Read();
                int error;
                if (dgvRow == null)
                {

                    error = bd.agregarUnidad(textUnidad.Text, nombreUsuario[0].ToString());
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
                    error = bd.modificarUnidad(dgvRow.Cells[0].Value.ToString(), textUnidad.Text, nombreUsuario[0].ToString());
                    if (error == 0)
                    {
                        MessageBox.Show("Unidad modificada de manera correcta", "Unidades", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar unidad\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
