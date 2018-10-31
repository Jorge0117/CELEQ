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
                if (dgvRow != null)
                {
                    textNombre.Text = dgvRow.Cells[0].Value.ToString();
                    textNombre.Enabled = false;
                    textCorreo.Text = dgvRow.Cells[1].Value.ToString();
                    cbPermisos.Text = dgvRow.Cells[2].Value.ToString();
                }
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
                int error;
                if (dgvRow == null)
                {
                    error = bd.agregarUsuario(textNombre.Text, textPass.Text, textCorreo.Text, cbPermisos.Text);
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
                    error = bd.modificarUsuario(textNombre.Text, textPass.Text, textCorreo.Text, cbPermisos.Text);
                    if (error == 1)
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
    }
}
