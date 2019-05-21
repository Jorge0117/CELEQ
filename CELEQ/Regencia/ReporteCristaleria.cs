using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELEQ.Regencia
{
    public partial class ReporteCristaleria : Form
    {
        public ReporteCristaleria()
        {
            InitializeComponent();
        }

        private void ReporteCristaleria_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
