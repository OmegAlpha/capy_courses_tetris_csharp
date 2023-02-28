using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TetraBrick_CSharp.Tetra
{
    public class GridCell
    {
        private Image _image;
        
        public GridCell(int x, int y, double size, MainWindow window)
        {
            _image = new Image();
            _image.Width = size;
            _image.Height = size;

            window.GameCanvas.Children.Add(_image);
                    
            Canvas.SetLeft(_image, x * size);
            Canvas.SetTop(_image, y * size);
        }

        public void SetBackground(bool isBackground)
        {
            string imageUri = isBackground ? "Assets/TileEmptyBG.png" : "Assets/woooo.png";

            _image.Source = new BitmapImage(new Uri(imageUri, UriKind.Relative ));
        }
    }
}