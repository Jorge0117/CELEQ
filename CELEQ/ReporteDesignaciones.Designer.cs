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
            this.RepDesignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepDesignacionesDataSet = new CELEQ.RepDesignacionesDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RepDesignacionesTableAdapter = new CELEQ.RepDesignacionesDataSetTableAdapters.RepDesignacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // RepDesignacionesBindingSource
            // 
            this.RepDesignacionesBindingSource.DataMember = "RepDesignaciones";
            this.RepDesignacionesBindingSource.DataSource = this.RepDesignacionesDataSet;
            // 
            // RepDesignacionesDataSet
            // 
            this.RepDesignacionesDataSet.DataSetName = "RepDesignacionesDataSet";
            this.RepDesignacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CELEQ.ReporteDesignaciones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepDesignacionesTableAdapter
            // 
            this.RepDesignacionesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDesignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDesignaciones";
            this.Text = "ReporteDesignaciones";
            this.Load += new System.EventHandler(this.ReporteDesignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepDesignacionesBindingSource;
        private RepDesignacionesDataSet RepDesignacionesDataSet;
        private RepDesignacionesDataSetTableAdapters.RepDesignacionesTableAdapter RepDesignacionesTableAdapter;
    }
}