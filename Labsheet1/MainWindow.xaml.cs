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

namespace Labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    //Prep
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TxtBtn_Click(object sender, RoutedEventArgs e)
        {
            //read user input
            string numEnt = txtBox.Text;

            //check for valid input - a number
            int num;
            bool isNum = int.TryParse(numEnt, out num);

            if (isNum)
            {
                //convert to number
                int number = Convert.ToInt32(num);

                //check if odd or even
                if (number % 2 == 0)

                //display message
                {
                    txtBlk.Text = "Number is even";
                    txtBlk.Foreground = new SolidColorBrush(Colors.Green);
                }

                else

                    txtBlk.Text = "Number is odd";
                txtBlk.Foreground = new SolidColorBrush(Colors.Red);

               
            }
            else
                txtBlk.Text = "Invalid entry";





        }
    }
}
