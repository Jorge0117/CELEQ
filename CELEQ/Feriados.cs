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
                tabla = bd.ejecutarConsultaTabla("select descripcion as Feriado, fechaInicio as Fecha from Feriados");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tabla;
            dgvFeriados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvFeriados.DataSource = bs;

            dgvFeriados.Columns[0].Width = dgvFeriados.Width / 2 - 1;
            dgvFeriados.Columns[1].Width = dgvFeriados.Width / 2 - 1;

            if (dgvFeriados.Rows.Count > 0)
            {
                butEliminar.Enabled = true;
            }
            else
            {
                butEliminar.Enabled = false;
            }
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            int index = dgvFeriados.Rows.Add();

        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = monthCalendar1.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (monthCalendar1.BoldedDates.Contains(info.Time))
                    monthCalendar1.RemoveBoldedDate(info.Time);
                else
                    monthCalendar1.AddBoldedDate(info.Time);
                monthCalendar1.UpdateBoldedDates();
            }
        }

        DateTimePicker oDateTimePicker;

        private void dgvFeriados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
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
                

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }
        }
    }
}
