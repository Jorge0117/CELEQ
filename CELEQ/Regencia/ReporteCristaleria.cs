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
    public partial class ReporteCristaleria : Form
    {
        string nombreDocumento;
        string versionDocumento;
        public ReporteCristaleria(string nombreDocumento, string versionDocumento)
        {
            this.nombreDocumento = nombreDocumento;
            this.versionDocumento = versionDocumento;
            InitializeComponent();
        }

        private void ReporteCotizacion_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void ReporteCristaleria_Load(object sender, EventArgs e)
        {
            this.CristaleriaTableAdapter.Fill(this.InventarioCristaleria.Cristaleria);

            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("nombreDocumento", nombreDocumento);
            parametros[1] = new ReportParameter("versionDocumento", versionDocumento);
            this.reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
        }
    }
}
