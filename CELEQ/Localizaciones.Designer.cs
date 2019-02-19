namespace CELEQ
{
    partial class Localizaciones
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
            this.dgvLocalizaciones = new System.Windows.Forms.DataGridView();
            this.labelLocalizaciones = new System.Windows.Forms.Label();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocalizaciones
            // 
            this.dgvLocalizaciones.AllowUserToAddRows = false;
            this.dgvLocalizaciones.AllowUserToDeleteRows = false;
            this.dgvLocalizaciones.AllowUserToResizeColumns = false;
            this.dgvLocalizaciones.AllowUserToResizeRows = false;
            this.dgvLocalizaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLocalizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalizaciones.Location = new System.Drawing.Point(35, 88);
            this.dgvLocalizaciones.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvLocalizaciones.Name = "dgvLocalizaciones";
            this.dgvLocalizaciones.ReadOnly = true;
            this.dgvLocalizaciones.RowHeadersVisible = false;
            this.dgvLocalizaciones.Size = new System.Drawing.Size(1080, 701);
            this.dgvLocalizaciones.TabIndex = 4;
            // 
            // labelLocalizaciones
            // 
            this.labelLocalizaciones.AutoSize = true;
            this.labelLocalizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalizaciones.Location = new System.Drawing.Point(31, 47);
            this.labelLocalizaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLocalizaciones.Name = "labelLocalizaciones";
            this.labelLocalizaciones.Size = new System.Drawing.Size(113, 20);
            this.labelLocalizaciones.TabIndex = 5;
            this.labelLocalizaciones.Text = "Localizaciones";
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(1139, 209);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(263, 53);
            this.butEliminar.TabIndex = 20;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(1139, 148);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(263, 53);
            this.butModificar.TabIndex = 19;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(1139, 88);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(263, 53);
            this.butAgregar.TabIndex = 18;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // Localizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1435, 821);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.labelLocalizaciones);
            this.Controls.Add(this.dgvLocalizaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Localizaciones";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizaciones";
            this.Load += new System.EventHandler(this.Localizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvLocalizaciones;
        private System.Windows.Forms.Label labelLocalizaciones;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butAgregar;
    }
}