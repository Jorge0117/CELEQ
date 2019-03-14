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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFeriados = new System.Windows.Forms.DataGridView();
            this.labelFeriados = new System.Windows.Forms.Label();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeriados
            // 
            this.dgvFeriados.AllowUserToDeleteRows = false;
            this.dgvFeriados.AllowUserToResizeColumns = false;
            this.dgvFeriados.AllowUserToResizeRows = false;
            this.dgvFeriados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeriados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeriados.Location = new System.Drawing.Point(28, 54);
            this.dgvFeriados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFeriados.Name = "dgvFeriados";
            this.dgvFeriados.RowHeadersVisible = false;
            this.dgvFeriados.Size = new System.Drawing.Size(415, 334);
            this.dgvFeriados.TabIndex = 4;
            this.dgvFeriados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeriados_CellClick);
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
            this.butEliminar.Location = new System.Drawing.Point(508, 100);
            this.butEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(167, 38);
            this.butEliminar.TabIndex = 9;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(508, 54);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 7;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(459, 151);
            this.monthCalendar1.MaxSelectionCount = 2;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseDown);
            // 
            // Feriados
            // 
            this.AccessibleName = "0";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(725, 511);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.labelFeriados);
            this.Controls.Add(this.dgvFeriados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}