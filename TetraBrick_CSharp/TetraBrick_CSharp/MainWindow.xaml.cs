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