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
            this.repDesignacionesTableAdapter.Fill(repDesignaciones._RepDesignaciones,"2018");
            this.reportViewer1.RefreshReport();
        }

    }
}
