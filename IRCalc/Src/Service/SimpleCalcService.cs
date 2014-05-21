using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IRCalc.Src.Model;

namespace IRCalc.Src.Service
{
    class SimpleCalcService : CalcService
    {
        public void InstallmenAmount(Calc calc)
        {
            // C = M / ( 1 + ( i * t ))
            calc.InstallmentAmount = calc.TotalAmount / ( 1 + (calc.InterestRate * calc.MonthQtd) );
        }

        public void InterestRate(Calc calc)
        {
            // i = ( M / C - 1 ) / t 
            calc.InterestRate = (calc.TotalAmount / calc.InstallmentAmount - 1) / calc.MonthQtd;
        }

        public void MonthQtd(Calc calc)
        {
            // t = ( M / C - 1 ) / i 
            calc.MonthQtd = Convert.ToInt32((calc.TotalAmount / calc.InstallmentAmount - 1) / calc.InterestRate);
        }

        public void TotalAmount(Calc calc)
        {
            // M = C * ( 1 + ( i * t ))
            calc.TotalAmount = calc.InstallmentAmount * ( 1 + (calc.InterestRate * calc.MonthQtd) );
        }
    }
}
