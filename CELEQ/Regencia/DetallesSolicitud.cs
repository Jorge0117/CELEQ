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
using System.Net;
using System.Net.Mail;

namespace CELEQ
{
    public partial class DetallesSolicitud : Form
    {
        AccesoBaseDatos bd;
        string correoSolicitante;
        string consecutivo;
        bool readOnly;
        List<int> reacDenegados; //Index de la fila de reactivos denegados
        List<string> motReacDen; //Motivos de la denegación de reactivos. Tienen una relación 1:1

        List<int> crisDenegados; //Index de la fila de cristaleria denegados
        List<string> motCrisDen; //Motivos de la denegación de cristaleria. Tienen una relación 1:1

        public DetallesSolicitud(string consecutivo, bool readOnly, string correoSol=null)
        {
            correoSolicitante = correoSol;
            InitializeComponent();
            bd = new AccesoBaseDatos();
            this.consecutivo = consecutivo;
            this.readOnly = readOnly;

            if (!readOnly)
            {
                reacDenegados = new List<int>();
                motReacDen = new List<string>();
                crisDenegados = new List<int>();
                motCrisDen = new List<string>();
            }
            else
            {
                butAprobarSolicutud.Visible = false;
                butDenReac.Visible = false;
                butDenCris.Visible = false;
                butDenegarSolicitud.Visible = false;
                textMotDenCris.Visible = false;
                textMotDenReac.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }

            dgvReactivos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReactivos.MultiSelect = false;
            dgvReactivos.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
            dgvCristaleria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCristaleria.MultiSelect = false;
            dgvCristaleria.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);
        }

