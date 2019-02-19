namespace CELEQ
{
    partial class HistoricoSolicitudesMantenimiento
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
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.textPersonAsig = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.labelPersonaAsignada = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textLugarTrabajo = new System.Windows.Forms.TextBox();
            this.textAreaTrabajo = new System.Windows.Forms.TextBox();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textConsecutivo = new System.Windows.Forms.TextBox();
            this.labelDescripción = new System.Windows.Forms.Label();
            this.labelLugarTrabajo = new System.Windows.Forms.Label();
            this.labelAreaTrabajo = new System.Windows.Forms.Label();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelConsecutivo = new System.Windows.Forms.Label();
            this.butCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(21, 84);
            this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.Size = new System.Drawing.Size(469, 681);
            this.dgvSolicitudes.TabIndex = 6;
            this.dgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textEstado);
            this.groupBox1.Controls.Add(this.textPersonAsig);
            this.groupBox1.Controls.Add(this.textFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textObservaciones);
            this.groupBox1.Controls.Add(this.labelObservaciones);
            this.groupBox1.Controls.Add(this.labelPersonaAsignada);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textLugarTrabajo);
            this.groupBox1.Controls.Add(this.textAreaTrabajo);
            this.groupBox1.Controls.Add(this.textUnidad);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textConsecutivo);
            this.groupBox1.Controls.Add(this.labelDescripción);
            this.groupBox1.Controls.Add(this.labelLugarTrabajo);
            this.groupBox1.Controls.Add(this.labelAreaTrabajo);
            this.groupBox1.Controls.Add(this.labelUnidad);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.labelConsecutivo);
            this.groupBox1.Location = new System.Drawing.Point(499, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1064, 688);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estado";
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(331, 91);
            this.textEstado.Margin = new System.Windows.Forms.Padding(4);
            this.textEstado.Name = "textEstado";
            this.textEstado.ReadOnly = true;
            this.textEstado.Size = new System.Drawing.Size(609, 22);
            this.textEstado.TabIndex = 27;
            // 
            // textPersonAsig
            // 
            this.textPersonAsig.Location = new System.Drawing.Point(331, 362);
            this.textPersonAsig.Margin = new System.Windows.Forms.Padding(4);
            this.textPersonAsig.Name = "textPersonAsig";
            this.textPersonAsig.ReadOnly = true;
            this.textPersonAsig.Size = new System.Drawing.Size(609, 22);
            this.textPersonAsig.TabIndex = 26;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(331, 145);
            this.textFecha.Margin = new System.Windows.Forms.Padding(4);
            this.textFecha.Name = "textFecha";
            this.textFecha.ReadOnly = true;
            this.textFecha.Size = new System.Drawing.Size(609, 22);
            this.textFecha.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fecha de solicitud:";
            // 
            // textObservaciones
            // 
            this.textObservaciones.Location = new System.Drawing.Point(331, 572);
            this.textObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.textObservaciones.MaxLength = 500;
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.ReadOnly = true;
            this.textObservaciones.Size = new System.Drawing.Size(609, 78);
            this.textObservaciones.TabIndex = 23;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Location = new System.Drawing.Point(124, 576);
            this.labelObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(103, 16);
            this.labelObservaciones.TabIndex = 22;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // labelPersonaAsignada
            // 
            this.labelPersonaAsignada.AutoSize = true;
            this.labelPersonaAsignada.Location = new System.Drawing.Point(125, 366);
            this.labelPersonaAsignada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersonaAsignada.Name = "labelPersonaAsignada";
            this.labelPersonaAsignada.Size = new System.Drawing.Size(122, 16);
            this.labelPersonaAsignada.TabIndex = 20;
            this.labelPersonaAsignada.Text = "Persona asignada:";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(331, 470);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textDescripcion.MaxLength = 500;
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.ReadOnly = true;
            this.textDescripcion.Size = new System.Drawing.Size(609, 72);
            this.textDescripcion.TabIndex = 17;
            // 
            // textLugarTrabajo
            // 
            this.textLugarTrabajo.Location = new System.Drawing.Point(331, 416);
            this.textLugarTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.textLugarTrabajo.Name = "textLugarTrabajo";
            this.textLugarTrabajo.ReadOnly = true;
            this.textLugarTrabajo.Size = new System.Drawing.Size(609, 22);
            this.textLugarTrabajo.TabIndex = 16;
            // 
            // textAreaTrabajo
            // 
            this.textAreaTrabajo.Location = new System.Drawing.Point(331, 308);
            this.textAreaTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.textAreaTrabajo.Name = "textAreaTrabajo";
            this.textAreaTrabajo.ReadOnly = true;
            this.textAreaTrabajo.Size = new System.Drawing.Size(609, 22);
            this.textAreaTrabajo.TabIndex = 15;
            // 
            // textUnidad
            // 
            this.textUnidad.Location = new System.Drawing.Point(331, 254);
            this.textUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.ReadOnly = true;
            this.textUnidad.Size = new System.Drawing.Size(609, 22);
            this.textUnidad.TabIndex = 11;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(331, 199);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(609, 22);
            this.textNombre.TabIndex = 10;
            // 
            // textConsecutivo
            // 
            this.textConsecutivo.Location = new System.Drawing.Point(331, 37);
            this.textConsecutivo.Margin = new System.Windows.Forms.Padding(4);
            this.textConsecutivo.Name = "textConsecutivo";
            this.textConsecutivo.ReadOnly = true;
            this.textConsecutivo.Size = new System.Drawing.Size(609, 22);
            this.textConsecutivo.TabIndex = 9;
            // 
            // labelDescripción
            // 
            this.labelDescripción.AutoSize = true;
            this.labelDescripción.Location = new System.Drawing.Point(125, 474);
            this.labelDescripción.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripción.Name = "labelDescripción";
            this.labelDescripción.Size = new System.Drawing.Size(150, 16);
            this.labelDescripción.TabIndex = 8;
            this.labelDescripción.Text = "Descripción del trabajo:";
            // 
            // labelLugarTrabajo
            // 
            this.labelLugarTrabajo.AutoSize = true;
            this.labelLugarTrabajo.Location = new System.Drawing.Point(124, 420);
            this.labelLugarTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLugarTrabajo.Name = "labelLugarTrabajo";
            this.labelLugarTrabajo.Size = new System.Drawing.Size(189, 16);
            this.labelLugarTrabajo.TabIndex = 7;
            this.labelLugarTrabajo.Text = "Lugar donde realiza el trabajo:";
            // 
            // labelAreaTrabajo
            // 
            this.labelAreaTrabajo.AutoSize = true;
            this.labelAreaTrabajo.Location = new System.Drawing.Point(128, 311);
            this.labelAreaTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAreaTrabajo.Name = "labelAreaTrabajo";
            this.labelAreaTrabajo.Size = new System.Drawing.Size(164, 16);
            this.labelAreaTrabajo.TabIndex = 6;
            this.labelAreaTrabajo.Text = "Área de trabajo a solicitar:";
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Location = new System.Drawing.Point(128, 257);
            this.labelUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(134, 16);
            this.labelUnidad.TabIndex = 2;
            this.labelUnidad.Text = "Unidad o laboratorio:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(125, 203);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(145, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre del solicitante:";
            // 
            // labelConsecutivo
            // 
            this.labelConsecutivo.AutoSize = true;
            this.labelConsecutivo.Location = new System.Drawing.Point(124, 41);
            this.labelConsecutivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConsecutivo.Name = "labelConsecutivo";
            this.labelConsecutivo.Size = new System.Drawing.Size(88, 16);
            this.labelConsecutivo.TabIndex = 0;
            this.labelConsecutivo.Text = "Consecutivo: ";
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(1463, 772);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 30;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // HistoricoSolicitudesMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.labelSoliciudes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoricoSolicitudesMantenimiento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoricoSolicitudesMantenimiento";
            this.Load += new System.EventHandler(this.HistoricoSolicitudesMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSoliciudes;
        public System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.TextBox textPersonAsig;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.Label labelPersonaAsignada;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textLugarTrabajo;
        private System.Windows.Forms.TextBox textAreaTrabajo;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textConsecutivo;
        private System.Windows.Forms.Label labelDescripción;
        private System.Windows.Forms.Label labelLugarTrabajo;
        private System.Windows.Forms.Label labelAreaTrabajo;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelConsecutivo;
        private System.Windows.Forms.Button butCancelar;
    }
}