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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvLocalizaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalizaciones.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalizaciones.Location = new System.Drawing.Point(28, 71);
            this.dgvLocalizaciones.Margin = new System.Windows.Forms.Padding(5);
            this.dgvLocalizaciones.Name = "dgvLocalizaciones";
            this.dgvLocalizaciones.ReadOnly = true;
            this.dgvLocalizaciones.RowHeadersVisible = false;
            this.dgvLocalizaciones.Size = new System.Drawing.Size(676, 410);
            this.dgvLocalizaciones.TabIndex = 4;
            // 
            // labelLocalizaciones
            // 
            this.labelLocalizaciones.AutoSize = true;
            this.labelLocalizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalizaciones.Location = new System.Drawing.Point(24, 30);
            this.labelLocalizaciones.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLocalizaciones.Name = "labelLocalizaciones";
            this.labelLocalizaciones.Size = new System.Drawing.Size(117, 20);
            this.labelLocalizaciones.TabIndex = 5;
            this.labelLocalizaciones.Text = "Localizaciones:";
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(713, 163);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(167, 38);
            this.butEliminar.TabIndex = 20;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(713, 117);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(167, 38);
            this.butModificar.TabIndex = 19;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(713, 71);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
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
            this.ClientSize = new System.Drawing.Size(905, 511);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.labelLocalizaciones);
            this.Controls.Add(this.dgvLocalizaciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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