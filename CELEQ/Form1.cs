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

        private void Form1_Load(object sender, EventArgs e)
        {
            comprobarPermisos();
            Login login = new Login();
            login.ShowDialog();
            login.Dispose();
            comprobarPermisos();
            labelBienv.Text += Globals.usuario;
        }

        private void comprobarPermisos()
        {
            if (Globals.categoria != "Administrador")
            {
                usuariosToolStripMenuItem.Visible = false;
            }
            else
            {
                usuariosToolStripMenuItem.Visible = true;
            }

            if (Globals.categoria == "Estudiante")
            {
                verSolicitudesToolStripMenuItem.Visible = false;
            }
            else
            {
                verSolicitudesToolStripMenuItem.Visible = true;
            }
        }

        private void solicitudesPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaSolicitudes listaSolicitudes = new ListaSolicitudes(0);
            listaSolicitudes.ShowDialog();
            listaSolicitudes.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaUsuarios ls = new ListaUsuarios();
            ls.ShowDialog();
            ls.Dispose();
        }

        private void historialDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaSolicitudes ls = new ListaSolicitudes(1);
            ls.ShowDialog();
            ls.Dispose();
        }
    }

    public static class Globals
    {
        public static string usuario;
        public static string correo;
        public static string categoria = "Estudiante";
    }

}
