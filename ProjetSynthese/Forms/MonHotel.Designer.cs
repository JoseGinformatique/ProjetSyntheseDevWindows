namespace ProjetSynthese
{
    partial class MonHotel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHotel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TarifsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ongletsOuvertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joseLuisGutierrez2146130ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TarifsToolStripMenuItem,
            this.ClientToolStripMenuItem,
            this.AdminToolStripMenuItem,
            this.ongletsOuvertsToolStripMenuItem,
            this.joseLuisGutierrez2146130ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ongletsOuvertsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(895, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TarifsToolStripMenuItem
            // 
            this.TarifsToolStripMenuItem.Name = "TarifsToolStripMenuItem";
            this.TarifsToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.TarifsToolStripMenuItem.Text = "Nos tarifs";
            this.TarifsToolStripMenuItem.Click += new System.EventHandler(this.TarifsToolStripMenuItem_Click);
            // 
            // ClientToolStripMenuItem
            // 
            this.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem";
            this.ClientToolStripMenuItem.Size = new System.Drawing.Size(135, 23);
            this.ClientToolStripMenuItem.Text = "Se connecter client";
            this.ClientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(194, 23);
            this.AdminToolStripMenuItem.Text = "Se connecter Administrateur";
            this.AdminToolStripMenuItem.Click += new System.EventHandler(this.AdminToolStripMenuItem_Click);
            // 
            // ongletsOuvertsToolStripMenuItem
            // 
            this.ongletsOuvertsToolStripMenuItem.Name = "ongletsOuvertsToolStripMenuItem";
            this.ongletsOuvertsToolStripMenuItem.Size = new System.Drawing.Size(119, 23);
            this.ongletsOuvertsToolStripMenuItem.Text = "Onglets ouverts";
            // 
            // joseLuisGutierrez2146130ToolStripMenuItem
            // 
            this.joseLuisGutierrez2146130ToolStripMenuItem.Name = "joseLuisGutierrez2146130ToolStripMenuItem";
            this.joseLuisGutierrez2146130ToolStripMenuItem.Size = new System.Drawing.Size(195, 23);
            this.joseLuisGutierrez2146130ToolStripMenuItem.Text = "Jose Luis Gutierrez 2146130";
            // 
            // MonHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 522);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MonHotel";
            this.Text = "Hotel-Jose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonHotel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TarifsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ongletsOuvertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joseLuisGutierrez2146130ToolStripMenuItem;
    }
}

