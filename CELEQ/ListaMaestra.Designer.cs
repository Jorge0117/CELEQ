namespace CELEQ
{
    partial class ListaMaestra
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboOpcionMostrar = new System.Windows.Forms.ComboBox();
            this.dgvListaM = new System.Windows.Forms.DataGridView();
            this.labelSoliciudes = new System.Windows.Forms.Label();
            this.butActualizar = new System.Windows.Forms.Button();
            this.butModificar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaM)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mostrar:";
            // 
            // comboOpcionMostrar
            // 
            this.comboOpcionMostrar.FormattingEnabled = true;
            this.comboOpcionMostrar.Items.AddRange(new object[] {
            "Vigentes",
            "Todos"});
            this.comboOpcionMostrar.Location = new System.Drawing.Point(282, 54);
            this.comboOpcionMostrar.Name = "comboOpcionMostrar";
            this.comboOpcionMostrar.Size = new System.Drawing.Size(144, 24);
            this.comboOpcionMostrar.TabIndex = 1;
            // 
            // dgvListaM
            // 
            this.dgvListaM.AllowUserToAddRows = false;
            this.dgvListaM.AllowUserToDeleteRows = false;
            this.dgvListaM.AllowUserToResizeColumns = false;
            this.dgvListaM.AllowUserToResizeRows = false;
            this.dgvListaM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaM.Location = new System.Drawing.Point(52, 85);
            this.dgvListaM.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaM.Name = "dgvListaM";
            this.dgvListaM.ReadOnly = true;
            this.dgvListaM.RowHeadersVisible = false;
            this.dgvListaM.Size = new System.Drawing.Size(613, 410);
            this.dgvListaM.TabIndex = 4;
            // 
            // labelSoliciudes
            // 
            this.labelSoliciudes.AutoSize = true;
            this.labelSoliciudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoliciudes.Location = new System.Drawing.Point(50, 54);
            this.labelSoliciudes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoliciudes.Name = "labelSoliciudes";
            this.labelSoliciudes.Size = new System.Drawing.Size(109, 20);
            this.labelSoliciudes.TabIndex = 5;
            this.labelSoliciudes.Text = "Lista Maestra:";
            // 
            // butActualizar
            // 
            this.butActualizar.Location = new System.Drawing.Point(673, 177);
            this.butActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(167, 38);
            this.butActualizar.TabIndex = 23;
            this.butActualizar.Text = "Actualizar";
            this.butActualizar.UseVisualStyleBackColor = true;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(673, 131);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(167, 38);
            this.butModificar.TabIndex = 22;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(673, 85);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 21;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(508, 57);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(157, 22);
            this.textBuscar.TabIndex = 25;
            // 
            // ListaMaestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(861, 534);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butActualizar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.labelSoliciudes);
            this.Controls.Add(this.dgvListaM);
            this.Controls.Add(this.comboOpcionMostrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaMaestra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaMaestra";
            this.Load += new System.EventHandler(this.ListaMaestra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboOpcionMostrar;
        public System.Windows.Forms.DataGridView dgvListaM;
        private System.Windows.Forms.Label labelSoliciudes;
        private System.Windows.Forms.Button butActualizar;
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBuscar;
    }
}