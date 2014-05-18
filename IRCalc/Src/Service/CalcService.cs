using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IRCalc.Src.Model;

namespace IRCalc.Src.Service
{
    interface CalcService
    {
        void InstallmenAmount(Calc calc);

        void InterestRate(Calc calc);

        void MonthQtd(Calc calc);

        void TotalAmount(Calc calc);

    }
}
