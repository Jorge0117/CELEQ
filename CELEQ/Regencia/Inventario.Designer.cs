namespace CELEQ
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelInventario = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.butAgregar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.butActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.numAgregar = new System.Windows.Forms.NumericUpDown();
            this.labelUnidad = new System.Windows.Forms.Label();
            this.butModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.Location = new System.Drawing.Point(15, 30);
            this.labelInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInventario.Name = "labelInventario";
            this.labelInventario.Size = new System.Drawing.Size(111, 20);
            this.labelInventario.TabIndex = 0;
            this.labelInventario.Text = "... Disponibles:";
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(20, 71);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(947, 410);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            this.dgvInventario.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvInventario_RowPostPaint);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(975, 71);
            this.butAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(167, 38);
            this.butAgregar.TabIndex = 2;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(580, 41);
            this.textBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(387, 22);
            this.textBuscar.TabIndex = 3;
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // butActualizar
            // 
            this.butActualizar.Location = new System.Drawing.Point(975, 163);
            this.butActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(167, 38);
            this.butActualizar.TabIndex = 5;
            this.butActualizar.Text = "Actualizar";
            this.butActualizar.UseVisualStyleBackColor = true;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(975, 44);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(65, 16);
            this.labelCantidad.TabIndex = 7;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // numAgregar
            // 
            this.numAgregar.Location = new System.Drawing.Point(1048, 42);
            this.numAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.numAgregar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAgregar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAgregar.Name = "numAgregar";
            this.numAgregar.Size = new System.Drawing.Size(94, 22);
            this.numAgregar.TabIndex = 8;
            this.numAgregar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Location = new System.Drawing.Point(1144, 44);
            this.labelUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(16, 16);
            this.labelUnidad.TabIndex = 9;
            this.labelUnidad.Text = "g";
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(975, 117);
            this.butModificar.Margin = new System.Windows.Forms.Padding(4);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(167, 38);
            this.butModificar.TabIndex = 10;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1174, 511);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.labelUnidad);
            this.Controls.Add(this.numAgregar);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butActualizar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.labelInventario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInventario;
        public System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button butActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.NumericUpDown numAgregar;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Button butModificar;
    }
}