using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBox.Classes
{
    public class Player
    {
        private static readonly Player instance = new Player();
        public string name = "";
        public int level = 0;

        private Player()
        {
        }

        //Singleton
        public static Player Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
