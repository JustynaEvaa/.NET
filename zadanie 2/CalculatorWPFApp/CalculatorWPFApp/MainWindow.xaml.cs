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
using static System.Collections.Specialized.BitVector32;

namespace CalculatorWPFApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        CalculatorLogic calculatorLogic { get; } = new();
        public MainWindow() {
            DataContext = calculatorLogic;
            InitializeComponent();
        }

        private void Number(object sender, RoutedEventArgs e) {

            string number = (sender as Button).Content.ToString();
            calculatorLogic.EnterNumber(number);

        }

        private void Sign(object sender, RoutedEventArgs e)
            => calculatorLogic.ChangeSign();

        private void Comma(object sender, RoutedEventArgs e)
            => calculatorLogic.AddComma();

        private void DeleteDigit(object sender, RoutedEventArgs e)
            => calculatorLogic.DeleteDigit();

        private void DeleteWholeNumber(object sender, RoutedEventArgs e)
            => calculatorLogic.DeleteWholeNumber();

        private void DeleteEverything(object sender, RoutedEventArgs e)
            => calculatorLogic.DeleteEverything();

        private void TwoArgumentAction(object sender, RoutedEventArgs e) {
            string action = (sender as Button).Content.ToString();
            calculatorLogic.EnterTwoArgumentAction(action);
        }

        private void MakeOperation(object sender, RoutedEventArgs e)
            => calculatorLogic.MakeOperation();

        private void SingleArgumentAction(object sender, RoutedEventArgs e) {
            string action = (sender as Button).Content.ToString();
            calculatorLogic.PerformSingleArgumentAction(action);
        }
           
    }
}
