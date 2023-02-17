using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TetraBrick_CSharp;

public class TetraGame
{
      public const int FRAME_TIME = 16;
      public const int CELL_SIZE = 30;
      public const int GRID_HEIGHT = 20;
      public const int GRID_WIDTH = 10;
      
      // Grilla de fondo 
      // Piezas
      // Input del jugador (teclado)
      // timer 
      // Sonido
      // Graficos

      private MainWindow _mainWindow;
      
      public TetraGame(MainWindow mainWindow)
      {
            Console.WriteLine("Creating Tetra Game");
            _mainWindow = mainWindow;
            
            Initialize();
      }

      public void StartEngine()
      {
            Console.WriteLine("Tetra Game Starting Game");
            
            GameLoop();
      }

      private void Initialize()
      {
            Console.WriteLine("Initializing Tetra Game");
            
            for (int y = 0; y < GRID_HEIGHT; y++)
            {
                  for (int x = 0; x < GRID_WIDTH; x++)
                  { 
                        Image imgBGCell = new Image();
                        imgBGCell.Width = CELL_SIZE;
                        imgBGCell.Height = CELL_SIZE;
                        imgBGCell.Source = new BitmapImage(new Uri("Assets/woooo.png", UriKind.Relative ));

                        _mainWindow.GameCanvas.Children.Add(imgBGCell);
                  
                        Canvas.SetLeft(imgBGCell, x * CELL_SIZE);
                        Canvas.SetTop(imgBGCell, y * CELL_SIZE);
                  }     
            }
      }

      private async Task GameLoop()
      {
            while (true)
            {
                  await Task.Delay(FRAME_TIME);
                  
                  // Execute Game Logic
                  // Keyboard Input
                  // Draw Graphics
            }
      }
}