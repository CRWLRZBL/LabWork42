using Microsoft.Win32;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class InkCanvas : Window
    {
        public InkCanvas()
        {
            InitializeComponent();
        }

        private void LoadImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openImage = new();
            openImage.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";

            if (openImage.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage(new Uri(openImage.FileName));
                addImage.Source = bitmap;
            }
        }

        private void LightPink_Click(object sender, RoutedEventArgs e)
        {
            canvas.DefaultDrawingAttributes.Color = Colors.LightPink;
        }

        private void LightBlue_Click(object sender, RoutedEventArgs e)
        {
            canvas.DefaultDrawingAttributes.Color = Colors.LightBlue;
        }

        private void LightCayan_Click(object sender, RoutedEventArgs e)
        {
            canvas.DefaultDrawingAttributes.Color = Colors.LightCyan;
        }

        private void ChangePenColor(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChangeThickness_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeThickness_Click(object sender, RoutedEventArgs e)
        {
            canvas.DefaultDrawingAttributes.Width = 20;
        }

        private void ChangeThickness_Click2(object sender, RoutedEventArgs e)
        {
            canvas.DefaultDrawingAttributes.Width = 10;
        }
    }
}