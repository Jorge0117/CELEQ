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
        AccesoBaseDatos abu;
        public bool logged;
        public Login()
        {
            InitializeComponent();
            abu = new AccesoBaseDatos();
            logged = false;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textUsuario.Text != "" && textPass.Text != "")
            {
                if (abu.login(textUsuario.Text, textPass.Text))
                {
                    logged = true;
                    Globals.usuario = textUsuario.Text;
                    Globals.correo = abu.getCorreo(textUsuario.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, por favor intente de nuevo");
                }
            }
            else
            {
                MessageBox.Show("Por favor digite su usuario y contraseña");
            }
            
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logged)
            {
                Application.Exit();
            }
        }
    }
}
