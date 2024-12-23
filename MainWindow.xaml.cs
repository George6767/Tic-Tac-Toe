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
            throw new NotImplementedException();
        }

    }
}