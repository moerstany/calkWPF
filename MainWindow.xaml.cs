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

namespace CalkinWPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        
       
        private void Start_OnClick_Sum(object sender, RoutedEventArgs e)
        {   double x = Convert.ToDouble(Input1.Text);
            double y = Convert.ToDouble(Input2.Text);

            Otvet1.Content = Convert.ToString(Calculator.Add(x,y));
            
        }


        private void Start_OnClick_Sub(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Input1.Text);
            double y = Convert.ToDouble(Input2.Text);
            
            Otvet1.Content = Convert.ToString(Calculator.Sub(x,y));
        }

        private void Start_OnClick_Mult(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Input1.Text);
            double y = Convert.ToDouble(Input2.Text);
            
            Otvet1.Content = Convert.ToString(Calculator.Mult(x,y));;
        }

        private void Start_OnClick_div(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Input1.Text);
            double y = Convert.ToDouble(Input2.Text);
            
            Otvet1.Content = Convert.ToString(Calculator.Div(x,y));;
        }

        private void Start_OnClick_Pow1(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Input1.Text);
            double y = Convert.ToDouble(Input2.Text);
            
            Otvet1.Content = Convert.ToString(Calculator.Pow1(x,y));
        }

        private void Start_OnClick_Sqrt1(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(Input1.Text);
           
            
            Otvet1.Content = Convert.ToString(Calculator.Sqrt1(x));
        }
    }
}
            
