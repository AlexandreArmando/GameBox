using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace GameBox.Classes
{
    class Table
    {
        private Card[] deck;
        private Card[] cards;
        private int level = 0;

        public Table()
        {
            char character = 'A';
            Image img = new Image();
            for (int i =0; i<2; i++)
            {
                BitmapImage bitmapImage = new BitmapImage();
                img.Width = bitmapImage.DecodePixelWidth = 120; 
                bitmapImage.UriSource = new Uri(img.BaseUri, "../Assets/"+character+".png");
                img.Source = bitmapImage;
                deck.Append(new Card(character.ToString(), img));
                character++;
            }
            // TODO create the complete deck
            // Shuffle
            // pop cards in cards
        }
    }
}
