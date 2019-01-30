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
                    " D.ciclo as Ciclo, D.horas as Horas, D.modalidad as Modalidad, D.monto as Monto, E.carrera as Carrera, D.encargado as Encargado, D.unidad as Unidad," +
                    " D.presupuesto as Presupuesto, D.convocatoria as Convocatoria from designacionAsistencia D join estudiante E on D.idEstudiante = E.id");
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
                    " D.ciclo as Ciclo, D.horas as Horas, D.modalidad as Modalidad, D.monto as Monto, E.carrera as Carrera, D.encargado as Encargado, D.unidad as Unidad," +
                    " D.presupuesto as Presupuesto, D.convocatoria as Convocatoria from designacionAsistencia D join estudiante E on D.idEstudiante = E.id and D.ano like '%"
                    + filtro + "%' or D.ciclo like '%" + filtro + "%' or D.idEstudiante like '%" + filtro + "%' or CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) like '%" + filtro +
                    "%' or D.horas like '%" + filtro + "%' or D.modalidad like '%" + filtro + "%' or D.monto like '%" + filtro + "%' or E.carrera like '%" + filtro + "%' or D.encargado like '%" +
                    filtro + "%' or D.unidad like '%" + filtro + "%'");
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
            for (int i = 0; i < dgvDesignaciones.ColumnCount; ++i)
            {
                dgvDesignaciones.Columns[i].Width = dgvDesignaciones.Width / dgvDesignaciones.ColumnCount;
            }
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }

    }
}
