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
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.butCancelar = new System.Windows.Forms.Button();
            this.butAceptar = new System.Windows.Forms.Button();
            this.dtpFechaSol = new System.Windows.Forms.DateTimePicker();
            this.saveFilePdf = new System.Windows.Forms.SaveFileDialog();
            this.comboUnidad = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del solicitante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del encargado (Si aplica):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de la solicitud:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo del solicitante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidad o laboratorio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observaciones:";
            // 
            // textNombreSol
            // 
            this.textNombreSol.Location = new System.Drawing.Point(283, 19);
            this.textNombreSol.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreSol.Name = "textNombreSol";
            this.textNombreSol.Size = new System.Drawing.Size(285, 22);
            this.textNombreSol.TabIndex = 0;
            // 
            // textNombreEnc
            // 
            this.textNombreEnc.Location = new System.Drawing.Point(283, 51);
            this.textNombreEnc.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreEnc.Name = "textNombreEnc";
            this.textNombreEnc.Size = new System.Drawing.Size(285, 22);
            this.textNombreEnc.TabIndex = 1;
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(283, 83);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(285, 22);
            this.textCorreo.TabIndex = 2;
            // 
            // textObservaciones
            // 
            this.textObservaciones.Location = new System.Drawing.Point(283, 180);
            this.textObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.textObservaciones.MaxLength = 255;
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(285, 95);
            this.textObservaciones.TabIndex = 5;
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(589, 320);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 7;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(481, 320);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 6;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // dtpFechaSol
            // 
            this.dtpFechaSol.Enabled = false;
            this.dtpFechaSol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSol.Location = new System.Drawing.Point(283, 148);
            this.dtpFechaSol.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaSol.Name = "dtpFechaSol";
            this.dtpFechaSol.Size = new System.Drawing.Size(285, 22);
            this.dtpFechaSol.TabIndex = 4;
            this.dtpFechaSol.Value = new System.DateTime(2018, 9, 12, 0, 0, 0, 0);
            // 
            // saveFilePdf
            // 
            this.saveFilePdf.DefaultExt = "pdf";
            // 
            // comboUnidad
            // 
            this.comboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUnidad.FormattingEnabled = true;
            this.comboUnidad.Location = new System.Drawing.Point(283, 115);
            this.comboUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.comboUnidad.Name = "comboUnidad";
            this.comboUnidad.Size = new System.Drawing.Size(285, 24);
            this.comboUnidad.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboUnidad);
            this.groupBox1.Controls.Add(this.textNombreSol);
            this.groupBox1.Controls.Add(this.dtpFechaSol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textObservaciones);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textCorreo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textNombreEnc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(54, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 295);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // DatosSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(702, 361);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatosSolicitud";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosSolicitud";
            this.Load += new System.EventHandler(this.DatosSolicitud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.DateTimePicker dtpFechaSol;
        private System.Windows.Forms.SaveFileDialog saveFilePdf;
        private System.Windows.Forms.ComboBox comboUnidad;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}