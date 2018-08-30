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
            this.labelInventario = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.butAgregar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.butActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.numAgregar = new System.Windows.Forms.NumericUpDown();
            this.labelUnidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInventario
            // 
            this.labelInventario.AutoSize = true;
            this.labelInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventario.Location = new System.Drawing.Point(12, 35);
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
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(16, 68);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.Size = new System.Drawing.Size(900, 553);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellClick);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(956, 92);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(197, 43);
            this.butAgregar.TabIndex = 2;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(573, 42);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(343, 20);
            this.textBuscar.TabIndex = 3;
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // butActualizar
            // 
            this.butActualizar.Location = new System.Drawing.Point(956, 141);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(197, 43);
            this.butActualizar.TabIndex = 5;
            this.butActualizar.Text = "Actualizar";
            this.butActualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(953, 68);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 7;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // numAgregar
            // 
            this.numAgregar.Location = new System.Drawing.Point(1011, 66);
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
            this.numAgregar.Size = new System.Drawing.Size(95, 20);
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
            this.labelUnidad.Location = new System.Drawing.Point(1108, 68);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(13, 13);
            this.labelUnidad.TabIndex = 9;
            this.labelUnidad.Text = "g";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.labelUnidad);
            this.Controls.Add(this.numAgregar);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butActualizar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.labelInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inventario";
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
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button butActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.NumericUpDown numAgregar;
        private System.Windows.Forms.Label labelUnidad;
    }
}