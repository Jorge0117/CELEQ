﻿namespace CELEQ
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivosYCristaleríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reactivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cristaleríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeSolicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBienv = new System.Windows.Forms.Label();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudesToolStripMenuItem1,
            this.verInventarioToolStripMenuItem,
            this.verSolicitudesToolStripMenuItem});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.solicitudesToolStripMenuItem.Text = "Regencia";
            // 
            // solicitudesToolStripMenuItem1
            // 
            this.solicitudesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reactivosYCristaleríaToolStripMenuItem});
            this.solicitudesToolStripMenuItem1.Name = "solicitudesToolStripMenuItem1";
            this.solicitudesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.solicitudesToolStripMenuItem1.Text = "Realizar Solicitud";
            // 
            // reactivosYCristaleríaToolStripMenuItem
            // 
            this.reactivosYCristaleríaToolStripMenuItem.Name = "reactivosYCristaleríaToolStripMenuItem";
            this.reactivosYCristaleríaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.reactivosYCristaleríaToolStripMenuItem.Text = "Reactivos y cristalería";
            this.reactivosYCristaleríaToolStripMenuItem.Click += new System.EventHandler(this.reactivosYCristaleríaToolStripMenuItem_Click);
            // 
            // verInventarioToolStripMenuItem
            // 
            this.verInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reactivosToolStripMenuItem,
            this.cristaleríaToolStripMenuItem});
            this.verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            this.verInventarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verInventarioToolStripMenuItem.Text = "Ver inventario";
            // 
            // reactivosToolStripMenuItem
            // 
            this.reactivosToolStripMenuItem.Name = "reactivosToolStripMenuItem";
            this.reactivosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.reactivosToolStripMenuItem.Text = "Reactivos";
            this.reactivosToolStripMenuItem.Click += new System.EventHandler(this.reactivosToolStripMenuItem_Click);
            // 
            // cristaleríaToolStripMenuItem
            // 
            this.cristaleríaToolStripMenuItem.Name = "cristaleríaToolStripMenuItem";
            this.cristaleríaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cristaleríaToolStripMenuItem.Text = "Cristalería";
            this.cristaleríaToolStripMenuItem.Click += new System.EventHandler(this.cristaleríaToolStripMenuItem_Click);
            // 
            // verSolicitudesToolStripMenuItem
            // 
            this.verSolicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudesPendientesToolStripMenuItem,
            this.historialDeSolicitudesToolStripMenuItem});
            this.verSolicitudesToolStripMenuItem.Name = "verSolicitudesToolStripMenuItem";
            this.verSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verSolicitudesToolStripMenuItem.Text = "Ver Solicitudes";
            // 
            // solicitudesPendientesToolStripMenuItem
            // 
            this.solicitudesPendientesToolStripMenuItem.Name = "solicitudesPendientesToolStripMenuItem";
            this.solicitudesPendientesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.solicitudesPendientesToolStripMenuItem.Text = "Solicitudes pendientes";
            this.solicitudesPendientesToolStripMenuItem.Click += new System.EventHandler(this.solicitudesPendientesToolStripMenuItem_Click);
            // 
            // historialDeSolicitudesToolStripMenuItem
            // 
            this.historialDeSolicitudesToolStripMenuItem.Name = "historialDeSolicitudesToolStripMenuItem";
            this.historialDeSolicitudesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.historialDeSolicitudesToolStripMenuItem.Text = "Historial de solicitudes";
            // 
            // labelBienv
            // 
            this.labelBienv.AutoSize = true;
            this.labelBienv.Location = new System.Drawing.Point(12, 33);
            this.labelBienv.Name = "labelBienv";
            this.labelBienv.Size = new System.Drawing.Size(63, 13);
            this.labelBienv.TabIndex = 1;
            this.labelBienv.Text = "Bienvenido ";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verUsuariosToolStripMenuItem,
            this.agregarUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariosToolStripMenuItem_Click);
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            this.agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            this.agregarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarUsuariosToolStripMenuItem.Text = "Agregar Usuarios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBienv);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reactivosYCristaleríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reactivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cristaleríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSolicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeSolicitudesToolStripMenuItem;
        private System.Windows.Forms.Label labelBienv;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariosToolStripMenuItem;
    }
}

