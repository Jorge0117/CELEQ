namespace CELEQ
{
    partial class AgregarPresupuesto
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
            this.codigoText = new System.Windows.Forms.TextBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // codigoText
            // 
            this.codigoText.Location = new System.Drawing.Point(231, 39);
            this.codigoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigoText.MaxLength = 12;
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(211, 22);
            this.codigoText.TabIndex = 2;
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(231, 79);
            this.nombreText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreText.MaxLength = 255;
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(211, 22);
            this.nombreText.TabIndex = 3;
            // 
            // butAceptar
            // 
            this.butAceptar.Location = new System.Drawing.Point(315, 129);
            this.butAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(100, 28);
            this.butAceptar.TabIndex = 18;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Location = new System.Drawing.Point(423, 129);
            this.butCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(100, 28);
            this.butCancelar.TabIndex = 17;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // AgregarPresupuesto
            // 
            this.AcceptButton = this.butAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(539, 172);
            this.Controls.Add(this.butAceptar);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarPresupuesto";
            this.Load += new System.EventHandler(this.AgregarPresupuesto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}