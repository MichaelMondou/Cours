namespace New_JPO
{
    partial class JPO
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
            this.components = new System.ComponentModel.Container();
            this.Barre_Menu = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.débutantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermédiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Barre_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barre_Menu
            // 
            this.Barre_Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Barre_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Barre_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.niveauToolStripMenuItem});
            this.Barre_Menu.Location = new System.Drawing.Point(0, 0);
            this.Barre_Menu.MinimumSize = new System.Drawing.Size(0, 34);
            this.Barre_Menu.Name = "Barre_Menu";
            this.Barre_Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Barre_Menu.Size = new System.Drawing.Size(1283, 34);
            this.Barre_Menu.TabIndex = 0;
            this.Barre_Menu.Text = "Barre_Menu";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(42, 30);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // niveauToolStripMenuItem
            // 
            this.niveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.débutantToolStripMenuItem,
            this.intermédiaireToolStripMenuItem,
            this.expertToolStripMenuItem});
            this.niveauToolStripMenuItem.Name = "niveauToolStripMenuItem";
            this.niveauToolStripMenuItem.Size = new System.Drawing.Size(67, 30);
            this.niveauToolStripMenuItem.Text = "Niveau";
            // 
            // débutantToolStripMenuItem
            // 
            this.débutantToolStripMenuItem.Name = "débutantToolStripMenuItem";
            this.débutantToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.débutantToolStripMenuItem.Text = "Débutant";
            this.débutantToolStripMenuItem.Click += new System.EventHandler(this.débutantToolStripMenuItem_Click);
            // 
            // intermédiaireToolStripMenuItem
            // 
            this.intermédiaireToolStripMenuItem.Name = "intermédiaireToolStripMenuItem";
            this.intermédiaireToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.intermédiaireToolStripMenuItem.Text = "Intermédiaire";
            this.intermédiaireToolStripMenuItem.Click += new System.EventHandler(this.intermédiaireToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.42F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(475, 636);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(522, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "PAUSE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(711, 635);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Indications";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(12, 635);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(443, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 54);
            this.label5.TabIndex = 5;
            this.label5.Text = "FIN DE PARTIE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(123, 635);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Niveau";
            // 
            // JPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 673);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Barre_Menu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.Barre_Menu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPO";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JPO_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.JPO_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.JPO_MouseMove);
            this.Barre_Menu.ResumeLayout(false);
            this.Barre_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Barre_Menu;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem niveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem débutantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermédiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}

