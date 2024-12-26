using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        /// <summary>
        ///  Starts a new game and clears all values back to the start
        /// </summary>
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
                // Change background, foreground and content to default values
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            //make sure the game hasn't finished
            mGameEnd = false;
        }

        /// <summary>
        /// Handles a button click event
        /// </summary>
        /// <param name="sender">The button that was clicked</param>
        /// <param name="e">The events of the click</param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // Start a new game on the click after it finished
            if (mGameEnd)
            {
                NewGame();
                return;
            }
            // Cast the sender to a button
            var button = (Button)sender;

            // Find the buttons in the array
            var column = Grid.GetColumn(button);
            var row =Grid.GetRow(button);

            var index = column + (row * 3);

            // Don't do anyting if the cell already has a value in it
            if (mResults?[index] != MarkType.Free)
                return;

            // Set the cell value based on which players turn it is
            mResults[index] = mPlayer1Turn ? MarkType.Cross : MarkType.Nought;

            // Set button text to the result
            button.Content = mPlayer1Turn ? "X" : "O";

        }
    }
}