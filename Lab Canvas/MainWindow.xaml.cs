using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab_Canvas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawCircle(Brushes.White, 400, 50, 50);
        }

        #region DrawCircle
        private void DrawCircle(Brush color, int size, int leftPosition, int topPosition)
        {
            // create circle
            Ellipse circle = new Ellipse();
            circle.Height = size;
            circle.Width = size;
            circle.Fill = color;

            // set position 
            Canvas.SetLeft(circle, leftPosition);
            Canvas.SetTop(circle, topPosition);

            // add circle to canvas
            BackgroundCanvas.Children.Add(circle);
        }
        #endregion

        private void ConcentricCirclesdButton_Click(object sender, RoutedEventArgs e)
        {
            int size = 400;
            int position = 50;
            SolidColorBrush color = Brushes.Black;

            for (int i = 0; i < 10; i++)
            {
                DrawCircle(color, size, position, position);
                size -= 40;
                position += 20;
                color = AlternateColor(color);
            }
        }

        private void OverlappingCircles_Click(object sender, RoutedEventArgs e)
        {
            int size = 400;
            int leftPosition = 50;
            int topPosition = 50;
            SolidColorBrush color = Brushes.Black;

            for (int i = 0; i < 10; i++)
            {
                DrawCircle(color, size, leftPosition, topPosition);
                size -= 40;
                leftPosition += 20;
                topPosition += 40;
                color = AlternateColor(color);
            }
        }

        private SolidColorBrush AlternateColor(SolidColorBrush color)
        {
            if (color == Brushes.Black)
            {
                color = Brushes.White;
            }
            else
            {
                color = Brushes.Black;
            }
            return color;
        }
    }
}
