namespace CELEQ
{
    partial class listarCotizaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.butModificar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuarios
            // 
            this.labelUsuarios.AutoSize = true;
            this.labelUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarios.Location = new System.Drawing.Point(25, 27);
            this.labelUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuarios.Name = "labelUsuarios";
            this.labelUsuarios.Size = new System.Drawing.Size(104, 20);
            this.labelUsuarios.TabIndex = 5;
            this.labelUsuarios.Text = "Cotizaciones:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(29, 73);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(942, 410);
            this.dgvClientes.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(584, 43);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(387, 22);
            this.textBuscar.TabIndex = 18;
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(977, 165);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(167, 38);
            this.butModificar.TabIndex = 21;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(977, 119);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 20;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butVer
            // 
            this.butVer.Location = new System.Drawing.Point(977, 73);
            this.butVer.Margin = new System.Windows.Forms.Padding(4);
            this.butVer.Name = "butVer";
            this.butVer.Size = new System.Drawing.Size(167, 38);
            this.butVer.TabIndex = 22;
            this.butVer.Text = "Visualizar";
            this.butVer.UseVisualStyleBackColor = true;
            this.butVer.Click += new System.EventHandler(this.butVer_Click);
            // 
            // listarCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1165, 511);
            this.Controls.Add(this.butVer);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.labelUsuarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "listarCotizaciones";
            this.Text = "listarCotizaciones";
            this.Load += new System.EventHandler(this.listarCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuarios;
        public System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butVer;
    }
}