﻿namespace CELEQ
{
    partial class Presupuesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.labelPresupuestos = new System.Windows.Forms.Label();
            this.dgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.butEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // butModificar
            // 
            this.butModificar.Location = new System.Drawing.Point(965, 119);
            this.butModificar.Name = "butModificar";
            this.butModificar.Size = new System.Drawing.Size(197, 43);
            this.butModificar.TabIndex = 19;
            this.butModificar.Text = "Modificar";
            this.butModificar.UseVisualStyleBackColor = true;
            this.butModificar.Click += new System.EventHandler(this.butModificar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(965, 70);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(197, 43);
            this.butAgregar.TabIndex = 18;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(583, 44);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(343, 20);
            this.textBuscar.TabIndex = 16;
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // labelPresupuestos
            // 
            this.labelPresupuestos.AutoSize = true;
            this.labelPresupuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresupuestos.Location = new System.Drawing.Point(22, 37);
            this.labelPresupuestos.Name = "labelPresupuestos";
            this.labelPresupuestos.Size = new System.Drawing.Size(111, 20);
            this.labelPresupuestos.TabIndex = 15;
            this.labelPresupuestos.Text = "Presupuestos:";
            // 
            // dgvPresupuesto
            // 
            this.dgvPresupuesto.AllowUserToAddRows = false;
            this.dgvPresupuesto.AllowUserToDeleteRows = false;
            this.dgvPresupuesto.AllowUserToResizeColumns = false;
            this.dgvPresupuesto.AllowUserToResizeRows = false;
            this.dgvPresupuesto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuesto.Location = new System.Drawing.Point(26, 70);
            this.dgvPresupuesto.Name = "dgvPresupuesto";
            this.dgvPresupuesto.ReadOnly = true;
            this.dgvPresupuesto.RowHeadersVisible = false;
            this.dgvPresupuesto.Size = new System.Drawing.Size(900, 553);
            this.dgvPresupuesto.TabIndex = 14;
            // 
            // butEliminar
            // 
            this.butEliminar.Location = new System.Drawing.Point(965, 168);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(197, 43);
            this.butEliminar.TabIndex = 20;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // Presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butModificar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.labelPresupuestos);
            this.Controls.Add(this.dgvPresupuesto);
            this.Name = "Presupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.Presupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butModificar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label labelPresupuestos;
        public System.Windows.Forms.DataGridView dgvPresupuesto;
        private System.Windows.Forms.Button butEliminar;
    }
}