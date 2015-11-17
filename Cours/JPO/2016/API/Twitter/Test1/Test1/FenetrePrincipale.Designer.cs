namespace Test1
{
    partial class FenetrePrincipale
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
			this.barre = new System.Windows.Forms.ToolStrip();
			this.nouveauTweetBouton = new System.Windows.Forms.ToolStripButton();
			this.rechargerTweetsBouton = new System.Windows.Forms.ToolStripButton();
			this.webBouton = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paramètresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.barre.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// barre
			// 
			this.barre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauTweetBouton,
            this.rechargerTweetsBouton,
            this.webBouton});
			this.barre.Location = new System.Drawing.Point(0, 24);
			this.barre.Name = "barre";
			this.barre.Size = new System.Drawing.Size(830, 25);
			this.barre.TabIndex = 1;
			this.barre.Text = "toolStrip1";
			// 
			// nouveauTweetBouton
			// 
			this.nouveauTweetBouton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.nouveauTweetBouton.Image = ((System.Drawing.Image)(resources.GetObject("nouveauTweetBouton.Image")));
			this.nouveauTweetBouton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nouveauTweetBouton.Name = "nouveauTweetBouton";
			this.nouveauTweetBouton.Size = new System.Drawing.Size(23, 22);
			this.nouveauTweetBouton.Text = "Ajouter un tweet";
			this.nouveauTweetBouton.Click += new System.EventHandler(this.nouveauTweetBouton_Click);
			// 
			// rechargerTweetsBouton
			// 
			this.rechargerTweetsBouton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rechargerTweetsBouton.Image = ((System.Drawing.Image)(resources.GetObject("rechargerTweetsBouton.Image")));
			this.rechargerTweetsBouton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.rechargerTweetsBouton.Name = "rechargerTweetsBouton";
			this.rechargerTweetsBouton.Size = new System.Drawing.Size(23, 22);
			this.rechargerTweetsBouton.Text = "Recharger la liste des tweets";
			this.rechargerTweetsBouton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// webBouton
			// 
			this.webBouton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.webBouton.Image = ((System.Drawing.Image)(resources.GetObject("webBouton.Image")));
			this.webBouton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.webBouton.Name = "webBouton";
			this.webBouton.Size = new System.Drawing.Size(23, 22);
			this.webBouton.Text = "Accéder au profil";
			this.webBouton.Click += new System.EventHandler(this.webButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(830, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// paramètresToolStripMenuItem
			// 
			this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
			this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.paramètresToolStripMenuItem.Text = "Paramètres";
			this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
			// 
			// sommaireToolStripMenuItem
			// 
			this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
			this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.sommaireToolStripMenuItem.Text = "&Sommaire";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.indexToolStripMenuItem.Text = "&Index";
			// 
			// rechercherToolStripMenuItem
			// 
			this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
			this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.rechercherToolStripMenuItem.Text = "&Rechercher";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
			// 
			// àproposdeToolStripMenuItem
			// 
			this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
			this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.àproposdeToolStripMenuItem.Text = "À &propos de...";
			// 
			// personnaliserToolStripMenuItem
			// 
			this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
			this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// annulerToolStripMenuItem
			// 
			this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
			this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.annulerToolStripMenuItem.Text = "&Annuler";
			// 
			// rétablirToolStripMenuItem
			// 
			this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
			this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.rétablirToolStripMenuItem.Text = "&Rétablir";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
			// 
			// couperToolStripMenuItem
			// 
			this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
			this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
			this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.couperToolStripMenuItem.Text = "&Couper";
			// 
			// copierToolStripMenuItem
			// 
			this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
			this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
			this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.copierToolStripMenuItem.Text = "Co&pier";
			// 
			// collerToolStripMenuItem
			// 
			this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
			this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
			this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.collerToolStripMenuItem.Text = "Co&ller";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
			// 
			// sélectionnertoutToolStripMenuItem
			// 
			this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
			this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
			// 
			// nouveauToolStripMenuItem
			// 
			this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
			this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
			this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.nouveauToolStripMenuItem.Text = "&Nouveau";
			// 
			// ouvrirToolStripMenuItem
			// 
			this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
			this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
			this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
			// 
			// enregistrerToolStripMenuItem
			// 
			this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
			this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
			this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
			// 
			// enregistrersousToolStripMenuItem
			// 
			this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
			this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
			// 
			// imprimerToolStripMenuItem
			// 
			this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
			this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
			this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.imprimerToolStripMenuItem.Text = "&Imprimer";
			// 
			// aperçuavantimpressionToolStripMenuItem
			// 
			this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
			this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
			this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.quitterToolStripMenuItem.Text = "&Quitter";
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
			this.vScrollBar1.Location = new System.Drawing.Point(813, 49);
			this.vScrollBar1.Maximum = 500;
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 265);
			this.vScrollBar1.TabIndex = 0;
			this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(830, 24);
			this.menuStrip2.TabIndex = 4;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// editionToolStripMenuItem
			// 
			this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem1});
			this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
			this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.editionToolStripMenuItem.Text = "Edition";
			// 
			// paramètresToolStripMenuItem1
			// 
			this.paramètresToolStripMenuItem1.Name = "paramètresToolStripMenuItem1";
			this.paramètresToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.paramètresToolStripMenuItem1.Text = "Paramètres";
			this.paramètresToolStripMenuItem1.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
			// 
			// FenetrePrincipale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 314);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.barre);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FenetrePrincipale";
			this.Text = "Form1";
			this.barre.ResumeLayout(false);
			this.barre.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barre;
        private System.Windows.Forms.ToolStripButton nouveauTweetBouton;
        private System.Windows.Forms.ToolStripButton webBouton;
        private System.Windows.Forms.ToolStripButton rechargerTweetsBouton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem1;

    }
}

