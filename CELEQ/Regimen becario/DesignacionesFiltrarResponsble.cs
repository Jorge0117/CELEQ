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
    public partial class DesignacionesFiltrarResponsble : Form
    {
        string ano;
        string ciclo;
        string ver;
        public DesignacionesFiltrarResponsble(string a, string c, string v = null)
        {
            ano = a;
            ciclo = c;
            ver = v;
            InitializeComponent();
        }

        private void DesignacionesFiltrarResponsble_Load(object sender, EventArgs e)
        {

            if (ver == null)
            {
                this.RepDesignacionesTableAdapter.Fill(this.RepDesignacionesResponsable.RepDesignaciones, ano, ciclo);
            }
            else
            {
                this.RepDesignacionesTableAdapter.FillByResponsable(this.RepDesignacionesResponsable.RepDesignaciones, ano, ciclo, ver);
            }
            ReportParameter[] parameter = new ReportParameter[2];
            parameter[0] = new ReportParameter("ano", ano);
            parameter[1] = new ReportParameter("ciclo", ciclo);
            this.reportViewer1.LocalReport.SetParameters(parameter);

            this.reportViewer1.RefreshReport();
        }
    }
}
