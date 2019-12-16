using GameBox.Classes;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace GameBox
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class GameMemory : Page
    {
        private Table table;
        private string playerName = "";
        public GameMemory()
        {
            this.InitializeComponent();
            this.table = new Table();
        }

        public void cardClicked(object sender, RoutedEventArgs e)
        {
            /*Image img = (Image)FindName(((Image)sender).Name);
            Uri path = new Uri("../Assets/" + table.Deck[short.Parse(((Image)sender).Name.Substring(((Image)sender).Name.Length - 1, 1))].Content + ".png");
            img.Source = new BitmapImage(path);*/
        }

        public void onNavigateTo()
        {
            playerName = (string)Application.Current.Resources["name"];
            playerNameLabel.Text = playerName;
            test.Text = (string)Application.Current.Resources["name"];
        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

    }
}
