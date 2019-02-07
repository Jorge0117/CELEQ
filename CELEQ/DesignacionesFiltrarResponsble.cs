﻿using System;
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
        public DesignacionesFiltrarResponsble()
        {
            InitializeComponent();
        }

        private void DesignacionesFiltrarResponsble_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'RepDesignacionesResponsable.RepDesignaciones' table. You can move, or remove it, as needed.
            this.RepDesignacionesTableAdapter.Fill(this.RepDesignacionesResponsable.RepDesignaciones, "2018", "III");
            ReportParameter[] parameter = new ReportParameter[2];
            parameter[0] = new ReportParameter("ano", "2018");
            parameter[1] = new ReportParameter("ciclo", "III");
            this.reportViewer1.LocalReport.SetParameters(parameter);

            this.reportViewer1.RefreshReport();
        }
    }
}