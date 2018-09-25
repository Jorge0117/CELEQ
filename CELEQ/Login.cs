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
    public partial class Login : Form
    {
        AccesobdUsuarios abu;
        public Login()
        {
            InitializeComponent();
            abu = new AccesobdUsuarios();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(abu.login(textUsuario.Text, textPass.Text))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos, por favor intente de nuevo");
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
