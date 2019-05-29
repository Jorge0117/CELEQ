namespace CELEQ
{
    partial class AgregarPermiso
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(373, 120);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 18;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(481, 120);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 17;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de permiso:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(155, 52);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(421, 22);
            this.textNombre.TabIndex = 20;
            // 
            // AgregarPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(594, 161);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarPermiso";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPermiso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
    }
}