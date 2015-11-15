namespace CasseBrique
{
    partial class Casse_Brique
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
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debutantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermédiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.score_label = new System.Windows.Forms.Label();
            this.niveau_label = new System.Windows.Forms.Label();
            this.instructions_label = new System.Windows.Forms.Label();
            this.fin_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.niveauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debutantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.intermédiaireToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.etat_label = new System.Windows.Forms.Label();
            this.vies_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.jeuToolStripMenuItem.Font = new System.Drawing.Font("StarJedi Special Edition", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jeuToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(159, 30);
            this.quitterToolStripMenuItem.Text = "quitter";
            // 
            // niveauToolStripMenuItem
            // 
            this.niveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debutantToolStripMenuItem,
            this.intermédiaireToolStripMenuItem,
            this.expertToolStripMenuItem});
            this.niveauToolStripMenuItem.Font = new System.Drawing.Font("StarJedi Special Edition", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveauToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.niveauToolStripMenuItem.Name = "niveauToolStripMenuItem";
            this.niveauToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.niveauToolStripMenuItem.Text = "niveau";
            // 
            // debutantToolStripMenuItem
            // 
            this.debutantToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.debutantToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.debutantToolStripMenuItem.Name = "debutantToolStripMenuItem";
            this.debutantToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.debutantToolStripMenuItem.Text = "debutant";
            // 
            // intermédiaireToolStripMenuItem
            // 
            this.intermédiaireToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.intermédiaireToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.intermédiaireToolStripMenuItem.Name = "intermédiaireToolStripMenuItem";
            this.intermédiaireToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.intermédiaireToolStripMenuItem.Text = "intermédiaire";
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.expertToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.expertToolStripMenuItem.Text = "expert";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.Transparent;
            this.score_label.Font = new System.Drawing.Font("StarJedi Special Edition", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.Location = new System.Drawing.Point(12, 401);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(76, 25);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "score :";
            // 
            // niveau_label
            // 
            this.niveau_label.AutoSize = true;
            this.niveau_label.BackColor = System.Drawing.Color.Transparent;
            this.niveau_label.Font = new System.Drawing.Font("StarJedi Special Edition", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveau_label.Location = new System.Drawing.Point(313, 399);
            this.niveau_label.Name = "niveau_label";
            this.niveau_label.Size = new System.Drawing.Size(84, 25);
            this.niveau_label.TabIndex = 2;
            this.niveau_label.Text = "niveau :";
            // 
            // instructions_label
            // 
            this.instructions_label.AutoSize = true;
            this.instructions_label.BackColor = System.Drawing.Color.Transparent;
            this.instructions_label.Font = new System.Drawing.Font("StarJedi Special Edition", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions_label.Location = new System.Drawing.Point(190, 4);
            this.instructions_label.Name = "instructions_label";
            this.instructions_label.Size = new System.Drawing.Size(137, 25);
            this.instructions_label.TabIndex = 4;
            this.instructions_label.Text = "instructions :";
            // 
            // fin_label
            // 
            this.fin_label.AutoSize = true;
            this.fin_label.BackColor = System.Drawing.Color.Transparent;
            this.fin_label.Font = new System.Drawing.Font("StarJedi Special Edition", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fin_label.Location = new System.Drawing.Point(300, 317);
            this.fin_label.Name = "fin_label";
            this.fin_label.Size = new System.Drawing.Size(243, 45);
            this.fin_label.TabIndex = 5;
            this.fin_label.Text = "fin de partie";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("StarJedi Special Edition", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem1,
            this.niveauToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem1
            // 
            this.jeuToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.jeuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem1});
            this.jeuToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.jeuToolStripMenuItem1.Name = "jeuToolStripMenuItem1";
            this.jeuToolStripMenuItem1.Size = new System.Drawing.Size(52, 29);
            this.jeuToolStripMenuItem1.Text = "jeu";
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.quitterToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(159, 30);
            this.quitterToolStripMenuItem1.Text = "quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // niveauToolStripMenuItem1
            // 
            this.niveauToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.niveauToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debutantToolStripMenuItem1,
            this.intermédiaireToolStripMenuItem1,
            this.expertToolStripMenuItem1});
            this.niveauToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.niveauToolStripMenuItem1.Name = "niveauToolStripMenuItem1";
            this.niveauToolStripMenuItem1.Size = new System.Drawing.Size(84, 29);
            this.niveauToolStripMenuItem1.Text = "niveau";
            // 
            // debutantToolStripMenuItem1
            // 
            this.debutantToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.debutantToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.debutantToolStripMenuItem1.Name = "debutantToolStripMenuItem1";
            this.debutantToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.debutantToolStripMenuItem1.Text = "debutant";
            this.debutantToolStripMenuItem1.Click += new System.EventHandler(this.débutantToolStripMenuItem_Click);
            // 
            // intermédiaireToolStripMenuItem1
            // 
            this.intermédiaireToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.intermédiaireToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.intermédiaireToolStripMenuItem1.Name = "intermédiaireToolStripMenuItem1";
            this.intermédiaireToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.intermédiaireToolStripMenuItem1.Text = "intermédiaire";
            this.intermédiaireToolStripMenuItem1.Click += new System.EventHandler(this.intermédiaireToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem1
            // 
            this.expertToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.expertToolStripMenuItem1.ForeColor = System.Drawing.Color.Gold;
            this.expertToolStripMenuItem1.Name = "expertToolStripMenuItem1";
            this.expertToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.expertToolStripMenuItem1.Text = "expert";
            this.expertToolStripMenuItem1.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // etat_label
            // 
            this.etat_label.AutoSize = true;
            this.etat_label.Font = new System.Drawing.Font("StarJedi Special Edition", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etat_label.Location = new System.Drawing.Point(679, 0);
            this.etat_label.Name = "etat_label";
            this.etat_label.Size = new System.Drawing.Size(68, 25);
            this.etat_label.TabIndex = 7;
            this.etat_label.Text = "en jeu";
            // 
            // vies_label
            // 
            this.vies_label.AutoSize = true;
            this.vies_label.BackColor = System.Drawing.Color.Transparent;
            this.vies_label.Location = new System.Drawing.Point(171, 401);
            this.vies_label.Name = "vies_label";
            this.vies_label.Size = new System.Drawing.Size(53, 23);
            this.vies_label.TabIndex = 8;
            this.vies_label.Text = "vies :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CasseBrique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(778, 429);
            this.Controls.Add(this.vies_label);
            this.Controls.Add(this.etat_label);
            this.Controls.Add(this.fin_label);
            this.Controls.Add(this.instructions_label);
            this.Controls.Add(this.niveau_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("StarJedi Special Edition", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CasseBrique";
            this.Text = "Star Wars Casse Brique";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CasseBrique_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CasseBrique_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CasseBrique_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debutantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermédiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label niveau_label;
        private System.Windows.Forms.Label instructions_label;
        private System.Windows.Forms.Label fin_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem niveauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debutantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem intermédiaireToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem1;
        private System.Windows.Forms.Label etat_label;
        private System.Windows.Forms.Label vies_label;
        private System.Windows.Forms.Timer timer1;
    }
}

