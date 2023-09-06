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

namespace Assignment4._1
{
    public partial class MainWindow : Window
    {
        #region MainWindow Constructor
        public MainWindow()
        {
            Math thisMath = new Math();
            DataContext = this;
            InitializeComponent();
        }
        #endregion MainWindow Constructor

        #region Data Field / Properties
        private double _x;
        private double _y;
        public double Result;

        public double X
        {
            get => _x; set => _x = value;
        }

        public double Y
        {
            get => _y; set => _y = value;
        }
        #endregion DataField / Properties

        private void On_Add_Click(object sender, RoutedEventArgs e)
        {
            runningCount.Clear();
            Result = X + Y;
            MessageBoxResult response = MessageBox.Show($"The answer is {Result}.", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            if (response == MessageBoxResult.OK)
            {
                X = 0;
                Y = 0;
            }
        }

        private void On_Subtract_Click(object sender, RoutedEventArgs e)
        {
            runningCount.Clear();
            Result = X - Y;
            MessageBoxResult response = MessageBox.Show($"The answer is {Result}.", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            if (response == MessageBoxResult.OK)
            {
                X = 0;
                Y = 0;
            }
        }

        private void On_Multiply_Click(object sender, RoutedEventArgs e)
        {
            runningCount.Clear();
            Result = X * Y;
            MessageBoxResult response = MessageBox.Show($"The answer is {Result}.", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            if (response == MessageBoxResult.OK)
            {
                X = 0;
                Y = 0;
            }
        }

        private void On_Divide_Click(object sender, RoutedEventArgs e)
        {
            runningCount.Clear();
            Result = X / Y;
            MessageBoxResult response = MessageBox.Show($"The answer is {Result}.", "Answer", MessageBoxButton.OK, MessageBoxImage.Information);
            if (response == MessageBoxResult.OK)
            {
                X = 0;
                Y = 0;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(runningCount.Text)) 
            {
                caPlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                caPlaceHolder.Visibility = Visibility.Hidden;
            }
        }

        private void runningCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Y = Convert.ToDouble(runningCount.Text);
            }
        }

        private void On_Assign_X(object sender, RoutedEventArgs e)
        {
            X = Convert.ToDouble(runningCount.Text);
        }

        private void On_Assign_Y(object sender, RoutedEventArgs e)
        {
            Y = Convert.ToDouble(runningCount.Text);
        }

        private void On_ClearXY(object sender, RoutedEventArgs e)
        {
            X = 0;
            Y = 0;
        }
    }

    #region Interface
    public interface ICalculator
    {
        double Multiply(double x, double y);
        double Divide(double x, double y);
        double Subtract(double x, double y);
        double Add(double x, double y);
    }
    #endregion Interface

    #region Math Class
    public class Math : ICalculator
    {
        public double Multiply (double x, double y)
        {
            double result;
            result = x * y;
            return result;
        }

        public double Divide(double x, double y)
        {
            double result1;
            result1 = x / y;
            return result1;
        }
        public double Subtract(double x, double y)
        {
            double result2;
            result2 = x - y;
            return result2;
        }
        public double Add(double x, double y)
        {
            double result3;
            result3 = x + y;
            return result3;
        }
    }
    #endregion Math Class

}
