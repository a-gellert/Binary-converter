using Newton.Classes;
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

namespace Newton
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void find_radical(object sender, RoutedEventArgs e)
        {
            string radicand = textBox.Text;
            string index = textBox1.Text;
            string accuracy = textBox2.Text;
            double result;

            result = NewtonClass.FindRadical(radicand, index, accuracy);

            textBox3.Text = result.ToString();
        }

        public static void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        private void check_values(object sender, RoutedEventArgs e)
        {
            string radical = textBox3.Text;
            string index = textBox1.Text;

            double result;
            result = CheckValues.Checking(radical, index);

            textBox4.Text = result.ToString();
        }
    }
}
