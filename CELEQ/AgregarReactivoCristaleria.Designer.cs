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
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.textEstante = new System.Windows.Forms.TextBox();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(416, 276);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(75, 23);
            this.butAceptar.TabIndex = 16;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(497, 276);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(75, 23);
            this.butCancelar.TabIndex = 15;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(36, 39);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelPureza
            // 
            this.labelPureza.AutoSize = true;
            this.labelPureza.Location = new System.Drawing.Point(36, 119);
            this.labelPureza.Name = "labelPureza";
            this.labelPureza.Size = new System.Drawing.Size(43, 13);
            this.labelPureza.TabIndex = 18;
            this.labelPureza.Text = "Pureza:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(36, 162);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(52, 13);
            this.labelCantidad.TabIndex = 19;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // labelEstante
            // 
            this.labelEstante.AutoSize = true;
            this.labelEstante.Location = new System.Drawing.Point(36, 206);
            this.labelEstante.Name = "labelEstante";
            this.labelEstante.Size = new System.Drawing.Size(46, 13);
            this.labelEstante.TabIndex = 20;
            this.labelEstante.Text = "Estante:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(110, 36);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(247, 20);
            this.textNombre.TabIndex = 21;
            // 
            // textPureza
            // 
            this.textPureza.Location = new System.Drawing.Point(110, 116);
            this.textPureza.Name = "textPureza";
            this.textPureza.Size = new System.Drawing.Size(247, 20);
            this.textPureza.TabIndex = 22;
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(110, 159);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(247, 20);
            this.textCantidad.TabIndex = 23;
            // 
            // textEstante
            // 
            this.textEstante.Location = new System.Drawing.Point(110, 203);
            this.textEstante.Name = "textEstante";
            this.textEstante.Size = new System.Drawing.Size(247, 20);
            this.textEstante.TabIndex = 24;
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(110, 74);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(247, 20);
            this.textEstado.TabIndex = 26;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(36, 77);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 25;
            this.labelEstado.Text = "Estado:";
            // 
            // AgregarReactivoCristaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.textEstante);
            this.Controls.Add(this.textCantidad);
            this.Controls.Add(this.textPureza);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelEstante);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelPureza);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarReactivoCristaleria";
            this.ShowInTaskbar = false;
            this.Text = "AgregarReactivoCristaleria";
            this.Load += new System.EventHandler(this.AgregarReactivoCristaleria_Load);
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
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.TextBox textEstante;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label labelEstado;
    }
}