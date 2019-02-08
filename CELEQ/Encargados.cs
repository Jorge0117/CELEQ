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
    public partial class Encargados : Form
    {
        AccesoBaseDatos bd;
        public Encargados()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvResponsables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResponsables.MultiSelect = false;
            dgvResponsables.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }


        private void Encargados_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void llenarTabla()
        {
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select nombre as Nombre from responsable");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvResponsables.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvResponsables.DataSource = bs;
            for (int i = 0; i < dgvResponsables.ColumnCount; ++i)
            {
                dgvResponsables.Columns[i].Width = dgvResponsables.Width / dgvResponsables.ColumnCount - 1;
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            string encargado = Microsoft.VisualBasic.Interaction.InputBox("Digite el nombre del responsable", "Responsable", " ");
            if (encargado != " " && encargado != "")
            {
                bd.ejecutarConsulta("insert into responsable values ('" + encargado + "')");
                MessageBox.Show("Responsable agregado correctamente", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.None);
                llenarTabla();
            }
            else if (encargado == " ")
            {
                MessageBox.Show("Por favor digite el nombre del responsable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            }
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            string encargado = Microsoft.VisualBasic.Interaction.InputBox("Digite el nombre del responsable", "Responsable", " ");
            int error = bd.modificarResponsable(dgvResponsables.SelectedRows[0].Cells[0].Value.ToString(), encargado);
            if (error == 0)
            {
                MessageBox.Show("Responsable modificado de manera correcta", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.None);
                llenarTabla();
            }
            else if (encargado == " ")
            {
                MessageBox.Show("Error al modificar responsable\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (dgvResponsables.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro que quiere borrar el responsable?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string nombre = dgvResponsables.SelectedRows[0].Cells[0].Value.ToString();
                    if (bd.eliminarResponsable(nombre) == 1)
                    {
                        MessageBox.Show("Responsable eliminado de manera correcta", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.None);
                        llenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar responsable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
            }
        }
    }
}
