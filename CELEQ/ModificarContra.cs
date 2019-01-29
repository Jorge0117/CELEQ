﻿using System;
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
        public ModificarContra(string user = null, string mail = null, 
            string perm = null, string unid = null, string name = null, string lastn1 = null, 
            string lastn2 = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            usuario = user;
            correo = mail;
            permisos = perm;
            unidad = unid;
            nombre = name;
            apellido1 = lastn1;
            apellido2 = lastn2;

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (nuevaContra.Text != confirmarContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Se va a agregar
                if (correo != null)
                {
                    int error = bd.agregarUsuario(usuario, nuevaContra.Text, correo, permisos, unidad, nombre, apellido1, apellido2);
                    if (error == 1)
                    {
                        MessageBox.Show("Usuario agregado de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
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
            this.Close();
        }
    }
}
