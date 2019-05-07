namespace CELEQ
{
    partial class SeleccionarAnalisisCotizacion
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
            this.dgvAnalisis = new System.Windows.Forms.DataGridView();
            this.labelSeleccion = new System.Windows.Forms.Label();
            this.labelMetodo = new System.Windows.Forms.Label();
            this.comboMetodo = new System.Windows.Forms.ComboBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnalisis
            // 
            this.dgvAnalisis.AllowUserToAddRows = false;
            this.dgvAnalisis.AllowUserToDeleteRows = false;
            this.dgvAnalisis.AllowUserToResizeColumns = false;
            this.dgvAnalisis.AllowUserToResizeRows = false;
            this.dgvAnalisis.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisis.Location = new System.Drawing.Point(67, 67);
            this.dgvAnalisis.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvAnalisis.MultiSelect = false;
            this.dgvAnalisis.Name = "dgvAnalisis";
            this.dgvAnalisis.ReadOnly = true;
            this.dgvAnalisis.RowHeadersVisible = false;
            this.dgvAnalisis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAnalisis.Size = new System.Drawing.Size(901, 406);
            this.dgvAnalisis.TabIndex = 1;
            this.dgvAnalisis.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAnalisis_CellMouseDoubleClick);
            // 
            // labelSeleccion
            // 
            this.labelSeleccion.AutoSize = true;
            this.labelSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccion.Location = new System.Drawing.Point(459, 13);
            this.labelSeleccion.Name = "labelSeleccion";
            this.labelSeleccion.Size = new System.Drawing.Size(117, 20);
            this.labelSeleccion.TabIndex = 2;
            this.labelSeleccion.Text = "Selección de ";
            // 
            // labelMetodo
            // 
            this.labelMetodo.AutoSize = true;
            this.labelMetodo.Location = new System.Drawing.Point(64, 36);
            this.labelMetodo.Name = "labelMetodo";
            this.labelMetodo.Size = new System.Drawing.Size(57, 16);
            this.labelMetodo.TabIndex = 3;
            this.labelMetodo.Text = "Método:";
            // 
            // comboMetodo
            // 
            this.comboMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMetodo.FormattingEnabled = true;
            this.comboMetodo.Location = new System.Drawing.Point(127, 33);
            this.comboMetodo.Name = "comboMetodo";
            this.comboMetodo.Size = new System.Drawing.Size(160, 24);
            this.comboMetodo.TabIndex = 4;
            this.comboMetodo.TextChanged += new System.EventHandler(this.comboMetodo_TextChanged);
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(814, 484);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 20;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(922, 484);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 19;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // SeleccionarAnalisisCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1035, 525);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.comboMetodo);
            this.Controls.Add(this.labelMetodo);
            this.Controls.Add(this.labelSeleccion);
            this.Controls.Add(this.dgvAnalisis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeleccionarAnalisisCotizacion";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarAnalisisCotizacion";
            this.Load += new System.EventHandler(this.SeleccionarAnalisisCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnalisis;
        private System.Windows.Forms.Label labelSeleccion;
        private System.Windows.Forms.Label labelMetodo;
        private System.Windows.Forms.ComboBox comboMetodo;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}