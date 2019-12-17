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
        private int nbCardVisible = 0;

        public Table()
        {
            this.deck = new List<Card>();
            this.cards = new List<Card>();
            char character = 'A';
          
            for (int i =0; i<26; i++)
            {
                Card card = new Card(character.ToString(), "ms-appx:///Assets/"+character+".png");
                character++;
                this.deck.Add(card);
            }
            this.deck = ShuffleList<Card>(deck);
            if(level < 13)
            {
                Random r = new Random();
                int randomIndex = 0;
                for (int i = 0; i < (level + 2); i++)
                {
                    randomIndex = r.Next(0, deck.Count);
                    cards.Add(new Card(deck[randomIndex]));
                    cards.Add(new Card(deck[randomIndex]));
                }
            }
            this.cards = ShuffleList<Card>(cards);

        }

        public List<Card> Deck
        {
            get => deck;
            set => deck = value;
        }

        public List<Card> Cards
        {
            get => cards;
            set => cards = value;
        }
        public int NbCardVisible { get => nbCardVisible; set => nbCardVisible = value; }

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
