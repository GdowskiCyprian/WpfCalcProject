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

namespace WPFCalcProject
{
    
    
    public partial class MainWindow : Window
    {
        OperationHandler operationHandler = new OperationHandler();
        String number = "";
        
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void percent_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = (Double.Parse(number) * 100).ToString() + "%";
        }

        private void ce_Click(object sender, RoutedEventArgs e)
        {
            number = "";
            operationHandler.number1 = 0;
            operationHandler.number2 = 0;
            operationHandler.char1 = '_';
            textBlock.Text = number;
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            number = "";
            textBlock.Text = number;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
                number = number.Substring(0, number.Length - 1);
            textBlock.Text = number;
        }

        private void inverse_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
                number = (1 / Double.Parse(number)).ToString();
            textBlock.Text = number;
        }

        private void power2_Click(object sender, RoutedEventArgs e)
        {
            if(number!="")
                number = (Double.Parse(number) * Double.Parse(number)).ToString();
            textBlock.Text = number;
        }

        private void sqrt_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
                number = (Math.Sqrt(Double.Parse(number))).ToString();
            textBlock.Text = number;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
            {
                operationHandler.number1 = Double.Parse(number);
                operationHandler.char1 = '/';
                textBlock.Text = "/";
                number = "";
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            number += "7";
            textBlock.Text = number;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            number += "8";
            textBlock.Text = number;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            number += "9";
            textBlock.Text = number;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if(number != ""){
                operationHandler.number1 = Double.Parse(number);
                operationHandler.char1 = '*';
                textBlock.Text = "*";
                number = "";
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            number += "4";
            textBlock.Text = number;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            number += "5";
            textBlock.Text = number;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            number += "6";
            textBlock.Text = number;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
            {
                operationHandler.number1 = Double.Parse(number);
                operationHandler.char1 = '-';
                textBlock.Text = "-";
                number = "";
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            number += "1";
            textBlock.Text = number;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            number += "2";
            textBlock.Text = number;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            number += "3";
            textBlock.Text = number;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
            {
                operationHandler.number1 = Double.Parse(number);
                operationHandler.char1 = '+';
                textBlock.Text = "+";
                number = "";
            }
        }

        private void plusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
                if (number.Substring(0,1) == "-")
            {
                number = number.Substring(1, number.Length - 1);
                textBlock.Text = number;
            }
            else
            {
                number = "-" + number;
                textBlock.Text = number;
            }
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        { 
            if(number != "0" && number != "")
            {
                number += "0";
                textBlock.Text = number;
            }
            
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            Boolean isDot = false;
            for(int i=0; i < number.Length; i++)
            {
                if(number[i] == '.')
                {
                    isDot = true;
                }
            }
            if (isDot == false)
            {
                if (number != "")
                {
                    if (number.Substring(number.Length - 1, 1) != ".")
                    {
                        number += ".";
                        textBlock.Text = number;
                    }
                }
                else
                {
                    number += "0.";
                    textBlock.Text = number;
                }
            }
            
            
            
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {   if (number != "")
            {
                operationHandler.number2 = Double.Parse(number);
                textBlock.Text = operationHandler.operation().ToString();
                number = operationHandler.operation().ToString();
                operationHandler.number1 = 0;
                operationHandler.number2 = 0;
                operationHandler.char1 = '_';
            }
        }
    }
}
