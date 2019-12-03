using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace GameBox
{
    class Card
    {
        private string content;
        private bool isHidden = true;
        private bool hasBeenLocated = false;
        private Image img;

        public Card (string content, Image img)
        {
            this.content = content;
            this.img = img;
        }

        public string Content
        {
            get => this.content;
            set => this.content = value;
        }
        public bool IsHidden
        {
            get => this.isHidden;
            set => this.isHidden = value;
        }
        public bool HasBeenLocated
        {
            get => this.hasBeenLocated;
            set => this.hasBeenLocated = value;
        }
    }
}
