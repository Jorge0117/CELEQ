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
    public partial class ListaDesignaciones : Form
    {
        AccesoBaseDatos bd;
        public ListaDesignaciones()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvDesignaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDesignaciones.MultiSelect = false;
            dgvDesignaciones.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void ListaDesignaciones_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void llenarTabla(string filtro = "")
        {
            DataTable tabla = null;
            if (filtro == "")
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select D.idEstudiante as Identificación, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, D.ano as Año," +
                    " D.ciclo as Ciclo, D.modalidad as Modalidad, E.carrera as Carrera, D.encargado as Encargado, D.id" +
                    " from designacionAsistencia D join estudiante E on D.idEstudiante = E.id");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select D.idEstudiante as Cédula, CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, D.ano as Año," +
                    " D.ciclo as Ciclo, D.modalidad as Modalidad, E.carrera as Carrera, D.encargado as Encargado" +
                    " from designacionAsistencia D join estudiante E on D.idEstudiante = E.id and D.ano like '%"
                    + filtro + "%' or D.ciclo like '%" + filtro + "%' or D.idEstudiante like '%" + filtro + "%' or CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) like '%" + filtro +
                    "%' or D.modalidad like '%" + filtro + "%' or E.carrera like '%" + filtro + "%' or D.encargado like '%" +
                    filtro + "%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvDesignaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvDesignaciones.DataSource = bs;
            dgvDesignaciones.Columns["id"].Visible = false;
            int tamano = dgvDesignaciones.Width / 7;
            dgvDesignaciones.Columns[0].Width = tamano;
            dgvDesignaciones.Columns[1].Width = tamano + 20;
            dgvDesignaciones.Columns[2].Width = tamano - 20;
            dgvDesignaciones.Columns[3].Width = tamano - 20;
            dgvDesignaciones.Columns[4].Width = tamano - 20;
            dgvDesignaciones.Columns[5].Width = tamano + 20;
            dgvDesignaciones.Columns[6].Width = tamano + 19;

            if (dgvDesignaciones.Rows.Count > 0)
            {
                butDetalles.Enabled = true;
            }
            else
            {
                butDetalles.Enabled = false;
            }
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }

        private void butDetalles_Click(object sender, EventArgs e)
        {
            if (dgvDesignaciones.Rows.Count > 0)
            {
                Designacion designacion = new Designacion(Convert.ToInt32(dgvDesignaciones.SelectedRows[0].Cells[dgvDesignaciones.ColumnCount - 1].Value));
                designacion.ShowDialog();
                designacion.Dispose();
                llenarTabla();
            }
        }
    }
}
