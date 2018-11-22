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
    public partial class InformeFinalSolicitudes : Form
    {
        AccesoBaseDatos bd;
        string idDoc;
        public InformeFinalSolicitudes()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            idDoc = null;

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
                     "SolicitudMantenimiento as s join SolicitudMantenimientoAprobada as sa on s.id = sa.idSolicitud where estado = 'En proceso' and personaAsignada = '" +
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

        private void InformeFinalSolicitudes_Load(object sender, EventArgs e)
        {
            llenarTabla();
            dgvSolicitudes.ClearSelection();

            labelArchivo.Visible = false;
            butDescargar.Visible = false;
            groupBox2.Visible = false;
            butAceptar.Visible = false;

            comboPeriodo.Items.Add("Inmedito");
            comboPeriodo.Items.Add("1-2 semanas");
            comboPeriodo.Items.Add("2-3 semanas");
            comboPeriodo.Items.Add("1-2 meses");
            comboPeriodo.Items.Add("2-4 meses");
            comboPeriodo.Items.Add("Más de 4 meses");
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            labelArchivo.Visible = true;
            butDescargar.Visible = true;
            groupBox2.Visible = true;
            butAceptar.Visible = true;

            SqlDataReader datosSolicitud = bd.ejecutarConsulta("select sm.NombreSolicitante, sm.lugarTrabajo, sm.descripcionTrabajo, sma.observacionesAprob, sma.observacionesAnalisis, sm.usuario, sma.documento " +
                                                            "from SolicitudMantenimiento as sm join SolicitudMantenimientoAprobada as sma on sm.id = sma.idSolicitud where sm.id = '" +
                                                            dgvSolicitudes.SelectedRows[0].Cells[0].Value.ToString() + "'");
            datosSolicitud.Read();

            textNombre.Text = datosSolicitud[0].ToString();
            textLugarTrabajo.Text = datosSolicitud[1].ToString();
            textDescripcion.Text = datosSolicitud[2].ToString();
            textObservacionesAprob.Text = datosSolicitud[3].ToString();
            textObservAnalisis.Text = datosSolicitud[4].ToString();

            SqlDataReader readerUnidad = bd.ejecutarConsulta("select unidad from Usuarios where nombreUsuario ='" + datosSolicitud[5] + "'");
            readerUnidad.Read();
            textUnidad.Text = readerUnidad[0].ToString();

            if (datosSolicitud[6].ToString() != "")
            {
                SqlDataReader readerDocumento = bd.ejecutarConsulta("select id, nombre from DocumentosMantenimiento where id = '" + datosSolicitud[6].ToString() + "'");
                readerDocumento.Read();
                idDoc = readerDocumento[0].ToString();
                labelArchivo.Text = readerDocumento[1].ToString();
                butDescargar.Visible = true;
            }
            else
            {
                idDoc = null;
                labelArchivo.Text = "Ningún archivo disponible";
                butDescargar.Visible = false;
            }
            
        }

        private void butDescargar_Click(object sender, EventArgs e)
        {

            string fileType = Path.GetExtension(labelArchivo.Text);
            string fileName = Path.GetFileNameWithoutExtension(labelArchivo.Text);

            saveFile.FileName = fileName;
            saveFile.Filter = "Tipo de archivo (*" + fileType + ")|*" + fileType;
            saveFile.DefaultExt = fileType;
            saveFile.AddExtension = true;
            if(saveFile.ShowDialog() != DialogResult.Cancel)
            {
                FileStream fs = new FileStream(saveFile.FileName, FileMode.Create);
                byte[] byteArray = bd.getDocument(idDoc);
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    ms.CopyTo(fs);
                }
                fs.Close();
                MessageBox.Show("Se ha descargado el arcivo correctamente", "Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            

        }

        private void butAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
