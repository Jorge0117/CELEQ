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
    public partial class AnalizarSolicitudMantenimiento : Form
    {
        AccesoBaseDatos bd;
        string filePath = null;
        public AnalizarSolicitudMantenimiento()
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
                tabla = bd.ejecutarConsultaTabla("select Id as 'Consecutivo', fecha as 'Fecha de solicitud', urgencia as 'Urgencia' from " +
                     "SolicitudMantenimiento as s join SolicitudMantenimientoAprobada as sa on s.id = sa.idSolicitud where estado = 'Aprobado' and personaAsignada = '" +
                     Globals.usuario + "'");
              
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

        private void AnalizarSolicitudMantenimiento_Load(object sender, EventArgs e)
        {
            llenarTabla();
            dgvSolicitudes.ClearSelection();
            groupBox2.Visible = false;
            butAceptar.Visible = false;

            labelArchivo.Visible = false;
            adjuntarFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            adjuntarFileDialog.Filter = "All files (*.*)|*.*";
            adjuntarFileDialog.FilterIndex = 0;
            adjuntarFileDialog.RestoreDirectory = true;
        }

        private void butAdjuntar_Click(object sender, EventArgs e)
        {
            if(butAdjuntar.Text == "Adjuntar archivo")
            {
                if (adjuntarFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = adjuntarFileDialog.FileName;
                    labelArchivo.Text = filePath;
                    labelArchivo.Visible = true;
                    butAdjuntar.Text = "Eliminar adjunto";
                }
            }
            else
            {
                filePath = null;
                butAdjuntar.Text = "Adjuntar archivo";
                labelArchivo.Visible = false;
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void dgvSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                groupBox2.Visible = true;
                butAceptar.Visible = true;

                SqlDataReader datosSolicitud = bd.ejecutarConsulta("select  nombreSolicitante, lugarTrabajo, descripcionTrabajo, usuario from SolicitudMantenimiento where id ='" +
                                                                dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString() + "'");
                datosSolicitud.Read();

                textNombre.Text = datosSolicitud[0].ToString();
                textLugarTrabajo.Text = datosSolicitud[1].ToString();
                textDescripcion.Text = datosSolicitud[2].ToString();

                SqlDataReader readerObs = bd.ejecutarConsulta("select ObservacionesAprob from SolicitudMantenimientoAprobada where idSolicitud = '" + dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString() + "'");
                readerObs.Read();
                textObservacionesAprob.Text = readerObs[0].ToString();

                SqlDataReader readerUnidad = bd.ejecutarConsulta("select unidad from Usuarios where nombreUsuario ='" + datosSolicitud[3] + "'");
                readerUnidad.Read();
                textUnidad.Text = readerUnidad[0].ToString();

                SqlDataReader readerFecha = bd.ejecutarConsulta("select fechaAprobacion from SolicitudMantenimientoAprobada where idSolicitud ='" + dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString() + "'");
                readerFecha.Read();
                textFecha.Text = readerFecha[0].ToString();
            }           
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textInsumos.Text == "" || textObservacionesAna.Text == "")
            {
                MessageBox.Show("Por favor llene los campos necesarios", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);              
            }
            else
            {
                FileStream fs = null;
                if (filePath != null)
                {
                    fs = File.OpenRead(filePath);
                }
                if(bd.analizarSolicitudMantenimiento(dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString(), textInsumos.Text, textCosto.Text, textObservacionesAna.Text, fs, Path.GetFileName(filePath)) == 1)
                {
                    MessageBox.Show("Se ha analizado la solicitud de manera correcta", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.None);
                    resetForm();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void resetForm()
        {
            llenarTabla();
            dgvSolicitudes.ClearSelection();
            groupBox2.Visible = false;
            butAceptar.Visible = false;
            labelArchivo.Visible = false;

            textFecha.Clear();
            textNombre.Clear();
            textUnidad.Clear();
            textLugarTrabajo.Clear();
            textDescripcion.Clear();
            textObservacionesAprob.Clear();

            textInsumos.Clear();
            textCosto.Clear();
            textObservacionesAna.Clear();

        }

    }
}
