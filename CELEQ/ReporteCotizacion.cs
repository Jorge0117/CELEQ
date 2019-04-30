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
        string versionDocumento;
        string consecutivo;
        string nombreDocumento;
        int gastosAdmin;
        int descuento;
        public ReporteCotizacion(int id, int anno, string versionDocumento, string consecutivo, string nombreDocumento, int gastosAdmin, int descuento)
        {
            this.id = id;
            this.anno = anno;
            this.versionDocumento = versionDocumento;
            this.consecutivo = consecutivo;
            this.nombreDocumento = nombreDocumento;
            this.gastosAdmin = gastosAdmin;
            this.descuento = descuento;
            InitializeComponent();
        }

        private void ReporteCotizacion_Load(object sender, EventArgs e)
        {
             this.vistaAnalisisTableAdapter.FillBy(this.CotizacionDataSet.vistaAnalisis, id, anno);

            this.vistaCotizacionTableAdapter.FillBy(this.CotizacionDataSet.vistaCotizacion, id, anno);

            ReportParameter[] parametros = new ReportParameter[5];
            parametros[0] = new ReportParameter("versionDocumento", versionDocumento);
            parametros[1] = new ReportParameter("Consecutivo", consecutivo);
            parametros[2] = new ReportParameter("nombreDocumento", nombreDocumento);
            parametros[3] = new ReportParameter("gastosAdmin", gastosAdmin.ToString());
            parametros[4] = new ReportParameter("descuento", descuento.ToString());
            this.reportViewer1.LocalReport.SetParameters(parametros);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
