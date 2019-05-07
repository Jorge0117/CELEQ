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
        int? idDesignacion;
        List<string> p9Files;
        bool agregandoP9 = false;
        public Designacion(int? id = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            idDesignacion = id;
            p9Files = new List<string>();
        }

        private void Designacion_Load(object sender, EventArgs e)
        {
            try
            {
                labelMotivo.Visible = false;
                textInopia.Visible = false;

                adjuntarDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                adjuntarDialog.Filter = "PDF files (*.pdf)|*.pdf";
                adjuntarDialog.FilterIndex = 0;
                adjuntarDialog.RestoreDirectory = true;

                saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.FilterIndex = 0;
                saveDialog.RestoreDirectory = true;

                SqlDataReader unidades = bd.ejecutarConsulta("select nombre from unidad");
                while (unidades.Read())
                {
                    comboUnidad.Items.Add(unidades[0].ToString());
                }

                SqlDataReader responsables = bd.ejecutarConsulta("select nombre from responsable");
                while (responsables.Read())
                {
                    comboResponsables.Items.Add(responsables[0].ToString());
                }


                //Si se va a agregar
                if (idDesignacion == null)
                {
                    comboTipoId.Items.Add("Cédula nacional");
                    comboTipoId.Items.Add("Cédula residencia");
                    comboTipoId.Items.Add("Pasaporte");
                    comboTipoId.Items.Add("Permiso residencia");
                    comboTipoId.SelectedIndex = 0;

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

                    butDescargar.Visible = false;
                    labelArchivo.Visible = false;

                    butAdjuntar.Visible = false;
                    butAgregarP9.Visible = false;

                    dateInicio.Value = DateTime.Today;
                    datefinal.Value = dateInicio.Value.AddDays(1);
                    datefinal.MinDate = dateInicio.Value.AddDays(1);
                }
                //Si se va a visualizar
                else
                {
                    butAceptar.Text = "Modificar";
                    butAgregarPresupuesto.Visible = false;

                    SqlDataReader datosDesignacion = bd.ejecutarConsulta("select ano, ciclo, fechainicio, fechafinal, convocatoria, horas, modalidad, inopia, " +
                        "motivoInopia, tramitado, observaciones, presupuesto, encargado, unidad, idestudiante, adHonorem from designacionasistencia where id = " + idDesignacion);

                    datosDesignacion.Read();
                    numAnno.Value = Convert.ToDecimal(datosDesignacion[0]);
                    comboCiclo.Items.Add(datosDesignacion[1].ToString());
                    comboCiclo.SelectedIndex = 0;
                    dateInicio.Value = DateTime.Parse(datosDesignacion[2].ToString());
                    datefinal.Value = DateTime.Parse(datosDesignacion[3].ToString());
                    textConvocatoria.Text = datosDesignacion[4].ToString();
                    numHoras.Value = Convert.ToDecimal(datosDesignacion[5].ToString());
                    comboModalidad.Items.Add(datosDesignacion[6].ToString());
                    comboModalidad.SelectedIndex = 0;

                    if (Convert.ToInt32(datosDesignacion[7]) == 1)
                    {
                        checkInopia.Checked = true;
                        textInopia.Visible = true;
                        labelMotivo.Visible = true;
                        textInopia.Text = datosDesignacion[8].ToString();
                    }

                    if (Convert.ToInt32(datosDesignacion[9]) == 1)
                    {
                        checkTramitado.Checked = true;
                    }

                    textObservaciones.Text = datosDesignacion[10].ToString();
                    comboPresupuesto.Items.Add(datosDesignacion[11].ToString());
                    comboPresupuesto.SelectedIndex = 0;
                    comboResponsables.SelectedIndex = comboResponsables.FindStringExact(datosDesignacion[12].ToString());
                    comboUnidad.SelectedIndex = comboUnidad.FindStringExact(datosDesignacion[13].ToString());

                    if (Convert.ToInt32(datosDesignacion[14]) == 1)
                    {
                        checkAdHonorem.Checked = true;
                    }

                    numAnno.Enabled = false;
                    comboCiclo.Enabled = false;
                    dateInicio.Enabled = false;
                    datefinal.Enabled = false;
                    textConvocatoria.Enabled = false;
                    numHoras.Enabled = false;
                    comboModalidad.Enabled = false;

                    checkInopia.Enabled = false;
                    textInopia.Enabled = false;
                    textInopia.Enabled = false;
                    checkTramitado.Enabled = false;

                    textObservaciones.Enabled = false;
                    comboPresupuesto.Enabled = false;
                    comboResponsables.Enabled = false;
                    comboUnidad.Enabled = false;
                    checkAdHonorem.Enabled = false;


                    string idEstudiante = datosDesignacion[14].ToString();
                    textIdentificacion.Text = idEstudiante;

                    SqlDataReader datosEstudiante = bd.ejecutarConsulta("select tipoId, nombre, apellido1, apellido2, correo, celular, telefonoFijo, carrera from estudiante where id = '" + idEstudiante + "'");
                    datosEstudiante.Read();
                    comboTipoId.Items.Add(datosEstudiante[0].ToString());
                    comboTipoId.SelectedIndex = 0;
                    textNombre.Text = datosEstudiante[1].ToString();
                    textApellido1.Text = datosEstudiante[2].ToString();
                    textApellido2.Text = datosEstudiante[3].ToString();
                    textCorreo.Text = datosEstudiante[4].ToString();
                    textCelular.Text = datosEstudiante[5].ToString();
                    textTelefono.Text = datosEstudiante[6].ToString();
                    textCarrera.Text = datosEstudiante[7].ToString();

                    textIdentificacion.Enabled = false;
                    comboTipoId.Enabled = false;
                    textNombre.Enabled = false;
                    textApellido1.Enabled = false;
                    textApellido2.Enabled = false;
                    textCorreo.Enabled = false;
                    textCelular.Enabled = false;
                    textTelefono.Enabled = false;
                    textCarrera.Enabled = false;

                    cargarP9();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al cargar la designación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelMotivo.Visible = !labelMotivo.Visible;
            textInopia.Visible = !textInopia.Visible;
            textInopia.Text = "";
        }

        private void comboP9_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Enter)
            {
                if (!comboP9.Items.Contains(comboP9.Text) && comboP9.Text!= "")
                {
                    comboP9.Items.Add(comboP9.Text);
                }      
            }
            */
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
                    //butDescargar.Visible = true;
                    butAdjuntar.Text = "Eliminar adjunto";
                }
            }
            else
            {
                filePath = null;
                butAdjuntar.Text = "Adjuntar archivo";
                labelArchivo.Visible = false;
                if (!agregandoP9)
                {
                    butDescargar.Visible = false;
                }
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (!agregandoP9)
            {
                agregandoP9 = true;
                comboP9.DropDownStyle = ComboBoxStyle.DropDown;
                comboP9.SelectedIndex = -1;
                comboP9.Text = "";
                butDescargar.Text = "Cancelar";
                butDescargar.Visible = true;
                labelArchivo.Text = "";
                butAdjuntar.Visible = true;
                butAceptar.Enabled = false;
            }
            else
            {
                //Lo agrega
                if(comboP9.Text != "")
                {
                    FileStream fs = null;
                    if (filePath != null)
                    {
                        fs = File.OpenRead(filePath);
                    }

                    bd.agregarP9(Path.GetFileName(filePath), fs, comboP9.Text, Convert.ToInt32(idDesignacion));
                }
                butAceptar.Enabled = true;
                agregandoP9 = false;
                butAdjuntar.Text = "Descargar archivo";

                comboP9.Items.Clear();
                cargarP9();
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            if(idDesignacion != null && butAceptar.Text == "Aceptar")
            {
                try
                {
                    comboResponsables.Items.Clear();
                    comboUnidad.Items.Clear();
                    comboPresupuesto.Items.Clear();
                    comboModalidad.Items.Clear();
                    comboCiclo.Items.Clear();
                    comboP9.Items.Clear();

                    labelMotivo.Visible = false;
                    textInopia.Visible = false;

                    adjuntarDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    adjuntarDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    adjuntarDialog.FilterIndex = 0;
                    adjuntarDialog.RestoreDirectory = true;

                    saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveDialog.FilterIndex = 0;
                    saveDialog.RestoreDirectory = true;

                    SqlDataReader unidades = bd.ejecutarConsulta("select nombre from unidad");
                    while (unidades.Read())
                    {
                        comboUnidad.Items.Add(unidades[0].ToString());
                    }

                    SqlDataReader responsables = bd.ejecutarConsulta("select nombre from responsable");
                    while (responsables.Read())
                    {
                        comboResponsables.Items.Add(responsables[0].ToString());
                    }

                    butAceptar.Text = "Modificar";
                    butAgregarPresupuesto.Visible = false;

                    SqlDataReader datosDesignacion = bd.ejecutarConsulta("select ano, ciclo, fechainicio, fechafinal, convocatoria, horas, modalidad, inopia, " +
                        "motivoInopia, tramitado, observaciones, presupuesto, encargado, unidad, idestudiante, adHonorem from designacionasistencia where id = " + idDesignacion);

                    datosDesignacion.Read();
                    numAnno.Value = Convert.ToDecimal(datosDesignacion[0]);
                    comboCiclo.Items.Add(datosDesignacion[1].ToString());
                    comboCiclo.SelectedIndex = 0;
                    dateInicio.Value = DateTime.Parse(datosDesignacion[2].ToString());
                    datefinal.Value = DateTime.Parse(datosDesignacion[3].ToString());
                    textConvocatoria.Text = datosDesignacion[4].ToString();
                    numHoras.Value = Convert.ToDecimal(datosDesignacion[5].ToString());
                    comboModalidad.Items.Add(datosDesignacion[6].ToString());
                    comboModalidad.SelectedIndex = 0;

                    if (Convert.ToInt32(datosDesignacion[7]) == 1)
                    {
                        checkInopia.Checked = true;
                        textInopia.Visible = true;
                        labelMotivo.Visible = true;
                        textInopia.Text = datosDesignacion[8].ToString();
                    }

                    if (Convert.ToInt32(datosDesignacion[9]) == 1)
                    {
                        checkTramitado.Checked = true;
                    }

                    textObservaciones.Text = datosDesignacion[10].ToString();
                    comboPresupuesto.Items.Add(datosDesignacion[11].ToString());
                    comboPresupuesto.SelectedIndex = 0;
                    comboResponsables.SelectedIndex = comboResponsables.FindStringExact(datosDesignacion[12].ToString());
                    comboUnidad.SelectedIndex = comboUnidad.FindStringExact(datosDesignacion[13].ToString());

                    if (Convert.ToInt32(datosDesignacion[14]) == 1)
                    {
                        checkAdHonorem.Checked = true;
                    }

                    numAnno.Enabled = false;
                    comboCiclo.Enabled = false;
                    dateInicio.Enabled = false;
                    datefinal.Enabled = false;
                    textConvocatoria.Enabled = false;
                    numHoras.Enabled = false;
                    comboModalidad.Enabled = false;

                    checkInopia.Enabled = false;
                    textInopia.Enabled = false;
                    textInopia.Enabled = false;
                    checkTramitado.Enabled = false;

                    textObservaciones.Enabled = false;
                    comboPresupuesto.Enabled = false;
                    comboResponsables.Enabled = false;
                    comboUnidad.Enabled = false;
                    checkAdHonorem.Enabled = false;


                    string idEstudiante = datosDesignacion[14].ToString();
                    textIdentificacion.Text = idEstudiante;

                    SqlDataReader datosEstudiante = bd.ejecutarConsulta("select tipoId, nombre, apellido1, apellido2, correo, celular, telefonoFijo, carrera from estudiante where id = '" + idEstudiante + "'");
                    datosEstudiante.Read();
                    comboTipoId.Items.Add(datosEstudiante[0].ToString());
                    comboTipoId.SelectedIndex = 0;
                    textNombre.Text = datosEstudiante[1].ToString();
                    textApellido1.Text = datosEstudiante[2].ToString();
                    textApellido2.Text = datosEstudiante[3].ToString();
                    textCorreo.Text = datosEstudiante[4].ToString();
                    textCelular.Text = datosEstudiante[5].ToString();
                    textTelefono.Text = datosEstudiante[6].ToString();
                    textCarrera.Text = datosEstudiante[7].ToString();

                    textIdentificacion.Enabled = false;
                    comboTipoId.Enabled = false;
                    textNombre.Enabled = false;
                    textApellido1.Enabled = false;
                    textApellido2.Enabled = false;
                    textCorreo.Enabled = false;
                    textCelular.Enabled = false;
                    textTelefono.Enabled = false;
                    textCarrera.Enabled = false;

                    cargarP9();
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error al cargar la designación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            datefinal.MinDate = dateInicio.Value.AddDays(1);

        }

        private void comboP9_TextChanged(object sender, EventArgs e)
        {
            if(idDesignacion == null)
            {
                if (comboP9.Text != "")
                {
                    butAdjuntar.Visible = true;
                    //butAgregarP9.Visible = true;
                }
                else
                {
                    butAdjuntar.Visible = false;
                    //butAgregarP9.Visible = false;
                }

                filePath = null;
                butAdjuntar.Text = "Adjuntar archivo";
                labelArchivo.Visible = false;
                butDescargar.Visible = false;
            }
            
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (idDesignacion == null)
            {
                if (comboTipoId.Text == "" || textIdentificacion.Text == "" || textCorreo.Text == "" || textCarrera.Text == "" ||
                comboResponsables.Text == "" || comboUnidad.Text == "" || comboCiclo.Text == "" ||
                comboModalidad.Text == "" || comboPresupuesto.Text == "" || textConvocatoria.Text == "" || comboP9.Text == "")
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
                    if(checkAdHonorem.Checked == false)
                    {
                        SqlDataReader valorHora;
                        if (comboModalidad.Text == "H.E")
                        {
                            valorHora = bd.ejecutarConsulta("select monto from montoHoras where tipo = 'HE'");
                        }
                        else if (comboModalidad.Text == "H.A")
                        {
                            valorHora = bd.ejecutarConsulta("select monto from montoHoras where tipo = 'HA'");
                        }
                        else
                        {
                            valorHora = bd.ejecutarConsulta("select monto from montoHoras where tipo = 'HP'");
                        }

                        valorHora.Read();

                        monto = Convert.ToInt32(numHoras.Value) * Convert.ToInt32(valorHora[0]);
                    }
                    else
                    {
                        monto = 0;
                    }
                    

                    int id = bd.agregarDesignacion(numAnno.Value.ToString(), comboCiclo.Text, dateInicio.Value.ToShortDateString(), datefinal.Value.ToShortDateString(),
                        textConvocatoria.Text, Convert.ToInt32(numHoras.Value), comboModalidad.Text, monto, checkInopia.Checked ? 1 : 0, textInopia.Text,
                        checkTramitado.Checked ? 1 : 0, textObservaciones.Text, textIdentificacion.Text, comboPresupuesto.Text, comboResponsables.Text, comboUnidad.Text,
                        checkAdHonorem.Checked ? 1 : 0);

                    if (id == -1)
                    {
                        MessageBox.Show("Error al crear la designación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (comboP9.Text != "")
                    {
                        FileStream fs = null;
                        if (filePath != null)
                        {
                            fs = File.OpenRead(filePath);
                        }

                        bd.agregarP9(Path.GetFileName(filePath), fs, comboP9.Text, id);

                    }

                    MessageBox.Show("Se realizado la designación de manera correcta", "Designaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
            }
            //Si se está visualizando
            else
            {
                if (butAceptar.Text == "Modificar")
                {

                    comboResponsables.Enabled = true;
                    comboUnidad.Enabled = true;
                    numHoras.Enabled = true;
                    datefinal.Enabled = true;
                    textObservaciones.Enabled = true;
                    checkTramitado.Enabled = true;


                    butAceptar.Text = "Aceptar";
                }
                else
                {
                    comboResponsables.Enabled = false;
                    comboUnidad.Enabled = false;
                    numHoras.Enabled = false;
                    datefinal.Enabled = false;
                    textObservaciones.Enabled = false;
                    checkTramitado.Enabled = false;
                    if(comboResponsables.Text != "" && comboUnidad.Text != "" && numHoras.Value != 0)
                    {
                        if(bd.modificarDesignacion(Convert.ToInt32(idDesignacion), comboResponsables.Text, comboUnidad.Text,
                        Convert.ToInt32(numHoras.Value), datefinal.Value.ToShortDateString(), textObservaciones.Text, checkTramitado.Checked ? 1 : 0) == 0)
                        {
                            MessageBox.Show("Se modificó la designación de manera correcta", "Designaciones", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            MessageBox.Show("Error al crear la designación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor llenar los campos requeridos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    

                    butAceptar.Text = "Modificar";
                }
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
            if (!agregandoP9)
            {
                if (labelArchivo.Text != "")
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
                        byte[] byteArray = bd.getP9Document(documento[0].ToString());
                        using (MemoryStream ms = new MemoryStream(byteArray))
                        {
                            ms.CopyTo(fs);
                        }
                        fs.Close();
                        MessageBox.Show("Se ha descargado el arcivo correctamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
            }
            else
            {
                agregandoP9 = false;
                butDescargar.Text = "Descargar archivo";
                butAceptar.Enabled = true;
                comboP9.Items.Clear();
                cargarP9();
            }

        }

        private void butAgregarPresupuesto_Click(object sender, EventArgs e)
        {
            AgregarPresupuesto ag = new AgregarPresupuesto();
            ag.ShowDialog();
            ag.Dispose();

            comboPresupuesto.Items.Clear();
            SqlDataReader presupuestos = bd.ejecutarConsulta("select codigo from presupuesto");
            while (presupuestos.Read())
            {
                comboPresupuesto.Items.Add(presupuestos[0].ToString());
            }

        }

        private void cargarP9()
        {
            SqlDataReader datosP9 = bd.ejecutarConsulta("select numero, nombre from p9 where idDesignacion  = " + idDesignacion + "order by numero desc");
            while (datosP9.Read())
            {
                comboP9.Items.Add(datosP9[0]);
                p9Files.Add(datosP9[1].ToString());
            }
            comboP9.SelectedIndex = 0;
            labelArchivo.Text = p9Files[0];
            labelArchivo.Visible = true;

            if (labelArchivo.Text != "")
            {
                butDescargar.Visible = true;
                butAdjuntar.Visible = false;
            }
            else
            {
                butDescargar.Visible = false;
                butAdjuntar.Visible = true;
            }

            comboP9.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboP9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!agregandoP9)
            {
                SqlDataReader archP9 = bd.ejecutarConsulta("select nombre from p9 where numero = '" + comboP9.SelectedItem.ToString() + "'");
                archP9.Read();
                labelArchivo.Text = archP9[0].ToString();
            }
            else if(comboP9.Text != "")
            {
                agregandoP9 = false;
                butDescargar.Text = "Descargar archivo";
                comboP9.DropDownStyle = ComboBoxStyle.DropDownList;
                SqlDataReader archP9 = bd.ejecutarConsulta("select nombre from p9 where numero = '" + comboP9.SelectedItem.ToString() + "'");
                archP9.Read();
                labelArchivo.Text = archP9[0].ToString();

            }
            butAceptar.Enabled = true;
            butAdjuntar.Visible = false;
            if(labelArchivo.Text == "")
            {
                butDescargar.Visible = false;
            }
            else
            {
                butDescargar.Visible = true;
            }
        }

        private void butAgregarResponsable_Click(object sender, EventArgs e)
        {
            string encargado = Microsoft.VisualBasic.Interaction.InputBox("Digite el nombre del responsable", "Responsable", " ");
            if (encargado != "" && encargado != " ")
            {
                bd.ejecutarConsulta("insert into responsable values ('" + encargado + "')");
                MessageBox.Show("Responsable agregado correctamente", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.None);
                SqlDataReader responsables = bd.ejecutarConsulta("select nombre from responsable");
                comboResponsables.Items.Clear();
                while (responsables.Read())
                {
                    comboResponsables.Items.Add(responsables[0].ToString());
                }
            }
            else if (encargado == " ")
            {
                MessageBox.Show("Por favor digite el nombre del responsable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            }
        }
    }

}
