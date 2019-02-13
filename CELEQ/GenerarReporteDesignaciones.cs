using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CELEQ
{
    public partial class GenerarReporteDesignaciones : Form
    {
        AccesoBaseDatos bd;
        public GenerarReporteDesignaciones()
        {
            bd = new AccesoBaseDatos();
            InitializeComponent();
        }

        private void GenerarReporteDesignaciones_Load(object sender, EventArgs e)
        {
            comboFiltro.Items.Add("Presupuesto");
            comboFiltro.Items.Add("Encargado");
            comboFiltro.Items.Add("Estudiante");

            numAno.Value = DateTime.Today.Year;

            comboVer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboVer.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void butGenerarReporte_Click(object sender, EventArgs e)
        {
            if (comboFiltro.Text == "" || (checkCicloI.Checked == false && checkCicloIIC.Checked == false && checkCicloII.Checked == false
                && checkCicloIIIC.Checked == false && checkcicloIII.Checked == false))
            {
                MessageBox.Show("Por favor llenar los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string ciclo = "";
                if (checkCicloI.Checked)
                    ciclo = "I";
                else if (checkCicloIIC.Checked)
                    ciclo = "I I.C";
                else if (checkCicloII.Checked)
                    ciclo = "II";
                else if (checkCicloIIIC.Checked)
                    ciclo = "II I.C";
                else if (checkcicloIII.Checked)
                    ciclo = "III";

                if (comboFiltro.Text == "Presupuesto")
                {
                    ReporteDesignacionesPresupuesto rd;
                    if (comboVer.Text == "Todos")
                    {
                        rd = new ReporteDesignacionesPresupuesto(numAno.Text, ciclo);
                        
                    }
                    else
                    {
                        rd = new ReporteDesignacionesPresupuesto(numAno.Text, ciclo, comboVer.Text);
                    }
                    rd.ShowDialog();
                    rd.Dispose();

                }
                else if(comboFiltro.Text == "Encargado")
                {
                    DesignacionesFiltrarResponsble dfr;
                    if (comboVer.Text == "Todos")
                    {
                        dfr = new DesignacionesFiltrarResponsble(numAno.Text, ciclo);
                    }
                    else
                    {
                        dfr = new DesignacionesFiltrarResponsble(numAno.Text, ciclo, comboVer.Text);
                    }
                        
                    dfr.ShowDialog();
                    dfr.Dispose();
                }
                else
                {
                    DesignacionFiltrarEstudiantes dfe;
                    if(comboVer.Text == "Todos")
                    {
                        dfe = new DesignacionFiltrarEstudiantes(numAno.Text, ciclo);
                    }
                    else
                    {
                        dfe = new DesignacionFiltrarEstudiantes(numAno.Text, ciclo, comboVer.Text);
                    }
                    
                    dfe.ShowDialog();
                    dfe.Dispose();
                }
            }
        }

        private void checkCicloI_CheckedChanged(object sender, EventArgs e)
        {
            if(checkCicloI.Checked == true)
            {
                checkCicloIIC.Checked = false;
                checkCicloII.Checked = false;
                checkCicloIIIC.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkCicloIIC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCicloIIC.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloII.Checked = false;
                checkCicloIIIC.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkCicloII_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCicloII.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloIIC.Checked = false;
                checkCicloIIIC.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkCicloIIIC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCicloIIIC.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloIIC.Checked = false;
                checkCicloII.Checked = false;
                checkcicloIII.Checked = false;
            }
        }

        private void checkcicloIII_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcicloIII.Checked == true)
            {
                checkCicloI.Checked = false;
                checkCicloIIC.Checked = false;
                checkCicloII.Checked = false;
                checkCicloIIIC.Checked = false;
            }
        }


        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboVer.Items.Clear();
            comboVer.Items.Add("Todos");
            if (comboFiltro.Text == "Presupuesto")
            {
                SqlDataReader presupuestos = bd.ejecutarConsulta("select codigo from presupuesto");
                while (presupuestos.Read())
                {  
                    comboVer.Items.Add(presupuestos[0].ToString());
                }
            }
            else if (comboFiltro.Text == "Encargado")
            {
                SqlDataReader encargados = bd.ejecutarConsulta("select nombre from responsable");
                while (encargados.Read())
                {
                    comboVer.Items.Add(encargados[0].ToString());
                }
            }
            else if (comboFiltro.Text == "Estudiante")
            {
                SqlDataReader estudiantes = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2) from estudiante");
                while (estudiantes.Read())
                {
                    comboVer.Items.Add(estudiantes[0].ToString());
                }
            }
        }
    }
}
