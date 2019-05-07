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
            this.label4 = new System.Windows.Forms.Label();
            this.comboVer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciclo:";
            // 
            // checkCicloI
            // 
            this.checkCicloI.AutoSize = true;
            this.checkCicloI.Location = new System.Drawing.Point(272, 26);
            this.checkCicloI.Margin = new System.Windows.Forms.Padding(4);
            this.checkCicloI.Name = "checkCicloI";
            this.checkCicloI.Size = new System.Drawing.Size(30, 20);
            this.checkCicloI.TabIndex = 1;
            this.checkCicloI.Text = "I";
            this.checkCicloI.UseVisualStyleBackColor = true;
            this.checkCicloI.CheckedChanged += new System.EventHandler(this.checkCicloI_CheckedChanged);
            // 
            // checkCicloIIC
            // 
            this.checkCicloIIC.AutoSize = true;
            this.checkCicloIIC.Location = new System.Drawing.Point(319, 26);
            this.checkCicloIIC.Margin = new System.Windows.Forms.Padding(4);
            this.checkCicloIIC.Name = "checkCicloIIC";
            this.checkCicloIIC.Size = new System.Drawing.Size(48, 20);
            this.checkCicloIIC.TabIndex = 2;
            this.checkCicloIIC.Text = "I I.C";
            this.checkCicloIIC.UseVisualStyleBackColor = true;
            this.checkCicloIIC.CheckedChanged += new System.EventHandler(this.checkCicloIIC_CheckedChanged);
            // 
            // checkCicloII
            // 
            this.checkCicloII.AutoSize = true;
            this.checkCicloII.Location = new System.Drawing.Point(379, 26);
            this.checkCicloII.Margin = new System.Windows.Forms.Padding(4);
            this.checkCicloII.Name = "checkCicloII";
            this.checkCicloII.Size = new System.Drawing.Size(33, 20);
            this.checkCicloII.TabIndex = 3;
            this.checkCicloII.Text = "II";
            this.checkCicloII.UseVisualStyleBackColor = true;
            this.checkCicloII.CheckedChanged += new System.EventHandler(this.checkCicloII_CheckedChanged);
            // 
            // checkCicloIIIC
            // 
            this.checkCicloIIIC.AutoSize = true;
            this.checkCicloIIIC.Location = new System.Drawing.Point(429, 26);
            this.checkCicloIIIC.Margin = new System.Windows.Forms.Padding(4);
            this.checkCicloIIIC.Name = "checkCicloIIIC";
            this.checkCicloIIIC.Size = new System.Drawing.Size(51, 20);
            this.checkCicloIIIC.TabIndex = 4;
            this.checkCicloIIIC.Text = "II I.C";
            this.checkCicloIIIC.UseVisualStyleBackColor = true;
            this.checkCicloIIIC.CheckedChanged += new System.EventHandler(this.checkCicloIIIC_CheckedChanged);
            // 
            // checkcicloIII
            // 
            this.checkcicloIII.AutoSize = true;
            this.checkcicloIII.Location = new System.Drawing.Point(493, 26);
            this.checkcicloIII.Margin = new System.Windows.Forms.Padding(4);
            this.checkcicloIII.Name = "checkcicloIII";
            this.checkcicloIII.Size = new System.Drawing.Size(36, 20);
            this.checkcicloIII.TabIndex = 5;
            this.checkcicloIII.Text = "III";
            this.checkcicloIII.UseVisualStyleBackColor = true;
            this.checkcicloIII.CheckedChanged += new System.EventHandler(this.checkcicloIII_CheckedChanged);
            // 
            // butGenerarReporte
            // 
            this.butGenerarReporte.Location = new System.Drawing.Point(381, 114);
            this.butGenerarReporte.Margin = new System.Windows.Forms.Padding(4);
            this.butGenerarReporte.Name = "butGenerarReporte";
            this.butGenerarReporte.Size = new System.Drawing.Size(148, 28);
            this.butGenerarReporte.TabIndex = 8;
            this.butGenerarReporte.Text = "Generar Reporte";
            this.butGenerarReporte.UseVisualStyleBackColor = true;
            this.butGenerarReporte.Click += new System.EventHandler(this.butGenerarReporte_Click);
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(243, 66);
            this.comboFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(211, 24);
            this.comboFiltro.TabIndex = 6;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged);
            // 
            // numAno
            // 
            this.numAno.Location = new System.Drawing.Point(125, 23);
            this.numAno.Margin = new System.Windows.Forms.Padding(4);
            this.numAno.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(84, 22);
            this.numAno.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ver:";
            // 
            // comboVer
            // 
            this.comboVer.FormattingEnabled = true;
            this.comboVer.Location = new System.Drawing.Point(133, 117);
            this.comboVer.Margin = new System.Windows.Forms.Padding(4);
            this.comboVer.Name = "comboVer";
            this.comboVer.Size = new System.Drawing.Size(239, 24);
            this.comboVer.TabIndex = 7;
            // 
            // GenerarReporteDesignaciones
            // 
            this.AcceptButton = this.butGenerarReporte;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(620, 158);
            this.Controls.Add(this.comboVer);
            this.Controls.Add(this.label4);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboVer;
    }
}