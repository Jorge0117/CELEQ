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

            this.reportViewer1.RefreshReport();
        }
    }
}
