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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void reactivosYCristaleríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReacCris frc = new FormReacCris();
            frc.ShowDialog();
            frc.Dispose();
        }

        private void reactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(0, null);
            inventario.ShowDialog();
            inventario.Dispose();
        }

        private void cristaleríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(1, null);
            inventario.ShowDialog();
            inventario.Dispose();
        }
    }
}
