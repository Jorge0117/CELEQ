using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

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
            this.RepDesignacionesTableAdapter.Fill(this.RepDesignacionesDataSet.RepDesignaciones,"2018","III");
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("ciclo", "III");
            parametros[1] = new ReportParameter("ano", "2018");
            this.reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
        }
    }
}
