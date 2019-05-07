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
    public partial class Feriados : Form
    {
        AccesoBaseDatos bd;
        public Feriados()
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();

            //Solo permite seleccionar filas en el dgv
            dgvFeriados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeriados.MultiSelect = false;
            dgvFeriados.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void Feriados_Load(object sender, EventArgs e)
        {
            llenarTabla();

            SqlDataReader semanaSanta = bd.ejecutarConsulta("select fechaInicio, fechaFinal from feriados where descripcion = 'Semana Santa'");
            if (semanaSanta.Read())
            {

                textInicio.Text = DateTime.Parse(semanaSanta[0].ToString()).ToShortDateString();
                textFin.Text = DateTime.Parse(semanaSanta[1].ToString()).ToShortDateString();
            }
        }

        private void llenarTabla()
        {
            DataTable tabla = null;

            try
            {
                tabla = bd.ejecutarConsultaTabla("select id, descripcion as Feriado, fechaInicio as Fecha from Feriados");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvFeriados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvFeriados.DataSource = bs;
            dgvFeriados.Columns["id"].Visible = false;

            dgvFeriados.Columns[1].Width = dgvFeriados.Width / 2 + 120;
            dgvFeriados.Columns[2].Width = dgvFeriados.Width  / 2 - 122;

            if (dgvFeriados.Rows.Count > 0)
            {
                butEliminar.Enabled = true;
                butModificar.Enabled = true;
            }
            else
            {
                butEliminar.Enabled = false;
                butModificar.Enabled = false;
            }
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro que quiere borrar el feriado?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bd.eliminarFeriado(Convert.ToInt32(dgvFeriados.SelectedRows[0].Cells[0].Value.ToString())) == 0)
                    {
                        MessageBox.Show("Feriado eliminado de manera correcta", "Feriados", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar feriado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                llenarTabla();
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            AgregarFeriado f = new AgregarFeriado();
            f.ShowDialog();
            f.Dispose();
            llenarTabla();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            AgregarFeriado f = new AgregarFeriado(dgvFeriados.SelectedRows[0]);
            f.ShowDialog();
            f.Dispose();
            llenarTabla();
        }

        void calcularSemanaSanta(int ano)
        {
            if (ano < 1900 || ano > 2100)
            {
                MessageBox.Show("No se puede calcular semana santa en el año actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int a, b, c, d, e, m, n, dia, mes;
                m = 24;
                n = 5;
                a = ano % 19;
                b = ano % 4;
                c = ano % 7;
                d = (19 * a + m) % 30;
                e = (2 * b + 4 * c + 6 * d + n) % 7;

                if (d + e < 10)
                {
                    mes = 3;
                    dia = d + e + 22;
                }
                else
                {
                    mes = 4;
                    dia = d + e - 9;
                }

                if (dia == 26 && mes == 4)
                {
                    dia = 19;
                }
                else if (dia == 25 && mes == 4 && d == 28 && e == 6 && a > 10)
                {
                    dia = 18;
                }
                /*
                Console.WriteLine(mes);
                Console.WriteLine(dia);
                */
                DateTime fin = new DateTime(ano, mes, dia);
                DateTime inicio = fin.AddDays(-7);

                SqlDataReader semanaSanta = bd.ejecutarConsulta("select id from feriados where descripcion = 'Semana Santa'");
                if (semanaSanta.Read())
                {

                    bd.eliminarFeriado(Convert.ToInt32(semanaSanta[0].ToString()));
                }

                if (bd.agregarFeriado("Semana Santa", inicio.ToShortDateString(), fin.ToShortDateString()) != 0)
                {
                    MessageBox.Show("Error al agregar semana santa", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    textInicio.Text = inicio.ToShortDateString();
                    textFin.Text = fin.ToShortDateString();
                }

            }
        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            calcularSemanaSanta(DateTime.Now.Year);
        }
    }
}
