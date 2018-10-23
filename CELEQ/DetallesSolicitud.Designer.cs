namespace CELEQ
{
    partial class DetallesSolicitud
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textObserv = new System.Windows.Forms.TextBox();
            this.textMotDenCris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textMotDenReac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCristaleria = new System.Windows.Forms.DataGridView();
            this.buDenCris = new System.Windows.Forms.Button();
            this.butDenReac = new System.Windows.Forms.Button();
            this.dgvReactivos = new System.Windows.Forms.DataGridView();
            this.butAprobarSolicutud = new System.Windows.Forms.Button();
            this.butDenegarSolicitud = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCristaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textMotDenCris);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textMotDenReac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvCristaleria);
            this.groupBox1.Controls.Add(this.buDenCris);
            this.groupBox1.Controls.Add(this.butDenReac);
            this.groupBox1.Controls.Add(this.dgvReactivos);
            this.groupBox1.Location = new System.Drawing.Point(50, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 668);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reactivos y cristalería solicitados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textObserv);
            this.groupBox2.Location = new System.Drawing.Point(58, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 117);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observaciones";
            // 
            // textObserv
            // 
            this.textObserv.Location = new System.Drawing.Point(16, 19);
            this.textObserv.Multiline = true;
            this.textObserv.Name = "textObserv";
            this.textObserv.ReadOnly = true;
            this.textObserv.Size = new System.Drawing.Size(878, 92);
            this.textObserv.TabIndex = 0;
            // 
            // textMotDenCris
            // 
            this.textMotDenCris.Location = new System.Drawing.Point(1012, 346);
            this.textMotDenCris.Multiline = true;
            this.textMotDenCris.Name = "textMotDenCris";
            this.textMotDenCris.Size = new System.Drawing.Size(194, 149);
            this.textMotDenCris.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1009, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Motivo:";
            // 
            // textMotDenReac
            // 
            this.textMotDenReac.Location = new System.Drawing.Point(1012, 121);
            this.textMotDenReac.Multiline = true;
            this.textMotDenReac.Name = "textMotDenReac";
            this.textMotDenReac.Size = new System.Drawing.Size(194, 137);
            this.textMotDenReac.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1009, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Motivo:";
            // 
            // dgvCristaleria
            // 
            this.dgvCristaleria.AllowUserToAddRows = false;
            this.dgvCristaleria.AllowUserToDeleteRows = false;
            this.dgvCristaleria.AllowUserToResizeColumns = false;
            this.dgvCristaleria.AllowUserToResizeRows = false;
            this.dgvCristaleria.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCristaleria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCristaleria.Location = new System.Drawing.Point(58, 297);
            this.dgvCristaleria.Name = "dgvCristaleria";
            this.dgvCristaleria.ReadOnly = true;
            this.dgvCristaleria.RowHeadersVisible = false;
            this.dgvCristaleria.Size = new System.Drawing.Size(912, 198);
            this.dgvCristaleria.TabIndex = 4;
            // 
            // buDenCris
            // 
            this.buDenCris.Location = new System.Drawing.Point(1009, 297);
            this.buDenCris.Name = "buDenCris";
            this.buDenCris.Size = new System.Drawing.Size(197, 43);
            this.buDenCris.TabIndex = 3;
            this.buDenCris.Text = "Denegar Cristalería";
            this.buDenCris.UseVisualStyleBackColor = true;
            this.buDenCris.Click += new System.EventHandler(this.buDenCris_Click);
            // 
            // butDenReac
            // 
            this.butDenReac.Location = new System.Drawing.Point(1009, 54);
            this.butDenReac.Name = "butDenReac";
            this.butDenReac.Size = new System.Drawing.Size(197, 43);
            this.butDenReac.TabIndex = 1;
            this.butDenReac.Text = "Denegar Reactivo";
            this.butDenReac.UseVisualStyleBackColor = true;
            this.butDenReac.Click += new System.EventHandler(this.butDenReac_Click);
            // 
            // dgvReactivos
            // 
            this.dgvReactivos.AllowUserToAddRows = false;
            this.dgvReactivos.AllowUserToDeleteRows = false;
            this.dgvReactivos.AllowUserToResizeColumns = false;
            this.dgvReactivos.AllowUserToResizeRows = false;
            this.dgvReactivos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReactivos.Location = new System.Drawing.Point(58, 50);
            this.dgvReactivos.MultiSelect = false;
            this.dgvReactivos.Name = "dgvReactivos";
            this.dgvReactivos.ReadOnly = true;
            this.dgvReactivos.RowHeadersVisible = false;
            this.dgvReactivos.Size = new System.Drawing.Size(912, 208);
            this.dgvReactivos.TabIndex = 0;
            // 
            // butAprobarSolicutud
            // 
            this.butAprobarSolicutud.Location = new System.Drawing.Point(1107, 686);
            this.butAprobarSolicutud.Name = "butAprobarSolicutud";
            this.butAprobarSolicutud.Size = new System.Drawing.Size(197, 43);
            this.butAprobarSolicutud.TabIndex = 7;
            this.butAprobarSolicutud.Text = "Aprobar Solicitud";
            this.butAprobarSolicutud.UseVisualStyleBackColor = true;
            this.butAprobarSolicutud.Click += new System.EventHandler(this.butAprobarSolicutud_Click);
            // 
            // butDenegarSolicitud
            // 
            this.butDenegarSolicitud.Location = new System.Drawing.Point(904, 686);
            this.butDenegarSolicitud.Name = "butDenegarSolicitud";
            this.butDenegarSolicitud.Size = new System.Drawing.Size(197, 43);
            this.butDenegarSolicitud.TabIndex = 8;
            this.butDenegarSolicitud.Text = "Denegar Solicitud";
            this.butDenegarSolicitud.UseVisualStyleBackColor = true;
            this.butDenegarSolicitud.Click += new System.EventHandler(this.butDenegarSolicitud_Click);
            // 
            // DetallesSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1316, 753);
            this.Controls.Add(this.butDenegarSolicitud);
            this.Controls.Add(this.butAprobarSolicutud);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetallesSolicitud";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetallesSolicitud";
            this.Load += new System.EventHandler(this.DetallesSolicitud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCristaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReactivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvCristaleria;
        private System.Windows.Forms.Button buDenCris;
        private System.Windows.Forms.Button butDenReac;
        public System.Windows.Forms.DataGridView dgvReactivos;
        private System.Windows.Forms.Button butAprobarSolicutud;
        private System.Windows.Forms.Button butDenegarSolicitud;
        private System.Windows.Forms.TextBox textMotDenCris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMotDenReac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textObserv;
    }
}