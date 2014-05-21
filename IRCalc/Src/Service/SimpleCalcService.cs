using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IRCalc.Src.Model;

namespace IRCalc.Src.Service
{
    class SimpleCalcService : CalcService
    {
        public void InitialAmount(Calc calc)
        {
            // C = M / ( 1 + ( i * t ))
            calc.InitialAmount = calc.TotalAmount / (1 + (calc.InterestRate * calc.MonthQtd));
            calc.InstallmentAmount = calc.TotalAmount / calc.MonthQtd;
        }

        public void InterestRate(Calc calc)
        {
            // i = ( M / C - 1 ) / t 
            calc.InterestRate = (calc.TotalAmount / calc.InitialAmount - 1) / calc.MonthQtd;
            calc.InstallmentAmount = calc.TotalAmount / calc.MonthQtd;
        }

        public void MonthQtd(Calc calc)
        {
            // t = ( M / C - 1 ) / i 
            calc.MonthQtd = Convert.ToInt32((calc.TotalAmount / calc.InitialAmount - 1) / calc.InterestRate);
            calc.InstallmentAmount = calc.TotalAmount / calc.MonthQtd;
        }

        public void TotalAmount(Calc calc)
        {
            // M = C * ( 1 + ( i * t ))
            calc.TotalAmount = calc.InitialAmount * (1 + (calc.InterestRate * calc.MonthQtd));
            calc.InstallmentAmount = calc.TotalAmount / calc.MonthQtd;
        }
    }
}
