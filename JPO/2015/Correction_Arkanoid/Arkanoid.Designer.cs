namespace arkanoid.V4
{
    partial class Arkanoid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arkanoid));
            this.pictureBoxVert = new System.Windows.Forms.PictureBox();
            this.pictureBoxBleu = new System.Windows.Forms.PictureBox();
            this.pictureBoxRouge = new System.Windows.Forms.PictureBox();
            this.pictureBoxJaune = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrange = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.txtscore = new System.Windows.Forms.Label();
            this.txtvie = new System.Windows.Forms.Label();
            this.JeuBoutton = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPause = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NiveauBoutton = new System.Windows.Forms.ToolStripMenuItem();
            this.DebutantMod = new System.Windows.Forms.ToolStripMenuItem();
            this.MoyenMod = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfirméMod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BarreDoutil = new System.Windows.Forms.ToolStrip();
            this.txtNiveau = new System.Windows.Forms.Label();
            this.instruction = new System.Windows.Forms.Label();
            this.barre = new arkanoid.V4.Barre();
            this.balle = new arkanoid.V4.Balle();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJaune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).BeginInit();
            this.BarreDoutil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVert
            // 
            this.pictureBoxVert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxVert.BackgroundImage")));
            this.pictureBoxVert.Location = new System.Drawing.Point(122, 42);
            this.pictureBoxVert.Name = "pictureBoxVert";
            this.pictureBoxVert.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxVert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxVert.TabIndex = 0;
            this.pictureBoxVert.TabStop = false;
            this.pictureBoxVert.Visible = false;
            // 
            // pictureBoxBleu
            // 
            this.pictureBoxBleu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBleu.BackgroundImage")));
            this.pictureBoxBleu.Location = new System.Drawing.Point(243, 42);
            this.pictureBoxBleu.Name = "pictureBoxBleu";
            this.pictureBoxBleu.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxBleu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxBleu.TabIndex = 1;
            this.pictureBoxBleu.TabStop = false;
            this.pictureBoxBleu.Visible = false;
            // 
            // pictureBoxRouge
            // 
            this.pictureBoxRouge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRouge.BackgroundImage")));
            this.pictureBoxRouge.Location = new System.Drawing.Point(187, 42);
            this.pictureBoxRouge.Name = "pictureBoxRouge";
            this.pictureBoxRouge.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxRouge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRouge.TabIndex = 2;
            this.pictureBoxRouge.TabStop = false;
            this.pictureBoxRouge.Visible = false;
            // 
            // pictureBoxJaune
            // 
            this.pictureBoxJaune.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxJaune.BackgroundImage")));
            this.pictureBoxJaune.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxJaune.Location = new System.Drawing.Point(65, 42);
            this.pictureBoxJaune.Name = "pictureBoxJaune";
            this.pictureBoxJaune.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxJaune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxJaune.TabIndex = 3;
            this.pictureBoxJaune.TabStop = false;
            this.pictureBoxJaune.Visible = false;
            // 
            // pictureBoxOrange
            // 
            this.pictureBoxOrange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrange.BackgroundImage")));
            this.pictureBoxOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOrange.Location = new System.Drawing.Point(12, 42);
            this.pictureBoxOrange.Name = "pictureBoxOrange";
            this.pictureBoxOrange.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxOrange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOrange.TabIndex = 4;
            this.pictureBoxOrange.TabStop = false;
            this.pictureBoxOrange.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Teal;
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.Location = new System.Drawing.Point(0, 488);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(344, 24);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Location = new System.Drawing.Point(229, 490);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(44, 13);
            this.txtscore.TabIndex = 8;
            this.txtscore.Text = "Score : ";
            // 
            // txtvie
            // 
            this.txtvie.AutoSize = true;
            this.txtvie.Location = new System.Drawing.Point(119, 490);
            this.txtvie.Name = "txtvie";
            this.txtvie.Size = new System.Drawing.Size(31, 13);
            this.txtvie.TabIndex = 9;
            this.txtvie.Text = "Vie : ";
            // 
            // JeuBoutton
            // 
            this.JeuBoutton.BackColor = System.Drawing.Color.Transparent;
            this.JeuBoutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.setPause,
            this.quitterToolStripMenuItem});
            this.JeuBoutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JeuBoutton.Name = "JeuBoutton";
            this.JeuBoutton.Size = new System.Drawing.Size(36, 25);
            this.JeuBoutton.Text = "Jeu";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.pauseToolStripMenuItem.Text = "Démarrer";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click_1);
            // 
            // setPause
            // 
            this.setPause.Name = "setPause";
            this.setPause.Size = new System.Drawing.Size(123, 22);
            this.setPause.Text = "Pause";
            this.setPause.Click += new System.EventHandler(this.appelPause);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NiveauBoutton
            // 
            this.NiveauBoutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebutantMod,
            this.MoyenMod,
            this.ConfirméMod});
            this.NiveauBoutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NiveauBoutton.Name = "NiveauBoutton";
            this.NiveauBoutton.Size = new System.Drawing.Size(56, 25);
            this.NiveauBoutton.Text = "Niveau";
            // 
            // DebutantMod
            // 
            this.DebutantMod.Name = "DebutantMod";
            this.DebutantMod.Size = new System.Drawing.Size(124, 22);
            this.DebutantMod.Text = "Débutant";
            this.DebutantMod.Click += new System.EventHandler(this.DebutantMod_Click);
            // 
            // MoyenMod
            // 
            this.MoyenMod.Checked = true;
            this.MoyenMod.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MoyenMod.Name = "MoyenMod";
            this.MoyenMod.Size = new System.Drawing.Size(124, 22);
            this.MoyenMod.Text = "Moyen";
            this.MoyenMod.Click += new System.EventHandler(this.MoyenMod_Click);
            // 
            // ConfirméMod
            // 
            this.ConfirméMod.Name = "ConfirméMod";
            this.ConfirméMod.Size = new System.Drawing.Size(124, 22);
            this.ConfirméMod.Text = "Confirmé";
            this.ConfirméMod.Click += new System.EventHandler(this.ConfirméMod_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton.Image")));
            this.ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton.Text = "&?";
            // 
            // BarreDoutil
            // 
            this.BarreDoutil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JeuBoutton,
            this.toolStripSeparator2,
            this.NiveauBoutton,
            this.toolStripSeparator1,
            this.ToolStripButton});
            this.BarreDoutil.Location = new System.Drawing.Point(0, 0);
            this.BarreDoutil.Name = "BarreDoutil";
            this.BarreDoutil.Size = new System.Drawing.Size(344, 25);
            this.BarreDoutil.TabIndex = 10;
            this.BarreDoutil.Text = "toolStrip1";
            // 
            // txtNiveau
            // 
            this.txtNiveau.AutoSize = true;
            this.txtNiveau.Location = new System.Drawing.Point(9, 490);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(50, 13);
            this.txtNiveau.TabIndex = 11;
            this.txtNiveau.Text = "Niveau : ";
            // 
            // instruction
            // 
            this.instruction.AllowDrop = true;
            this.instruction.BackColor = System.Drawing.Color.Transparent;
            this.instruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.instruction.Location = new System.Drawing.Point(32, 327);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(278, 102);
            this.instruction.TabIndex = 0;
            this.instruction.Text = "Pour démarrer, appuyez sur F2";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // barre
            // 
            this.barre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.barre.BackgroundImage = global::arkanoid.V4.Properties.Resources.barre_Image;
            this.barre.Location = new System.Drawing.Point(140, 470);
            this.barre.Name = "barre";
            this.barre.Size = new System.Drawing.Size(60, 5);
            this.barre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.barre.TabIndex = 6;
            this.barre.TabStop = false;
            // 
            // balle
            // 
            this.balle.BackColor = System.Drawing.Color.Transparent;
            this.balle.BackgroundImage = global::arkanoid.V4.Properties.Resources.balle_valide_Image;
            this.balle.ErrorImage = null;
            this.balle.InitialImage = null;
            this.balle.Location = new System.Drawing.Point(165, 455);
            this.balle.Name = "balle";
            this.balle.Size = new System.Drawing.Size(15, 15);
            this.balle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balle.TabIndex = 5;
            this.balle.TabStop = false;
            // 
            // Arkanoid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(344, 512);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.BarreDoutil);
            this.Controls.Add(this.txtvie);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.barre);
            this.Controls.Add(this.balle);
            this.Controls.Add(this.pictureBoxOrange);
            this.Controls.Add(this.pictureBoxJaune);
            this.Controls.Add(this.pictureBoxRouge);
            this.Controls.Add(this.pictureBoxBleu);
            this.Controls.Add(this.pictureBoxVert);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(360, 550);
            this.Name = "Arkanoid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid JPO";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arkanoid_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.arkanoid_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBleu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRouge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJaune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrange)).EndInit();
            this.BarreDoutil.ResumeLayout(false);
            this.BarreDoutil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVert;
        private System.Windows.Forms.PictureBox pictureBoxBleu;
        private System.Windows.Forms.PictureBox pictureBoxRouge;
        private System.Windows.Forms.PictureBox pictureBoxJaune;
        private System.Windows.Forms.PictureBox pictureBoxOrange;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menu;
        private Balle balle;
        private Barre barre;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label txtvie;
        private System.Windows.Forms.ToolStripMenuItem JeuBoutton;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem NiveauBoutton;
        private System.Windows.Forms.ToolStripMenuItem MoyenMod;
        private System.Windows.Forms.ToolStripMenuItem ConfirméMod;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.ToolStrip BarreDoutil;
        private System.Windows.Forms.Label txtNiveau;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DebutantMod;

    }
}

