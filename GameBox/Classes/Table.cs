using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GameBox.Classes
{
    class Table
    {
        // The list of levels
        private List<Level> levels;       

        public Table()
        {
            this.levels = new List<Level>();
            // Call to parser
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
    }
}
