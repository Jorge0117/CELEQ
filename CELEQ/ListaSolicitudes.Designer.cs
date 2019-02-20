namespace CELEQ
{
    partial class ListaSolicitudes
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
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.labelSoliciudes = new System.Windows.Forms.Label();
            this.butDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(29, 71);
            this.dgvSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.RowHeadersVisible = false;
            this.dgvSolicitudes.Size = new System.Drawing.Size(947, 410);
            this.dgvSolicitudes.TabIndex = 2;
            // 
            // labelSoliciudes
            // 
            this.labelSoliciudes.AutoSize = true;
            this.labelSoliciudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoliciudes.Location = new System.Drawing.Point(24, 30);
            this.labelSoliciudes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSoliciudes.Name = "labelSoliciudes";
            this.labelSoliciudes.Size = new System.Drawing.Size(86, 20);
            this.labelSoliciudes.TabIndex = 3;
            this.labelSoliciudes.Text = "Solicitudes";
            // 
            // butDetalles
            // 
            this.butDetalles.Location = new System.Drawing.Point(984, 71);
            this.butDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.butDetalles.Name = "butDetalles";
            this.butDetalles.Size = new System.Drawing.Size(167, 38);
            this.butDetalles.TabIndex = 4;
            this.butDetalles.Text = "Detalles";
            this.butDetalles.UseVisualStyleBackColor = true;
            this.butDetalles.Click += new System.EventHandler(this.butDetalles_Click);
            // 
            // ListaSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1174, 511);
            this.Controls.Add(this.butDetalles);
            this.Controls.Add(this.labelSoliciudes);
            this.Controls.Add(this.dgvSolicitudes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaSolicitudes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaSolicitudes";
            this.Load += new System.EventHandler(this.ListaSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label labelSoliciudes;
        private System.Windows.Forms.Button butDetalles;
    }
}