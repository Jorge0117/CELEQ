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
    public partial class AgregarListaMaestra : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;
        bool act;
        public AgregarListaMaestra(DataGridViewRow dgvw = null, bool actualizar = false)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
            act = actualizar;
        }

        private void AgregarListaMaestra_Load(object sender, EventArgs e)
        {
            textCodigo.Show();
            if (dgvRow != null)
            {
                textCodigo.Text = dgvRow.Cells[0].Value.ToString();
                textVersion.Text = dgvRow.Cells[1].Value.ToString();
                textNombre.Text = dgvRow.Cells[2].Value.ToString();
                dateTimePickerFecha.Value = DateTime.Parse(dgvRow.Cells[3].Value.ToString());
                if (act)
                {
                    textCodigo.Enabled = false;
                    textNombre.Enabled = false;
                }
				else
				{
					textVersion.Enabled = false;
					dateTimePickerFecha.Enabled = false;
				}
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (textCodigo.Text == "" && textNombre.Text == "" && textVersion.Text == "")
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int error;
                if (dgvRow == null)
                {

                    error = bd.agregarListaMaestra(textCodigo.Text, textVersion.Text, textNombre.Text, dateTimePickerFecha.Value.ToShortDateString());
                    if (error == 0)
                    {
                        MessageBox.Show("Formulario agregado de manera correcta", "Responsables", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar formulario\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(!act)
                {
                    error = bd.modificarListaMaestra(dgvRow.Cells[0].Value.ToString(), textCodigo.Text, dgvRow.Cells[1].Value.ToString(), textVersion.Text, textNombre.Text, dateTimePickerFecha.Value.ToShortDateString());
                    if (error == 0)
                    {
                        MessageBox.Show("Formulario modificado de manera correcta", "Localizaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar formulario\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error = bd.actualizarEnListaMaestra(dgvRow.Cells[0].Value.ToString(), dgvRow.Cells[1].Value.ToString(), textVersion.Text, dgvRow.Cells[2].Value.ToString(), dateTimePickerFecha.Value.ToShortDateString());
                    if(error == 0)
						MessageBox.Show("El formulario ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					else if (error == 1)
                    {
                        MessageBox.Show("Formulario actualizado de manera correcta", "Localizaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar formulario\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
