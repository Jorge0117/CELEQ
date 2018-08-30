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
    public partial class AgregarReactivoCristaleria : Form
    {
        int tipo;
        AccesoBaseDatos bd;
        public AgregarReactivoCristaleria(int tipo)
        {
            InitializeComponent();
            //Tipo 0 = Reactivo
            //Tipo 1 = Cristaleria
            this.tipo = tipo;
            bd = new AccesoBaseDatos();

            if(tipo == 1)
            {
                labelEstado.Text = "Material";
                labelPureza.Text = "Capacidad";
                labelEstante.Hide();
                textEstante.Hide();
            }
        }

        private void AgregarReactivoCristaleria_Load(object sender, EventArgs e)
        {

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text != "" || textEstado.Text != "" || textCantidad.Text != "" || textEstante.Text != "" || textPureza.Text != "")
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres salir?No se guardarán los cambios", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            //Falta algún dato
            if (textNombre.Text == "" || textEstado.Text == "" || textCantidad.Text == "" || textPureza.Text == "" || (tipo == 0 && textEstante.Text == ""))
            {
                MessageBox.Show("Porfavor llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tipo == 0)
                {
                    if (bd.agregarReactivo(textNombre.Text, textPureza.Text, float.Parse(textCantidad.Text),
                        textEstado.Text, textEstante.Text) != 1)
                    {
                        MessageBox.Show("No se pudo agregar el reactivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    if(bd.agregarCristaleria(textNombre.Text, textEstado.Text, textPureza.Text, Int32.Parse(textCantidad.Text)) != 1){
                        MessageBox.Show("No se pudo agregar la cristalería", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
