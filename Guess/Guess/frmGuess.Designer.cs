﻿namespace Guess
{
    partial class frmGuess
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnNon = new System.Windows.Forms.Button();
            this.btnOui = new System.Windows.Forms.Button();
            this.pbxGuess = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnLancerPartie = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuess)).BeginInit();
>>>>>>> acbd561eee749c67427f3f0c9a2ab200d328988b
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(95, 186);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(43, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "aaaaaa";
            this.lblQuestion.Visible = false;
            // 
            // btnNon
            // 
            this.btnNon.Location = new System.Drawing.Point(276, 299);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(115, 60);
            this.btnNon.TabIndex = 1;
            this.btnNon.Text = "non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Visible = false;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(73, 299);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(115, 60);
            this.btnOui.TabIndex = 2;
            this.btnOui.Text = "oui";
            this.btnOui.UseVisualStyleBackColor = true;
            this.btnOui.Visible = false;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // pbxGuess
            // 
            this.pbxGuess.Image = global::Guess.Properties.Resources.GuessTitleIMG;
            this.pbxGuess.Location = new System.Drawing.Point(98, 31);
            this.pbxGuess.Name = "pbxGuess";
            this.pbxGuess.Size = new System.Drawing.Size(241, 118);
            this.pbxGuess.TabIndex = 3;
            this.pbxGuess.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(57, 99);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(171, 100);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnLancerPartie
            // 
            this.btnLancerPartie.Location = new System.Drawing.Point(234, 155);
            this.btnLancerPartie.Name = "btnLancerPartie";
            this.btnLancerPartie.Size = new System.Drawing.Size(179, 100);
            this.btnLancerPartie.TabIndex = 5;
            this.btnLancerPartie.Text = "Lancer une partie";
            this.btnLancerPartie.UseVisualStyleBackColor = true;
            this.btnLancerPartie.Click += new System.EventHandler(this.btnLancerPartie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLancerPartie);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pbxGuess);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmGuess";
            this.Text = "Guess";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.PictureBox pbxGuess;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnLancerPartie;
        private System.Windows.Forms.Button button1;
    }
}

