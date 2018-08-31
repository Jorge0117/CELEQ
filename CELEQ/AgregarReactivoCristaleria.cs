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
        Inventario inventario;
        public AgregarReactivoCristaleria(int tipo, Inventario inventario)
        {
            InitializeComponent();
            //Tipo 0 = Reactivo
            //Tipo 1 = Cristaleria
            this.tipo = tipo;
            bd = new AccesoBaseDatos();
            this.inventario = inventario;

            if(tipo == 1)
            {
                labelEstado.Text = "Material";
                labelPureza.Text = "Capacidad";
                labelEstante.Hide();
                textEstante.Hide();
            }

            //Si se va a modificar
            if(inventario != null)
            {
                if(tipo == 0)
                {
                    textNombre.Text = inventario.dgvInventario.SelectedRows[0].Cells[0].Value.ToString();
                    textEstado.Text = inventario.dgvInventario.SelectedRows[0].Cells[3].Value.ToString();
                    textPureza.Text = inventario.dgvInventario.SelectedRows[0].Cells[1].Value.ToString();
                    textCantidad.Text = inventario.dgvInventario.SelectedRows[0].Cells[2].Value.ToString();
                    textEstante.Text = inventario.dgvInventario.SelectedRows[0].Cells[4].Value.ToString();
                }
                else
                {
                    textNombre.Text = inventario.dgvInventario.SelectedRows[0].Cells[0].Value.ToString();
                    textEstado.Text = inventario.dgvInventario.SelectedRows[0].Cells[1].Value.ToString();
                    textPureza.Text = inventario.dgvInventario.SelectedRows[0].Cells[2].Value.ToString();
                    textCantidad.Text = inventario.dgvInventario.SelectedRows[0].Cells[3].Value.ToString();
                }
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
            //Si se va a agregar
            if (inventario == null)
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
                        if (bd.agregarCristaleria(textNombre.Text, textEstado.Text, textPureza.Text, Int32.Parse(textCantidad.Text)) != 1)
                        {
                            MessageBox.Show("No se pudo agregar la cristalería", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            //Si se va a modificar
            else
            {
                if (tipo == 0)
                {
                    if (bd.modificarReactivo(textNombre.Text, textPureza.Text, float.Parse(textCantidad.Text), textEstado.Text, textEstante.Text,
                        inventario.dgvInventario.SelectedRows[0].Cells[0].Value.ToString(), inventario.dgvInventario.SelectedRows[0].Cells[1].Value.ToString()) != 1)
                    {
                        MessageBox.Show("No se pudo modificar el reactivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    if(bd.modificarCristaleria(textNombre.Text, textEstado.Text, textPureza.Text, Int32.Parse(textCantidad.Text), 
                        inventario.dgvInventario.SelectedRows[0].Cells[0].Value.ToString(), inventario.dgvInventario.SelectedRows[0].Cells[1].Value.ToString(),
                        inventario.dgvInventario.SelectedRows[0].Cells[2].Value.ToString()) != 1)
                    {
                        MessageBox.Show("No se pudo modificar el reactivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
