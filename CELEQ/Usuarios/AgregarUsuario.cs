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
    public partial class AgregarUsuario : Form
    {
        DataGridViewRow dgvRow;
        AccesoBaseDatos bd;
        public AgregarUsuario(DataGridViewRow dgvw = null)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            dgvRow = dgvw;

            //Solo permite seleccionar filas en el dgv
            dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuestos.MultiSelect = false;
            dgvPuestos.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }


        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            dgvPuestos.Columns.Add("puesto", "Puesto");
            dgvPuestos.Columns[0].Width = dgvPuestos.Width -1;
            foreach (string permiso in Globals.listaCategorias)
            {
                cbPermisos.Items.Add(permiso);
            }

            SqlDataReader unidades = bd.ejecutarConsulta("select * from Unidad");
            while (unidades.Read())
            {
                comboUnidad.Items.Add(unidades[0].ToString());
            }

            if (dgvRow != null)
            {
                textUsuario.Text = dgvRow.Cells[0].Value.ToString();
                textUsuario.Enabled = false;
                textCorreo.Text = dgvRow.Cells[2].Value.ToString();
                comboUnidad.Text = dgvRow.Cells[3].Value.ToString();

                SqlDataReader nombre = bd.ejecutarConsulta("select nombre, apellido1, apellido2 from usuarios where nombreUsuario = '" + textUsuario.Text + "'");
                nombre.Read();
                textNombre.Text = nombre[0].ToString();
                textApellido1.Text = nombre[1].ToString();
                textApellido2.Text = nombre[2].ToString();

                SqlDataReader puestos = bd.ejecutarConsulta("select puesto from puestosUsuarios where nombreUsuario = '" + textUsuario.Text + "'");
                while (puestos.Read())
                {
                    dgvPuestos.Rows.Add(puestos[0]);
                }
            }
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textUsuario.Text == "" || textCorreo.Text == "" || cbPermisos.Text == "" 
                || comboUnidad.Text == "" || textNombre.Text == "" || textApellido1.Text == "" || 
                textApellido2.Text == "" || dgvPuestos.Rows.Count == 0)
            {
                MessageBox.Show("Porfavor llene los datos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int error;
                if (dgvRow == null)
                {
                    List<string> puestos = new List<string>();
                    foreach(DataGridViewRow row in dgvPuestos.Rows)
                    {
                        puestos.Add(row.Cells[0].Value.ToString());
                    }
                    ModificarContra mc = new ModificarContra(textUsuario.Text, textCorreo.Text, comboUnidad.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, puestos);
                    mc.ShowDialog();
                    bool cerrar = mc.aceptar;
                    mc.Dispose();
                    if (cerrar)
                    {
                        this.Close(); 
                    }
                    
                }
                else
                {
                    List<string> puestos = new List<string>();
                    foreach (DataGridViewRow row in dgvPuestos.Rows)
                    {
                        puestos.Add(row.Cells[0].Value.ToString());
                    }

                    error = bd.modificarUsuario(textUsuario.Text, textCorreo.Text, comboUnidad.Text, textNombre.Text, textApellido1.Text, textApellido2.Text, puestos);
                    if (error == 0)
                    {
                        MessageBox.Show("Usuario modificado de manera correcta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar usuario\nNúmero de error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                
            }

        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAgregarPuesto_Click(object sender, EventArgs e)
        {
            ListaPuestos puestos = new ListaPuestos(true);
            puestos.ShowDialog();
            DataGridViewRow row = puestos.getRow();
            if (row != null)
            {
                dgvPuestos.Rows.Add(row);
            }
            puestos.Dispose();
        }

        private void butEliminarPuesto_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPuestos.SelectedRows[0];
                dgvPuestos.Rows.Remove(row);
            }
        }
    }
}
