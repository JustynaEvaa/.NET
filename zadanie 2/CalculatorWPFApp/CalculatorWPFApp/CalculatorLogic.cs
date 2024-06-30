using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPFApp {
    internal class CalculatorLogic : INotifyPropertyChanged {
        private double?
            leftOperand = null,
            rightOperand = null;

        private string? operation = null;
        private string showNumber = "0";
        private bool operationFlag;

        public string ShowOperation {
            get {
                if (leftOperand == null)
                    return "";
                else if (operation == null)
                    return $"{leftOperand}";
                else if (rightOperand == null)
                    return $"{leftOperand} {operation}";
                else
                    return $"{leftOperand} {operation} {rightOperand} =";
            }
        }
        public string ShowNumber {
            get => showNumber;
            set {
                showNumber = value;
                PropertyChanged?.Invoke(this, new("ShowNumber"));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        internal void AddComma() {
            if (operationFlag)
                DeleteEverything();
            if (ShowNumber.Contains(","))
                return;
            else
                ShowNumber += ",";
        }

        internal void ChangeSign() {
            if (operationFlag)
                DeleteEverything();
            if (ShowNumber == "0")
                return;
            else if (ShowNumber[0] == '-')
                ShowNumber = ShowNumber.Substring(1);
            else
                ShowNumber = "-" + ShowNumber;
        }

        internal void DeleteDigit() {
            if (operationFlag)
                DeleteEverything();

            if (ShowNumber.Length == 1 || ShowNumber == "-0,")
                ShowNumber = "0";
            else
                ShowNumber = ShowNumber.Substring(0, ShowNumber.Length - 1);
        }

        internal void DeleteEverything() {
            operationFlag = false;
            DeleteWholeNumber();
            leftOperand = rightOperand = null;
            operation = null;
            PropertyChanged?.Invoke(this, new("ShowOperation"));
        }

        internal void DeleteWholeNumber() {
            if (operationFlag)
                DeleteEverything();
            ShowNumber = "0";
        }

        internal void EnterNumber(string? number) {
            if (operationFlag)
                DeleteEverything();

            if (ShowNumber == "0")
                ShowNumber = number;
            else
                ShowNumber += number;
        }

        internal void EnterTwoArgumentAction(string? action) {
            if (operationFlag) {
                rightOperand = null;
                operationFlag = false;
            }
            else if (operation == null)
                leftOperand = Convert.ToDouble(ShowNumber);
            else {
                MakeOperation();
                rightOperand = null;
                operationFlag = false;
            }
            operation = action;
            PropertyChanged?.Invoke(this, new("ShowOperation"));
            showNumber = "0";
        }

        internal void MakeOperation() {
            if (rightOperand == null)
                if (showNumber == "0")
                    rightOperand = leftOperand;
                else
                    rightOperand = Convert.ToDouble(ShowNumber);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ShowOperation"));

            switch (operation) {
                case "+":
                    ShowNumber = $"{leftOperand + rightOperand}";
                    break;
                case "-":
                    ShowNumber = $"{leftOperand - rightOperand}";
                    break;
                case "×":
                    ShowNumber = $"{leftOperand * rightOperand}";
                    break;
                case "÷":
                    ShowNumber = rightOperand != 0 ? $"{leftOperand / rightOperand}" : "0";
                    break;
                case "^":
                    ShowNumber = $"{Math.Pow((double)leftOperand, (double)rightOperand)}";
                    break;
                case "mod":
                    ShowNumber = rightOperand != 0 ? $"{leftOperand % rightOperand}" : "0";
                    break;
                default:
                    break;
            }
            leftOperand = Convert.ToDouble(ShowNumber);
            operationFlag = true;
        }

        internal void PerformSingleArgumentAction(object action) {
            double number = Convert.ToDouble(ShowNumber);
            switch (action) {
                case "1/x":
                    ShowNumber = $"{1 / number}";
                    break;
                case "x²":
                    ShowNumber = $"{number * number}";
                    break;
                case "√x":
                    ShowNumber = $"{Math.Sqrt(number)}";
                    break;
                case "log":
                    ShowNumber = $"{Math.Log10(number)}";
                    break;
                case "ln":
                    ShowNumber = $"{Math.Log(number)}";
                    break;
                case "x!":
                    ShowNumber = $"{Factorial((int)number)}";
                    break;
                case "↓":
                    ShowNumber = $"{Math.Floor(number)}";
                    break;
                case "↑":
                    ShowNumber = $"{Math.Ceiling(number)}";
                    break;
                default:
                    break;
            }
            operationFlag = true;
        }

        private double Factorial(int number) {
            if (number < 0)
                return 0;
            if (number == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= number; i++)
                result *= i;
            return result;
        }
    }
}
