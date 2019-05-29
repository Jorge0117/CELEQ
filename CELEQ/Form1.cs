using CELEQ.Vinculo_externo;
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
            labelUcr.Font = new Font("Times New Roman", screenWidth / 70);
            labelUcr.Location = new Point(screenWidth/2 - labelUcr.Width/2, (int)(screenHeight * 0.3));
            //labelCeleq.Width = screenWidth / 3;
            //labelCeleq.Height = screenWidth / 27;
            labelCeleq.Font = new Font("Times New Roman", screenWidth / 76);
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
            if (login.logged == true)
            {
                this.Show();
                comprobarPermisos();
                labelBienv.Text += Globals.usuario;
                linkLogout.Show();
            }
            login.Dispose();
        }

        private void comprobarPermisos()
        {
            
            if(Globals.categoria == "Administrador")
            {
                regenciaToolStripMenuItem.Visible = true;
                solicitudesPendientesToolStripMenuItem.Visible = true;
                historialDeSolicitudesToolStripMenuItem.Visible = true;
            }
            else if(Globals.categoria == "Regencia")
            {
                regenciaToolStripMenuItem.Visible = true;
                solicitudesPendientesToolStripMenuItem.Visible = true;
                historialDeSolicitudesToolStripMenuItem.Visible = true;
            }
            else if(Globals.categoria == "Estudiante")
            {
                regenciaToolStripMenuItem.Visible = true;
                solicitudesPendientesToolStripMenuItem.Visible = false;
                historialDeSolicitudesToolStripMenuItem.Visible = false;
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

        private void realizarSolicitudMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitudMantenimiento sl = new SolicitudMantenimiento();
            sl.ShowDialog();
            sl.Dispose();
        }

        private void verSolicitudesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListaSolicitudMantenimiento lsm = new ListaSolicitudMantenimiento();
            lsm.ShowDialog();
            lsm.Dispose();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unidad unidad = new Unidad();
            unidad.ShowDialog();
            unidad.Dispose();
        }

        private void analizarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalizarSolicitudMantenimiento asm = new AnalizarSolicitudMantenimiento();
            asm.ShowDialog();
            asm.Dispose();
        }

        private void finalizarSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeFinalSolicitudes fs = new InformeFinalSolicitudes();
            fs.ShowDialog();
            fs.Dispose();
        }

        private void históricoDeSolicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricoSolicitudesMantenimiento hsm = new HistoricoSolicitudesMantenimiento();
            hsm.ShowDialog();
            hsm.Dispose();
        }

        private void arancelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aranceles aranceles = new Aranceles();
            aranceles.ShowDialog();
            aranceles.Dispose();
        }

        private void agregarDesignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Designacion designacion = new Designacion();
            designacion.ShowDialog();
            designacion.Dispose();
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presupuesto p = new Presupuesto();
            p.ShowDialog();
            p.Dispose();
        }

        private void verDesignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDesignaciones l = new ListaDesignaciones();
            l.ShowDialog();
            l.Dispose();
        }

        private void verEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstudiantes l = new ListaEstudiantes();
            l.ShowDialog();
            l.Dispose();
        }

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarReporteDesignaciones reporteDesignaciones = new GenerarReporteDesignaciones();
            reporteDesignaciones.ShowDialog();
            reporteDesignaciones.Dispose();
        }

        private void pruebaReportePresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteDesignacionesPresupuesto r = new ReporteDesignacionesPresupuesto("2018", "III");
            r.ShowDialog();
            r.Dispose();
        }

        private void responsablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encargados en = new Encargados();
            en.ShowDialog();
            en.Dispose();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cotizacion cotizacion = new Cotizacion(0);
            cotizacion.ShowDialog();
            cotizacion.Dispose();
        }

        private void preciosParaGirasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreciosGiras preciosGiras = new PreciosGiras();
            preciosGiras.ShowDialog();
            preciosGiras.Dispose();
        }

        private void localizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizaciones l = new Localizaciones();
            l.ShowDialog();
            l.Dispose();    
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientesCotizacion lcc = new ListaClientesCotizacion();
            lcc.ShowDialog();
            lcc.Dispose();
        }

        private void análisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaAnalisisCotizacion la = new ListaAnalisisCotizacion();
            la.ShowDialog();
            la.Dispose();
        }

        private void listaMaestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMaestra l = new ListaMaestra();
            l.ShowDialog();
            l.Dispose();
        }

		private void feriadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Feriados f = new Feriados();
			f.ShowDialog();
			f.Dispose();
		}

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPuestos puestos = new ListaPuestos(false);
            puestos.ShowDialog();
            puestos.Dispose();
        }

        private void recepciónDeMuestrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecepcionMuestrasCotizacion recepcionMuestras = new RecepcionMuestrasCotizacion();
            recepcionMuestras.ShowDialog();
            recepcionMuestras.Dispose();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listarCotizaciones l = new listarCotizaciones();
            l.ShowDialog();
            l.Dispose();
        }

        private void reporteCristaleríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteCristaleria rc = new ReporteCristaleria("Inventario de cristalería","P-05:PC-01:F01");
            rc.ShowDialog();
            rc.Dispose();
        }

        private void reporteReactivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteReactivos rr = new ReporteReactivos("Inventario de reactivos", "P-05:PC-01:F01");
            rr.ShowDialog();
            rr.Dispose();
        }

        private void listarPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permisos p = new Permisos();
            p.ShowDialog();
            p.Dispose();
        }

        private void listarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos g = new Grupos();
            g.ShowDialog();
            g.Dispose();
        }
    }

    public static class Globals
    {
        public static string usuario;
        public static string correo;
        public static string categoria = "Estudiante";

        public static string[] listaCategorias = new string[] { "Estudiante", "Regencia", "Administrador" , "Dirección", "Mantenimiento"};
    }

}

        