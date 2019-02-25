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
    public partial class ListaEstudiantes : Form
    {
        AccesoBaseDatos bd;
        public ListaEstudiantes()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void ListaEstudiantes_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void llenarTabla(string filtro = null)
        {
            DataTable tabla = null;

            try
            {
                if(filtro == "")
                    tabla = bd.ejecutarConsultaTabla("select E.id as Identificación, E.tipoId as 'Tipo Identificación', CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, E.carrera as Carrera from estudiante E");
                else
                    tabla = bd.ejecutarConsultaTabla("select E.id as Identificación, E.tipoId as 'Tipo Identificación'," +
                        " CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Nombre, " +
                        "E.carrera as Carrera from estudiante E where id like '%" + filtro + "%' or tipoId like '%" + filtro + "%' or CONCAT(nombre, ' ', apellido1, ' ', apellido2) like '%" + filtro +
                        "%' or carrera like '%" + filtro + "%'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvEstudiantes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvEstudiantes.DataSource = bs;
            int tamano = dgvEstudiantes.Width / 4;
            dgvEstudiantes.Columns[0].Width = tamano;
            dgvEstudiantes.Columns[1].Width = tamano - 6;
            dgvEstudiantes.Columns[2].Width = tamano;
            dgvEstudiantes.Columns[3].Width = tamano + 6;
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }
    }
}
