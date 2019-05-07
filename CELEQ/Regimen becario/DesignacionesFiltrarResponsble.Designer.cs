namespace CELEQ
{
    partial class DesignacionesFiltrarResponsble
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RepDesignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepDesignacionesResponsable = new CELEQ.RepDesignacionesResponsable();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RepDesignacionesTableAdapter = new CELEQ.RepDesignacionesResponsableTableAdapters.RepDesignacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // RepDesignacionesBindingSource
            // 
            this.RepDesignacionesBindingSource.DataMember = "RepDesignaciones";
            this.RepDesignacionesBindingSource.DataSource = this.RepDesignacionesResponsable;
            // 
            // RepDesignacionesResponsable
            // 
            this.RepDesignacionesResponsable.DataSetName = "RepDesignacionesResponsable";
            this.RepDesignacionesResponsable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetResponsable";
            reportDataSource1.Value = this.RepDesignacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CELEQ.ReporteDesignacionesResponsable.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1067, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepDesignacionesTableAdapter
            // 
            this.RepDesignacionesTableAdapter.ClearBeforeFill = true;
            // 
            // DesignacionesFiltrarResponsble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DesignacionesFiltrarResponsble";
            this.Text = "DesignacionesFiltrarResponsble";
            this.Load += new System.EventHandler(this.DesignacionesFiltrarResponsble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesResponsable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepDesignacionesBindingSource;
        private RepDesignacionesResponsable RepDesignacionesResponsable;
        private RepDesignacionesResponsableTableAdapters.RepDesignacionesTableAdapter RepDesignacionesTableAdapter;
    }
}