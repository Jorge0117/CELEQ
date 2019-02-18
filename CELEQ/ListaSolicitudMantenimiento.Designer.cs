namespace CELEQ
{
    partial class ListaSolicitudMantenimiento
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
            this.textObservaciones = new System.Windows.Forms.TextBox();
            this.labelObservaciones = new System.Windows.Forms.Label();
            this.comboPersonas = new System.Windows.Forms.ComboBox();
            this.labelPersonaAsignada = new System.Windows.Forms.Label();
            this.checkBoxRechazar = new System.Windows.Forms.CheckBox();
            this.checkBoxAprobado = new System.Windows.Forms.CheckBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textLugarTrabajo = new System.Windows.Forms.TextBox();
            this.textAreaTrabajo = new System.Windows.Forms.TextBox();
            this.textUrgencia = new System.Windows.Forms.TextBox();
            this.textContacto = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textConsecutivo = new System.Windows.Forms.TextBox();
            this.labelDescripción = new System.Windows.Forms.Label();
            this.labelLugarTrabajo = new System.Windows.Forms.Label();
            this.labelAreaTrabajo = new System.Windows.Forms.Label();
            this.labrlUrgencia = new System.Windows.Forms.Label();
            this.labrlContacto = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelConsecutivo = new System.Windows.Forms.Label();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dgvSolicitudes.Location = new System.Drawing.Point(21, 84);
            this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.Size = new System.Drawing.Size(469, 681);
            this.dgvSolicitudes.TabIndex = 3;
            this.dgvSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudes_CellClick);
            // 
            // labelSoliciudes
            // 
            this.labelSoliciudes.AutoSize = true;
            this.labelSoliciudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoliciudes.Location = new System.Drawing.Point(16, 43);
            this.labelSoliciudes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoliciudes.Name = "labelSoliciudes";
            this.labelSoliciudes.Size = new System.Drawing.Size(217, 20);
            this.labelSoliciudes.TabIndex = 4;
            this.labelSoliciudes.Text = "Solicitudes de mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textObservaciones);
            this.groupBox1.Controls.Add(this.labelObservaciones);
            this.groupBox1.Controls.Add(this.comboPersonas);
            this.groupBox1.Controls.Add(this.labelPersonaAsignada);
            this.groupBox1.Controls.Add(this.checkBoxRechazar);
            this.groupBox1.Controls.Add(this.checkBoxAprobado);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.textLugarTrabajo);
            this.groupBox1.Controls.Add(this.textAreaTrabajo);
            this.groupBox1.Controls.Add(this.textUrgencia);
            this.groupBox1.Controls.Add(this.textContacto);
            this.groupBox1.Controls.Add(this.textTelefono);
            this.groupBox1.Controls.Add(this.textUnidad);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textConsecutivo);
            this.groupBox1.Controls.Add(this.labelDescripción);
            this.groupBox1.Controls.Add(this.labelLugarTrabajo);
            this.groupBox1.Controls.Add(this.labelAreaTrabajo);
            this.groupBox1.Controls.Add(this.labrlUrgencia);
            this.groupBox1.Controls.Add(this.labrlContacto);
            this.groupBox1.Controls.Add(this.labelTelefono);
            this.groupBox1.Controls.Add(this.labelUnidad);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.labelConsecutivo);
            this.groupBox1.Location = new System.Drawing.Point(499, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1064, 688);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textObservaciones
            // 
            this.textObservaciones.Location = new System.Drawing.Point(301, 581);
            this.textObservaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textObservaciones.MaxLength = 500;
            this.textObservaciones.Multiline = true;
            this.textObservaciones.Name = "textObservaciones";
            this.textObservaciones.Size = new System.Drawing.Size(609, 78);
            this.textObservaciones.TabIndex = 23;
            // 
            // labelObservaciones
            // 
            this.labelObservaciones.AutoSize = true;
            this.labelObservaciones.Location = new System.Drawing.Point(95, 585);
            this.labelObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObservaciones.Name = "labelObservaciones";
            this.labelObservaciones.Size = new System.Drawing.Size(103, 16);
            this.labelObservaciones.TabIndex = 22;
            this.labelObservaciones.Text = "Observaciones:";
            // 
            // comboPersonas
            // 
            this.comboPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPersonas.FormattingEnabled = true;
            this.comboPersonas.Location = new System.Drawing.Point(301, 543);
            this.comboPersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboPersonas.Name = "comboPersonas";
            this.comboPersonas.Size = new System.Drawing.Size(609, 24);
            this.comboPersonas.TabIndex = 21;
            // 
            // labelPersonaAsignada
            // 
            this.labelPersonaAsignada.AutoSize = true;
            this.labelPersonaAsignada.Location = new System.Drawing.Point(95, 546);
            this.labelPersonaAsignada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersonaAsignada.Name = "labelPersonaAsignada";
            this.labelPersonaAsignada.Size = new System.Drawing.Size(122, 16);
            this.labelPersonaAsignada.TabIndex = 20;
            this.labelPersonaAsignada.Text = "Persona asignada:";
            // 
            // checkBoxRechazar
            // 
            this.checkBoxRechazar.AutoSize = true;
            this.checkBoxRechazar.Location = new System.Drawing.Point(393, 508);
            this.checkBoxRechazar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxRechazar.Name = "checkBoxRechazar";
            this.checkBoxRechazar.Size = new System.Drawing.Size(85, 20);
            this.checkBoxRechazar.TabIndex = 19;
            this.checkBoxRechazar.Text = "Rechazar";
            this.checkBoxRechazar.UseVisualStyleBackColor = true;
            this.checkBoxRechazar.Click += new System.EventHandler(this.checkBoxRechazar_Click);
            // 
            // checkBoxAprobado
            // 
            this.checkBoxAprobado.AutoSize = true;
            this.checkBoxAprobado.Location = new System.Drawing.Point(301, 508);
            this.checkBoxAprobado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxAprobado.Name = "checkBoxAprobado";
            this.checkBoxAprobado.Size = new System.Drawing.Size(76, 20);
            this.checkBoxAprobado.TabIndex = 18;
            this.checkBoxAprobado.Text = "Aprobar";
            this.checkBoxAprobado.UseVisualStyleBackColor = true;
            this.checkBoxAprobado.Click += new System.EventHandler(this.checkBoxAprobado_Click);
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(301, 415);
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
            this.textLugarTrabajo.Location = new System.Drawing.Point(301, 366);
            this.textLugarTrabajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textLugarTrabajo.Name = "textLugarTrabajo";
            this.textLugarTrabajo.ReadOnly = true;
            this.textLugarTrabajo.Size = new System.Drawing.Size(609, 22);
            this.textLugarTrabajo.TabIndex = 16;
            // 
            // textAreaTrabajo
            // 
            this.textAreaTrabajo.Location = new System.Drawing.Point(301, 316);
            this.textAreaTrabajo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAreaTrabajo.Name = "textAreaTrabajo";
            this.textAreaTrabajo.ReadOnly = true;
            this.textAreaTrabajo.Size = new System.Drawing.Size(609, 22);
            this.textAreaTrabajo.TabIndex = 15;
            // 
            // textUrgencia
            // 
            this.textUrgencia.Location = new System.Drawing.Point(301, 267);
            this.textUrgencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUrgencia.Name = "textUrgencia";
            this.textUrgencia.ReadOnly = true;
            this.textUrgencia.Size = new System.Drawing.Size(609, 22);
            this.textUrgencia.TabIndex = 14;
            // 
            // textContacto
            // 
            this.textContacto.Location = new System.Drawing.Point(301, 218);
            this.textContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textContacto.Name = "textContacto";
            this.textContacto.ReadOnly = true;
            this.textContacto.Size = new System.Drawing.Size(609, 22);
            this.textContacto.TabIndex = 13;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(301, 169);
            this.textTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.ReadOnly = true;
            this.textTelefono.Size = new System.Drawing.Size(609, 22);
            this.textTelefono.TabIndex = 12;
            // 
            // textUnidad
            // 
            this.textUnidad.Location = new System.Drawing.Point(301, 119);
            this.textUnidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.ReadOnly = true;
            this.textUnidad.Size = new System.Drawing.Size(609, 22);
            this.textUnidad.TabIndex = 11;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(301, 70);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.ReadOnly = true;
            this.textNombre.Size = new System.Drawing.Size(609, 22);
            this.textNombre.TabIndex = 10;
            // 
            // textConsecutivo
            // 
            this.textConsecutivo.Location = new System.Drawing.Point(301, 21);
            this.textConsecutivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textConsecutivo.Name = "textConsecutivo";
            this.textConsecutivo.ReadOnly = true;
            this.textConsecutivo.Size = new System.Drawing.Size(609, 22);
            this.textConsecutivo.TabIndex = 9;
            // 
            // labelDescripción
            // 
            this.labelDescripción.AutoSize = true;
            this.labelDescripción.Location = new System.Drawing.Point(96, 418);
            this.labelDescripción.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripción.Name = "labelDescripción";
            this.labelDescripción.Size = new System.Drawing.Size(150, 16);
            this.labelDescripción.TabIndex = 8;
            this.labelDescripción.Text = "Descripción del trabajo:";
            // 
            // labelLugarTrabajo
            // 
            this.labelLugarTrabajo.AutoSize = true;
            this.labelLugarTrabajo.Location = new System.Drawing.Point(95, 369);
            this.labelLugarTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLugarTrabajo.Name = "labelLugarTrabajo";
            this.labelLugarTrabajo.Size = new System.Drawing.Size(189, 16);
            this.labelLugarTrabajo.TabIndex = 7;
            this.labelLugarTrabajo.Text = "Lugar donde realiza el trabajo:";
            // 
            // labelAreaTrabajo
            // 
            this.labelAreaTrabajo.AutoSize = true;
            this.labelAreaTrabajo.Location = new System.Drawing.Point(95, 320);
            this.labelAreaTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAreaTrabajo.Name = "labelAreaTrabajo";
            this.labelAreaTrabajo.Size = new System.Drawing.Size(164, 16);
            this.labelAreaTrabajo.TabIndex = 6;
            this.labelAreaTrabajo.Text = "Área de trabajo a solicitar:";
            // 
            // labrlUrgencia
            // 
            this.labrlUrgencia.AutoSize = true;
            this.labrlUrgencia.Location = new System.Drawing.Point(96, 271);
            this.labrlUrgencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labrlUrgencia.Name = "labrlUrgencia";
            this.labrlUrgencia.Size = new System.Drawing.Size(151, 16);
            this.labrlUrgencia.TabIndex = 5;
            this.labrlUrgencia.Text = "Urgencia de la solicitud:";
            // 
            // labrlContacto
            // 
            this.labrlContacto.AutoSize = true;
            this.labrlContacto.Location = new System.Drawing.Point(96, 222);
            this.labrlContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labrlContacto.Name = "labrlContacto";
            this.labrlContacto.Size = new System.Drawing.Size(122, 16);
            this.labrlContacto.TabIndex = 4;
            this.labrlContacto.Text = "Contacto adicional:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(96, 172);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(136, 16);
            this.labelTelefono.TabIndex = 3;
            this.labelTelefono.Text = "Teléfono o extensión:";
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Location = new System.Drawing.Point(96, 123);
            this.labelUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(134, 16);
            this.labelUnidad.TabIndex = 2;
            this.labelUnidad.Text = "Unidad o laboratorio:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(95, 74);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(145, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre del solicitante:";
            // 
            // labelConsecutivo
            // 
            this.labelConsecutivo.AutoSize = true;
            this.labelConsecutivo.Location = new System.Drawing.Point(96, 25);
            this.labelConsecutivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConsecutivo.Name = "labelConsecutivo";
            this.labelConsecutivo.Size = new System.Drawing.Size(88, 16);
            this.labelConsecutivo.TabIndex = 0;
            this.labelConsecutivo.Text = "Consecutivo: ";
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(1355, 772);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 18;
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
            this.butCancelar.TabIndex = 17;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // ListaSolicitudMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.labelSoliciudes);
            this.Controls.Add(this.dgvSolicitudes);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaSolicitudMantenimiento";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaSolicitudMantenimiento";
            this.Load += new System.EventHandler(this.ListaSolicitudMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label labelSoliciudes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDescripción;
        private System.Windows.Forms.Label labelLugarTrabajo;
        private System.Windows.Forms.Label labelAreaTrabajo;
        private System.Windows.Forms.Label labrlUrgencia;
        private System.Windows.Forms.Label labrlContacto;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelConsecutivo;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textLugarTrabajo;
        private System.Windows.Forms.TextBox textAreaTrabajo;
        private System.Windows.Forms.TextBox textUrgencia;
        private System.Windows.Forms.TextBox textContacto;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textConsecutivo;
        private System.Windows.Forms.CheckBox checkBoxRechazar;
        private System.Windows.Forms.CheckBox checkBoxAprobado;
        private System.Windows.Forms.TextBox textObservaciones;
        private System.Windows.Forms.Label labelObservaciones;
        private System.Windows.Forms.ComboBox comboPersonas;
        private System.Windows.Forms.Label labelPersonaAsignada;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}