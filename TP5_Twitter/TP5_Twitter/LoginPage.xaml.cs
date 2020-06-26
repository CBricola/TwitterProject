using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Twitter.Modeles;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP5_Twitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void Connection_Clicked(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                Debug.WriteLine("Connection Available");

                CacherErreur();
                if (string.IsNullOrEmpty(this.id.Text.ToString()) || this.id.Text.Length < 3 || string.IsNullOrEmpty(this.pwd.Text.ToString()) || this.pwd.Text.Length < 6)
                {
                    this.AfficherErreur("Veuillez saisir un identifiant et un mot de passe valide");
                    return;
                }
                else
                {


                    User User = new User(this.id.Text, this.pwd.Text);

                    TwitterService TS = new TwitterService();

                    bool result = TS.Authenticate(User);

                    if (result)
                    {
                        Redirect();
                    }
                    else
                    {
                        this.AfficherErreur("Compte introuvable");

                    }



                }
            }
        }

        private void AfficherErreur(string erreur)
        {
            this.erreur.Text = erreur;
            this.erreur.IsVisible = true;
        }

        

        private void CacherErreur()
        {
            this.erreur.IsVisible = false;
        }

        async void Redirect()
        {
            await Navigation.PushAsync(new TweetPage());

        }
    }
}