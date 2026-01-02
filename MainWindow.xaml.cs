using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRODIGY_SD_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Number;
        int Guesses;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            Number = rnd.Next(1, 101);
            Guesses = 0;

        }

        private void GuessButton_Click(object sender, RoutedEventArgs e)
        {
            int userguess;
            if(!int.TryParse(GuessTextBox.Text,out userguess))
            {
                ResultText.Text = "Enter a Valid Number: ";
                return;
            }

            Guesses++;

            if (userguess > Number)
            {
                ResultText.Text = "Broo that's too High ";
            }

            else if (userguess< Number)
            {
                ResultText.Text = "Just Missed but it's too low";
            }

            else
            {
                ResultText.Text = $"Bravooo You got it right in {Guesses} attempts";
            }
        }
    }
}
