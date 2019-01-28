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
    public partial class AgregarUsuario : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;
        public AgregarUsuario(DataGridViewRow dgvw = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
        }

        private void loadPermisos()
        {
            foreach (string permiso in Globals.listaCategorias)
            {
                cbPermisos.Items.Add(permiso);
            }

            SqlDataReader unidades = bd.ejecutarConsulta("select * from Unidad");
            while (unidades.Read())
            {
                comboUnidad.Items.Add(unidades[0].ToString());
            }

            if (dgvRow != null)
            {
                textUsuario.Text = dgvRow.Cells[0].Value.ToString();
                textUsuario.Enabled = false;
                textCorreo.Text = dgvRow.Cells[2].Value.ToString();
                cbPermisos.Text = dgvRow.Cells[4].Value.ToString();
                comboUnidad.Text = dgvRow.Cells[3].Value.ToString();

                SqlDataReader nombre = bd.ejecutarConsulta("select nombre, apellido1, apellido2 from usuarios where nombreUsuario = '" + textUsuario.Text + "'");
                nombre.Read();
                textNombre.Text = nombre[0].ToString();
                textApellido1.Text = nombre[1].ToString();
                textApellido2.Text = nombre[2].ToString();
            }
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            loadPermisos();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textUsuario.Text == "" || textCorreo.Text == "" || cbPermisos.Text == "" 
                || comboUnidad.Text == "" || textNombre.Text == "" || textApellido1.Text == "" || textApellido2.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int error;
                if (dgvRow == null)
                {
                    ModificarContra mc = new ModificarContra(textUsuario.Text, textCorreo.Text, cbPermisos.Text, comboUnidad.Text, textNombre.Text, textApellido1.Text, textApellido2.Text); 
                    /*
                    error = bd.agregarUsuario(textUsuario.Text, textPass.Text, textCorreo.Text, cbPermisos.Text, comboUnidad.Text, textNombre.Text, textApellido1.Text, textApellido2.Text);
                    if (error == 1)
                    {
                        MessageBox.Show("Usuario agregado de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar usuario\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    */
                }
                else
                {
                    
                    error = bd.modificarUsuario(textUsuario.Text, textCorreo.Text, cbPermisos.Text, comboUnidad.Text, textNombre.Text, textApellido1.Text, textApellido2.Text);
                    if (error == 0)
                    {
                        MessageBox.Show("Usuario modificado de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
