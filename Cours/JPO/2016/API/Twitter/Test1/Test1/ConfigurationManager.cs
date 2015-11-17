using System.Collections.Generic;
using System.Collections.Specialized;

namespace Test1
{
    static class ConfigurationManager
    {
        static Dictionary<string, string> appSettings;

        public static Dictionary<string, string> AppSettings
        {
            get { return ConfigurationManager.appSettings; }
            set { ConfigurationManager.appSettings = value; }
        }

        public static int HEIGHT_TWEET_CONTROL;
        public static int HEIGHT_TOOLBAR;

        static ConfigurationManager()
        {
            appSettings = new Dictionary<string, string>();
            appSettings["consumerKey"] = "PbLnBTRKUnTZiMeMyGmVJryfQ";
            appSettings["consumerSecret"] = "LkbdLhxkMvabydaFl5ODFirZ04IoiyGiDnCj4cwuoOM4hfmg4D";
            appSettings["accessToken"] = "2499365748-3SNKTmz0AlQeEaOhIJ6gpALH2nB2lFgwp8jd50w";
            appSettings["accessTokenSecret"] = "aVRaRxC7RZdL00v4UQXflTDgvuKRIkRQUCwE6dCWlPnmY";
            HEIGHT_TWEET_CONTROL = 50;
            HEIGHT_TOOLBAR = 20;
        }
    }
}
