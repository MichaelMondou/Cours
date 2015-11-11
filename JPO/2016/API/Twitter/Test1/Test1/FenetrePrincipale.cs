using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToTwitter;

namespace Test1
{
    public partial class FenetrePrincipale : Form {
        private SingleUserAuthorizer authorizer = new SingleUserAuthorizer
        {
            CredentialStore =
               new SingleUserInMemoryCredentialStore
               {
                   ConsumerKey =
                       ConfigurationManager.AppSettings["consumerKey"],
                   ConsumerSecret =
                      ConfigurationManager.AppSettings["consumerSecret"],
                   AccessToken =
                      ConfigurationManager.AppSettings["accessToken"],
                   AccessTokenSecret =
                      ConfigurationManager.AppSettings["accessTokenSecret"]
               }
        };

        private List<TweetControl> listeTweets;
        private int nbTweetsToShow = 20;

        public FenetrePrincipale()
        {
            InitializeComponent();
            listeTweets = new List<TweetControl>();
			vScrollBar1.Maximum = nbTweetsToShow * ConfigurationManager.HEIGHT_TWEET_CONTROL - this.Height + ConfigurationManager.HEIGHT_TOOLBAR;
			recupererTweets();            
        }           
        

        private void recupererTweets() {
			var twitterContext = new TwitterContext(authorizer);
            var tweets = from tweet in twitterContext.Status
                         where tweet.Type == StatusType.Home &&
                         tweet.Count == nbTweetsToShow
                         select tweet;
            int i = 0;

			foreach (TweetControl control in listeTweets)
			{
				Controls.Remove(control);
			}

			listeTweets.Clear();

            try
            {
                foreach (LinqToTwitter.Status tweet in tweets.ToList())
                {
                    TweetControl tw = new TweetControl();
                    tw.setTweet(tweet);
                    tw.Width = this.Width;
                    tw.Location = new Point(0, i * ConfigurationManager.HEIGHT_TWEET_CONTROL + ConfigurationManager.HEIGHT_TOOLBAR - vScrollBar1.Value);
                    listeTweets.Add(tw);
                    i++;

                    this.Controls.Add(tw);
                }
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e);
            }
        }

        private void nouveauTweetBouton_Click(object sender, EventArgs e)
        {
			var twitterContext = new TwitterContext(authorizer);

			nouveauTweetFenetre nt = new nouveauTweetFenetre();

			if (nt.ShowDialog() == DialogResult.OK)
			{

				if (nt.Tweet.Length > 0)
				{
					twitterContext.TweetAsync(nt.Tweet);
					MessageBox.Show("Le tweet est publié");
				}

				recupererTweets();
			}

			
        }

        private void webButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/remibot3");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            recupererTweets();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parametresFenetre pf = new parametresFenetre();
            pf.ShowDialog();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int i = 0;
            foreach (TweetControl statut in listeTweets)
            {
                statut.Location = new Point(0, i * ConfigurationManager.HEIGHT_TWEET_CONTROL + ConfigurationManager.HEIGHT_TOOLBAR - vScrollBar1.Value);
                i++;
            }
        }
    }
}
