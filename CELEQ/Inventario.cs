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
    public partial class Inventario : Form
    {
        int tipo;
        AccesoBaseDatos bd;
        public Inventario(int tipo, DataGridView dgv)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            this.tipo = tipo;
            //Tipo 0 = Reactivos
            if (tipo == 0)
            {
                labelInventario.Text = "Reactivos disponibles:";
            }
            //Tipo 1 = Cristaleria
            else
            {
                labelInventario.Text = "Cristalería disponible:";
            }

            //En caso de sólo ver inventario
            if (dgv == null)
            {
                butAgregar.Text = "Agregar nuevo";
            }

            //Solo permite seleccionar filas en el dgv
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.MultiSelect = false;
            dgvInventario.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            if (butAgregar.Text == "Agregar nuevo")
            {
                AgregarReactivoCristaleria arc = new AgregarReactivoCristaleria(tipo);
                arc.ShowDialog();
                arc.Dispose();
                cargarTabla("");
                textBuscar.Text = "";
            }
        }

        private void cargarTabla(string filtro)
        {
            DataTable tabla = null;
            string consulta;
            if (tipo == 0)
            {
                if(filtro == "")
                {
                    consulta = "select * from Reactivo";
                }
                else
                {
                    consulta = "select * from Reactivo where Nombre like '%" + filtro + "%' or Pureza like '%" +
                        filtro + "%' or Cantidad like '%" + filtro + "%' or Estado like '%" + filtro +
                        "%' or Estante like '%´" + filtro + "%'"; 
                }

            }
            else
            {
                consulta = "select * from Cristaleria";
            }
            try
            {

                tabla = bd.ejecutarConsultaTabla(consulta);

            }
            catch (SqlException ex) { }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvInventario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvInventario.DataSource = bs;
            for (int i = 0; i < dgvInventario.ColumnCount; ++i)
            {
                dgvInventario.Columns[i].Width = dgvInventario.Width / dgvInventario.ColumnCount - 1;
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cargarTabla("");
        }
    }
}
