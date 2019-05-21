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
    public partial class ReporteReactivos : Form
    {
        string nombreDocumento;
        string versionDocumento;
        public ReporteReactivos(string nombreDocumento, string versionDocumento)
        {
            this.nombreDocumento = nombreDocumento;
            this.versionDocumento = versionDocumento;
            InitializeComponent();
        }

        private void ReporteReactivos_Load(object sender, EventArgs e)
        {
            this.ReactivoTableAdapter.Fill(this.InventarioReactivos.Reactivo);

            /*ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("nombreDocumento", nombreDocumento);
            parametros[1] = new ReportParameter("versionDocumento", versionDocumento);*/

            this.reportViewer1.RefreshReport();
        }
    }
}
