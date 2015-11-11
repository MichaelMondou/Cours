namespace Puissance_4
{
    partial class Puissance4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puissance4));
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nouveauToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nouveauToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nouveauToolStripButton
            // 
            this.nouveauToolStripButton.Name = "nouveauToolStripButton";
            this.nouveauToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // ToolStripButton
            // 
            this.ToolStripButton.Name = "ToolStripButton";
            this.ToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripButton1,
            this.toolStripSeparator2,
            this.ToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(294, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // nouveauToolStripButton1
            // 
            this.nouveauToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nouveauToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripButton1.Image")));
            this.nouveauToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nouveauToolStripButton1.Name = "nouveauToolStripButton1";
            this.nouveauToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.nouveauToolStripButton1.Text = "&Nouveau";
            this.nouveauToolStripButton1.Click += new System.EventHandler(this.nouveauToolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton1.Text = "&?";
            this.ToolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 246);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(294, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // Puissance4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Puissance4";
            this.Text = "Puissance 4";
            this.Load += new System.EventHandler(this.Puissance4_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Puissance4_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Puissance4_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Puissance4_MouseMove);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton nouveauToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton nouveauToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ToolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

