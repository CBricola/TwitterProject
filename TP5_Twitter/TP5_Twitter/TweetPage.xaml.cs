using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Twitter.Modèles;
using TP5_Twitter.Modeles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP5_Twitter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TweetPage : ContentPage
    {
        public TweetPage()
        {
            InitializeComponent();

            TwitterService TwitterService = new TwitterService();
            this.MaListe.ItemsSource = TwitterService.GetTweets();
        }
    }
}