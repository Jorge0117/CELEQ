namespace CELEQ
{
    partial class Unidad
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
            this.dgvUnidad = new System.Windows.Forms.DataGridView();
            this.labelSoliciudes = new System.Windows.Forms.Label();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnidad
            // 
            this.dgvUnidad.AllowUserToAddRows = false;
            this.dgvUnidad.AllowUserToDeleteRows = false;
            this.dgvUnidad.AllowUserToResizeColumns = false;
            this.dgvUnidad.AllowUserToResizeRows = false;
            this.dgvUnidad.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnidad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidad.Location = new System.Drawing.Point(29, 71);
            this.dgvUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUnidad.Name = "dgvUnidad";
            this.dgvUnidad.ReadOnly = true;
            this.dgvUnidad.RowHeadersVisible = false;
            this.dgvUnidad.Size = new System.Drawing.Size(613, 410);
            this.dgvUnidad.TabIndex = 3;
            // 
            // labelSoliciudes
            // 
            this.labelSoliciudes.AutoSize = true;
            this.labelSoliciudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoliciudes.Location = new System.Drawing.Point(24, 30);
            this.labelSoliciudes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoliciudes.Name = "labelSoliciudes";
            this.labelSoliciudes.Size = new System.Drawing.Size(81, 20);
            this.labelSoliciudes.TabIndex = 4;
            this.labelSoliciudes.Text = "Unidades:";
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(650, 71);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 5;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(650, 117);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(167, 38);
            this.butModificar.TabIndex = 6;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // Unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(839, 511);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.labelSoliciudes);
            this.Controls.Add(this.dgvUnidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Unidad";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidad";
            this.Load += new System.EventHandler(this.Unidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvUnidad;
        private System.Windows.Forms.Label labelSoliciudes;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butModificar;
    }
}