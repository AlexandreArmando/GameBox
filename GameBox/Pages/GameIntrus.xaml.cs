using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace GameBox
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class GameIntrus : Page
    {
        private Image img;
        private bool win = false;
        public GameIntrus()
        {
            this.InitializeComponent();
            init();
        }

        private void init()
        {
            // Creation rectangle rouge qui sera l’objet de l’animation 
            Rectangle myRectangle = new Rectangle();
            myRectangle.Width = 200;
            myRectangle.Height = 200;
            Color myColor = Color.FromArgb(255, 255, 0, 0);
            SolidColorBrush myBrush = new SolidColorBrush();
            myBrush.Color = myColor;
            myRectangle.Fill = myBrush;
            // Init transform 
            TranslateTransform moveTransform = new TranslateTransform();
            moveTransform.X = 0;
            moveTransform.Y = 0;
            myRectangle.RenderTransform = moveTransform;
            // Add to the view
            LayoutRoot.Children.Add(myRectangle);
            // Event duration 2 secondes. 
            Duration duration = new Duration(TimeSpan.FromSeconds(2));
            
        }

        private void Run_Animation(object sender, RoutedEventArgs e)
        {
            myStoryBoard.Begin();
        }
    }
    
}
