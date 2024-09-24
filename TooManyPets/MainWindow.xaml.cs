// Author:  Kyle Chapman
// Created: September 17, 2024
// Modified: September 24, 2024
// Description:
//  Attempts to measure whether a user has too many pets or not using
// a super-secret proprietary algorithm. It's so secret I don't know
// what it is as of this writing.

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TooManyPets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor for the form.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            textPeople.Focus();
        }

        #region "Event Handlers"

        /// <summary>
        /// Checks whether the person has too many pets based on the data entered into
        /// several form controls.
        /// </summary>
        private void CheckClick(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Clears all input and output fields to put the form in its initial state.
        /// </summary>
        private void ClearClick(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        #endregion

        // Some kind of algorithm for whether a person has too many pets...
        // adjusted quantity = cats + dogs + birds + sqrt(other) + (if fish 1)
        // if people * 2 >= adjusted quantity it's not too many
        // Sorry for judging.
    }
}