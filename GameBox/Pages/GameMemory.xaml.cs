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
        private Player player;
        public GameMemory()
        {
            this.InitializeComponent();
            this.table = new Table();
            this.player = Player.Instance;
            playerNameLabel.Text = player.name;
        }

        public void cardClicked(object sender, RoutedEventArgs e)
        {
            string img = ((Image)sender).Name;
            if (table.Cards[int.Parse(img.Substring(4, 1))].IsHidden == true)
            {
                switch (table.NbCardVisible)
                {
                    case 0:
                        ((Image)sender).Source = new BitmapImage(new Uri(table.Cards[int.Parse(img.Substring(4, 1))].Img));
                        table.Cards[int.Parse(img.Substring(4, 1))].IsHidden = false;
                        table.NbCardVisible++;
                        break;
                    case 1:
                        ((Image)sender).Source = new BitmapImage(new Uri(table.Cards[int.Parse(img.Substring(4, 1))].Img));
                        table.Cards[int.Parse(img.Substring(4, 1))].IsHidden = false;
                        table.NbCardVisible++;
                        //here
                        break;

                }
            }
            
            if (table.Cards[int.Parse(img.Substring(4, 1))].IsHidden == true && this.table.NbCardVisible < 2)
            {
                ((Image)sender).Source = new BitmapImage(new Uri(table.Cards[int.Parse(img.Substring(4, 1))].Img));
                table.Cards[int.Parse(img.Substring(4, 1))].IsHidden = false;
                table.NbCardVisible++;
            }
            
            
        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

    }
}
