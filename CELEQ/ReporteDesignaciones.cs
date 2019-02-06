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
    public partial class ReporteDesignaciones : Form
    {
        public ReporteDesignaciones()
        {
            InitializeComponent();
        }

        private void ReporteDesignaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RepDesignacionesDataSet.RepDesignaciones' table. You can move, or remove it, as needed.
            this.RepDesignacionesTableAdapter.Fill(this.RepDesignacionesDataSet.RepDesignaciones,"2018");

            this.reportViewer1.RefreshReport();
        }
    }
}
