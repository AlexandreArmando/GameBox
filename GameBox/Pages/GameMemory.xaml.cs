using GameBox.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;



namespace GameBox
{
    public sealed partial class GameMemory : Page
    {
        private static Table table;
        private Player player;
        private int levelNumber = 0;
        List<Image> display = new List<Image>();
        Stack<Image> alreadyUsed = new Stack<Image>();
        private int nbWordToFind = 0;
        public ObservableCollection<string> wordsAlreadyValidated { get; set; }
        public ObservableCollection<string> solutions { get; set; }
        public GameMemory()
        {
            wordsAlreadyValidated = new ObservableCollection<string>();
            solutions = new ObservableCollection<string>();
            this.InitializeComponent();
            DataContext = this;
            table = new Table();
            this.player = Player.Instance;
            this.levelNumber = player.level;
            playerNameLabel.Text = player.name;
            nbWordToFind = table.Levels[levelNumber].NbWords;
            refreshLabel();
            display.Add(card0);
            display.Add(card1);
            display.Add(card2);
            display.Add(card3);
            display.Add(card4);
            display.Add(card5);
            display.Add(card6);
            display.Add(card7);
            for(int i = 0; i < table.Levels[levelNumber].Letters.Count; i++)
            {
                display[i].Source = new BitmapImage(new Uri("ms-appx:///Assets/" + table.Levels[levelNumber].Letters[i] + ".png"));       
            }
        }

        // On click event handler of letters
        public void letterClicked(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;
            img.IsTapEnabled = false;
           /* if(!alreadyUsed.Contains(img))
            {*/
            wordLabel.Text += table.Levels[levelNumber].Letters[int.Parse(img.Name.Substring(4, 1))];
            alreadyUsed.Push(img);
            //}
        }

        // Remove the last letter clicked
        public void popLast(object sender, RoutedEventArgs e)
        {
            if(wordLabel.Text.Length > 0)
            {
                wordLabel.Text = wordLabel.Text.Substring(0, wordLabel.Text.Length - 1);

                alreadyUsed.Pop().IsTapEnabled = true;
            }
        }

        // Check if the word is correct, if it is, it add this word to the list of already pushed words
        public void sendWord(object sender, RoutedEventArgs e)
        {
            if(table.Levels[levelNumber].Words.Contains(wordLabel.Text) && !wordsAlreadyValidated.Contains(wordLabel.Text))
            {
                wordsAlreadyValidated.Add(wordLabel.Text);
                nbWordToFind--;
                refreshLabel();
            }
            clearLettersUsed();
            if (nbWordToFind == 0)
            {
                youWin();
            }
        }

        // Refresh the data in the interface, level and words remaining labels 
        private void refreshLabel()
        {
            nbWordsToWinLabel.Text = nbWordToFind.ToString();
            levelLabel.Text = levelNumber.ToString();
        }

        // Show win popup
        private void youWin()
        {
            ShowPopupOffsetClicked();
            nextLevel();
        }

        // Clear the interface data and load the next level
        private void nextLevel()
        {
            if (table.Levels.Count == levelNumber + 1) return;
            levelNumber++;
            player.level++;
            for (int i = 0; i < table.Levels[levelNumber].Letters.Count; i++)
            {
                display[i].Source = new BitmapImage(new Uri("ms-appx:///Assets/" + table.Levels[levelNumber].Letters[i] + ".png"));
            }
            clearLettersUsed();
            wordsAlreadyValidated.Clear();
            solutions.Clear();
            nbWordToFind = table.Levels[levelNumber].NbWords;
            refreshLabel();
        }

        // Clear the stack and re enable letters clicks
        private void clearLettersUsed()
        {
            foreach (Image img in alreadyUsed)
            {
                img.IsTapEnabled = true;
            }
            alreadyUsed.Clear();
            wordLabel.Text = "";
        }

        // To display / mask solution list
        public void SeeSolutions(object sender, RoutedEventArgs e)
        {
            if(solutions.Count == 0)
            {
                foreach (string word in table.Levels[levelNumber].Words)
                {
                    solutions.Add(word);
                }
            } else
            {
                solutions.Clear();
            }
            
        }
        
        // Back button to return to the menu
        public void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }

        // Handles the Click event on the Button inside the Popup control and 
        // closes the Popup. 
        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {
            // if the Popup is open, then close it 
            if (StandardPopup.IsOpen) { StandardPopup.IsOpen = false; }
        }

        // Handles the Click event on the Button on the page and opens the Popup. 
        private void ShowPopupOffsetClicked()
        {
            // open the Popup if it isn't open already 
            if (!StandardPopup.IsOpen) { StandardPopup.IsOpen = true; }
        }
    }
}
