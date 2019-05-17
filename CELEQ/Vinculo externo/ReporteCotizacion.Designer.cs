namespace CELEQ
{
    partial class ReporteCotizacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vistaCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CotizacionDataSet = new CELEQ.CotizacionDataSet();
            this.vistaAnalisisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaAnalisisTableAdapter = new CELEQ.CotizacionDataSetTableAdapters.vistaAnalisisTableAdapter();
            this.vistaCotizacionTableAdapter = new CELEQ.CotizacionDataSetTableAdapters.vistaCotizacionTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAnalisisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaCotizacionBindingSource
            // 
            this.vistaCotizacionBindingSource.DataMember = "vistaCotizacion";
            this.vistaCotizacionBindingSource.DataSource = this.CotizacionDataSet;
            // 
            // CotizacionDataSet
            // 
            this.CotizacionDataSet.DataSetName = "CotizacionDataSet";
            this.CotizacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaAnalisisBindingSource
            // 
            this.vistaAnalisisBindingSource.DataMember = "vistaAnalisis";
            this.vistaAnalisisBindingSource.DataSource = this.CotizacionDataSet;
            // 
            // vistaAnalisisTableAdapter
            // 
            this.vistaAnalisisTableAdapter.ClearBeforeFill = true;
            // 
            // vistaCotizacionTableAdapter
            // 
            this.vistaCotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "CotizacionDataSet";
            reportDataSource3.Value = this.vistaCotizacionBindingSource;
            reportDataSource4.Name = "AnalisisDataSet";
            reportDataSource4.Value = this.vistaAnalisisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CELEQ.ReporteCotizacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteCotizacion";
            this.Load += new System.EventHandler(this.ReporteCotizacion_Load);
            this.Shown += new System.EventHandler(this.ReporteCotizacion_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.vistaCotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CotizacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAnalisisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CotizacionDataSetTableAdapters.vistaAnalisisTableAdapter vistaAnalisisTableAdapter;
        private CotizacionDataSetTableAdapters.vistaCotizacionTableAdapter vistaCotizacionTableAdapter;
        private System.Windows.Forms.BindingSource vistaAnalisisBindingSource;
        private CotizacionDataSet CotizacionDataSet;
        private System.Windows.Forms.BindingSource vistaCotizacionBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}