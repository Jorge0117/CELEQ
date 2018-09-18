using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using PdfSharp.Drawing.Layout;
namespace CELEQ
{
    
    class Pdf
    {
        PdfDocument document;
        XGraphics gfx;
        PdfPage page;
        public Pdf()
        {
            document = new PdfDocument();
            page = document.AddPage();
            gfx = XGraphics.FromPdfPage(page);
        }
        public void imprimirSolicitud(string direccion, string[,] matReactivos, string[,] matCristaleria, 
            string consecutivo, string nombreSol, string unidad, string fecha, string correo, string observaciones)
        {

            //Se hace el encabezado
            //Rectangulos
            XRect recEncabezado = new XRect(100, 20, page.Width - 100 - 100, 60);
            XRect recConsecutivo = new XRect(100, 80, page.Width - 100 - 100, 20);
            XRect recEscudoUcr = new XRect(20, 20, 80, 80);
            XRect recEscudoCeleq = new XRect(page.Width - 100, 20, 80, 80);
            gfx.DrawRectangle(XPens.Black, recEncabezado);
            gfx.DrawRectangle(XPens.Black, recConsecutivo);
            gfx.DrawRectangle(XPens.Black, recEscudoUcr);
            gfx.DrawRectangle(XPens.Black, recEscudoCeleq);
            //Texto
            XFont calibri22B = new XFont("Calibri", 22, XFontStyle.Bold);
            XFont calibri13 = new XFont("Calibri", 13);
            XBrush blackBrush = XBrushes.Black;
            XStringFormat format = new XStringFormat();
            format.Alignment = XStringAlignment.Center;
            gfx.DrawString("P-05:PC-01:F-03", calibri22B, blackBrush, recEncabezado, format);
            format.LineAlignment = XLineAlignment.Far;
            gfx.DrawString("Solicitud de reactivos o cristalería de la bodega del CELEQ", calibri13, blackBrush, recEncabezado, format);
            format.LineAlignment = XLineAlignment.Center;
            gfx.DrawString("Consecutivo: " + consecutivo, calibri13, blackBrush, recConsecutivo, format);
            //Imagenes
            XImage logoUcr = XImage.FromFile("LogoUcr.png");
            XImage logoCeleq = XImage.FromFile("LogoCeleq.gif");
            gfx.DrawImage(logoUcr, 20, 20, 80, 72);
            gfx.DrawImage(logoCeleq, page.Width - 95, 30, 70, 62);


            //Datos personales
            gfx.DrawString("Nombre del solicitante: " + nombreSol, calibri13, blackBrush, new XRect(20, 110, page.Width / 2 - 100, 20), XStringFormats.TopLeft);
            gfx.DrawString("Unidad o laboratorio: " + unidad, calibri13, blackBrush, new XRect(20, 130, page.Width / 2 - 100, 20), XStringFormats.TopLeft);
            gfx.DrawString("Fecha de la solicitud: " + fecha, calibri13, blackBrush, new XRect(page.Width / 2 , 110, page.Width / 2 - 100, 20), XStringFormats.TopLeft);
            gfx.DrawString("Correo electrónico: " + correo, calibri13, blackBrush, new XRect(page.Width / 2, 130, page.Width / 2 - 100, 20), XStringFormats.TopLeft);

            int posMatCris;
            int posObs = 0;
            if (matReactivos != null)
            {
                gfx.DrawString("Reactivos solicitados:", calibri13, blackBrush, new XRect(20, 160, 100, 20), XStringFormats.TopLeft);
                posMatCris = 180 + 40 + matrixToTable(matReactivos, 180);

                if(matCristaleria != null)
                {
                    gfx.DrawString("Cristalería solicitada:", calibri13, blackBrush, new XRect(20, posMatCris - 20, 100, 20), XStringFormats.TopLeft);
                    posObs = posMatCris + 20 + matrixToTable(matCristaleria, posMatCris);
                }
            }
            else
            {
                gfx.DrawString("Cristalería solicitada:", calibri13, blackBrush, new XRect(20, 160, 100, 20), XStringFormats.TopLeft);
                posObs = 180 + 40 + 20 + matrixToTable(matCristaleria, 180);
            }

            XTextFormatter tf = new XTextFormatter(gfx);
            tf.DrawString("Observaciones: " + observaciones, calibri13, blackBrush, new XRect(20, posObs, page.Width - 20 - 20, 100));

            document.Save(direccion);
        }

        private int matrixToTable(string[,] matrix, int posY)
        {
            int numFilas = matrix.GetLength(0);
            int numColumnas = matrix.GetLength(1);
            int posX = 20;
            int largoRec = (Convert.ToInt32(page.Width - 20 - 20)) / numColumnas;
            int anchoRec = 20;
            int numCharRec = 23;
            int largo = 0;

            XTextFormatter tf = new XTextFormatter(gfx);
            //Dibuja los rectangulos
            for(int fila = 0; fila<numFilas; fila++)
            {
                for(int columna = 0; columna<numColumnas; columna++)
                {
                    if(columna == 0 && matrix[fila, 0].Length > numCharRec)
                    {
                        anchoRec += (matrix[fila, 0].Length / numCharRec) * anchoRec;
                    }
                    XRect rectangulo = new XRect(posX, posY, largoRec, anchoRec);
                    gfx.DrawRectangle(XPens.Black, rectangulo);
                    if(columna != 0) {
                        gfx.DrawString(matrix[fila, columna], new XFont("Calibri", 13), XBrushes.Black, rectangulo, XStringFormats.Center);
                    }
                    else
                    {
                        tf.DrawString(matrix[fila, columna], new XFont("Calibri", 13), XBrushes.Black, rectangulo, XStringFormats.TopLeft);
                    }
                    posX += largoRec;
                }
                posX = 20;
                posY += anchoRec;
                largo += anchoRec;
                anchoRec = 20;
            }
            return largo;
        }
    }
}
