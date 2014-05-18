﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IRCalc.Src.Model;

namespace IRCalc.Src.Service
{
    class CompoundCalcService: CalcService
    {
        public void InstallmenAmount(Calc calc)
        {
            // C = M / (1 + i) ^ t
            calc.InstallmentAmount = (calc.TotalAmount / Math.Pow(1 + calc.InterestRate, calc.MonthQtd));
        }

        public void InterestRate(Calc calc)
        {
            // i = exp(ln(M / C) / t) - 1
            calc.InterestRate = Math.Exp(Math.Log(calc.TotalAmount / calc.InstallmentAmount) / calc.MonthQtd) - 1;
        }

        public void MonthQtd(Calc calc)
        {
            // t = ln(M / C) / ln(1 + i)
            calc.MonthQtd = Convert.ToInt32(Math.Log(calc.TotalAmount / calc.InstallmentAmount) / Math.Log(1 + calc.InterestRate));
        }

        public void TotalAmount(Calc calc)
        {
            // M = C * (1 + i) ^ t
            calc.TotalAmount = calc.InstallmentAmount * Math.Pow(1 + calc.InterestRate, calc.MonthQtd);
        }
    }
}
