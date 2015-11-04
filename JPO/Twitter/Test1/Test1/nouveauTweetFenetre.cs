using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class nouveauTweetFenetre : Form
    {
        private string tweet;

        public string Tweet
        {
            get { return tweet; }
            set { tweet = value; }
        }

        public nouveauTweetFenetre()
        {
            InitializeComponent();
        }

        private void tweeterBouton_Click(object sender, EventArgs e)
        {
            tweet = texteTweet.Text;
        }

        private void texteTweet_TextChanged(object sender, EventArgs e)
        {
            if (texteTweet.TextLength > 0)
            {
                tweeterBouton.Enabled = true;
            }
            else
            {
                tweeterBouton.Enabled = false;
            }
        }
    }
}
