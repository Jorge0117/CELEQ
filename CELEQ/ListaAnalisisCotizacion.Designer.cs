namespace CELEQ
{
    partial class ListaAnalisisCotizacion
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
            this.labelUsuarios = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.butModificar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoAnalisis = new System.Windows.Forms.ComboBox();
            this.butAgregarTipo = new System.Windows.Forms.Button();
            this.butEliminarTipo = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.Location = new System.Drawing.Point(25, 30);
            this.labelUsuarios.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(67, 20);
            this.labelUsuarios.TabIndex = 5;
            this.labelUsuarios.Text = "Análisis:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(29, 71);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(947, 410);
            this.dgvClientes.TabIndex = 6;
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(984, 117);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(167, 38);
            this.butModificar.TabIndex = 20;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(984, 71);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 19;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tipo de muetra:";
            // 
            // comboTipoAnalisis
            // 
            this.comboTipoAnalisis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoAnalisis.FormattingEnabled = true;
            this.comboTipoAnalisis.Location = new System.Drawing.Point(543, 41);
            this.comboTipoAnalisis.Name = "comboTipoAnalisis";
            this.comboTipoAnalisis.Size = new System.Drawing.Size(271, 24);
            this.comboTipoAnalisis.TabIndex = 22;
            this.comboTipoAnalisis.SelectedIndexChanged += new System.EventHandler(this.comboTipoAnalisis_SelectedIndexChanged);
            // 
            // butAgregarTipo
            // 
            this.butAgregarTipo.Location = new System.Drawing.Point(820, 41);
            this.butAgregarTipo.Name = "butAgregarTipo";
            this.butAgregarTipo.Size = new System.Drawing.Size(75, 23);
            this.butAgregarTipo.TabIndex = 23;
            this.butAgregarTipo.Text = "Agregar";
            this.butAgregarTipo.UseVisualStyleBackColor = true;
            this.butAgregarTipo.Click += new System.EventHandler(this.butAgregarTipo_Click);
            // 
            // butEliminarTipo
            // 
            this.butEliminarTipo.Location = new System.Drawing.Point(901, 41);
            this.butEliminarTipo.Name = "butEliminarTipo";
            this.butEliminarTipo.Size = new System.Drawing.Size(75, 23);
            this.butEliminarTipo.TabIndex = 24;
            this.butEliminarTipo.Text = "Eliminar";
            this.butEliminarTipo.UseVisualStyleBackColor = true;
            this.butEliminarTipo.Click += new System.EventHandler(this.butEliminarTipo_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(984, 163);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(167, 38);
            this.butEliminar.TabIndex = 25;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            // 
            // ListaAnalisisCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1174, 511);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butEliminarTipo);
            this.Controls.Add(this.butAgregarTipo);
            this.Controls.Add(this.comboTipoAnalisis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.labelUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaAnalisisCotizacion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaAnalisis";
            this.Load += new System.EventHandler(this.ListaAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuarios;
        public System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTipoAnalisis;
        private System.Windows.Forms.Button butAgregarTipo;
        private System.Windows.Forms.Button butEliminarTipo;
        private System.Windows.Forms.Button butEliminar;
    }
}