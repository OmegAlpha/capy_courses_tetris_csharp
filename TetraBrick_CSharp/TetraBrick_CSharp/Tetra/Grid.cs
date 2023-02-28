namespace TetraBrick_CSharp.Tetra
{
    public class Grid
    {
        public const int CELL_SIZE = 30;

        public GridCell[,] cells;
        
        public Grid(int width, int height, MainWindow mainWindow)
        {
            cells = new GridCell[width, height];
            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    GridCell cell = new GridCell(x, y, CELL_SIZE, mainWindow);
                    cells[x, y] = cell;
                }     
            }
        }
    }
}