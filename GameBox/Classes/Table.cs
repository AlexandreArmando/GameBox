using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameBox.Classes
{
    class Table
    {
        private List<Level> levels;       

        public Table()
        {
            this.levels = new List<Level>();
            loadJson();

        }

        // Load and deserialize levels from JSON file in the Assets folder
        public void loadJson()
        {
            using (StreamReader r = File.OpenText("Assets/levels.json"))
            {
                string json = r.ReadToEnd();
                this.levels = JsonConvert.DeserializeObject<List<Level>>(json);
            }
        }

        public List<Level> Levels
        {
            get => levels;
            set => levels = value;
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
