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
    public partial class DatosSolicitud : Form
    {
        private int segundos = 600;
        AccesoBaseDatos bd;
        public DatosSolicitud()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos--;
            int min = segundos / 60;
            int sec = segundos % 60;
            string timer;
            timer = min < 10 ? "0" + min.ToString() + ":" : min.ToString() + ":";
            timer = sec < 10 ? timer + "0" + sec.ToString() : timer + sec.ToString();
            labelTimer.Text = timer;
            if (segundos == 0)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void DatosSolicitud_Load(object sender, EventArgs e)
        {
            labelIdSolicitud.Text = generarId(bd.obtenerUltimoIdSolicitud());
        }

        private string generarId(string idAnterior)
        {
            string idNuevo = "REG - " + dtpFechaSol.Value.Year + " - ";
            int ultimoConsecutivo = Convert.ToInt32(idAnterior.Substring(idAnterior.Length - 4));
            int numDigitos = Convert.ToInt32(Math.Floor(Math.Log10(ultimoConsecutivo) + 1));
            for(int i=0; i<4-numDigitos; ++i)
            {
                idNuevo += "0";
            }
            return idNuevo + (ultimoConsecutivo + 1).ToString();
        }
    }
}