        //Pinta la fila completa en el dgv
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void llenarTablas()
        {
            DataTable tablaReac = null;
            DataTable tablaCris = null;

            try
            {
                tablaReac = bd.ejecutarConsultaTabla("select NombreReactivo, Pureza, Cantidad from SolicitudReactivo where idSolicitud = '" + consecutivo+"'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla de reactivos.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                tablaCris = bd.ejecutarConsultaTabla("select NombreCristaleria, Material, Capacidad, Cantidad from SolicitudCristaleria where idSolicitud = '" + consecutivo + "'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cargando la tabla de cristalería.\nError número " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource bsR = new BindingSource();
            bsR.DataSource = tablaReac;
            dgvReactivos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvReactivos.DataSource = bsR;

			dgvReactivos.Columns[0].Width = dgvReactivos.Width / 3 + 200;
			dgvReactivos.Columns[1].Width = dgvReactivos.Width / 3 - 101;
			dgvReactivos.Columns[2].Width = dgvReactivos.Width / 3 - 102;

            BindingSource bsC = new BindingSource();
            bsC.DataSource = tablaCris;
            dgvCristaleria.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvCristaleria.DataSource = bsC;

			dgvCristaleria.Columns[0].Width = dgvCristaleria.Width / 4 + 52;
			dgvCristaleria.Columns[1].Width = dgvCristaleria.Width / 4 + 50;
			dgvCristaleria.Columns[2].Width = dgvCristaleria.Width / 4 - 52;
			dgvCristaleria.Columns[3].Width = dgvCristaleria.Width / 4 - 51;
		}

        private void enviarCorreo(string correoUsuario, string texto)
        {
            using (SmtpClient smtpClient = new SmtpClient())
            {
                var basicCredential = new NetworkCredential("compras.celeq", "Compras.p8c");
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress("compras.celeq@ucr.ac.cr");

                    smtpClient.Host = "smtp.ucr.ac.cr";
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    message.From = fromAddress;
                    message.Subject = "Estado de la solicitud";
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = texto;
                    message.To.Add(correoUsuario);

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        //Error, could not send the message
                        MessageBox.Show("Se produjo un error enviando el correo\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DetallesSolicitud_Load(object sender, EventArgs e)
        {
            llenarTablas();

            SqlDataReader observaciones = bd.ejecutarConsulta("select Observacion from Solicitud where Id = '" + consecutivo + "'");
            observaciones.Read();
            textObserv.Text = observaciones[0].ToString();

            //Evita que se pueda cambiar el orden en los dgv
            foreach (DataGridViewColumn column in dgvReactivos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dgvCristaleria.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void butDenReac_Click(object sender, EventArgs e)
        {
            if(dgvReactivos.Rows.Count > 0)
            {
                if(textMotDenReac.Text != "")
                {
                    if (!reacDenegados.Contains(dgvReactivos.SelectedRows[0].Index))
                    {
                        dgvReactivos.SelectedRows[0].DefaultCellStyle.BackColor = Color.Crimson;
                        reacDenegados.Add(dgvReactivos.SelectedRows[0].Index);
                        motReacDen.Add(textMotDenReac.Text);
                        textMotDenReac.Text = "";
                        MessageBox.Show("Reactivo denegado correctamente", "Denegación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Este reactivo ya fue denegado", "Denegación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor escriba el motivo para la denegación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buDenCris_Click(object sender, EventArgs e)
        {
            if (dgvCristaleria.Rows.Count > 0)
            {
                if (textMotDenCris.Text != "")
                {
                    if (!crisDenegados.Contains(dgvCristaleria.SelectedRows[0].Index))
                    {
                        dgvCristaleria.SelectedRows[0].DefaultCellStyle.BackColor = Color.Crimson;
                        crisDenegados.Add(dgvCristaleria.SelectedRows[0].Index);
                        motCrisDen.Add(textMotDenCris.Text);
                        textMotDenCris.Text = "";
                        MessageBox.Show("Cristaleria denegada correctamente", "Denegación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Esta cristalería ya fue denegada", "Denegación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor escriba el motivo para la denegación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void butAprobarSolicutud_Click(object sender, EventArgs e)
        {
            string textoCorreo = "<b> UNIDAD DE REGENCIA</b> <br><br>Su solicitud con el consecutivo " + consecutivo + " fue aprobada.<br>";
            //Denega los articulos rojos y los regresa a la base. También escribe el correo
            if(reacDenegados.Count > 0)
            {
                textoCorreo += "Los siguientes reactivos fueron denegados;<br>";
                for (int i = 0; i < reacDenegados.Count; ++i)
                {
                    textoCorreo += "Nombre: " + dgvReactivos.Rows[reacDenegados[i]].Cells[0].Value.ToString() + 
                        "<br> Pureza: " + dgvReactivos.Rows[reacDenegados[i]].Cells[1].Value.ToString() + "<br> Motivo: " +
                        motReacDen[i] + "<br><br>";
                    bd.denegarReactivo(consecutivo, dgvReactivos.Rows[reacDenegados[i]].Cells[0].Value.ToString(), 
                        dgvReactivos.Rows[reacDenegados[i]].Cells[1].Value.ToString());
                }
            }
            if (crisDenegados.Count > 0)
            {
                textoCorreo += "Los siguientes artículos de cristalería fueron denegados:<br>";
                for (int i = 0; i < crisDenegados.Count; ++i)
                {
                    textoCorreo += "Nombre: " + dgvCristaleria.Rows[crisDenegados[i]].Cells[0].Value.ToString() +
                        "<br> Material: " + dgvCristaleria.Rows[crisDenegados[i]].Cells[1].Value.ToString() + 
                        "<br> Capacidad: " + dgvCristaleria.Rows[crisDenegados[i]].Cells[2].Value.ToString() + "<br> Motivo: " + motCrisDen[i] + "<br><br>";
                    bd.denegarCristaleria(consecutivo, dgvCristaleria.Rows[crisDenegados[i]].Cells[0].Value.ToString(),
                        dgvCristaleria.Rows[crisDenegados[i]].Cells[1].Value.ToString(), dgvCristaleria.Rows[crisDenegados[i]].Cells[2].Value.ToString() +
                        "<br>");
                }     
            }

            //Se envía correo
            //System.IO.File.WriteAllLines(@"C:\Users\Jorge\Desktop\correo.txt", textoCorreo.Split('\n'));
            enviarCorreo(correoSolicitante, textoCorreo);

            //Se cambia el estado
            bd.ejecutarConsulta("update Solicitud set Estado = 'Aceptado', FechaAprobacion = GETDATE() where Id = '" + consecutivo + "'");

            //Se muestra un mensaje y se cierra la ventana
            MessageBox.Show("La solicitud ha sido aprobada correctamente", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Close();
        }

        private void butDenegarSolicitud_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que quieres cancelar la solicitud?", "Solicitud", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bd.ejecutarConsulta("update Solicitud set Estado = 'Denegado' where Id = '" + consecutivo + "'");
                string textoCorreo = "<b> UNIDAD DE REGENCIA</b> <br><br>Su solicitud con el consecutivo " + consecutivo + " fue denegada.<br>";
                enviarCorreo(correoSolicitante, textoCorreo);
                this.Close();
            }
        }

    }
}
