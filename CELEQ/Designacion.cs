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
using System.IO;

namespace CELEQ
{
    public partial class Designacion : Form
    {
        AccesoBaseDatos bd;
        string filePath = null;
        public Designacion()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
        }

        private void Designacion_Load(object sender, EventArgs e)
        {
            comboTipoId.Items.Add("Cédula nacional");
            comboTipoId.Items.Add("Cédula residencia");
            comboTipoId.Items.Add("Pasaporte");
            comboTipoId.Items.Add("Permiso residencia");
            comboTipoId.SelectedIndex = 0;

            SqlDataReader encargados = bd.ejecutarConsulta("select concat(nombre, ' ', apellido1, ' ', apellido2) from Usuarios where categoria != 'Estudiante'");
            while (encargados.Read())
            {
                comboResponsable.Items.Add(encargados[0].ToString());
            }

            SqlDataReader unidades = bd.ejecutarConsulta("select nombre from unidad");
            while (unidades.Read())
            {
                comboUnidad.Items.Add(unidades[0].ToString());
            }

            comboCiclo.Items.Add("I");
            comboCiclo.Items.Add("I I.C");
            comboCiclo.Items.Add("II");
            comboCiclo.Items.Add("II I.C");
            comboCiclo.Items.Add("III");

            comboModalidad.Items.Add("H.E");
            comboModalidad.Items.Add("H.A");
            comboModalidad.Items.Add("H.A.P");

            SqlDataReader presupuestos = bd.ejecutarConsulta("select codigo from presupuesto");
            while (presupuestos.Read())
            {
                comboPresupuesto.Items.Add(presupuestos[0].ToString());
            }

            labelMotivo.Visible = false;
            textInopia.Visible = false;

            butDescargar.Visible = false;
            labelArchivo.Visible = false;
            adjuntarDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            adjuntarDialog.Filter = "PDF files (*.pdf)|*.pdf";
            adjuntarDialog.FilterIndex = 0;
            adjuntarDialog.RestoreDirectory = true;

            butAdjuntar.Visible = false;
            butEliminar.Visible = false;

            dateInicio.Value = DateTime.Today;
            datefinal.Value = dateInicio.Value.AddDays(1);
            datefinal.MinDate = dateInicio.Value.AddDays(1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelMotivo.Visible = !labelMotivo.Visible;
            textInopia.Visible = !textInopia.Visible;
            textInopia.Text = "";
        }

        private void comboP9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!comboP9.Items.Contains(comboP9.Text) && comboP9.Text!= "")
                {
                    comboP9.Items.Add(comboP9.Text);
                }      
            }
        }

        private void butAdjuntar_Click(object sender, EventArgs e)
        {
            if (butAdjuntar.Text == "Adjuntar archivo")
            {
                if (adjuntarDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = adjuntarDialog.FileName;
                    labelArchivo.Text = filePath;
                    labelArchivo.Visible = true;
                    butDescargar.Visible = true;
                    butAdjuntar.Text = "Eliminar adjunto";
                }
            }
            else
            {
                filePath = null;
                butAdjuntar.Text = "Adjuntar archivo";
                labelArchivo.Visible = false;
                butDescargar.Visible = false;
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (comboP9.Items.Contains(comboP9.Text))
            {
                comboP9.Items.Remove(comboP9.Text);
            }
            comboP9.Text = "";
            bd.ejecutarConsulta("delete from p9 where numero = '" + comboP9.Text + "'");
            filePath = null;
            butAdjuntar.Text = "Adjuntar archivo";
            labelArchivo.Visible = false;
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            datefinal.MinDate = dateInicio.Value.AddDays(1);

        }

        private void comboP9_TextChanged(object sender, EventArgs e)
        {
            if(comboP9.Text != "")
            {
                butAdjuntar.Visible = true;
                butEliminar.Visible = true;
            }
            else
            {
                butAdjuntar.Visible = false;
                butEliminar.Visible = false;
            }

            filePath = null;
            butAdjuntar.Text = "Adjuntar archivo";
            labelArchivo.Visible = false;
            butDescargar.Visible = false;
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(comboTipoId.Text == "" || textIdentificacion.Text == "" || textCorreo.Text == "" || textCarrera.Text == "" ||
                comboResponsable.Text == "" || comboUnidad.Text == "" || comboCiclo.Text == "" ||
                comboModalidad.Text == "" || comboPresupuesto.Text == "" || textConvocatoria.Text == "")
            {
                MessageBox.Show("Por favor llenar los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                //Se revisa si el estdiante está en la base
                SqlDataReader estudiante = bd.ejecutarConsulta("select id from estudiante where id = '" + textIdentificacion.Text + "'");
                if (!estudiante.Read())
                {
                    //Si no está se agrega
                    bd.agregarEstudiante(textIdentificacion.Text, comboTipoId.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, textCorreo.Text,
                        textCelular.Text, textTelefono.Text, textCarrera.Text);
                }
                else
                {
                    //En caso de que esté, se actualizan los datos en caso de algún cambio
                    bd.modificarEstudiante(textIdentificacion.Text, comboTipoId.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, textCorreo.Text,
                        textCelular.Text, textTelefono.Text, textCarrera.Text);
                }

                //Se calcula el monto mensual de la asistencia
                int monto;
                SqlDataReader valorHora;
                if(comboModalidad.Text == "H.E")
                {
                    valorHora = bd.ejecutarConsulta("select monto from montoHoras where tipo = 'HE'");
                }
                else if(comboModalidad.Text == "H.A")
                {
                    valorHora = bd.ejecutarConsulta("select monto from montoHoras where tipo = 'HA'");
                }
                else
                {
                    valorHora = bd.ejecutarConsulta("select monto from montoHoras where tipo = 'HP'");
                }

                valorHora.Read();

                monto = Convert.ToInt32(numHoras.Value) * Convert.ToInt32(valorHora[0]);

                //Se obtiene el nombre de usuario del encargado
                SqlDataReader nombreUsuario = bd.ejecutarConsulta("select nombreUsuario from usuarios where concat(nombre, ' ', apellido1, ' ', apellido2) = '" + comboResponsable.Text + "'");
                nombreUsuario.Read();

                int id = bd.agregarDesignacion(numAnno.Value.ToString(), comboCiclo.Text, dateInicio.Value.ToShortDateString(), datefinal.Value.ToShortDateString(),
                    textConvocatoria.Text, Convert.ToInt32(numHoras.Value), comboModalidad.Text, monto, checkInopia.Checked ? 1 : 0, textInopia.Text,
                    checkTramitado.Checked ? 1 : 0, textObservaciones.Text, textIdentificacion.Text, comboPresupuesto.Text, nombreUsuario[0].ToString(), comboUnidad.Text);

                if(id == -1)
                {
                    MessageBox.Show("Error al crear la designación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    FileStream fs = null;
                    if (filePath != null)
                    {
                        fs = File.OpenRead(filePath);
                    }

                    bd.agregarP9(Path.GetFileName(filePath), fs, Convert.ToInt32(comboP9.Text), id);

                }

                MessageBox.Show("Se realizado la designación de manera correcta", "Designaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }

        }

        private void textIdentificacion_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader estudiante = bd.ejecutarConsulta("select nombre, apellido1, apellido2, correo, celular, telefonofijo, carrera from estudiante where id = '" + textIdentificacion.Text + "' and tipoId ='" + comboTipoId.Text + "'");
            if (estudiante.Read())
            {
                textNombre.Text = estudiante[0].ToString();
                textApellido1.Text = estudiante[1].ToString();
                textApellido2.Text = estudiante[2].ToString();
                textCorreo.Text = estudiante[3].ToString();
                textCelular.Text = estudiante[4].ToString();
                textTelefono.Text = estudiante[5].ToString();
                textCarrera.Text = estudiante[6].ToString();

            }
        }


        private void comboTipoId_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader estudiante = bd.ejecutarConsulta("select nombre, apellido1, apellido2, correo, celular, telefonofijo, carrera from estudiante where id = '" + textIdentificacion.Text + "' and tipoId ='" + comboTipoId.Text + "'");
            if (estudiante.Read())
            {
                textNombre.Text = estudiante[0].ToString();
                textApellido1.Text = estudiante[1].ToString();
                textApellido2.Text = estudiante[2].ToString();
                textCorreo.Text = estudiante[3].ToString();
                textCelular.Text = estudiante[4].ToString();
                textTelefono.Text = estudiante[5].ToString();
                textCarrera.Text = estudiante[6].ToString();

            }
        }

        private void butDescargar_Click(object sender, EventArgs e)
        {

            if(filePath != null)
            {

                //Se obtiene el id del documento
                SqlDataReader documento = bd.ejecutarConsulta("Select id from p9 where numero = '" + comboP9.Text + "'");
                documento.Read();

                string fileType = Path.GetExtension(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);

                saveDialog.FileName = fileName;
                saveDialog.Filter = "Tipo de archivo (*" + fileType + ")|*" + fileType;
                saveDialog.DefaultExt = fileType;
                saveDialog.AddExtension = true;
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create);
                    byte[] byteArray = bd.getDocument(documento[0].ToString());
                    using (MemoryStream ms = new MemoryStream(byteArray))
                    {
                        ms.CopyTo(fs);
                    }
                    fs.Close();
                    MessageBox.Show("Se ha descargado el arcivo correctamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

        }
    }

}
