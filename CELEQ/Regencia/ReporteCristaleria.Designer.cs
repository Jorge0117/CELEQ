﻿namespace CELEQ
{
    partial class ReporteCristaleria
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
            this.CristaleriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioCristaleria = new CELEQ.InventarioCristaleria();
            this.CristaleriaTableAdapter = new CELEQ.InventarioCristaleriaTableAdapters.CristaleriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CristaleriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioCristaleria)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CristaleriaDataSet";
            reportDataSource1.Value = this.CristaleriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CELEQ.ReporteCristaleria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.ReporteCristaleria_Load);
            // 
            // CristaleriaBindingSource
            // 
            this.CristaleriaBindingSource.DataMember = "Cristaleria";
            this.CristaleriaBindingSource.DataSource = this.InventarioCristaleria;
            // 
            // InventarioCristaleria
            // 
            this.InventarioCristaleria.DataSetName = "InventarioCristaleria";
            this.InventarioCristaleria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CristaleriaTableAdapter
            // 
            this.CristaleriaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCristaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCristaleria";
            this.Text = "ReporteCristaleria";
            this.Load += new System.EventHandler(this.ReporteCristaleria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CristaleriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioCristaleria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CristaleriaBindingSource;
        private InventarioCristaleria InventarioCristaleria;
        private InventarioCristaleriaTableAdapters.CristaleriaTableAdapter CristaleriaTableAdapter;
    }
}