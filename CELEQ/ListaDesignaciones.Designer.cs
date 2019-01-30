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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesignaciones
            // 
            this.labelDesignaciones.AutoSize = true;
            this.labelDesignaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignaciones.Location = new System.Drawing.Point(12, 35);
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
            this.dgvDesignaciones.Location = new System.Drawing.Point(16, 68);
            this.dgvDesignaciones.Name = "dgvDesignaciones";
            this.dgvDesignaciones.ReadOnly = true;
            this.dgvDesignaciones.RowHeadersVisible = false;
            this.dgvDesignaciones.Size = new System.Drawing.Size(1145, 553);
            this.dgvDesignaciones.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(769, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(818, 42);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(343, 20);
            this.textBuscar.TabIndex = 18;
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // ListaDesignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelDesignaciones);
            this.Controls.Add(this.dgvDesignaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}