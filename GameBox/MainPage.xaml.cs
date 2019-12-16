using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GameBox
{
    public sealed partial class MainPage : Page
    {
        private string pseudo = "";










        // FAIRE SINGLETON












        public MainPage()
        {
            this.InitializeComponent();
            myStoryBoard.Begin();
        }

        public void onNavigateTo()
        {
            playerName.Text = pseudo;
        }

        public void FirstGame(object sender, RoutedEventArgs e)
        {
            if(playerName.Text != "")
            {
                pseudo = playerName.Text;
                Console.WriteLine(pseudo);
                if (Application.Current.Resources.ContainsKey("name"))
                {
                    Application.Current.Resources["name"] = pseudo;
                }
                else
                {
                    Application.Current.Resources.Add("name", this.playerName.Text);
                }
                Frame.Navigate(typeof(GameIntrus));
            }
        }
        public void SecondGame(object sender, RoutedEventArgs e)
        {
            if (playerName.Text != "")
            {
                pseudo = playerName.Text;
                if (Application.Current.Resources.ContainsKey("name"))
                {
                    Application.Current.Resources["name"] = pseudo;
                }
                else
                {
                    Application.Current.Resources.Add("name", this.playerName.Text);
                }
                Frame.Navigate(typeof(GameMemory));
            }
        }

    }

}
