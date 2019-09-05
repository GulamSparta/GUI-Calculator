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
using Calculator;

namespace Calculator
{
    
    /// <summary>
    /// 
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double number1 = Convert.ToDouble(ValueBoxOne.Text), number2 = Convert.ToDouble(number1);
            Calculator c = new Calculator();
            if (Steve.Text == "Add")
            {
                MessageBox.Show("Result is " + c.Add(number1, number2));
            }
        }

        private void test(object sender, StylusDownEventArgs e)
        {

        }

        private void Main(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button has recieved focus");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
