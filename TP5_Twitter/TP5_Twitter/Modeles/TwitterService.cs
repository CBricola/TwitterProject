using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP5_Twitter.Modeles;
using TP5_Twitter.Modèles;
using TP5_Twitter.Services;

namespace TP5_Twitter.Modeles
{
    class TwitterService : ITwitterService
    {

        public Boolean Authenticate(User User)
        {

            List<Tweet> tweets = GetTweets();

            Boolean findUser = tweets.Any(p => p.User.Login.Equals(User.Login)&& p.User.Pwd.Equals(User.Pwd));
            

            if (findUser == true)  
            {
                return true;
            }
            else 
            {  
                return false;
            }
        }

        public List<Tweet> GetTweets()
        {
            List<Tweet> result = new List<Tweet>();

            User User = new User("clement","xamarin");

            Tweet tweet1 = new Tweet("1", "35s", "Hello, je suis très content", User);
            Tweet tweet2 = new Tweet("2", "3m", "Il fait beau aujourd'hui", User);
            Tweet tweet3 = new Tweet("3", "15m", "Hello, je suis très content", User);

            result.Add(tweet1);
            result.Add(tweet2);
            result.Add(tweet3);
            
            return result;

        }
    }
}
