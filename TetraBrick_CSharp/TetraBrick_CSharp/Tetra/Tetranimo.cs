using System.Collections.Generic;

namespace TetraBrick_CSharp.Tetra
{
    public class Tetranimo
    {
        // it has an internal grid
        // can move to the sides using input
        // can move down 
        // can rotate left and right
        // can detect collision with walls and other pieces

        private Grid _activeGrid;

        private List<Grid> _rotationGrids;

        public Tetranimo(MainWindow window)
        {
            _activeGrid = new Grid(2, 2, window);
            
            _activeGrid.cells[0, 0].SetBackground(false);
            _activeGrid.cells[1, 0].SetBackground(false);
            _activeGrid.cells[1, 1].SetBackground(false);
        }
    }
}