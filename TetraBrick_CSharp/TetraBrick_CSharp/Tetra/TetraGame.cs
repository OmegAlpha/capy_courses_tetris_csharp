using System;
using System.Threading.Tasks;

public class TetraGame
{
      public const int FRAME_TIME = 16;
      
      // Grilla de fondo 
      // Piezas
      // Input del jugador (teclado)
      // timer 
      // Sonido
      // Graficos
      
      public TetraGame()
      {
            Console.WriteLine("Creating Tetra Game");

            GameLoop();
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