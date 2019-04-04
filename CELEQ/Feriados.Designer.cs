namespace CELEQ
{
    partial class Feriados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFeriados = new System.Windows.Forms.DataGridView();
            this.labelFeriados = new System.Windows.Forms.Label();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textInicio = new System.Windows.Forms.TextBox();
            this.textFin = new System.Windows.Forms.TextBox();
            this.butCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeriados
            // 
            this.dgvFeriados.AllowUserToAddRows = false;
            this.dgvFeriados.AllowUserToDeleteRows = false;
            this.dgvFeriados.AllowUserToResizeColumns = false;
            this.dgvFeriados.AllowUserToResizeRows = false;
            this.dgvFeriados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeriados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeriados.Location = new System.Drawing.Point(28, 54);
            this.dgvFeriados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFeriados.Name = "dgvFeriados";
            this.dgvFeriados.RowHeadersVisible = false;
            this.dgvFeriados.Size = new System.Drawing.Size(497, 334);
            this.dgvFeriados.TabIndex = 4;
            // 
            // labelFeriados
            // 
            this.labelFeriados.AutoSize = true;
            this.labelFeriados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFeriados.Location = new System.Drawing.Point(24, 30);
            this.labelFeriados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFeriados.Name = "labelFeriados";
            this.labelFeriados.Size = new System.Drawing.Size(75, 20);
            this.labelFeriados.TabIndex = 5;
            this.labelFeriados.Text = "Feriados:";
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(533, 146);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(167, 38);
            this.butEliminar.TabIndex = 9;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(533, 54);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 10;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(533, 100);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(167, 38);
            this.butModificar.TabIndex = 11;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Semana Santa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fin:";
            // 
            // textInicio
            // 
            this.textInicio.Location = new System.Drawing.Point(73, 427);
            this.textInicio.Name = "textInicio";
            this.textInicio.ReadOnly = true;
            this.textInicio.Size = new System.Drawing.Size(145, 22);
            this.textInicio.TabIndex = 15;
            // 
            // textFin
            // 
            this.textFin.Location = new System.Drawing.Point(260, 427);
            this.textFin.Name = "textFin";
            this.textFin.ReadOnly = true;
            this.textFin.Size = new System.Drawing.Size(145, 22);
            this.textFin.TabIndex = 16;
            // 
            // butCalcular
            // 
            this.butCalcular.Location = new System.Drawing.Point(423, 427);
            this.butCalcular.Name = "butCalcular";
            this.butCalcular.Size = new System.Drawing.Size(75, 23);
            this.butCalcular.TabIndex = 17;
            this.butCalcular.Text = "Calcular";
            this.butCalcular.UseVisualStyleBackColor = true;
            this.butCalcular.Click += new System.EventHandler(this.butCalcular_Click);
            // 
            // Feriados
            // 
            this.AccessibleName = "0";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(713, 480);
            this.Controls.Add(this.butCalcular);
            this.Controls.Add(this.textFin);
            this.Controls.Add(this.textInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.labelFeriados);
            this.Controls.Add(this.dgvFeriados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Feriados";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feriados";
            this.Load += new System.EventHandler(this.Feriados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFeriados;
        private System.Windows.Forms.Label labelFeriados;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textInicio;
        private System.Windows.Forms.TextBox textFin;
        private System.Windows.Forms.Button butCalcular;
    }
}