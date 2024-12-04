namespace DataTransformation.Forms
{
    partial class MainMenu
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
            menuStrip1 = new MenuStrip();
            leerCSVToolStripMenuItem = new ToolStripMenuItem();
            itemClients = new ToolStripMenuItem();
            itemProducts = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { leerCSVToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // leerCSVToolStripMenuItem
            // 
            leerCSVToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itemClients, itemProducts });
            leerCSVToolStripMenuItem.Name = "leerCSVToolStripMenuItem";
            leerCSVToolStripMenuItem.Size = new Size(65, 20);
            leerCSVToolStripMenuItem.Text = "Leer CSV";
            // 
            // itemClients
            // 
            itemClients.Name = "itemClients";
            itemClients.Size = new Size(212, 22);
            itemClients.Text = "Información de Clientes";
            itemClients.Click += itemClients_Click;
            // 
            // itemProducts
            // 
            itemProducts.Name = "itemProducts";
            itemProducts.Size = new Size(212, 22);
            itemProducts.Text = "Información de Productos";
            itemProducts.Click += itemProducts_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem leerCSVToolStripMenuItem;
        private ToolStripMenuItem itemClients;
        private ToolStripMenuItem itemProducts;
    }
}