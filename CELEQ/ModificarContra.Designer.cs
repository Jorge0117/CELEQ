namespace CELEQ
{
    partial class ModificarContra
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
            this.nuevaContra = new System.Windows.Forms.TextBox();
            this.confirmarContra = new System.Windows.Forms.TextBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña:";
            this.label1.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmar Contraseña:";
            this.label2.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // nuevaContra
            // 
            this.nuevaContra.Location = new System.Drawing.Point(196, 30);
            this.nuevaContra.Margin = new System.Windows.Forms.Padding(4);
            this.nuevaContra.Name = "nuevaContra";
            this.nuevaContra.PasswordChar = '*';
            this.nuevaContra.Size = new System.Drawing.Size(237, 22);
            this.nuevaContra.TabIndex = 2;
            this.nuevaContra.TextChanged += new System.EventHandler(this.nuevaContra_TextChanged);
            // 
            // confirmarContra
            // 
            this.confirmarContra.Location = new System.Drawing.Point(196, 70);
            this.confirmarContra.Margin = new System.Windows.Forms.Padding(4);
            this.confirmarContra.Name = "confirmarContra";
            this.confirmarContra.PasswordChar = '*';
            this.confirmarContra.Size = new System.Drawing.Size(237, 22);
            this.confirmarContra.TabIndex = 3;
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(254, 101);
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
            this.butCancelar.Location = new System.Drawing.Point(362, 101);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 17;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // ModificarContra
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(475, 142);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.confirmarContra);
            this.Controls.Add(this.nuevaContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarContra";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nuevaContra;
        private System.Windows.Forms.TextBox confirmarContra;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}