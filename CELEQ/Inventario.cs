﻿using System;
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
        FormReacCris formulario;
        public Inventario(int tipo, FormReacCris formulario)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            this.tipo = tipo;
            this.formulario = formulario;
            //Tipo 0 = Reactivos
            if (tipo == 0)
            {
                labelInventario.Text = "Reactivos disponibles:";
            }
            //Tipo 1 = Cristaleria
            else
            {
                labelInventario.Text = "Cristalería disponible:";
                labelUnidad.Text = "unidades";
            }

            //En caso de sólo ver inventario
            if (formulario == null)
            {
                butAgregar.Text = "Agregar nuevo";
                labelCantidad.Hide();
                labelUnidad.Hide();
                numAgregar.Hide();
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
            //Se va a agregar a la solicitud
            else
            {
                if (numAgregar.Value > 0)
                {
                    if (tipo == 0)
                    {
                        //Pasa los datos a la dgv en formReacCris
                        DataTable dataTable = (DataTable)formulario.dgvReactivos.DataSource;
                        DataRow row = dataTable.NewRow();

                        //Nombre
                        row[0] = dgvInventario.SelectedRows[0].Cells[0].Value;
                        //Pureza
                        row[1] = dgvInventario.SelectedRows[0].Cells[1].Value;
                        //Estante
                        row[2] = dgvInventario.SelectedRows[0].Cells[4].Value;
                        //Cantidad solicitada
                        row[3] = numAgregar.Value;

                        dataTable.Rows.Add(row);
                        dataTable.AcceptChanges();

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad solicitada no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                        "%' or Estante like '%" + filtro + "%'"; 
                }

            }
            else
            {
                if (filtro == "")
                {
                    consulta = "select * from Cristaleria";
                }
                else
                {
                    consulta = "select * from Cristaleria where Nombre like '%" + filtro + "%' or Material like '%" +
                        filtro + "%' or Capacidad like '%" + filtro + "%' or cantidad like '%" + filtro + "%'";
                }
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
            if (tipo == 0)
            {
                cambiarUnidad();
            }
        }

        private void cambiarUnidad()
        {
            if (dgvInventario.SelectedRows[0].Cells[3].Value.ToString() == "Sólido")
            {
                labelUnidad.Text = "g";
            }
            else
            {
                labelUnidad.Text = "ml";
            }
        }

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            cargarTabla(textBuscar.Text);
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cambiarUnidad();
        }
    }
}