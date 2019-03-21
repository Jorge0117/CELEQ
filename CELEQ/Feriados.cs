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

            dgvFeriados.Columns[0].Width = dgvFeriados.Width / 2 - 1;
            dgvFeriados.Columns[1].Width = dgvFeriados.Width / 2 - 1;

            if (dgvFeriados.Rows.Count > 0 || (dgvFeriados.Rows.Count == 1 && dgvFeriados.Rows[0].Cells[0].Value.ToString() == null))
            {
                butEliminar.Enabled = true;
            }
            else
            {
                butEliminar.Enabled = false;
            }
        }

        DateTimePicker oDateTimePicker;

        private void dgvFeriados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                dgvFeriados.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Short;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvFeriados.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker1 which is fired when any date is selected.
                oDateTimePicker.TextChanged += new EventHandler(DateTimePickerChange);

                // An event attached to dateTimePicker1 which is fired when DateTimeControl is closed.
                oDateTimePicker.CloseUp += new EventHandler(DateTimePickerClose);

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }
        }

        private void DateTimePickerChange(object sender, EventArgs e)
        {
            dgvFeriados.CurrentCell.Value = oDateTimePicker.Value.ToShortDateString();
            if (dgvFeriados.CurrentRow.Cells[0].Value.ToString() == "")
            {
                if (dgvFeriados.CurrentRow.Cells[1].Value.ToString() != "")
                {
                    if (bd.agregarFeriado(dgvFeriados.CurrentRow.Cells[1].Value.ToString(), oDateTimePicker.Value.ToShortDateString(), oDateTimePicker.Value.ToShortDateString()) == 0)
                    {
                        MessageBox.Show("Feriado agregado correctamente");
                        llenarTabla();
                    }
                    else
                        MessageBox.Show("Error al eliminar feriado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Digite primero la descripción del feriado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dgvFeriados.CurrentRow.Cells[0].Value.ToString() != "")
            {
                if (bd.modificarFeriado(Convert.ToInt32(dgvFeriados.CurrentRow.Cells[0].Value.ToString()), dgvFeriados.CurrentRow.Cells[1].Value.ToString(), oDateTimePicker.Value.ToShortDateString(), oDateTimePicker.Value.ToShortDateString()) == 0)
                    MessageBox.Show("Feriado modificado correctamente");
                else
                    MessageBox.Show("Error al modificar feriado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DateTimePickerClose(object sender, EventArgs e)
        {
            oDateTimePicker.Visible = false;
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.RowCount > 0)
            {
                if (MessageBox.Show("¿Seguro que quiere borrar el feriado?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int pb = Convert.ToInt32(dgvFeriados.SelectedRows[0].Cells[0].Value.ToString());
                    if (bd.eliminarFeriado(Convert.ToInt32(dgvFeriados.SelectedRows[0].Cells[0].Value.ToString())) == 0)
                    {
                        MessageBox.Show("Feriado eliminado de manera correcta", "Feriados", MessageBoxButtons.OK, MessageBoxIcon.None);
                        llenarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar feriado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
