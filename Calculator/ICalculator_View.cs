using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator_View
    {
        string DisplayText { get; set; }
        event EventHandler Calculate;
        event EventHandler Clear;
        event EventHandler<string> Operation;
        event EventHandler<string> Number_button;
    }
}
