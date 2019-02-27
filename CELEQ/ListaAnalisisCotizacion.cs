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
    public partial class ListaAnalisisCotizacion : Form
    {
        AccesoBaseDatos bd;
        public ListaAnalisisCotizacion()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
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

        private void butAgregarTipo_Click(object sender, EventArgs e)
        {
            if(butAgregarTipo.Text == "Agregar")
            {
                comboTipoAnalisis.DropDownStyle = ComboBoxStyle.DropDown;
                butEliminarTipo.Text = "Cancelar";
                butAgregarTipo.Text = "Aceptar";
                comboTipoAnalisis.Text = "";
            }
            else
            {
                try
                {
                    string agregado = comboTipoAnalisis.Text;
                    comboTipoAnalisis.DropDownStyle = ComboBoxStyle.DropDownList;
                    butEliminarTipo.Text = "Eliminar";
                    butAgregarTipo.Text = "Agregar";

                    bd.ejecutarConsulta("insert into tipoAnalisis values ('" + agregado + "')");
                    llenarComboBox();
                    comboTipoAnalisis.SelectedIndex = comboTipoAnalisis.FindStringExact(agregado);
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error agregando el tipo de análisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
            
        }

        private void ListaAnalisis_Load(object sender, EventArgs e)
        {
            llenarComboBox();
            butAgregar.Enabled = false;
            butModificar.Enabled = false;
            butEliminar.Enabled = false;
        }

        private void llenarComboBox()
        {
            try
            {
                comboTipoAnalisis.Items.Clear();
                SqlDataReader tipoAnalisis = bd.ejecutarConsulta("select tipo from tipoAnalisis");
                while (tipoAnalisis.Read())
                {
                    comboTipoAnalisis.Items.Add(tipoAnalisis[0].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error cargando los tipos de análisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }


        private void comboTipoAnalisis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoAnalisis.DropDownStyle == ComboBoxStyle.DropDown)
            {
                comboTipoAnalisis.DropDownStyle = ComboBoxStyle.DropDownList;
                butEliminarTipo.Text = "Eliminar";
                butAgregarTipo.Text = "Agregar";
            }

            if (comboTipoAnalisis.Text == "")
            {
                butAgregar.Enabled = false;
                butModificar.Enabled = false;
                butEliminar.Enabled = false;
            }
            else
            {
                butAgregar.Enabled = true;
                butModificar.Enabled = true;
                butEliminar.Enabled = true;
            }
        }

        private void butEliminarTipo_Click(object sender, EventArgs e)
        {
            if(butEliminarTipo.Text == "Eliminar")
            {
                try
                {
                    SqlDataReader hayAnalisis = bd.ejecutarConsulta("select descripcion from analisis where tipoAnalisis = '" + comboTipoAnalisis.Text + "'");
                    if (hayAnalisis.Read())
                    {
                        MessageBox.Show("No se puede eliminar debido a que hay análisis asociados a este tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bd.ejecutarConsulta("delete from tipoAnalisis where tipo = '" + comboTipoAnalisis.Text + "'");
                        llenarComboBox();
                        butAgregar.Enabled = false;
                        butModificar.Enabled = false;
                        butEliminar.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Ha ocurrido un error eliminando el tipo de análisis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboTipoAnalisis.DropDownStyle = ComboBoxStyle.DropDownList;
                butEliminarTipo.Text = "Eliminar";
                butAgregarTipo.Text = "Agregar";
                comboTipoAnalisis.SelectedIndex = -1;
                butAgregar.Enabled = false;
                butModificar.Enabled = false;
                butEliminar.Enabled = false;
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarAnalisisCotizacion agregar = new AgregarAnalisisCotizacion(comboTipoAnalisis.Text);
            agregar.ShowDialog();
            agregar.Dispose();
        }
    }
}
