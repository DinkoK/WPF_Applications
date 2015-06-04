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

namespace WPF_Calculator
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
       
        private void btnDigits_Click(object sender, RoutedEventArgs e)
        {
            bool txtBoxClear = false;
                var digitClick = (Button)e.OriginalSource; 

                int number = 0;
                bool isDigit = false;

                isDigit = int.TryParse(digitClick.Tag.ToString(), out number); 

                if (isDigit)
                {
                    if (txtBoxClear)
                    {
                        txtBoxInput.Text = "";
                        txtBoxClear = false;
                    }
                    txtBoxInput.Text += digitClick.Tag.ToString(); 
                }
                else if (digitClick.Tag.ToString() == ".") 
                {

                    if (txtBoxInput.Text.IndexOf(".") >= 0) 
                    {
                        return;
                    }
                    else
                    {
                        txtBoxInput.Text += ".";
                    }
                }
                else if (digitClick.Tag.ToString() == "C") 
                {
                    txtBoxInput.Text = "";
                }            
        }
    }
}
