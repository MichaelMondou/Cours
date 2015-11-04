namespace GestionCompteFacebook
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
			this.loginBrowser = new System.Windows.Forms.WebBrowser();
			this.ongletsApplication = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.ongletsApplication.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginBrowser
			// 
			this.loginBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loginBrowser.Location = new System.Drawing.Point(0, 0);
			this.loginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.loginBrowser.Name = "loginBrowser";
			this.loginBrowser.Size = new System.Drawing.Size(1084, 692);
			this.loginBrowser.TabIndex = 0;
			this.loginBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.loginBrowser_Navigated);
			// 
			// ongletsApplication
			// 
			this.ongletsApplication.Controls.Add(this.tabPage1);
			this.ongletsApplication.Controls.Add(this.tabPage2);
			this.ongletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ongletsApplication.Location = new System.Drawing.Point(0, 0);
			this.ongletsApplication.Name = "ongletsApplication";
			this.ongletsApplication.SelectedIndex = 0;
			this.ongletsApplication.Size = new System.Drawing.Size(1084, 692);
			this.ongletsApplication.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1076, 666);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(3, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(1070, 660);
			this.listBox1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(321, 175);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// FenetrePrincipale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 692);
			this.Controls.Add(this.ongletsApplication);
			this.Controls.Add(this.loginBrowser);
			this.Name = "FenetrePrincipale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ongletsApplication.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser loginBrowser;
		private System.Windows.Forms.TabControl ongletsApplication;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TabPage tabPage2;
	}
}

