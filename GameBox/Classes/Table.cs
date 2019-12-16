using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace GameBox.Classes
{
    class Table
    {
        private List<Card> deck;
        private List<Card> cards;
        private int level = 0;

        public Table()
        {
            this.deck = new List<Card>();
            char character = 'A';
            string path = "..\\Assets\\";
            string ending = ".png";
            for (int i =0; i<26; i++)
            {
                Card card = new Card(character.ToString(), path+character+ending);
                character++;
                this.deck.Add(card);
            }
            this.deck = ShuffleList<Card>(deck);
            
            if(level = 0)
            {
                cards.Add(deck.)
            }
        }

        public List<Card> Deck
        {
            get => deck;
            set => deck = value;
        }

        private List<Card> ShuffleList<Card>(List<Card> inputList)
        {
            List<Card> randomList = new List<Card>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count);
                randomList.Add(inputList[randomIndex]); 
                inputList.RemoveAt(randomIndex);
            }

            return randomList;
        }
    }
}
