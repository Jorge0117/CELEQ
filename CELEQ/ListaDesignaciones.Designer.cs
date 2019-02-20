namespace CELEQ
{
    partial class ListaDesignaciones
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
            this.labelDesignaciones = new System.Windows.Forms.Label();
            this.dgvDesignaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.butAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesignaciones
            // 
            this.labelDesignaciones.AutoSize = true;
            this.labelDesignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignaciones.Location = new System.Drawing.Point(24, 30);
            this.labelDesignaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesignaciones.Name = "labelDesignaciones";
            this.labelDesignaciones.Size = new System.Drawing.Size(114, 20);
            this.labelDesignaciones.TabIndex = 5;
            this.labelDesignaciones.Text = "Designaciones";
            // 
            // dgvDesignaciones
            // 
            this.dgvDesignaciones.AllowUserToAddRows = false;
            this.dgvDesignaciones.AllowUserToDeleteRows = false;
            this.dgvDesignaciones.AllowUserToResizeColumns = false;
            this.dgvDesignaciones.AllowUserToResizeRows = false;
            this.dgvDesignaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDesignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesignaciones.Location = new System.Drawing.Point(29, 71);
            this.dgvDesignaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDesignaciones.Name = "dgvDesignaciones";
            this.dgvDesignaciones.ReadOnly = true;
            this.dgvDesignaciones.RowHeadersVisible = false;
            this.dgvDesignaciones.Size = new System.Drawing.Size(947, 410);
            this.dgvDesignaciones.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(589, 41);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(387, 22);
            this.textBuscar.TabIndex = 18;
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(984, 71);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 20;
            this.butAgregar.Text = "Detalles";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // ListaDesignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1174, 511);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelDesignaciones);
            this.Controls.Add(this.dgvDesignaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaDesignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDesignaciones";
            this.Load += new System.EventHandler(this.ListaDesignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesignaciones;
        public System.Windows.Forms.DataGridView dgvDesignaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button butAgregar;
    }
}