using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IRCalc.Src.Model
{
    class Calc {

        public Calc()
        {
        }

        public Calc(Double installmentAmount, Double interestRate, Int32 monthQtd, Double totalAmount)
        {
            this.InstallmentAmount = installmentAmount;
            this.InterestRate = interestRate;
            this.MonthQtd = monthQtd;
            this.TotalAmount = totalAmount;
        }

        private Double _installmentAmount;

        public Double InstallmentAmount
        {
            get { return _installmentAmount; }
            set { _installmentAmount = value; }
        }

        private Double _interestRate;

        public Double InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        private Int32 _monthQtd;

        public Int32 MonthQtd
        {
            get { return _monthQtd; }
            set { _monthQtd = value; }
        }

        private Double _totalAmount;

        public Double TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
    }
}
