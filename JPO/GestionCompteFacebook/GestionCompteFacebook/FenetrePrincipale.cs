using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCompteFacebook
{
	public partial class FenetrePrincipale : Form
	{
		String redirect_url { get; set; }

		public FenetrePrincipale()
		{
			try
			{
				InitializeComponent();
				string login_url = @"https://www.facebook.com/dialog/oauth?client_id=" +
					ConfigurationManager.AppSettings["AppID"] +
					"&redirect_uri=https://www.facebook.com/connect/login_success.html" +
					"&response_type=token" +
					"&scope=public_profile,user_friends,email,user_status";

				loginBrowser.Navigate(login_url);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			ongletsApplication.Visible = false;
		}

		private void loginBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			if (loginBrowser.Url.OriginalString.StartsWith("https://www.facebook.com/connect/login_success.html"))
			{
				redirect_url = loginBrowser.Url.OriginalString;
				string end_url = redirect_url.Substring(redirect_url.IndexOf("access_token") + 13);
				string accessToken = end_url.Substring(0, end_url.IndexOf("&"));
				// On affiche l'interface de gestion du compte
				loginBrowser.Visible = false;
				ongletsApplication.Visible = true;
				FacebookClient fb = new FacebookClient(accessToken);
				dynamic feed = fb.Get("me?fields=id,name,picture,email,bio");
			}
		}
	}
}
