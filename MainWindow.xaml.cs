using System.Windows;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members
        /// <summary>
        /// Holds the curent results of cells in the active game
        /// </summary>
        private MarkType[]? mResults;

        /// <summary>
        /// True if it is player 1's turn (x) or player 2's turn (0)
        /// </summary>
        private bool mPlayer1Turn;
        /// <summary>
        /// Tru if the game has ended
        /// </summary>
        private bool mGameEnd;


        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

        }


        #endregion
        private void NewGame()
        {

        }

    }
}