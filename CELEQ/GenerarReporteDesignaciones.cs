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
                if (comboFiltro.Text == "Presupuesto")
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
                    ReporteDesignacionesPresupuesto rd = new ReporteDesignacionesPresupuesto(numAno.Text,ciclo);
                    rd.ShowDialog();
                    rd.Dispose();
                }
            }
        }
    }
}
