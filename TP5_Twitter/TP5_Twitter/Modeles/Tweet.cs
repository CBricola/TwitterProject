using System;
using System.Collections.Generic;
using System.Text;
using TP5_Twitter.Modeles;

namespace TP5_Twitter.Modèles
{
    class Tweet
    {
        public String Id { get; set; }
        public String Date { get; set; }
        public String Texte { get; set; }
        public User User { get; set; }
        

        public Tweet(String Id, String Date, String Texte, User User)
        {
            this.Id = Id;
            this.Date = Date;
            this.Texte = Texte;
            this.User = User;
        }

    }
}
