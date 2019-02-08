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
    public partial class DesignacionFiltrarEstudiantes : Form
    {
        string ano;
        string ciclo;
        public DesignacionFiltrarEstudiantes(string a, string c)
        {
            ano = a;
            ciclo = c;
            InitializeComponent();
        }

        private void DesignacionFiltrarEstudiantes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RepDesignacionesResponsable.RepDesignaciones' table. You can move, or remove it, as needed.
            this.RepDesignacionesTableAdapter.Fill(this.RepDesignacionesResponsable.RepDesignaciones, ano, ciclo);
            ReportParameter[] parameter = new ReportParameter[2];
            parameter[0] = new ReportParameter("ano", ano);
            parameter[1] = new ReportParameter("ciclo", ciclo);
            this.reportViewer1.LocalReport.SetParameters(parameter);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
