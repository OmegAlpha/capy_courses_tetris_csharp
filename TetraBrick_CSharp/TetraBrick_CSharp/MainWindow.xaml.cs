using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TetraBrick_CSharp
{
    public partial class MainWindow
    {
        public TetraGame game;

        public MainWindow()
        {
            InitializeComponent();

            game = new TetraGame(this);
            
            game.StartEngine();
        }
    }
}