using System;
using System.Collections.Generic;
using System.Text;

namespace TP5_Twitter.Modeles
{
    class User
    {
        public String Login { get; set; }

        public String Pwd { get; set; }

        public User( String Login, String Pwd) 
        {
            this.Login = Login;
            this.Pwd = Pwd;

        }

    }
}
