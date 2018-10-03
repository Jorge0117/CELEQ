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
    public partial class AgregarUsuario : Form
    {
        AccesobdUsuarios bd;
        public AgregarUsuario()
        {
            InitializeComponent();
            bd = new AccesobdUsuarios();

        }

        private void loadPermisos()
        {
            foreach (string permiso in Globals.listaCategorias)
            {
                cbPermisos.Items.Add(permiso);
            }
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            loadPermisos();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textNombre.Text == "" || textPass.Text == "" || textConfirmar.Text == "" || textCorreo.Text == "" || cbPermisos.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPass.Text != textConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }
    }
}
