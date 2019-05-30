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
    public partial class ModificarContra : Form
    {
        AccesoBaseDatos bd;
        string usuario = null;
        string correo = null;
        string permisos;
        string unidad;
        string nombre;
        string apellido1;
        string apellido2;
        public bool aceptar;
        List<string> puestos;

        public ModificarContra(string user = null, string mail = null, string unid = null, string name = null, string lastn1 = null, 
            string lastn2 = null, List<string> puestos = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            usuario = user;
            correo = mail;
            unidad = unid;
            nombre = name;
            apellido1 = lastn1;
            apellido2 = lastn2;
            this.puestos = puestos;

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (nuevaContra.Text != confirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nuevaContra.Text == "" && confirmarContra.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Se va a agregar
                if (correo != null)
                {
                    int error = bd.agregarUsuario(usuario, nuevaContra.Text, correo, unidad, nombre, apellido1, apellido2);
                    if (error == 1)
                    {
                        for(int i = 0; i<puestos.Count; ++i)
                        {
                            bd.agregarPuestoUsuario(usuario, puestos[i]);
                        }

                        MessageBox.Show("Usuario agregado de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
                        aceptar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar usuario\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int error = bd.modificarContrasena(usuario, nuevaContra.Text);
                    if (error == 1)
                    {
                        MessageBox.Show("Contraseña modificada de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
                        aceptar = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar contraseña: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            aceptar = false;
            this.Close();
        }

        private void nuevaContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
