namespace Test1
{
    partial class nouveauTweetFenetre
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
            this.texteTweet = new System.Windows.Forms.RichTextBox();
            this.tweeterBouton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texteTweet
            // 
            this.texteTweet.Location = new System.Drawing.Point(12, 12);
            this.texteTweet.MaxLength = 140;
            this.texteTweet.Name = "texteTweet";
            this.texteTweet.Size = new System.Drawing.Size(260, 60);
            this.texteTweet.TabIndex = 0;
            this.texteTweet.Text = "";
            this.texteTweet.TextChanged += new System.EventHandler(this.texteTweet_TextChanged);
            // 
            // tweeterBouton
            // 
            this.tweeterBouton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tweeterBouton.Enabled = false;
            this.tweeterBouton.Location = new System.Drawing.Point(172, 78);
            this.tweeterBouton.Name = "tweeterBouton";
            this.tweeterBouton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tweeterBouton.Size = new System.Drawing.Size(100, 23);
            this.tweeterBouton.TabIndex = 1;
            this.tweeterBouton.Text = "Publier le tweet";
            this.tweeterBouton.UseVisualStyleBackColor = true;
            this.tweeterBouton.Click += new System.EventHandler(this.tweeterBouton_Click);
            // 
            // nouveauTweetFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.tweeterBouton);
            this.Controls.Add(this.texteTweet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "nouveauTweetFenetre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Publier un twet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox texteTweet;
        private System.Windows.Forms.Button tweeterBouton;
    }
}