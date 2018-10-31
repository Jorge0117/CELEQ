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

            int screenWidth = Screen.FromControl(this).Bounds.Width;
            int screenHeight = Screen.FromControl(this).Bounds.Height;

            //labelUcr.Width = screenWidth / 5;
            //labelUcr.Height = screenWidth / 27;
            labelUcr.Font = new Font("Microsoft Sans Serif", screenWidth / 74);
            labelUcr.Location = new Point(screenWidth/2 - labelUcr.Width/2, (int)(screenHeight * 0.3));
            //labelCeleq.Width = screenWidth / 3;
            //labelCeleq.Height = screenWidth / 27;
            labelCeleq.Font = new Font("Microsoft Sans Serif", screenWidth / 80);
            labelCeleq.Location = new Point(screenWidth / 2 - labelCeleq.Width / 2, (int)(screenHeight * 0.35));
            pictureUcr.Width = screenWidth / 15;
            pictureUcr.Height = screenHeight / 9;
            pictureUcr.Location = new Point((int)(screenWidth * 0.25), (int)(screenHeight * 0.3));
            pictureCeleq.Width = screenWidth / 15;
            pictureCeleq.Height = screenHeight / 9;
            pictureCeleq.Location = new Point((int)(screenWidth * 0.75 - pictureCeleq.Width), (int)(screenHeight * 0.3));

            this.Hide();
            comprobarPermisos();
            linkLogout.Hide();
            Login login = new Login();
            login.ShowDialog();
            login.Dispose();
            this.Show();
            comprobarPermisos();
            labelBienv.Text += Globals.usuario;
            linkLogout.Show();
        }

        private void comprobarPermisos()
        {
            
            if(Globals.categoria == "Administrador")
            {
                regenciaToolStripMenuItem.Visible = true;
                solicitudesPendientesToolStripMenuItem.Visible = true;
                historialDeSolicitudesToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }
            else if(Globals.categoria == "Regencia")
            {
                regenciaToolStripMenuItem.Visible = true;
                solicitudesPendientesToolStripMenuItem.Visible = true;
                historialDeSolicitudesToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = false;
            }
            else if(Globals.categoria == "Estudiante")
            {
                regenciaToolStripMenuItem.Visible = true;
                solicitudesPendientesToolStripMenuItem.Visible = false;
                historialDeSolicitudesToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
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

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globals.usuario = "";
            Globals.correo = "";
            Globals.categoria = "Estudiante";
            labelBienv.Text = "Bienvenido ";
            linkLogout.Hide();
            this.Hide();
            Login login = new Login();
            login.logged = false;
            login.ShowDialog();
            if(login.logged == true)
            {
                this.Show();
                comprobarPermisos();
                labelBienv.Text += Globals.usuario;
                linkLogout.Show();
            }
            login.Dispose();
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.ShowDialog();
            agregarUsuario.Dispose();
        }

        private void solicitudesRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaSolicitudes ls = new ListaSolicitudes(2);
            ls.ShowDialog();
            ls.Dispose();
        }
    }

    public static class Globals
    {
        public static string usuario;
        public static string correo;
        public static string categoria = "Estudiante";

        public static string[] listaCategorias = new string[] { "Estudiante", "Regencia", "Administrador" };
    }

}
