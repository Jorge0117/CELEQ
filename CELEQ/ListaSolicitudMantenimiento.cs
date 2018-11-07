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

            SqlDataReader datosSolicitud = bd.ejecutarConsulta("select fecha, nombreSolicitante, unidad, telefono, contactoAdicional, urgencia, areaTrabajo, lugarTrabajo, descripcionTrabajo from SolicitudMantenimiento where id ='" +
                                                            textConsecutivo.Text + "'");
            datosSolicitud.Read();

            textNombre.Text = datosSolicitud[1].ToString();
            textUnidad.Text = datosSolicitud[2].ToString();
            textTelefono.Text = datosSolicitud[3].ToString();
            textContacto.Text = datosSolicitud[4].ToString();
            textUrgencia.Text = datosSolicitud[5].ToString();
            textAreaTrabajo.Text = datosSolicitud[6].ToString();
            textLugarTrabajo.Text = datosSolicitud[7].ToString();
            textDescripcion.Text = datosSolicitud[8].ToString();

            comboPersonas.Items.Clear();
            SqlDataReader personas = bd.ejecutarConsulta("select CONCAT(nombre, ' ', apellido1, ' ', apellido2) from Usuarios");
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
    }
}
