namespace CELEQ
{
    partial class AgregarReactivoCristaleria
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
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPureza = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelEstante = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textPureza = new System.Windows.Forms.TextBox();
            this.textEstante = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(555, 340);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 16;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(663, 340);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 15;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(179, 39);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(60, 16);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelPureza
            // 
            this.labelPureza.AutoSize = true;
            this.labelPureza.Location = new System.Drawing.Point(179, 160);
            this.labelPureza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPureza.Name = "labelPureza";
            this.labelPureza.Size = new System.Drawing.Size(53, 16);
            this.labelPureza.TabIndex = 18;
            this.labelPureza.Text = "Pureza:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(179, 220);
            this.labelCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(65, 16);
            this.labelCantidad.TabIndex = 19;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelEstante
            // 
            this.labelEstante.AutoSize = true;
            this.labelEstante.Location = new System.Drawing.Point(179, 281);
            this.labelEstante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstante.Name = "labelEstante";
            this.labelEstante.Size = new System.Drawing.Size(56, 16);
            this.labelEstante.TabIndex = 20;
            this.labelEstante.Text = "Estante:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(272, 36);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(328, 22);
            this.textNombre.TabIndex = 21;
            // 
            // textPureza
            // 
            this.textPureza.Location = new System.Drawing.Point(272, 156);
            this.textPureza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPureza.Name = "textPureza";
            this.textPureza.Size = new System.Drawing.Size(328, 22);
            this.textPureza.TabIndex = 22;
            // 
            // textEstante
            // 
            this.textEstante.Location = new System.Drawing.Point(272, 277);
            this.textEstante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEstante.MaxLength = 10;
            this.textEstante.Name = "textEstante";
            this.textEstante.Size = new System.Drawing.Size(328, 22);
            this.textEstante.TabIndex = 24;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(272, 96);
            this.textEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(328, 22);
            this.textEstado.TabIndex = 26;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(179, 100);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(54, 16);
            this.labelEstado.TabIndex = 25;
            this.labelEstado.Text = "Estado:";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(272, 218);
            this.textCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCantidad.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(329, 22);
            this.textCantidad.TabIndex = 27;
            // 
            // AgregarReactivoCristaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(779, 383);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textEstante);
            this.Controls.Add(this.textPureza);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelEstante);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelPureza);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarReactivoCristaleria";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarReactivoCristaleria";
            ((System.ComponentModel.ISupportInitialize)(this.textCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPureza;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelEstante;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textPureza;
        private System.Windows.Forms.TextBox textEstante;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.NumericUpDown textCantidad;
    }
}