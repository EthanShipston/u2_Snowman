using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Program_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Canvas myCanvas = new Canvas();
            SolidColorBrush mySolidColourBrush = new SolidColorBrush();
            mySolidColourBrush.Color = Color.FromArgb(0, 0, 0, 0);
            int counter = 50;
            for (int i = 0; i < 3; ++i)
            {
                int heightCounter = counter * i;
                Ellipse ellipse = new Ellipse();
                Canvas.SetLeft(ellipse, 100 - 25 * i);
                Canvas.SetTop(ellipse, heightCounter);
                ellipse.Fill = mySolidColourBrush;
                ellipse.StrokeThickness = 2;
                ellipse.Stroke = Brushes.Black;
                ellipse.Width = 50 + 50 * i;
                ellipse.Height = 50 + 50 * i;
                myCanvas.Children.Add(ellipse);
                this.Content = myCanvas;
                counter = (counter + counter);
            }
        }
    }
}
