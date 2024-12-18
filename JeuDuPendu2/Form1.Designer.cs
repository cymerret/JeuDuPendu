
namespace JeuDuPendu2
{
    partial class Form1
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
            this.txtMot = new System.Windows.Forms.TextBox();
            this.grbMotMystere = new System.Windows.Forms.GroupBox();
            this.lblMot = new System.Windows.Forms.Label();
            this.grbLettres = new System.Windows.Forms.GroupBox();
            this.pctRejouer = new System.Windows.Forms.PictureBox();
            this.pctPendu = new System.Windows.Forms.PictureBox();
            this.grbMotMystere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRejouer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(6, 19);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(228, 31);
            this.txtMot.TabIndex = 0;
            this.txtMot.Visible = false;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMot_KeyPress);
            // 
            // grbMotMystere
            // 
            this.grbMotMystere.Controls.Add(this.lblMot);
            this.grbMotMystere.Controls.Add(this.txtMot);
            this.grbMotMystere.Location = new System.Drawing.Point(12, 12);
            this.grbMotMystere.Name = "grbMotMystere";
            this.grbMotMystere.Size = new System.Drawing.Size(241, 60);
            this.grbMotMystere.TabIndex = 0;
            this.grbMotMystere.TabStop = false;
            this.grbMotMystere.Text = "Mot à chercher";
            // 
            // lblMot
            // 
            this.lblMot.AutoSize = true;
            this.lblMot.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot.Location = new System.Drawing.Point(6, 19);
            this.lblMot.Name = "lblMot";
            this.lblMot.Size = new System.Drawing.Size(0, 31);
            this.lblMot.TabIndex = 3;
            // 
            // grbLettres
            // 
            this.grbLettres.Location = new System.Drawing.Point(12, 78);
            this.grbLettres.Name = "grbLettres";
            this.grbLettres.Size = new System.Drawing.Size(241, 117);
            this.grbLettres.TabIndex = 1;
            this.grbLettres.TabStop = false;
            this.grbLettres.Text = "Lettres à tester";
            // 
            // pctRejouer
            // 
            this.pctRejouer.Image = global::JeuDuPendu2.Properties.Resources.playagain;
            this.pctRejouer.Location = new System.Drawing.Point(98, 222);
            this.pctRejouer.Name = "pctRejouer";
            this.pctRejouer.Size = new System.Drawing.Size(46, 46);
            this.pctRejouer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctRejouer.TabIndex = 3;
            this.pctRejouer.TabStop = false;
            this.pctRejouer.Click += new System.EventHandler(this.pctRejouer_Click);
            // 
            // pctPendu
            // 
            this.pctPendu.Image = global::JeuDuPendu2.Properties.Resources.pendu0;
            this.pctPendu.Location = new System.Drawing.Point(259, 18);
            this.pctPendu.Name = "pctPendu";
            this.pctPendu.Size = new System.Drawing.Size(250, 250);
            this.pctPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctPendu.TabIndex = 2;
            this.pctPendu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 282);
            this.Controls.Add(this.pctRejouer);
            this.Controls.Add(this.pctPendu);
            this.Controls.Add(this.grbLettres);
            this.Controls.Add(this.grbMotMystere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMotMystere.ResumeLayout(false);
            this.grbMotMystere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRejouer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMotMystere;
        private System.Windows.Forms.GroupBox grbLettres;
        private System.Windows.Forms.PictureBox pctPendu;
        private System.Windows.Forms.Label lblMot;
        private System.Windows.Forms.PictureBox pctRejouer;
    }
}

