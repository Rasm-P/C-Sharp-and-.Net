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

namespace WPF_based_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack<String> chars = new Stack<String>();
        String text;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("1");
            text += "1";
            textbox.Text = text;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("2");
            text += "2";
            textbox.Text = text;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("3");
            text += "3";
            textbox.Text = text;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("4");
            text += "4";
            textbox.Text = text;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("5");
            text += "5";
            textbox.Text = text;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("6");
            text += "6";
            textbox.Text = text;
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("7");
            text += "7";
            textbox.Text = text;
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("8");
            text += "8";
            textbox.Text = text;
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("9");
            text += "9";
            textbox.Text = text;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("+");
            text += "+";
            textbox.Text = text;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("*");
            text += "*";
            textbox.Text = text;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("-");
            text += "-";
            textbox.Text = text;
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            chars.Push("/");
            text += "/";
            textbox.Text = text;
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text = calculate(chars).ToString();
            text = "";
        }

        private double calculate(Stack<string> chars)
        {
            //Pops the first off and tries to parse it
            String c = chars.Pop();
            double n1;
            double n2;

            //Id we cant parse the string as a double, is is probably a sign.
            if (!double.TryParse(c, out n1))
            {
                //If we parse succesfully, we will call the metod recursively, and use the next numbers that we can pop from the stack to calculate.
                n1 = calculate(chars);
                n2 = calculate(chars);

                //Each case for our sign c.
                if (c=="+")
                {
                    n1 += n2;
                }
                else if (c == "-")
                {
                    n1 -= n2;
                }
                else if (c == "*")
                {
                    n1 *= n2;
                }
                else if (c == "/")
                {
                    n1 /= n2;
                }
            }
            return n1;
        }
    }
}
