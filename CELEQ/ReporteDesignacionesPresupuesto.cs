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
    public partial class ReporteDesignacionesPresupuesto : Form
    {
        string ano;
        string ciclo;
        public ReporteDesignacionesPresupuesto(string a, string c)
        {
            ano = a;
            ciclo = c;
            InitializeComponent();
        }

        private void ReporteDesignacionesPresupuesto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RepDesignacionesDataSet.RepDesignaciones' table. You can move, or remove it, as needed.
            this.RepDesignacionesTableAdapter.Fill(this.RepDesignacionesDataSet.RepDesignaciones, ano, ciclo);
            ReportParameter[] parametros = new ReportParameter[2];
            parametros[0] = new ReportParameter("ciclo", ciclo);
            parametros[1] = new ReportParameter("ano", ano);
            this.reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
        }
    }
}
