namespace CELEQ
{
    partial class DatosSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNombreSol = new System.Windows.Forms.TextBox();
            this.textNombreEnc = new System.Windows.Forms.TextBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.dtpFechaSol = new System.Windows.Forms.DateTimePicker();
            this.saveFilePdf = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del solicitante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del encargado (Si aplica):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de la solicitud:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo del solicitante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidad o laboratorio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observaciones:";
            // 
            // textNombreSol
            // 
            this.textNombreSol.Location = new System.Drawing.Point(215, 52);
            this.textNombreSol.Name = "textNombreSol";
            this.textNombreSol.Size = new System.Drawing.Size(215, 20);
            this.textNombreSol.TabIndex = 7;
            // 
            // textNombreEnc
            // 
            this.textNombreEnc.Location = new System.Drawing.Point(215, 79);
            this.textNombreEnc.Name = "textNombreEnc";
            this.textNombreEnc.Size = new System.Drawing.Size(215, 20);
            this.textNombreEnc.TabIndex = 8;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(215, 103);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(215, 20);
            this.textCorreo.TabIndex = 9;
            // 
            // textUnidad
            // 
            this.textUnidad.Location = new System.Drawing.Point(215, 127);
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.Size = new System.Drawing.Size(215, 20);
            this.textUnidad.TabIndex = 10;
            // 
            // textObservaciones
            // 
            this.textObservaciones.Location = new System.Drawing.Point(215, 187);
            this.textObservaciones.MaxLength = 255;
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(215, 78);
            this.textObservaciones.TabIndex = 12;
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(497, 276);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 13;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(416, 276);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 14;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // dtpFechaSol
            // 
            this.dtpFechaSol.Enabled = false;
            this.dtpFechaSol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSol.Location = new System.Drawing.Point(215, 154);
            this.dtpFechaSol.Name = "dtpFechaSol";
            this.dtpFechaSol.Size = new System.Drawing.Size(215, 20);
            this.dtpFechaSol.TabIndex = 15;
            this.dtpFechaSol.Value = new System.DateTime(2018, 9, 12, 0, 0, 0, 0);
            // 
            // saveFilePdf
            // 
            this.saveFilePdf.DefaultExt = "pdf";
            // 
            // DatosSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.dtpFechaSol);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.textObservaciones);
            this.Controls.Add(this.textUnidad);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.textNombreEnc);
            this.Controls.Add(this.textNombreSol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosSolicitud";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosSolicitud";
            this.Load += new System.EventHandler(this.DatosSolicitud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNombreSol;
        private System.Windows.Forms.TextBox textNombreEnc;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.DateTimePicker dtpFechaSol;
        private System.Windows.Forms.SaveFileDialog saveFilePdf;
    }
}