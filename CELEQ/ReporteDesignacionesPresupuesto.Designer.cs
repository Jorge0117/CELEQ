﻿namespace CELEQ
{
    partial class ReporteDesignacionesPresupuesto
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
            this.RepDesignacionesDataSet = new CELEQ.RepDesignacionesDataSet();
            this.RepDesignacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepDesignacionesTableAdapter = new CELEQ.RepDesignacionesDataSetTableAdapters.RepDesignacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RepDesignacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CELEQ.ReporteDesignacionesPresupuesto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // RepDesignacionesDataSet
            // 
            this.RepDesignacionesDataSet.DataSetName = "RepDesignacionesDataSet";
            this.RepDesignacionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RepDesignacionesBindingSource
            // 
            this.RepDesignacionesBindingSource.DataMember = "RepDesignaciones";
            this.RepDesignacionesBindingSource.DataSource = this.RepDesignacionesDataSet;
            // 
            // RepDesignacionesTableAdapter
            // 
            this.RepDesignacionesTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDesignacionesPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteDesignacionesPresupuesto";
            this.Text = "ReporteDesignacionesPresupuesto";
            this.Load += new System.EventHandler(this.ReporteDesignacionesPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepDesignacionesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RepDesignacionesBindingSource;
        private RepDesignacionesDataSet RepDesignacionesDataSet;
        private RepDesignacionesDataSetTableAdapters.RepDesignacionesTableAdapter RepDesignacionesTableAdapter;
    }
}