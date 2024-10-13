using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public  class Calculator_Presenter
    {
        private readonly Calculator_Mod _model;
        private readonly ICalculator_View _view;
        private double _firstnumber;
        private double _secondnumber;
        private string _operation;
        private bool _isSecondNumber;

        public Calculator_Presenter(ICalculator_View view, Calculator_Mod model)
        {
            _view = view;
            _model = model;

            _view.Number_button += OnNumberButtonClicked;
            _view.Operation += OnOperationButtonClicked;
            _view.Calculate += OnEqualsButtonClicked;
            _view.Clear += OnClearButtonClicked;

            _view.DisplayText = "0";
        }

        private void OnNumberButtonClicked(object sender, string number)
        {
            if (_view.DisplayText == "0" || (_isSecondNumber && _view.DisplayText == _firstnumber.ToString()))
            {
                _view.DisplayText = number;
            }
            else
            {
                _view.DisplayText += number;
            }
        }

        private void OnOperationButtonClicked(object sender, string operation)
        {
            _firstnumber = double.Parse(_view.DisplayText);
            _operation = operation;
            _isSecondNumber = true;
        }

        private void OnEqualsButtonClicked(object sender, EventArgs e)
        {
            _secondnumber = double.Parse(_view.DisplayText);
            double result = 0;

            try
            {
                switch (_operation)
                {
                    case "+":
                        result = _model.Add (_firstnumber, _secondnumber);
                        break;
                    case "-":
                        result = _model.Minus(_firstnumber, _secondnumber);
                        break;
                    case "*":
                        result = _model.Multiply(_firstnumber, _secondnumber);
                        break;
                    case "/":
                        if(_secondnumber!=0)
                        result = _model.Divivde(_firstnumber, _secondnumber);
                        else
                            throw new DivideByZeroException("Нельзя делить на ноль");
                        break;
                    default:
                        throw new InvalidOperationException("Unknown operation");
                }

                _view.DisplayText = result.ToString();
            }
            catch (Exception ex)
            {
                _view.DisplayText = $"Error: {ex.Message}";
            }

            _isSecondNumber = false;
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            _view.DisplayText = "0";
            _firstnumber = 0;
            _secondnumber = 0;
            _operation = string.Empty;
            _isSecondNumber = false;
        }
    }
    
}
