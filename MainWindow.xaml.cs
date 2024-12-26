using System.Windows;
using System.Windows.Controls;

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

        {   //Create a new blank array of free cells
            mResults = new MarkType[9];

            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;

            // Make sure Player 1 starts the game
            mPlayer1Turn = true;

            // Interate every button on the grid...
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {

            }
            );
        }

    }
}