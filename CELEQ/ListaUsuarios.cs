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
    public partial class ListaUsuarios : Form
    {
        AccesobdUsuarios bd;
        public ListaUsuarios()
        {        
            InitializeComponent();
            bd = new AccesobdUsuarios();
            //Solo permite seleccionar filas en el dgv
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTabla(string filtro = "")
        {
            DataTable tabla = null;

            if(filtro == "")
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select nombreUsuario as Nombre, correo as Correo, Categoria as Categoría from Usuarios");
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
                    tabla = bd.ejecutarConsultaTabla("select nombreUsuario as Nombre, correo as Correo, Categoria as Categoría from Usuarios where nombreUsuario like '%" +
                        filtro + "%' or correo like '%" + filtro + "%' or categoria like '%" + filtro + "%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
  
            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvUsuarios.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvUsuarios.DataSource = bs;
            for (int i = 0; i < dgvUsuarios.ColumnCount; ++i)
            {
                dgvUsuarios.Columns[i].Width = dgvUsuarios.Width / dgvUsuarios.ColumnCount - 1;
            }
        }

        private void ListaUsuarios_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario ag = new AgregarUsuario();
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarUsuario ag = new AgregarUsuario(dgvUsuarios.SelectedRows[0]);
            ag.ShowDialog();
            ag.Dispose();
            llenarTabla();
        }
    }
}
