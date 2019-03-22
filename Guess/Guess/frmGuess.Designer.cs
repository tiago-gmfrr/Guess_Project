namespace Guess
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tspMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mtsQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesPersonnagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuess)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(144, 208);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(157, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Les questions seront affichés ici";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblQuestion.Location = new System.Drawing.Point(0, 177);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(435, 40);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "aaaaaa";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblQuestion.Visible = false;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnNon
            // 
            this.btnNon.Location = new System.Drawing.Point(243, 280);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(171, 100);
            this.btnNon.TabIndex = 1;
            this.btnNon.Text = "non";
            this.btnNon.UseVisualStyleBackColor = true;
            this.btnNon.Visible = false;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // btnOui
            // 
            this.btnOui.Location = new System.Drawing.Point(38, 280);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(171, 100);
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
            this.btnQuitter.Location = new System.Drawing.Point(38, 270);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(171, 100);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnLancerPartie
            // 
            this.btnLancerPartie.Location = new System.Drawing.Point(243, 270);
            this.btnLancerPartie.Name = "btnLancerPartie";
            this.btnLancerPartie.Size = new System.Drawing.Size(171, 100);
            this.btnLancerPartie.TabIndex = 1;
            this.btnLancerPartie.Text = "Lancer une partie";
            this.btnLancerPartie.UseVisualStyleBackColor = true;
            this.btnLancerPartie.Click += new System.EventHandler(this.btnLancerPartie_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspMenu,
            this.aideToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(435, 24);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // tspMenu
            // 
            this.tspMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsMenuPrincipal,
            this.toolStripSeparator2,
            this.mtsQuitter});
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(50, 20);
            this.tspMenu.Text = "&Menu";
            // 
            // mtsMenuPrincipal
            // 
            this.mtsMenuPrincipal.Name = "mtsMenuPrincipal";
            this.mtsMenuPrincipal.Size = new System.Drawing.Size(154, 22);
            this.mtsMenuPrincipal.Text = "Menu Principal";
            this.mtsMenuPrincipal.Click += new System.EventHandler(this.mtsMenuPrincipal_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // mtsQuitter
            // 
            this.mtsQuitter.Name = "mtsQuitter";
            this.mtsQuitter.Size = new System.Drawing.Size(154, 22);
            this.mtsQuitter.Text = "&Quitter";
            this.mtsQuitter.Click += new System.EventHandler(this.mtsQuitter_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àproposdeToolStripMenuItem,
            this.listeDesPersonnagesToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // àproposdeToolStripMenuItem
            // 
            this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.àproposdeToolStripMenuItem.Text = "À &propos de...";
            this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.àproposdeToolStripMenuItem_Click);
            // 
            // listeDesPersonnagesToolStripMenuItem
            // 
            this.listeDesPersonnagesToolStripMenuItem.Name = "listeDesPersonnagesToolStripMenuItem";
            this.listeDesPersonnagesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listeDesPersonnagesToolStripMenuItem.Text = "Liste des Personnages";
            this.listeDesPersonnagesToolStripMenuItem.Click += new System.EventHandler(this.listeDesPersonnagesToolStripMenuItem_Click);
            // 
            // frmGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 392);
            this.Controls.Add(this.btnLancerPartie);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pbxGuess);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGuess_FormClosing);
            this.Load += new System.EventHandler(this.frmGuess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuess)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tspMenu;
        private System.Windows.Forms.ToolStripMenuItem mtsMenuPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mtsQuitter;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesPersonnagesToolStripMenuItem;
    }
}

