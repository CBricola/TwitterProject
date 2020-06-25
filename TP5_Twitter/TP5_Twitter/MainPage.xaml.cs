using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Twitter.Modeles;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace TP5_Twitter
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
                    CacherPost();
                    this.AfficherErreur("Veuillez saisir un identifiant et un mot de passe valide");
                    return;
                }
                else
                {


                    User User = new User(this.id.Text, this.pwd.Text);

                    TwitterService TS = new TwitterService();

                    bool result = TS.Authenticate(User);

                    if (result == true)
                    {

                        AfficherPost();
                        return;

                    }
                    else
                    {
                        CacherPost();
                        this.AfficherErreur("Vous ne possédez aucun tweet! ");
                        return;
                    }

                }
            }
            else 
            {

                CacherPost();
                this.AfficherErreur("Vous n'êtes pas connecté à internet ! ");
                return;

            }

        }

        private void AfficherPost()
        {
            this.post.IsVisible = true;
        }

        private void CacherPost()
        {
            this.post.IsVisible = false;
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
    }
}

