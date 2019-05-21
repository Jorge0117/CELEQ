namespace CELEQ
{
    partial class ReporteReactivos
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
            this.InventarioReactivos = new CELEQ.InventarioReactivos();
            this.ReactivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReactivoTableAdapter = new CELEQ.InventarioReactivosTableAdapters.ReactivoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioReactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReactivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReactivosDataSet";
            reportDataSource1.Value = this.ReactivoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CELEQ.ReporteReactivos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // InventarioReactivos
            // 
            this.InventarioReactivos.DataSetName = "InventarioReactivos";
            this.InventarioReactivos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReactivoBindingSource
            // 
            this.ReactivoBindingSource.DataMember = "Reactivo";
            this.ReactivoBindingSource.DataSource = this.InventarioReactivos;
            // 
            // ReactivoTableAdapter
            // 
            this.ReactivoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteReactivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteReactivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteReactivos";
            this.Load += new System.EventHandler(this.ReporteReactivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventarioReactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReactivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReactivoBindingSource;
        private InventarioReactivos InventarioReactivos;
        private InventarioReactivosTableAdapters.ReactivoTableAdapter ReactivoTableAdapter;
    }
}