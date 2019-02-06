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
                DesignacionesFiltrarResponsble filtrarResponsble = new DesignacionesFiltrarResponsble();
                filtrarResponsble.ShowDialog();
            }
        }
    }
}
