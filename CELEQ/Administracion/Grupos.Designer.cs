namespace CELEQ
{
    partial class Grupos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelGrupos = new System.Windows.Forms.Label();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(615, 177);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(167, 38);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(615, 131);
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
            this.butAgregar.Location = new System.Drawing.Point(615, 85);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 20;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(220, 45);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(387, 22);
            this.textBuscar.TabIndex = 18;
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // labelGrupos
            // 
            this.labelGrupos.AutoSize = true;
            this.labelGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupos.Location = new System.Drawing.Point(32, 32);
            this.labelGrupos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrupos.Name = "labelGrupos";
            this.labelGrupos.Size = new System.Drawing.Size(66, 20);
            this.labelGrupos.TabIndex = 17;
            this.labelGrupos.Text = "Grupos:";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.AllowUserToResizeColumns = false;
            this.dgvGrupos.AllowUserToResizeRows = false;
            this.dgvGrupos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(36, 85);
            this.dgvGrupos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            this.dgvGrupos.RowHeadersVisible = false;
            this.dgvGrupos.Size = new System.Drawing.Size(571, 400);
            this.dgvGrupos.TabIndex = 16;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(796, 510);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelGrupos);
            this.Controls.Add(this.dgvGrupos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Grupos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos";
            this.Load += new System.EventHandler(this.Grupos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelGrupos;
        public System.Windows.Forms.DataGridView dgvGrupos;
    }
}