﻿using System;
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
    public partial class ReporteTransferenciaDeMuestras : Form
    {
        public ReporteTransferenciaDeMuestras()
        {
            InitializeComponent();
        }

        private void ReporteTransferenciaDeMuestras_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}