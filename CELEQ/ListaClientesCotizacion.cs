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
    public partial class ListaClientesCotizacion : Form
    {
        AccesoBaseDatos bd;
        public ListaClientesCotizacion()
        {
            InitializeComponent();bd = new AccesoBaseDatos();
            //Solo permite seleccionar filas en el dgv
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTabla(string filtro = "")
        {
            DataTable tabla = null;

            if (filtro == "")
            {
                try
                {
                    tabla = bd.ejecutarConsultaTabla("select nombre as 'Cliente', telefono as 'Teléfono 1', telefono2 as 'Teléfono 2', correo as 'Correo', fax as 'Fax', direccion as 'Direccion', atencionDe as 'Atención de' from ClienteCotizacion as cl join ContactoCotizacion as co on cl.nombre = co.nombreCliente where co.ultimoAgregado = 1");
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
                    tabla = bd.ejecutarConsultaTabla("select nombre as 'Cliente', telefono as 'Teléfono 1', telefono2 as 'teléfono 2', correo as 'Correo', fax as 'Fax', direccion as 'Direccion', atencionDe as 'Atención de' from ClienteCotizacion as cl join ContactoCotizacion as co on cl.nombre = co.nombreCliente where " +
                        "nombre like '%" + filtro + "%' or telefono like '%" + filtro + "%' or telefono2 like '%" + filtro + "%' or correo like '%" + filtro + "%' or fax like '%" + filtro + "%' or direccion like '%" + filtro + "%' or atencionDe like '%" + filtro + "%' and co.ultimoAgregado = 1");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvClientes.DataSource = bs;
            for (int i = 0; i < dgvClientes.ColumnCount; ++i)
            {
                dgvClientes.Columns[i].Width = dgvClientes.Width / dgvClientes.ColumnCount - 1;
            }

        }

        private void ListaClientesCotizacion_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            llenarTabla(textBuscar.Text);
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarClienteCotizacion acc = new AgregarClienteCotizacion();
            acc.ShowDialog();
            acc.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            if(dgvClientes.RowCount > 0)
            {
                AgregarClienteCotizacion acc = new AgregarClienteCotizacion(dgvClientes.SelectedRows[0].Cells[0].Value.ToString());
                acc.ShowDialog();
                acc.Dispose();
                llenarTabla();
            }
            
        }
    }
}
