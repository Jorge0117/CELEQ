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
    public partial class SolicitudMantenimiento : Form
    {
        AccesoBaseDatos bd;
        public SolicitudMantenimiento()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }

        private void SolicitudMantenimiento_Load(object sender, EventArgs e)
        {
            comboUrgencia.Items.Add("No urge");
            comboUrgencia.Items.Add("Poco urgente");
            comboUrgencia.Items.Add("Urgente");
            comboUrgencia.Items.Add("Muy urgente");
            comboUrgencia.Items.Add("Emergencia");

            comboAreaTrabajo.Items.Add("Redes / informática / computadoras");
            comboAreaTrabajo.Items.Add("Equipos varios");
            comboAreaTrabajo.Items.Add("Edificio o infraestructura");

            dateSolicitud.Value = DateTime.Now;
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textNombre.Text == "" || textUnidad.Text == "" || textTelefono.Text == "" || comboUrgencia.Text == ""
                || comboAreaTrabajo.Text == "" || textLugarTrabajo.Text == "" || textDescripcion.Text == "")
            {
                MessageBox.Show("Por favor llenar los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (bd.agregarSolicitudMantenimiento(generarConsecutivo(comboAreaTrabajo.Text), dateSolicitud.Value.ToShortDateString(), textNombre.Text, textUnidad.Text,
                    textTelefono.Text, textContacto.Text, comboUrgencia.Text, comboAreaTrabajo.Text, textLugarTrabajo.Text, textDescripcion.Text) == 1)
                {
                    MessageBox.Show("Se realizó la solicitud correctamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error realizando la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string generarConsecutivo(string areaTrabajo)
        {
            string consecutivo = "";
            string anterior = bd.ultimaSolicitudMantenimiento(areaTrabajo);
            int id = 0;

            string codigoArea;
            if(areaTrabajo == "Redes / informática / computadoras")
            {
                codigoArea = "MIF";
            }
            else if(areaTrabajo == "Equipos varios")
            {
                codigoArea = "MEQ";
            }
            else
            {
                codigoArea = "MED";
            }

            if(anterior != null)
            {
                string[] strArray = anterior.Split('-');
                id = Convert.ToInt32(strArray[2]);
            }

            int numDigitos = 0;
            if (id > 0)
            {
                numDigitos = Convert.ToInt32(Math.Floor(Math.Log10(id) + 1));
                if (id == 9 || id == 99 || id == 999 || id == 9999 || id == 99999 || id == 999999 || id == 9999999)
                {
                    numDigitos--;
                }
            }
            else
            {
                numDigitos = 1;
            }

            for (int i = 0; i < 4 - numDigitos; ++i)
            {
                consecutivo += "0";
            }
            return "UMI-" + codigoArea + "-" + consecutivo + (id + 1).ToString()  + "-" + dateSolicitud.Value.Year.ToString();
        }
    }
}
