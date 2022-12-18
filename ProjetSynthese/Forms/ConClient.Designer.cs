namespace ProjetSynthese.Forms
{
    partial class ConClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConClient));
            this.Connection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero_client = new System.Windows.Forms.TextBox();
            this.MotDePasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nouveau_client = new System.Windows.Forms.Label();
            this.labelErrNum = new System.Windows.Forms.Label();
            this.labelErrMdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connection
            // 
            this.Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection.Location = new System.Drawing.Point(87, 290);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(225, 32);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Se connecter";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection Client";
            // 
            // Numero_client
            // 
            this.Numero_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_client.Location = new System.Drawing.Point(87, 128);
            this.Numero_client.Name = "Numero_client";
            this.Numero_client.Size = new System.Drawing.Size(225, 29);
            this.Numero_client.TabIndex = 2;
            // 
            // MotDePasse
            // 
            this.MotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotDePasse.Location = new System.Drawing.Point(87, 218);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(225, 29);
            this.MotDePasse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro de client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mot de passe";
            // 
            // Nouveau_client
            // 
            this.Nouveau_client.AutoSize = true;
            this.Nouveau_client.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nouveau_client.Location = new System.Drawing.Point(132, 325);
            this.Nouveau_client.Name = "Nouveau_client";
            this.Nouveau_client.Size = new System.Drawing.Size(128, 18);
            this.Nouveau_client.TabIndex = 1;
            this.Nouveau_client.Text = "Nouveau client";
            this.Nouveau_client.Click += new System.EventHandler(this.Nouveau_client_Click);
            // 
            // labelErrNum
            // 
            this.labelErrNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrNum.AutoSize = true;
            this.labelErrNum.Location = new System.Drawing.Point(91, 166);
            this.labelErrNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrNum.Name = "labelErrNum";
            this.labelErrNum.Size = new System.Drawing.Size(0, 13);
            this.labelErrNum.TabIndex = 15;
            // 
            // labelErrMdp
            // 
            this.labelErrMdp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrMdp.AutoSize = true;
            this.labelErrMdp.Location = new System.Drawing.Point(91, 262);
            this.labelErrMdp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrMdp.Name = "labelErrMdp";
            this.labelErrMdp.Size = new System.Drawing.Size(0, 13);
            this.labelErrMdp.TabIndex = 15;
            // 
            // ConClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 450);
            this.Controls.Add(this.labelErrMdp);
            this.Controls.Add(this.labelErrNum);
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.Numero_client);
            this.Controls.Add(this.Nouveau_client);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConClient";
            this.Text = "Connection Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero_client;
        private System.Windows.Forms.TextBox MotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nouveau_client;
        private System.Windows.Forms.Label labelErrNum;
        private System.Windows.Forms.Label labelErrMdp;
    }
}