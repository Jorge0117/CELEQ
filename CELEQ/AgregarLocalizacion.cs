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
    public partial class AgregarLocalizacion : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;
        public AgregarLocalizacion(DataGridViewRow dgvw = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;
        }

        private void AgregarLocalizacion_Load(object sender, EventArgs e)
        {
            SqlDataReader provincia = bd.ejecutarConsulta("SELECT DISTINCT provincia FROM Localizaciones");
            SqlDataReader canton = bd.ejecutarConsulta("SELECT DISTINCT canton FROM Localizaciones");
            SqlDataReader localidad = bd.ejecutarConsulta("SELECT DISTINCT localidad FROM Localizaciones");
            while (provincia.Read())
            {
                comboProvincia.Items.Add(provincia[0].ToString());
            }
            while (canton.Read())
            {
                comboCanton.Items.Add(canton[0].ToString());
            }
            while (localidad.Read())
            {
                comboLocalidad.Items.Add(localidad[0].ToString());
            }

            if (dgvRow != null)
            {
                comboProvincia.SelectedIndex = comboProvincia.FindStringExact(dgvRow.Cells[0].Value.ToString());
                comboCanton.SelectedIndex = comboCanton.FindStringExact(dgvRow.Cells[1].Value.ToString());
                comboLocalidad.SelectedIndex = comboLocalidad.FindStringExact(dgvRow.Cells[2].Value.ToString());
                numericDistancia.Value = Convert.ToDecimal(dgvRow.Cells[3].Value);
                numericHospedaje.Value = Convert.ToDecimal(dgvRow.Cells[4].Value);
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (comboProvincia.Text == "" || comboCanton.Text == "")
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int error;
                if (dgvRow == null)
                {

                    error = bd.agregarLocalizacion(comboProvincia.Text, comboCanton.Text, comboLocalidad.Text, numericDistancia.Value, numericHospedaje.Value);
                    if (error == 0)
                    {
                        MessageBox.Show("Localización agregada de manera correcta", "Localizaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Localización\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    error = bd.modificarLocalizacion(dgvRow.Cells[0].Value.ToString(), dgvRow.Cells[1].Value.ToString(), dgvRow.Cells[2].Value.ToString(), comboProvincia.Text, comboCanton.Text, comboLocalidad.Text, numericDistancia.Value, numericHospedaje.Value);
                    if (error == 0)
                    {
                        MessageBox.Show("Localización modificada de manera correcta", "Localizaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar localización\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
