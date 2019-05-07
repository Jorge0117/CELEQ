using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        Warning[] warnings;
        string[] streamids;
        string mimeType;
        string encoding;
        string filenameExtension;
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

        public void saveToPdf()
        {
            string anno = DateTime.Now.Year.ToString();
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + anno);
            byte[] bytes = reportViewer1.LocalReport.Render(
                "PDF", null, out mimeType, out encoding, out filenameExtension,
                out streamids, out warnings);

            using (FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + anno + "/" + consecutivo + ".pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
