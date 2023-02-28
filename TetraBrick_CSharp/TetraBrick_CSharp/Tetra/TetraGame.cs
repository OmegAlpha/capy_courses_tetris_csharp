using System;
using System.Threading.Tasks;
using TetraBrick_CSharp;
using TetraBrick_CSharp.Tetra;

public class TetraGame
{
      public const int FRAME_TIME = 16;
      
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
            Grid gameGrid = new Grid(GRID_WIDTH, GRID_HEIGHT, _mainWindow);
            for (int x = 0; x < GRID_WIDTH; x++)
            {
                  for (int y = 0; y < GRID_HEIGHT; y++)
                  {
                        gameGrid.cells[x, y].SetBackground(true);
                  }     
            }

            Tetranimo tetranimo = new Tetranimo(_mainWindow);
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