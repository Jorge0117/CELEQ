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
    public partial class HistoricoSolicitudesMantenimiento : Form
    {
        AccesoBaseDatos bd;
        public HistoricoSolicitudesMantenimiento()
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
                tabla = bd.ejecutarConsultaTabla("select Id as 'Consecutivo', fecha as 'Fecha de solicitud', estado as 'Estado' from SolicitudMantenimiento");
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

        private void HistoricoSolicitudesMantenimiento_Load(object sender, EventArgs e)
        {
            llenarTabla();
            dgvSolicitudes.ClearSelection();

            groupBox1.Visible = false;
        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                groupBox1.Visible = true;

                textConsecutivo.Text = dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString();

                SqlDataReader datosSolicitud = bd.ejecutarConsulta("select estado, fecha, nombreSolicitante, areaTrabajo, lugarTrabajo, descripcionTrabajo, usuario from SolicitudMantenimiento where id ='" +
                                                                textConsecutivo.Text + "'");
                datosSolicitud.Read();

                textEstado.Text = datosSolicitud[0].ToString();
                textFecha.Text = datosSolicitud[1].ToString();
                textNombre.Text = datosSolicitud[2].ToString();
                textAreaTrabajo.Text = datosSolicitud[3].ToString();
                textLugarTrabajo.Text = datosSolicitud[4].ToString();
                textDescripcion.Text = datosSolicitud[5].ToString();

                SqlDataReader readerUnidad = bd.ejecutarConsulta("select unidad from Usuarios where nombreUsuario ='" + datosSolicitud[6] + "'");
                readerUnidad.Read();
                textUnidad.Text = readerUnidad[0].ToString();

                if (textEstado.Text == "Pendiente")
                {
                    labelObservaciones.Visible = false;
                    textObservaciones.Visible = false;

                    textPersonAsig.Text = "N/A";
                }
                else if (textEstado.Text == "Aprobado")
                {
                    labelObservaciones.Visible = true;
                    textObservaciones.Visible = true;

                    SqlDataReader aprob = bd.ejecutarConsulta("select personaAsignada, observacionesAprob from SolicitudMantenimientoAprobada where idSolicitud ='" +
                                                                textConsecutivo.Text + "'");
                    aprob.Read();

                    textPersonAsig.Text = aprob[0].ToString();
                    textObservaciones.Text = aprob[1].ToString();

                    labelObservaciones.Text = "Observaciones aprobación:";
                }
                else if(textEstado.Text == "En proceso")
                {
                    labelObservaciones.Visible = true;
                    textObservaciones.Visible = true;

                    SqlDataReader aprob = bd.ejecutarConsulta("select personaAsignada, observacionesAnalisis from SolicitudMantenimientoAprobada where idSolicitud ='" +
                                                                textConsecutivo.Text + "'");
                    aprob.Read();

                    textPersonAsig.Text = aprob[0].ToString();
                    textObservaciones.Text = aprob[1].ToString();

                    labelObservaciones.Text = "Observaciones análisis:";
                }
                else if(textEstado.Text == "Finalizado")
                {
                    labelObservaciones.Visible = true;
                    textObservaciones.Visible = true;

                    SqlDataReader aprob = bd.ejecutarConsulta("select personaAsignada, observacionesFinales from SolicitudMantenimientoAprobada where idSolicitud ='" +
                                                                textConsecutivo.Text + "'");
                    aprob.Read();

                    textPersonAsig.Text = aprob[0].ToString();
                    textObservaciones.Text = aprob[1].ToString();

                    labelObservaciones.Text = "Observaciones finales:";
                }
                else
                {
                    labelObservaciones.Visible = true;
                    textObservaciones.Visible = true;

                    SqlDataReader rech = bd.ejecutarConsulta("select motivo from SolicitudMantenimientoRechazada where idSolicitud ='" +
                                                                textConsecutivo.Text + "'");
                    rech.Read();

                    textObservaciones.Text = rech[0].ToString();

                    labelObservaciones.Text = "Motivo del rechazo:";
                    textPersonAsig.Text = "N/A";
                }

            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
