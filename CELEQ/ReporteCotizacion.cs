using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class ReporteCotizacion : Form
    {
        public ReporteCotizacion()
        {
            InitializeComponent();
        }

        private void ReporteCotizacion_Load(object sender, EventArgs e)
        {
             this.vistaAnalisisTableAdapter.FillBy(this.CotizacionDataSet.vistaAnalisis, 1, 2019);

            this.vistaCotizacionTableAdapter.FillBy(this.CotizacionDataSet.vistaCotizacion, 1, 2019);

            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("versionDocumento", "P-03:F01 Versión 01 Fecha: 25/04/2019");
            parametros[1] = new ReportParameter("Consecutivo", "CELEQ-1418-2018");
            this.reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
