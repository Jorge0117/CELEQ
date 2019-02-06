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
    public partial class DesignacionesFiltrarResponsble : Form
    {
        string ano;
        string ciclo;
        public DesignacionesFiltrarResponsble(string a, string c)
        {
            ano = a;
            ciclo = c;
            InitializeComponent();
        }

        private void DesignacionesFiltrarResponsble_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RepDesignacionesDataSet.RepDesignaciones' table. You can move, or remove it, as needed.
            this.RepDesignacionesTableAdapter.Fill(this.RepDesignacionesDataSet.RepDesignaciones, ano,ciclo);

            this.reportViewer1.RefreshReport();

        }
    }
}
