﻿namespace YONKER
{
    partial class formMenu
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
            this.rentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDePiezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDePizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piezasEntrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDePiezasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentasToolStripMenuItem,
            this.reporteDePiezasToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(379, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rentasToolStripMenuItem
            // 
            this.rentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.inventarioGeneralToolStripMenuItem});
            this.rentasToolStripMenuItem.Name = "rentasToolStripMenuItem";
            this.rentasToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.rentasToolStripMenuItem.Text = "Rentas";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.productosToolStripMenuItem.Text = "Descripcion de pieza";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.clientesToolStripMenuItem.Text = "Marca Vehiculo";
            // 
            // inventarioGeneralToolStripMenuItem
            // 
            this.inventarioGeneralToolStripMenuItem.Name = "inventarioGeneralToolStripMenuItem";
            this.inventarioGeneralToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.inventarioGeneralToolStripMenuItem.Text = "Inventario General";
            // 
            // reporteDePiezasToolStripMenuItem
            // 
            this.reporteDePiezasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDePizasToolStripMenuItem,
            this.piezasEntrantesToolStripMenuItem,
            this.pedidoDePiezasToolStripMenuItem});
            this.reporteDePiezasToolStripMenuItem.Name = "reporteDePiezasToolStripMenuItem";
            this.reporteDePiezasToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.reporteDePiezasToolStripMenuItem.Text = "Reporte ";
            // 
            // reporteDePizasToolStripMenuItem
            // 
            this.reporteDePizasToolStripMenuItem.Name = "reporteDePizasToolStripMenuItem";
            this.reporteDePizasToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.reporteDePizasToolStripMenuItem.Text = "Reporte de Pizas";
            // 
            // piezasEntrantesToolStripMenuItem
            // 
            this.piezasEntrantesToolStripMenuItem.Name = "piezasEntrantesToolStripMenuItem";
            this.piezasEntrantesToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.piezasEntrantesToolStripMenuItem.Text = "Piezas Entrantes ";
            // 
            // pedidoDePiezasToolStripMenuItem
            // 
            this.pedidoDePiezasToolStripMenuItem.Name = "pedidoDePiezasToolStripMenuItem";
            this.pedidoDePiezasToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.pedidoDePiezasToolStripMenuItem.Text = "Pedido de Piezas";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formMenu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDePiezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDePizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piezasEntrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDePiezasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}