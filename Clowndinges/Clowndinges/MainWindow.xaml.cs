using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clowndinges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateDynamicCanvasPanel();
        }

        private void CreateDynamicCanvasPanel()
        {
            // Create a Canvas Panel control
            Canvas canvasPanel = new Canvas();
            // Set Canvas Panel properties
            canvasPanel.Background = new SolidColorBrush(Colors.LightCyan);

            Ellipse hoofd1 = new Ellipse();
            hoofd1.Width = 140;
            hoofd1.Height = 140;
            hoofd1.Stroke = new SolidColorBrush(Colors.Black);
            hoofd1.Fill = new SolidColorBrush(Colors.White);
            Canvas.SetLeft(hoofd1, 60);
            Canvas.SetTop(hoofd1, 60);
            canvasPanel.Children.Add(hoofd1);

           


            // Set Grid Panel as content of the Window
            this.Content = canvasPanel;
        }
    }
}
