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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void _decimal_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void leftParenth_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "(";
        }

        private void rightParenth_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ")";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "*";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "/";
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "-";
        }

        private void exp_Click(object sender, RoutedEventArgs e)
        {
            //textBox.Text = textBox.Text + "^";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "+";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "=" + calculator.Calculate(textBox.Text);
        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "")
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }
    }
}
