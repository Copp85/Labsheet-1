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

namespace Exercise_2    
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StBtn_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        public async void Update()
        {
            //generate a random number (1-6)
            Random firstNum = new Random();

            for (int i = 0; i < 20; i++)
            {
                //display on screen
                firstBlk.Text = firstNum.Next(1, 21).ToString();

                await Task.Delay(20);
                
            }


        }

        private void Guessbtn_Click(object sender, RoutedEventArgs e)
        {
            //determine which button was clicked
            
            bool biggerSelected = bigBtn.IsChecked.Equals(true);
            bool smallerSelected = smallRad.IsChecked.Equals(true);

            //print out the second number
            UpdateSec();

            int numOne = Int32.Parse(firstBlk.Text);
            int numTwo = Int32.Parse(secBlk.Text);
            if ((biggerSelected == true) && (numTwo > numOne))
            {
                resBlk.Text = "You win";
            }

            else if ((biggerSelected == true) && (numTwo < numOne))
            {
                resBlk.Text = "You lose";
            }

            else if ((smallerSelected == true) && (numTwo > numOne))
            {
                resBlk.Text = "You lose";
            }
            else
            {
                resBlk.Text = "You win";
            }
        }

        public async void UpdateSec()
        {
            //generate a random number (1-6)
            Random secNum = new Random();

            for (int i = 0; i < 20; i++)
            {
                //display on screen
                secBlk.Text = secNum.Next(1, 21).ToString();

                await Task.Delay(20);
            }


        }

        
    }
}
