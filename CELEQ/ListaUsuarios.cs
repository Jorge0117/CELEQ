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
        AccesoBaseDatos bd;
        public ListaUsuarios()
        {        
            InitializeComponent();
            bd = new AccesoBaseDatos();
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
                    tabla = bd.ejecutarConsultaTabla("select nombreUsuario as 'Usuario', concat(nombre, ' ' ,apellido1, ' ', apellido2) as 'Nombre', correo as 'Correo', unidad as 'Unidad o laboratorio', categoria as 'Categoría'  from Usuarios");
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
                    tabla = bd.ejecutarConsultaTabla("select nombreUsuario as 'Usuario', concat(nombre, ' ' ,apellido1, ' ', apellido2) as 'Nombre', correo as 'Correo', unidad as 'Unidad o laboratorio', categoria as 'Categoría'  from Usuarios where nombreUsuario like '%" +
                        filtro + "%' or correo like '%" + filtro + "%' or categoria like '%" + filtro + "%' or nombre like '%" + filtro + "%' or apellido1 like '%" + filtro +
                        "%' or apellido2 like '%" + filtro + "%' or unidad like '%" + filtro + "%'");
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
            int tamCelda = dgvUsuarios.Width / 5;
            dgvUsuarios.Columns[0].Width = tamCelda -20;
            dgvUsuarios.Columns[1].Width = tamCelda + 35;
            dgvUsuarios.Columns[2].Width = tamCelda + 34;
            dgvUsuarios.Columns[3].Width = tamCelda - 25;
            dgvUsuarios.Columns[4].Width = tamCelda - 25;

            if (dgvUsuarios.Rows.Count > 0)
            {
                butModificar.Enabled = true;
                cambiarContra.Enabled = true;
            }
            else
            {
                butModificar.Enabled = false;
                cambiarContra.Enabled = false;
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

        private void cambiarContra_Click(object sender, EventArgs e)
        {
            ModificarContra c = new ModificarContra(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            c.ShowDialog();
            c.Dispose();
            llenarTabla();
        }

        private void butPermisos_Click(object sender, EventArgs e)
        {
            Permisos p = new Permisos(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            p.ShowDialog();
            p.Dispose();
        }
    }
}
