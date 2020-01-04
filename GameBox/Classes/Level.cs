using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBox.Classes
{
    // POJO class to Map JSON file to c# object
    public class Level
    {
        public int Id { get; set; }
        public List<string> Letters { get; set; }
        public int NbWords { get; set; }
        public List<string> Words { get; set; }
    }
}
