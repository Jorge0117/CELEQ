namespace CELEQ
{
    partial class AnalizarSolicitudMantenimiento
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
            this.labelSoliciudes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textObservacionesAprob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textLugarTrabajo = new System.Windows.Forms.TextBox();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelDescripción = new System.Windows.Forms.Label();
            this.labelLugarTrabajo = new System.Windows.Forms.Label();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textCosto = new System.Windows.Forms.TextBox();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.butAdjuntar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textObservacionesAna = new System.Windows.Forms.TextBox();
            this.textInsumos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.adjuntarFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSoliciudes
            // 
            this.labelSoliciudes.AutoSize = true;
            this.labelSoliciudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoliciudes.Location = new System.Drawing.Point(16, 43);
            this.labelSoliciudes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoliciudes.Name = "labelSoliciudes";
            this.labelSoliciudes.Size = new System.Drawing.Size(217, 20);
            this.labelSoliciudes.TabIndex = 5;
            this.labelSoliciudes.Text = "Solicitudes de mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textFecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textObservacionesAprob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textLugarTrabajo);
            this.groupBox1.Controls.Add(this.textUnidad);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.labelDescripción);
            this.groupBox1.Controls.Add(this.labelLugarTrabajo);
            this.groupBox1.Controls.Add(this.labelUnidad);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Location = new System.Drawing.Point(499, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1064, 401);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(303, 27);
            this.textFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFecha.Name = "textFecha";
            this.textFecha.ReadOnly = true;
            this.textFecha.Size = new System.Drawing.Size(609, 22);
            this.textFecha.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fecha de aprobación:";
            // 
            // textObservacionesAprob
            // 
            this.textObservacionesAprob.Location = new System.Drawing.Point(303, 303);
            this.textObservacionesAprob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textObservacionesAprob.MaxLength = 500;
            this.textObservacionesAprob.Multiline = true;
            this.textObservacionesAprob.Name = "textObservacionesAprob";
            this.textObservacionesAprob.ReadOnly = true;
            this.textObservacionesAprob.Size = new System.Drawing.Size(609, 72);
            this.textObservacionesAprob.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Observaciones:";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(303, 219);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDescripcion.MaxLength = 500;
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.ReadOnly = true;
            this.textDescripcion.Size = new System.Drawing.Size(609, 72);
            this.textDescripcion.TabIndex = 17;
            // 
            // textLugarTrabajo
            // 
            this.textLugarTrabajo.Location = new System.Drawing.Point(303, 171);
            this.textLugarTrabajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLugarTrabajo.Name = "textLugarTrabajo";
            this.textLugarTrabajo.ReadOnly = true;
            this.textLugarTrabajo.Size = new System.Drawing.Size(609, 22);
            this.textLugarTrabajo.TabIndex = 16;
            // 
            // textUnidad
            // 
            this.textUnidad.Location = new System.Drawing.Point(303, 123);
            this.textUnidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.ReadOnly = true;
            this.textUnidad.Size = new System.Drawing.Size(609, 22);
            this.textUnidad.TabIndex = 11;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(303, 75);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(609, 22);
            this.textNombre.TabIndex = 10;
            // 
            // labelDescripción
            // 
            this.labelDescripción.AutoSize = true;
            this.labelDescripción.Location = new System.Drawing.Point(97, 223);
            this.labelDescripción.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripción.Name = "labelDescripción";
            this.labelDescripción.Size = new System.Drawing.Size(150, 16);
            this.labelDescripción.TabIndex = 8;
            this.labelDescripción.Text = "Descripción del trabajo:";
            // 
            // labelLugarTrabajo
            // 
            this.labelLugarTrabajo.AutoSize = true;
            this.labelLugarTrabajo.Location = new System.Drawing.Point(96, 175);
            this.labelLugarTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLugarTrabajo.Name = "labelLugarTrabajo";
            this.labelLugarTrabajo.Size = new System.Drawing.Size(189, 16);
            this.labelLugarTrabajo.TabIndex = 7;
            this.labelLugarTrabajo.Text = "Lugar donde realiza el trabajo:";
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Location = new System.Drawing.Point(97, 127);
            this.labelUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(134, 16);
            this.labelUnidad.TabIndex = 2;
            this.labelUnidad.Text = "Unidad o laboratorio:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(96, 79);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(145, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre del solicitante:";
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(1355, 772);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 20;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(1463, 772);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 19;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textCosto);
            this.groupBox2.Controls.Add(this.labelArchivo);
            this.groupBox2.Controls.Add(this.butAdjuntar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textObservacionesAna);
            this.groupBox2.Controls.Add(this.textInsumos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(499, 485);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1064, 279);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Análisis";
            // 
            // textCosto
            // 
            this.textCosto.Location = new System.Drawing.Point(333, 117);
            this.textCosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCosto.MaxLength = 100;
            this.textCosto.Name = "textCosto";
            this.textCosto.Size = new System.Drawing.Size(577, 22);
            this.textCosto.TabIndex = 27;
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Location = new System.Drawing.Point(476, 245);
            this.labelArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(53, 16);
            this.labelArchivo.TabIndex = 26;
            this.labelArchivo.Text = "Archivo";
            // 
            // butAdjuntar
            // 
            this.butAdjuntar.Location = new System.Drawing.Point(333, 239);
            this.butAdjuntar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAdjuntar.Name = "butAdjuntar";
            this.butAdjuntar.Size = new System.Drawing.Size(133, 28);
            this.butAdjuntar.TabIndex = 25;
            this.butAdjuntar.Text = "Adjuntar archivo";
            this.butAdjuntar.UseVisualStyleBackColor = true;
            this.butAdjuntar.Click += new System.EventHandler(this.butAdjuntar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Documento adjunto:";
            // 
            // textObservacionesAna
            // 
            this.textObservacionesAna.Location = new System.Drawing.Point(333, 158);
            this.textObservacionesAna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textObservacionesAna.MaxLength = 500;
            this.textObservacionesAna.Multiline = true;
            this.textObservacionesAna.Name = "textObservacionesAna";
            this.textObservacionesAna.Size = new System.Drawing.Size(577, 72);
            this.textObservacionesAna.TabIndex = 23;
            // 
            // textInsumos
            // 
            this.textInsumos.Location = new System.Drawing.Point(333, 28);
            this.textInsumos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textInsumos.MaxLength = 500;
            this.textInsumos.Multiline = true;
            this.textInsumos.Name = "textInsumos";
            this.textInsumos.Size = new System.Drawing.Size(577, 72);
            this.textInsumos.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Observaciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Costo aproximado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insumos necesarios para el trabajo:";
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(16, 76);
            this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.Size = new System.Drawing.Size(469, 681);
            this.dgvSolicitudes.TabIndex = 21;
            this.dgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellClick);
            // 
            // AnalizarSolicitudMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSoliciudes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalizarSolicitudMantenimiento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalizarSolicitudMantenimiento";
            this.Load += new System.EventHandler(this.AnalizarSolicitudMantenimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoliciudes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textLugarTrabajo;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelDescripción;
        private System.Windows.Forms.Label labelLugarTrabajo;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textObservacionesAprob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textObservacionesAna;
        private System.Windows.Forms.TextBox textInsumos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog adjuntarFileDialog;
        private System.Windows.Forms.Button butAdjuntar;
        private System.Windows.Forms.Label labelArchivo;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCosto;
    }
}