namespace CELEQ
{
    partial class FormReacCris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butElimCri = new System.Windows.Forms.Button();
            this.dgvCristaleria = new System.Windows.Forms.DataGridView();
            this.butAgCr = new System.Windows.Forms.Button();
            this.butElimReac = new System.Windows.Forms.Button();
            this.butAgRe = new System.Windows.Forms.Button();
            this.dgvReactivos = new System.Windows.Forms.DataGridView();
            this.butRealizarSolicutud = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCristaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butElimCri);
            this.groupBox1.Controls.Add(this.dgvCristaleria);
            this.groupBox1.Controls.Add(this.butAgCr);
            this.groupBox1.Controls.Add(this.butElimReac);
            this.groupBox1.Controls.Add(this.butAgRe);
            this.groupBox1.Controls.Add(this.dgvReactivos);
            this.groupBox1.Location = new System.Drawing.Point(67, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1387, 714);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitudes";
            // 
            // butElimCri
            // 
            this.butElimCri.Location = new System.Drawing.Point(1081, 460);
            this.butElimCri.Margin = new System.Windows.Forms.Padding(4);
            this.butElimCri.Name = "butElimCri";
            this.butElimCri.Size = new System.Drawing.Size(263, 53);
            this.butElimCri.TabIndex = 5;
            this.butElimCri.Text = "Eliminar";
            this.butElimCri.UseVisualStyleBackColor = true;
            this.butElimCri.Click += new System.EventHandler(this.butElimCri_Click);
            // 
            // dgvCristaleria
            // 
            this.dgvCristaleria.AllowUserToAddRows = false;
            this.dgvCristaleria.AllowUserToDeleteRows = false;
            this.dgvCristaleria.AllowUserToResizeColumns = false;
            this.dgvCristaleria.AllowUserToResizeRows = false;
            this.dgvCristaleria.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCristaleria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCristaleria.Location = new System.Drawing.Point(77, 400);
            this.dgvCristaleria.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCristaleria.Name = "dgvCristaleria";
            this.dgvCristaleria.ReadOnly = true;
            this.dgvCristaleria.RowHeadersVisible = false;
            this.dgvCristaleria.Size = new System.Drawing.Size(960, 278);
            this.dgvCristaleria.TabIndex = 4;
            // 
            // butAgCr
            // 
            this.butAgCr.Location = new System.Drawing.Point(1081, 400);
            this.butAgCr.Margin = new System.Windows.Forms.Padding(4);
            this.butAgCr.Name = "butAgCr";
            this.butAgCr.Size = new System.Drawing.Size(263, 53);
            this.butAgCr.TabIndex = 3;
            this.butAgCr.Text = "Agregar Cristalería";
            this.butAgCr.UseVisualStyleBackColor = true;
            this.butAgCr.Click += new System.EventHandler(this.butAgCr_Click);
            // 
            // butElimReac
            // 
            this.butElimReac.Location = new System.Drawing.Point(1081, 122);
            this.butElimReac.Margin = new System.Windows.Forms.Padding(4);
            this.butElimReac.Name = "butElimReac";
            this.butElimReac.Size = new System.Drawing.Size(263, 53);
            this.butElimReac.TabIndex = 2;
            this.butElimReac.Text = "Eliminar";
            this.butElimReac.UseVisualStyleBackColor = true;
            this.butElimReac.Click += new System.EventHandler(this.butElimReac_Click);
            // 
            // butAgRe
            // 
            this.butAgRe.Location = new System.Drawing.Point(1081, 62);
            this.butAgRe.Margin = new System.Windows.Forms.Padding(4);
            this.butAgRe.Name = "butAgRe";
            this.butAgRe.Size = new System.Drawing.Size(263, 53);
            this.butAgRe.TabIndex = 1;
            this.butAgRe.Text = "Agregar Reactivo";
            this.butAgRe.UseVisualStyleBackColor = true;
            this.butAgRe.Click += new System.EventHandler(this.butAgRe_Click);
            // 
            // dgvReactivos
            // 
            this.dgvReactivos.AllowUserToAddRows = false;
            this.dgvReactivos.AllowUserToDeleteRows = false;
            this.dgvReactivos.AllowUserToResizeColumns = false;
            this.dgvReactivos.AllowUserToResizeRows = false;
            this.dgvReactivos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReactivos.Location = new System.Drawing.Point(77, 62);
            this.dgvReactivos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReactivos.Name = "dgvReactivos";
            this.dgvReactivos.ReadOnly = true;
            this.dgvReactivos.RowHeadersVisible = false;
            this.dgvReactivos.Size = new System.Drawing.Size(960, 278);
            this.dgvReactivos.TabIndex = 0;
            // 
            // butRealizarSolicutud
            // 
            this.butRealizarSolicutud.Location = new System.Drawing.Point(1147, 745);
            this.butRealizarSolicutud.Margin = new System.Windows.Forms.Padding(4);
            this.butRealizarSolicutud.Name = "butRealizarSolicutud";
            this.butRealizarSolicutud.Size = new System.Drawing.Size(263, 53);
            this.butRealizarSolicutud.TabIndex = 6;
            this.butRealizarSolicutud.Text = "Continuar con Solicitud";
            this.butRealizarSolicutud.UseVisualStyleBackColor = true;
            this.butRealizarSolicutud.Click += new System.EventHandler(this.butRealizarSolicutud_Click);
            // 
            // FormReacCris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.butRealizarSolicutud);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReacCris";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReacCris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReacCris_FormClosing);
            this.Load += new System.EventHandler(this.FormReacCris_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCristaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvReactivos;
        private System.Windows.Forms.Button butElimReac;
        private System.Windows.Forms.Button butAgRe;
        private System.Windows.Forms.Button butAgCr;
        private System.Windows.Forms.Button butElimCri;
        public System.Windows.Forms.DataGridView dgvCristaleria;
        private System.Windows.Forms.Button butRealizarSolicutud;
    }
}