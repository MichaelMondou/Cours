using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class TweetControl : UserControl
    {
        public TweetControl()
        {
            InitializeComponent();
        }

        public void setTweet(LinqToTwitter.Status status)
        {
            imageAuthor.Load(status.User.ProfileImageUrl);
            name.Text = status.User.Name;
            tweet.Text = status.Text;
        }
    }
}
