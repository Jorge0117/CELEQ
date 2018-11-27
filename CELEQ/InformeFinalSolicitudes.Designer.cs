namespace CELEQ
{
    partial class InformeFinalSolicitudes
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
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.labelSoliciudes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.textObservAnalisis = new System.Windows.Forms.TextBox();
            this.butDescargar = new System.Windows.Forms.Button();
            this.textObservacionesAprob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textLugarTrabajo = new System.Windows.Forms.TextBox();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelDescripción = new System.Windows.Forms.Label();
            this.labelLugarTrabajo = new System.Windows.Forms.Label();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textObservFinales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPeriodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 62);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.Size = new System.Drawing.Size(352, 553);
            this.dgvSolicitudes.TabIndex = 22;
            this.dgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellContentClick);
            // 
            // labelSoliciudes
            // 
            this.labelSoliciudes.AutoSize = true;
            this.labelSoliciudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoliciudes.Location = new System.Drawing.Point(12, 35);
            this.labelSoliciudes.Name = "labelSoliciudes";
            this.labelSoliciudes.Size = new System.Drawing.Size(217, 20);
            this.labelSoliciudes.TabIndex = 23;
            this.labelSoliciudes.Text = "Solicitudes de mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelArchivo);
            this.groupBox1.Controls.Add(this.textObservAnalisis);
            this.groupBox1.Controls.Add(this.butDescargar);
            this.groupBox1.Controls.Add(this.textObservacionesAprob);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textLugarTrabajo);
            this.groupBox1.Controls.Add(this.textUnidad);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.labelDescripción);
            this.groupBox1.Controls.Add(this.labelLugarTrabajo);
            this.groupBox1.Controls.Add(this.labelUnidad);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Location = new System.Drawing.Point(374, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 364);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Location = new System.Drawing.Point(223, 338);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(43, 13);
            this.labelArchivo.TabIndex = 26;
            this.labelArchivo.Text = "Archivo";
            // 
            // textObservAnalisis
            // 
            this.textObservAnalisis.Location = new System.Drawing.Point(226, 265);
            this.textObservAnalisis.MaxLength = 500;
            this.textObservAnalisis.Multiline = true;
            this.textObservAnalisis.Name = "textObservAnalisis";
            this.textObservAnalisis.ReadOnly = true;
            this.textObservAnalisis.Size = new System.Drawing.Size(458, 59);
            this.textObservAnalisis.TabIndex = 20;
            // 
            // butDescargar
            // 
            this.butDescargar.Location = new System.Drawing.Point(584, 330);
            this.butDescargar.Name = "butDescargar";
            this.butDescargar.Size = new System.Drawing.Size(100, 23);
            this.butDescargar.TabIndex = 25;
            this.butDescargar.Text = "Descargar";
            this.butDescargar.UseVisualStyleBackColor = true;
            this.butDescargar.Click += new System.EventHandler(this.butDescargar_Click);
            // 
            // textObservacionesAprob
            // 
            this.textObservacionesAprob.Location = new System.Drawing.Point(226, 195);
            this.textObservacionesAprob.MaxLength = 500;
            this.textObservacionesAprob.Multiline = true;
            this.textObservacionesAprob.Name = "textObservacionesAprob";
            this.textObservacionesAprob.ReadOnly = true;
            this.textObservacionesAprob.Size = new System.Drawing.Size(458, 59);
            this.textObservacionesAprob.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Documento adjunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Observaciones asignadas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Observaciones de análisis:";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(226, 124);
            this.textDescripcion.MaxLength = 500;
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.ReadOnly = true;
            this.textDescripcion.Size = new System.Drawing.Size(458, 59);
            this.textDescripcion.TabIndex = 17;
            // 
            // textLugarTrabajo
            // 
            this.textLugarTrabajo.Location = new System.Drawing.Point(226, 90);
            this.textLugarTrabajo.Name = "textLugarTrabajo";
            this.textLugarTrabajo.ReadOnly = true;
            this.textLugarTrabajo.Size = new System.Drawing.Size(458, 20);
            this.textLugarTrabajo.TabIndex = 16;
            // 
            // textUnidad
            // 
            this.textUnidad.Location = new System.Drawing.Point(226, 51);
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.ReadOnly = true;
            this.textUnidad.Size = new System.Drawing.Size(458, 20);
            this.textUnidad.TabIndex = 11;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(226, 12);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(458, 20);
            this.textNombre.TabIndex = 10;
            // 
            // labelDescripción
            // 
            this.labelDescripción.AutoSize = true;
            this.labelDescripción.Location = new System.Drawing.Point(72, 127);
            this.labelDescripción.Name = "labelDescripción";
            this.labelDescripción.Size = new System.Drawing.Size(118, 13);
            this.labelDescripción.TabIndex = 8;
            this.labelDescripción.Text = "Descripción del trabajo:";
            // 
            // labelLugarTrabajo
            // 
            this.labelLugarTrabajo.AutoSize = true;
            this.labelLugarTrabajo.Location = new System.Drawing.Point(71, 93);
            this.labelLugarTrabajo.Name = "labelLugarTrabajo";
            this.labelLugarTrabajo.Size = new System.Drawing.Size(149, 13);
            this.labelLugarTrabajo.TabIndex = 7;
            this.labelLugarTrabajo.Text = "Lugar donde realiza el trabajo:";
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Location = new System.Drawing.Point(72, 54);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(105, 13);
            this.labelUnidad.TabIndex = 2;
            this.labelUnidad.Text = "Unidad o laboratorio:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(71, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(114, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre del solicitante:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textObservFinales);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboPeriodo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(374, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 189);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informe final";
            // 
            // textObservFinales
            // 
            this.textObservFinales.Location = new System.Drawing.Point(226, 86);
            this.textObservFinales.MaxLength = 500;
            this.textObservFinales.Multiline = true;
            this.textObservFinales.Name = "textObservFinales";
            this.textObservFinales.Size = new System.Drawing.Size(458, 59);
            this.textObservFinales.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Observaciones asignadas:";
            // 
            // comboPeriodo
            // 
            this.comboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPeriodo.FormattingEnabled = true;
            this.comboPeriodo.Location = new System.Drawing.Point(226, 36);
            this.comboPeriodo.Name = "comboPeriodo";
            this.comboPeriodo.Size = new System.Drawing.Size(458, 21);
            this.comboPeriodo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Periodo de ejecución:";
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(1016, 627);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 27;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(1097, 627);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 26;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // InformeFinalSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSoliciudes);
            this.Controls.Add(this.dgvSolicitudes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformeFinalSolicitudes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeFinalSolicitudes";
            this.Load += new System.EventHandler(this.InformeFinalSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label labelSoliciudes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textObservacionesAprob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textLugarTrabajo;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelDescripción;
        private System.Windows.Forms.Label labelLugarTrabajo;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelArchivo;
        private System.Windows.Forms.Button butDescargar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.TextBox textObservAnalisis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textObservFinales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPeriodo;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}