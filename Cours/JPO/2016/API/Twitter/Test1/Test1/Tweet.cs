using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Test1
{
    class Tweet
    {
        private LinqToTwitter.Status tweet;

        public Tweet(LinqToTwitter.Status tweet)
        {
            // TODO: Complete member initialization
            this.tweet = tweet;
        }

        public void DrawItem(Graphics gr, Rectangle bounds, Font font, bool showNameOnly)
        {

        }
    }
}
