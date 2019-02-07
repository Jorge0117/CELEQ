namespace CELEQ
{
    partial class GenerarReporteDesignaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkCicloI = new System.Windows.Forms.CheckBox();
            this.checkCicloIIC = new System.Windows.Forms.CheckBox();
            this.checkCicloII = new System.Windows.Forms.CheckBox();
            this.checkCicloIIIC = new System.Windows.Forms.CheckBox();
            this.checkcicloIII = new System.Windows.Forms.CheckBox();
            this.butGenerarReporte = new System.Windows.Forms.Button();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciclo:";
            // 
            // checkCicloI
            // 
            this.checkCicloI.AutoSize = true;
            this.checkCicloI.Location = new System.Drawing.Point(204, 21);
            this.checkCicloI.Name = "checkCicloI";
            this.checkCicloI.Size = new System.Drawing.Size(29, 17);
            this.checkCicloI.TabIndex = 4;
            this.checkCicloI.Text = "I";
            this.checkCicloI.UseVisualStyleBackColor = true;
            // 
            // checkCicloIIC
            // 
            this.checkCicloIIC.AutoSize = true;
            this.checkCicloIIC.Location = new System.Drawing.Point(239, 21);
            this.checkCicloIIC.Name = "checkCicloIIC";
            this.checkCicloIIC.Size = new System.Drawing.Size(45, 17);
            this.checkCicloIIC.TabIndex = 5;
            this.checkCicloIIC.Text = "I I.C";
            this.checkCicloIIC.UseVisualStyleBackColor = true;
            // 
            // checkCicloII
            // 
            this.checkCicloII.AutoSize = true;
            this.checkCicloII.Location = new System.Drawing.Point(284, 21);
            this.checkCicloII.Name = "checkCicloII";
            this.checkCicloII.Size = new System.Drawing.Size(32, 17);
            this.checkCicloII.TabIndex = 6;
            this.checkCicloII.Text = "II";
            this.checkCicloII.UseVisualStyleBackColor = true;
            // 
            // checkCicloIIIC
            // 
            this.checkCicloIIIC.AutoSize = true;
            this.checkCicloIIIC.Location = new System.Drawing.Point(322, 21);
            this.checkCicloIIIC.Name = "checkCicloIIIC";
            this.checkCicloIIIC.Size = new System.Drawing.Size(48, 17);
            this.checkCicloIIIC.TabIndex = 7;
            this.checkCicloIIIC.Text = "II I.C";
            this.checkCicloIIIC.UseVisualStyleBackColor = true;
            // 
            // checkcicloIII
            // 
            this.checkcicloIII.AutoSize = true;
            this.checkcicloIII.Location = new System.Drawing.Point(370, 21);
            this.checkcicloIII.Name = "checkcicloIII";
            this.checkcicloIII.Size = new System.Drawing.Size(35, 17);
            this.checkcicloIII.TabIndex = 8;
            this.checkcicloIII.Text = "III";
            this.checkcicloIII.UseVisualStyleBackColor = true;
            // 
            // butGenerarReporte
            // 
            this.butGenerarReporte.Location = new System.Drawing.Point(178, 87);
            this.butGenerarReporte.Name = "butGenerarReporte";
            this.butGenerarReporte.Size = new System.Drawing.Size(111, 23);
            this.butGenerarReporte.TabIndex = 9;
            this.butGenerarReporte.Text = "Generar Reporte";
            this.butGenerarReporte.UseVisualStyleBackColor = true;
            this.butGenerarReporte.Click += new System.EventHandler(this.butGenerarReporte_Click);
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(182, 54);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(159, 21);
            this.comboFiltro.TabIndex = 10;
            // 
            // numAno
            // 
            this.numAno.Location = new System.Drawing.Point(94, 19);
            this.numAno.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(63, 20);
            this.numAno.TabIndex = 11;
            // 
            // GenerarReporteDesignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(465, 128);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.butGenerarReporte);
            this.Controls.Add(this.checkcicloIII);
            this.Controls.Add(this.checkCicloIIIC);
            this.Controls.Add(this.checkCicloII);
            this.Controls.Add(this.checkCicloIIC);
            this.Controls.Add(this.checkCicloI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerarReporteDesignaciones";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarReporteDesignaciones";
            this.Load += new System.EventHandler(this.GenerarReporteDesignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkCicloI;
        private System.Windows.Forms.CheckBox checkCicloIIC;
        private System.Windows.Forms.CheckBox checkCicloII;
        private System.Windows.Forms.CheckBox checkCicloIIIC;
        private System.Windows.Forms.CheckBox checkcicloIII;
        private System.Windows.Forms.Button butGenerarReporte;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.NumericUpDown numAno;
    }
}