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
    public partial class GenerarReporteDesignaciones : Form
    {
        public GenerarReporteDesignaciones()
        {
            InitializeComponent();
        }

        private void GenerarReporteDesignaciones_Load(object sender, EventArgs e)
        {
            comboFiltro.Items.Add("Presupuesto");
            comboFiltro.Items.Add("Encargado");
            comboFiltro.Items.Add("Estudiante");

            numAno.Value = DateTime.Today.Year;
        }

        private void butGenerarReporte_Click(object sender, EventArgs e)
        {
            if (comboFiltro.Text == "" || (checkCicloI.Checked == false && checkCicloIIC.Checked == false && checkCicloII.Checked == false
                && checkCicloIIIC.Checked == false && checkcicloIII.Checked == false))
            {
                MessageBox.Show("Por favor llenar los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string ciclo = "";
                if (checkCicloI.Checked)
                    ciclo = "I";
                else if (checkCicloIIC.Checked)
                    ciclo = "I I.C";
                else if (checkCicloII.Checked)
                    ciclo = "II";
                else if (checkCicloIIIC.Checked)
                    ciclo = "II I.C";
                else if (checkcicloIII.Checked)
                    ciclo = "III";

                if (comboFiltro.Text == "Presupuesto")
                {
                    ReporteDesignacionesPresupuesto rd = new ReporteDesignacionesPresupuesto(numAno.Text,ciclo);
                    rd.ShowDialog();
                    rd.Dispose();
                }else if(comboFiltro.Text == "Encargado")
                {
                    DesignacionesFiltrarResponsble dfr = new DesignacionesFiltrarResponsble(numAno.Text, ciclo);
                    dfr.ShowDialog();
                    dfr.Dispose();
                }
                else
                {
                    DesignacionFiltrarEstudiantes dfe = new DesignacionFiltrarEstudiantes(numAno.Text, ciclo);
                    dfe.ShowDialog();
                    dfe.Dispose();
                }
            }
        }

        private void checkCicloI_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCicloI.Checked == true)
            {
                checkCicloIIC.Checked = false;
                checkCicloII.Checked = false;
                checkCicloIIIC.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkCicloIIC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCicloIIC.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloII.Checked = false;
                checkCicloIIIC.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkCicloII_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCicloII.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloIIC.Checked = false;
                checkCicloIIIC.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkCicloIIIC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCicloIIIC.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloIIC.Checked = false;
                checkCicloII.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkcicloIII_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcicloIII.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloIIC.Checked = false;
                checkCicloII.Checked = false;
                checkCicloIIIC.Checked = false;
            }
        }
    }
}
