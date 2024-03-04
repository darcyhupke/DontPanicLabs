using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    class CalcController
    {
        private CalcModel aInput;
        private CalcView aView;

        public CalcController()
        {
            aInput = new CalcModel();
            aView = new CalcView();

            aInput.Input1 = aView.GetFirstInput();
            aInput.Input2 = aView.GetSecondInput();
            string oper = aView.GetOperatorOption();
            aView.ShowResult(aInput.CalculateResult(oper));
        }
    }
}
