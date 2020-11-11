using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutGrid
{
    public partial class MainPage : ContentPage
    {
        int currentState = 1;

        string mathOperator;

        double firstNumber;

        double secondNumber;

        public MainPage()
        {
            InitializeComponent();

            OnClear(new object(), new EventArgs());
        }

        void OnClear(object sender, EventArgs e)
        {
            firstNumber = 0;

            secondNumber = 0;
            
            currentState = 1;
            
            labelResultado.Text = "0";
        }

        void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = sender as Button;

            string pressed = button.Text;

            if (labelResultado.Text.Equals("0") || currentState < 0)
            {
                labelResultado.Text = string.Empty;

                if (currentState < 0)
                {
                    currentState *= -1;
                }
            }

            labelResultado.Text += pressed;

            double number;

            if(double.TryParse(labelResultado.Text, out number))
            {
                labelResultado.Text = number.ToString("N0");

                if(currentState == 1)
                {
                    firstNumber = number;
                }
                else
                {
                    secondNumber = number;
                }
            }
        }

        void OnSelectOperator(object sender, EventArgs e)
        {
            currentState = -2;

            Button button = sender as Button;

            string pressed = button.Text;

            mathOperator = pressed;
        }

        void OnCalculate(object sender, EventArgs e)
        {
            if(currentState == 2)
            {
                double result = 0;

                switch (mathOperator)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;

                    case "-":
                        result = firstNumber - secondNumber;
                        break;

                    case "X":
                        result = firstNumber * secondNumber;
                        break;

                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                }

                labelResultado.Text = result.ToString();

                firstNumber = result;

                currentState = -1;
            }
        }
    }
}
