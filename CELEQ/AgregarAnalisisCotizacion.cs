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
    public partial class AgregarAnalisisCotizacion : Form
    {
        AccesoBaseDatos bd;
        string tipoAnalisis;
        public AgregarAnalisisCotizacion(string tipo)
        {
            InitializeComponent();
            tipoAnalisis = tipo;
        }

        private void AgregarAnalisisCotizacion_Load(object sender, EventArgs e)
        {
            textTipoMuestra.Text = tipoAnalisis;
            textTipoMuestra.Enabled = false;
        }
    }
}
