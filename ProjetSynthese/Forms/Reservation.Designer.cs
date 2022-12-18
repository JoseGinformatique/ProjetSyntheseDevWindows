namespace ProjetSynthese.Forms
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.comboBoxRes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelErr = new System.Windows.Forms.Label();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxRes
            // 
            this.comboBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRes.FormattingEnabled = true;
            this.comboBoxRes.Items.AddRange(new object[] {
            "Chambre: Suite",
            "Chambre: Régulière",
            "Salle: Piscine",
            "Salle: Cinema",
            "Salle: Salle de reunions"});
            this.comboBoxRes.Location = new System.Drawing.Point(175, 117);
            this.comboBoxRes.Name = "comboBoxRes";
            this.comboBoxRes.Size = new System.Drawing.Size(265, 28);
            this.comboBoxRes.TabIndex = 0;
            this.comboBoxRes.Text = "Cliquez pour derrouler les options";
            this.comboBoxRes.SelectedIndexChanged += new System.EventHandler(this.comboBoxRes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choix de réservation";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmer la séléction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelErr
            // 
            this.labelErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErr.AutoSize = true;
            this.labelErr.Location = new System.Drawing.Point(172, 253);
            this.labelErr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(0, 13);
            this.labelErr.TabIndex = 16;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnuler.Location = new System.Drawing.Point(175, 253);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(265, 39);
            this.buttonAnnuler.TabIndex = 2;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 370);
            this.Controls.Add(this.labelErr);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reservation";
            this.Text = "Réservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.Button buttonAnnuler;
    }
}