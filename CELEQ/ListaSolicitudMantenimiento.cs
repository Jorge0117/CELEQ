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
    public partial class ListaSolicitudMantenimiento : Form
    {
        AccesoBaseDatos bd;
        public ListaSolicitudMantenimiento()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvSolicitudes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSolicitudes.MultiSelect = false;
            dgvSolicitudes.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTabla()
        {
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select Id as 'Consecutivo', fecha as 'Fecha de solicitud', urgencia as 'Urgencia' from SolicitudMantenimiento where estado = 'Pendiente'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvSolicitudes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvSolicitudes.DataSource = bs;
            for (int i = 0; i < dgvSolicitudes.ColumnCount; ++i)
            {
                dgvSolicitudes.Columns[i].Width = dgvSolicitudes.Width / dgvSolicitudes.ColumnCount - 1;
            }
        }

        private void ListaSolicitudMantenimiento_Load(object sender, EventArgs e)
        {
            llenarTabla();
            dgvSolicitudes.ClearSelection();

            labelPersonaAsignada.Visible = false;
            labelObservaciones.Visible = false;
            comboPersonas.Visible = false;
            textObservaciones.Visible = false;

            checkBoxAprobado.Visible = false;
            checkBoxRechazar.Visible = false;

            butAceptar.Visible = false;
        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            checkBoxAprobado.Visible = true;
            checkBoxRechazar.Visible = true;

            textConsecutivo.Text = dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString();

            SqlDataReader datosSolicitud = bd.ejecutarConsulta("select fecha, nombreSolicitante, telefono, contactoAdicional, urgencia, areaTrabajo, lugarTrabajo, descripcionTrabajo, usuario from SolicitudMantenimiento where id ='" +
                                                            textConsecutivo.Text + "'");
            datosSolicitud.Read();

            textNombre.Text = datosSolicitud[1].ToString();
            textTelefono.Text = datosSolicitud[2].ToString();
            textContacto.Text = datosSolicitud[3].ToString();
            textUrgencia.Text = datosSolicitud[4].ToString();
            textAreaTrabajo.Text = datosSolicitud[5].ToString();
            textLugarTrabajo.Text = datosSolicitud[6].ToString();
            textDescripcion.Text = datosSolicitud[7].ToString();

            SqlDataReader readerUnidad = bd.ejecutarConsulta("select unidad from Usuarios where nombreUsuario ='" + datosSolicitud[8] + "'");
            readerUnidad.Read();
            textUnidad.Text = readerUnidad[0].ToString();
            comboPersonas.Items.Clear();
            SqlDataReader personas = bd.ejecutarConsulta("select CONCAT(nombre, ' ', apellido1, ' ', apellido2) from Usuarios where unidad = 'UMI'");
            while (personas.Read())
            {
                comboPersonas.Items.Add(personas[0].ToString());
            }
        }

        private void checkBoxAprobado_Click(object sender, EventArgs e)
        {
            if(checkBoxAprobado.CheckState == CheckState.Checked)
            {
                checkBoxRechazar.Checked = false;
                labelPersonaAsignada.Visible = true;
                labelObservaciones.Text = "Observaciones:";
                labelObservaciones.Visible = true;
                comboPersonas.SelectedIndex = -1;
                comboPersonas.Visible = true;
                textObservaciones.Visible = true;

                butAceptar.Visible = true; 
            }
            else
            {
                labelPersonaAsignada.Visible = false;
                labelObservaciones.Visible = false;
                comboPersonas.Visible = false;
                textObservaciones.Text = "";
                textObservaciones.Visible = false;
                butAceptar.Visible = false;
            }
        }

        private void checkBoxRechazar_Click(object sender, EventArgs e)
        {
            if (checkBoxRechazar.CheckState == CheckState.Checked)
            {
                checkBoxAprobado.Checked = false;
                labelPersonaAsignada.Visible = false;
                comboPersonas.Visible = false;
                labelObservaciones.Text = "Motivo del rechazo:";
                labelObservaciones.Visible = true;
                textObservaciones.Text = "";
                textObservaciones.Visible = true;
                butAceptar.Visible = true;
            }
            else
            {
                labelPersonaAsignada.Visible = false;
                labelObservaciones.Visible = false;
                comboPersonas.Visible = false;
                textObservaciones.Visible = false;
                butAceptar.Visible = false;
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if (checkBoxAprobado.CheckState == CheckState.Checked)
            {
                if (comboPersonas.Text == "")
                {
                    MessageBox.Show("Por favor seleccionar una persona encargada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string[] nombre = comboPersonas.Text.Split(' ');
                    SqlDataReader usuario = bd.ejecutarConsulta("select nombreUsuario from usuarios where nombre = '" + nombre[0] + "' and apellido1 = '" + nombre[1]
                        + "' and apellido2 ='" + nombre[2] + "'");
                    usuario.Read();
                    if (bd.aprobarSolicitudMantenimiento(textConsecutivo.Text, DateTime.Now.ToShortDateString(),usuario[0].ToString(), textObservaciones.Text) == 1)
                    {
                        MessageBox.Show("Se ha aprobado la solicitud", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.None);
                        llenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error aprobando la solicitud", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (textObservaciones.Text == "")
                {
                    MessageBox.Show("Por favor indique el motivo del rechazo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (bd.rechazarSolicitudMantenimiento(textConsecutivo.Text, textObservaciones.Text) == 1)
                    {
                        MessageBox.Show("Se ha rechazado la solicitud", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.None);
                        llenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error rechazando la solicitud", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
