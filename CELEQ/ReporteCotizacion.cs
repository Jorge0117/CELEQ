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
        int id;
        int anno;
        string versionD;
        string consecutivo;
        string nd;
        public ReporteCotizacion(int i, int a, string v, string c, string n)
        {
            id = i;
            anno = a;
            versionD = v;
            consecutivo = c;
            nd = n;
            InitializeComponent();
        }

        private void ReporteCotizacion_Load(object sender, EventArgs e)
        {
             this.vistaAnalisisTableAdapter.FillBy(this.CotizacionDataSet.vistaAnalisis, id, anno);

            this.vistaCotizacionTableAdapter.FillBy(this.CotizacionDataSet.vistaCotizacion, id, anno);

            ReportParameter[] parametros = new ReportParameter[3];
            parametros[0] = new ReportParameter("versionDocumento", versionD);
            parametros[1] = new ReportParameter("Consecutivo", consecutivo);
            parametros[2] = new ReportParameter("nombreDocumento", nd);
            this.reportViewer1.LocalReport.SetParameters(parametros);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
