﻿using System;
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

namespace Ex_8
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

        

        private void Guess_Click(object sender, RoutedEventArgs e)
        {
            //determine which button was clicked

            bool oddSelected = oddBtn.IsChecked.Equals(true);
            bool evenSelected = EvenBtn.IsChecked.Equals(true);

           
            }
        }

        
        }
    }
}
