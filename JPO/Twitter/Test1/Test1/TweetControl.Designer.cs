namespace Test1
{
    partial class TweetControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageAuthor = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.tweet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // imageAuthor
            // 
            this.imageAuthor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imageAuthor.Location = new System.Drawing.Point(6, 4);
            this.imageAuthor.Name = "imageAuthor";
            this.imageAuthor.Size = new System.Drawing.Size(48, 48);
            this.imageAuthor.TabIndex = 0;
            this.imageAuthor.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(60, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Nom d\'utiisateur";
            // 
            // tweet
            // 
            this.tweet.AutoSize = true;
            this.tweet.Location = new System.Drawing.Point(60, 30);
            this.tweet.Name = "tweet";
            this.tweet.Size = new System.Drawing.Size(33, 13);
            this.tweet.TabIndex = 2;
            this.tweet.Text = "tweet";
            // 
            // TweetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tweet);
            this.Controls.Add(this.name);
            this.Controls.Add(this.imageAuthor);
            this.Name = "TweetControl";
            this.Size = new System.Drawing.Size(741, 57);
            ((System.ComponentModel.ISupportInitialize)(this.imageAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageAuthor;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label tweet;
    }
}
