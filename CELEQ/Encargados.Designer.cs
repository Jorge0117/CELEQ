namespace CELEQ
{
    partial class Encargados
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
            this.butModificar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.labelEncargados = new System.Windows.Forms.Label();
            this.dgvResponsables = new System.Windows.Forms.DataGridView();
            this.butEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(475, 119);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(197, 43);
            this.butModificar.TabIndex = 10;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(475, 70);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(197, 43);
            this.butAgregar.TabIndex = 9;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // labelEncargados
            // 
            this.labelEncargados.AutoSize = true;
            this.labelEncargados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncargados.Location = new System.Drawing.Point(25, 37);
            this.labelEncargados.Name = "labelEncargados";
            this.labelEncargados.Size = new System.Drawing.Size(111, 20);
            this.labelEncargados.TabIndex = 8;
            this.labelEncargados.Text = "Responsables";
            // 
            // dgvResponsables
            // 
            this.dgvResponsables.AllowUserToAddRows = false;
            this.dgvResponsables.AllowUserToDeleteRows = false;
            this.dgvResponsables.AllowUserToResizeColumns = false;
            this.dgvResponsables.AllowUserToResizeRows = false;
            this.dgvResponsables.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsables.Location = new System.Drawing.Point(29, 70);
            this.dgvResponsables.Name = "dgvResponsables";
            this.dgvResponsables.ReadOnly = true;
            this.dgvResponsables.RowHeadersVisible = false;
            this.dgvResponsables.Size = new System.Drawing.Size(395, 358);
            this.dgvResponsables.TabIndex = 7;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(475, 168);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(197, 43);
            this.butEliminar.TabIndex = 11;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // Encargados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(715, 461);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.labelEncargados);
            this.Controls.Add(this.dgvResponsables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Encargados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsable";
            this.Load += new System.EventHandler(this.Encargados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Label labelEncargados;
        public System.Windows.Forms.DataGridView dgvResponsables;
        private System.Windows.Forms.Button butEliminar;
    }
}