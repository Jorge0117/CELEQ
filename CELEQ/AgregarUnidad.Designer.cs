namespace CELEQ
{
    partial class AgregarUnidad
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textUnidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEncargado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUnidad
            // 
            this.textUnidad.BackColor = System.Drawing.SystemColors.Window;
            this.textUnidad.Location = new System.Drawing.Point(296, 31);
            this.textUnidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUnidad.MaxLength = 100;
            this.textUnidad.Name = "textUnidad";
            this.textUnidad.Size = new System.Drawing.Size(255, 22);
            this.textUnidad.TabIndex = 0;
            this.textUnidad.TextChanged += new System.EventHandler(this.nombreUnidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre de Unidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboEncargado
            // 
            this.comboEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEncargado.FormattingEnabled = true;
            this.comboEncargado.Location = new System.Drawing.Point(296, 86);
            this.comboEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboEncargado.Name = "comboEncargado";
            this.comboEncargado.Size = new System.Drawing.Size(255, 24);
            this.comboEncargado.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Encargado de la Unidad:";
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(395, 137);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 23;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(503, 137);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 22;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // AgregarUnidad
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(617, 180);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEncargado);
            this.Controls.Add(this.textUnidad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarUnidad";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUnidad";
            this.Load += new System.EventHandler(this.AgregarUnidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textUnidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEncargado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}