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
    public partial class DatosSolicitud : Form
    {
        AccesoBaseDatos bd;
        FormReacCris formulario;
        Pdf pdf;
        public DatosSolicitud(FormReacCris formulario)
        {
            InitializeComponent();
            bd = new AccesoBaseDatos();
            pdf = new Pdf();
            this.formulario = formulario;
        }

        private void DatosSolicitud_Load(object sender, EventArgs e)
        {
            dtpFechaSol.Value = DateTime.Now;
            textCorreo.Text = Globals.correo;
            SqlDataReader unidades = bd.ejecutarConsulta("select nombre from Unidad");
            while (unidades.Read())
            {
                comboUnidad.Items.Add(unidades[0].ToString());
            }
        }

        private string generarId(string idAnterior)
        {
            string idNuevo = "REG-" + dtpFechaSol.Value.Year + "-";
            int ultimoConsecutivo = Convert.ToInt32(idAnterior.Substring(idAnterior.Length - 4));

            int numDigitos = 0;
            if(ultimoConsecutivo > 0)
            {
                numDigitos = Convert.ToInt32(Math.Floor(Math.Log10(ultimoConsecutivo) + 1));
                if(ultimoConsecutivo == 9 || ultimoConsecutivo == 99 || ultimoConsecutivo == 999 || ultimoConsecutivo == 9999 || ultimoConsecutivo == 99999
                    || ultimoConsecutivo == 999999 || ultimoConsecutivo == 9999999)
                {
                    numDigitos--;
                }
            }
            else
            {
                numDigitos = 1;
            }
             
            for(int i=0; i<4-numDigitos; ++i)
            {
                idNuevo += "0";
            }
            return idNuevo + (ultimoConsecutivo + 1).ToString();
        }

        private void butAceptar_Click(object sender, EventArgs e)
        {
            if(textNombreSol.Text == "" || textCorreo.Text == "" || comboUnidad.Text == "")
            {
                MessageBox.Show("Falta algún dato obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Se revisa que las cantidades solicitadas esten disponibles
                bool error = false;
                for(int i = 0; i<formulario.dgvReactivos.Rows.Count; ++i)
                {
                    if(Convert.ToInt32(formulario.dgvReactivos.Rows[i].Cells[3].Value) > bd.obtenerCantidadReactivos(formulario.dgvReactivos.Rows[i].Cells[0].Value.ToString(),
                        formulario.dgvReactivos.Rows[i].Cells[1].Value.ToString()))
                    {
                        MessageBox.Show("La cantidad de " + formulario.dgvReactivos.Rows[i].Cells[0].Value.ToString() + " no está disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                }

                for (int i = 0; i < formulario.dgvCristaleria.Rows.Count; ++i)
                {
                    if (Convert.ToInt32(formulario.dgvCristaleria.Rows[i].Cells[3].Value) > bd.obtenerCantidadcristaleria(formulario.dgvCristaleria.Rows[i].Cells[0].Value.ToString(),
                        formulario.dgvCristaleria.Rows[i].Cells[1].Value.ToString(), formulario.dgvCristaleria.Rows[i].Cells[2].Value.ToString()))
                    {
                        MessageBox.Show("La cantidad de " + formulario.dgvCristaleria.Rows[i].Cells[0].Value.ToString() + " no está disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                }
                if (!error)
                {
                    //Como están disponobles se genera el id y se hace la solicitud
                    string id = generarId(bd.obtenerUltimoIdSolicitud());
                    if (bd.agregarSolicitud(id, dtpFechaSol.Value.ToShortDateString(), textNombreSol.Text, textNombreEnc.Text, textCorreo.Text, comboUnidad.Text, textObservaciones.Text, Globals.usuario) != 1)
                    {
                        MessageBox.Show("Error al crear la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                    if (!error)
                    {
                        //Se agregan los reactivos
                        for (int i = 0; i < formulario.dgvReactivos.Rows.Count; ++i)
                        {
                            string nombre = formulario.dgvReactivos.Rows[i].Cells[0].Value.ToString();
                            string pureza = formulario.dgvReactivos.Rows[i].Cells[1].Value.ToString();
                            float cantidad = (float)Convert.ToDouble(formulario.dgvReactivos.Rows[i].Cells[3].Value.ToString());
                            bd.agregarSolicitudReactivo(id, nombre, pureza, cantidad);
                        }

                        //Se agregan las critalerias
                        for (int i = 0; i < formulario.dgvCristaleria.Rows.Count; ++i)
                        {
                            string nombre = formulario.dgvCristaleria.Rows[i].Cells[0].Value.ToString();
                            string material = formulario.dgvCristaleria.Rows[i].Cells[1].Value.ToString();
                            string capacidad = formulario.dgvCristaleria.Rows[i].Cells[2].Value.ToString();
                            int cantidad = Convert.ToInt32(formulario.dgvCristaleria.Rows[i].Cells[3].Value.ToString());
                            bd.agregarSolicitudCristaleria(id, nombre, material, capacidad, cantidad);
                        }

                        MessageBox.Show("Se realizó la solicitud correctamente", "Solicitud realizada", MessageBoxButtons.OK, MessageBoxIcon.None);
                        //Se genera el pdf
                        saveFilePdf.Filter = "PDF File|*.pdf";
                        saveFilePdf.FileName = "Comprobante " + id;
                        if(saveFilePdf.ShowDialog() == DialogResult.Cancel)
                        {
                            saveFilePdf.FileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            saveFilePdf.FileName += "/Comprobante " + id + ".pdf";
                        }
                        
                        pdf.imprimirSolicitud(saveFilePdf.FileName, generarMatriz(0), generarMatriz(1), id, textNombreSol.Text, 
                            comboUnidad.Text, dtpFechaSol.Value.ToShortDateString(), textCorreo.Text, textObservaciones.Text);

                        formulario.dgvReactivos.DataSource = null;
                        formulario.dgvCristaleria.DataSource = null;
                        formulario.Close();
                        this.Close();
                    }
                }   
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[,] generarMatriz(int tipo)
        {
            string[,] matriz;
            int numfilas;
            int numcolum;
            if (tipo == 0)//Reactivo
            {
                numfilas = formulario.dgvReactivos.RowCount + 1;
                numcolum = formulario.dgvReactivos.ColumnCount;
                if(numfilas == 1)
                {
                    return null;
                }
                matriz = new string[numfilas, numcolum];

                //Nombres de columnas
                matriz[0, 0] = "Nombre del reactivo"; matriz[0, 1] = "Pureza";matriz[0, 2] = "Estante"; matriz[0, 3] = "Cantidad solicitada";

                //Resto de columnas
                for(int fila = 1; fila < numfilas; fila++)
                {
                    for(int columna = 0; columna < numcolum; columna++)
                    {
                        matriz[fila, columna] = formulario.dgvReactivos.Rows[fila - 1].Cells[columna].Value.ToString();
                    }
                }
            }
            else//Cristaleria
            {
                numfilas = formulario.dgvCristaleria.RowCount + 1;
                numcolum = formulario.dgvCristaleria.ColumnCount;
                if (numfilas == 1)
                {
                    return null;
                }
                matriz = new string[numfilas, numcolum];

                //Nombres de columnas
                matriz[0, 0] = "Nombre del Articulo"; matriz[0, 1] = "Material"; matriz[0, 2] = "Capacidad"; matriz[0, 3] = "Cantidad solicitada";

                //Resto de columnas
                for (int fila = 1; fila < numfilas; fila++)
                {
                    for (int columna = 0; columna < numcolum; columna++)
                    {
                        matriz[fila, columna] = formulario.dgvCristaleria.Rows[fila - 1].Cells[columna].Value.ToString();
                    }
                }
            }

            return matriz;
        }
    }
}
