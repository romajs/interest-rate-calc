using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IRCalc.Src.Model;
using IRCalc.Src.Service;

namespace IRCalc
{
    public partial class IRCalcForm : Form
    {
        public IRCalcForm()
        {
            InitializeComponent();
        }

        private Calc calc;
        private CalcService service;
        private int target;

        private int reverseTarget(int value)
        {
            return 3 - value;
        }

        private void modelToView(Calc calc)
        {
            txtInstallmentAmount.Text = Convert.ToString(calc.InstallmentAmount);
            txtInterestRate.Text = Convert.ToString(calc.InterestRate * 100);
            txtMonthQtd.Text = Convert.ToString(calc.MonthQtd);
            txtTotalAmount.Text = Convert.ToString(calc.TotalAmount);
            this.targetToRadio();
            this.updateDataGrid();
        }

        private void targetToRadio()
        {
            var checkedRadio = pnTargetRadios.Controls.OfType<RadioButton>().ElementAt(reverseTarget(this.target));
            checkedRadio.Checked = true;
        }

        private void viewToModel(Calc calc)
        {
            calc.InstallmentAmount = txtInstallmentAmount.Text != "" ? Double.Parse(txtInstallmentAmount.Text) : 0.00;
            calc.InterestRate = txtInterestRate.Text != "" ? Double.Parse(txtInterestRate.Text) / 100 : 0.00;
            calc.MonthQtd = txtMonthQtd.Text != "" ? Int32.Parse(txtMonthQtd.Text) : 0;
            calc.TotalAmount = txtTotalAmount.Text != "" ? Double.Parse(txtTotalAmount.Text) : 0.00;
            this.radioToTarget();
        }

        private void radioToTarget()
        {
            var checkedRadio = pnTargetRadios.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            this.target = reverseTarget(pnTargetRadios.Controls.IndexOf(checkedRadio));
        }

        private void updateDataGrid()
        {
            int monthQtd = calc.MonthQtd;
            this.dataGridView1.Rows.Clear();
            for (var i = 1; i >= 1 && i <= monthQtd; i++)
            {
                Calc line = this.calc;
                line.MonthQtd = i;
                this.calcTarget(line);
                this.dataGridView1.Rows.Add(calc.MonthQtd, calc.InstallmentAmount, calc.TotalAmount);
            }
        }

        private void prepareAndCalc()
        {
            this.viewToModel(this.calc);
            this.calcTarget(this.calc);
            this.modelToView(this.calc);
        }

        private void calcTarget(Calc calc)
        {
            switch (target)
            {
                case 0:
                    this.service.InstallmenAmount(calc);
                    break;
                case 1:
                    this.service.InterestRate(calc);
                    break;
                case 2:
                    this.service.MonthQtd(calc);
                    break;
                case 3:
                    this.service.TotalAmount(calc);
                    break;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.target = 3;
            this.service = new CompoundCalcService();
            this.calc = new Calc(1000.00, 0.01, 12, 0.00);

            this.modelToView(this.calc);
            this.calcTarget(this.calc);
        }

        private void txtCalcField_Leave(object sender, EventArgs e)
        {
            this.prepareAndCalc();
        }

    }
}
