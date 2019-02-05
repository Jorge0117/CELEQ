namespace CELEQ
{
    partial class ReporteDesignaciones
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.repDesignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repDesignaciones = new CELEQ.RepDesignaciones();
            this.repDesignacionesTableAdapter = new CELEQ.RepDesignacionesTableAdapters.RepDesignacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.repDesignacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDesignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.repDesignacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CELEQ.ReporteDesignaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // repDesignacionesBindingSource
            // 
            this.repDesignacionesBindingSource.DataMember = "RepDesignaciones";
            this.repDesignacionesBindingSource.DataSource = this.repDesignaciones;
            // 
            // repDesignaciones
            // 
            this.repDesignaciones.DataSetName = "RepDesignaciones";
            this.repDesignaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repDesignacionesTableAdapter
            // 
            this.repDesignacionesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDesignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReporteDesignaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteDesignaciones";
            this.Load += new System.EventHandler(this.ReporteDesignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repDesignacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDesignaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private RepDesignaciones repDesignaciones;
        private RepDesignacionesTableAdapters.RepDesignacionesTableAdapter repDesignacionesTableAdapter;
        private System.Windows.Forms.BindingSource repDesignacionesBindingSource;
    }
}