using GameBox.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace GameBox
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class GameMemory : Page
    {
        private Table table;
        public GameMemory()
        {
            this.InitializeComponent();
            this.table = new Table();
        }

        public void cardClicked(object sender, RoutedEventArgs e)
        {
            ((Image)sender).Source = "../Assets/"+table.deck[sender.name.substring(sender.name.length-1, sender.name.lenght])].content+".png";
        }
    }
}
