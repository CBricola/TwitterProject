using System;
using System.Collections.Generic;
using System.Text;
using TP5_Twitter.Modèles;
using TP5_Twitter.Modeles;

namespace TP5_Twitter.Services
{
    interface ITwitterService
    {

       Boolean Authenticate(User user);

       List<Tweet> GetTweets();

    }
}
