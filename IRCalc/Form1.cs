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
using System.Globalization;

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
        private int targetField;
        private int targetService;
        private List<CalcService> services;

        private void modelToView(Calc calc)
        {
            txtInstallmentAmount.Text = calc.InstallmentAmount.ToString("C2");
            txtInterestRate.Text = Convert.ToString(calc.InterestRate * 100);
            txtMonthQtd.Text = Convert.ToString(calc.MonthQtd);
            txtTotalAmount.Text = calc.TotalAmount.ToString("C2");
            this.targetFieldToRadio();
            this.targetServiceToRadio();
            this.updateDataGrid();
        }

        private RadioButton getRadioButtonAt(Control control, int index)
        {
            int count = control.Controls.OfType<RadioButton>().Count() - 1;
            int reverseIndex = count - index;
            return control.Controls.OfType<RadioButton>().ElementAt(reverseIndex);
        }

        private int getSelectedRadioButtonIndex(Control control)
        {
            var checkedRadio = control.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            int reverseIndex = control.Controls.IndexOf(checkedRadio);
            int count = control.Controls.OfType<RadioButton>().Count() - 1;
            int item = count - reverseIndex;
            return item;
        }

        private void targetFieldToRadio()
        {
            var checkedRadio = this.getRadioButtonAt(this.pnTargetRadios, this.targetField);
            checkedRadio.Checked = true;
        }


        private void targetServiceToRadio()
        {
            var checkedRadio = this.getRadioButtonAt(this.gpOptions, this.targetService);
            checkedRadio.Checked = true;
        }

        private void viewToModel(Calc calc)
        {
            calc.InstallmentAmount = txtInstallmentAmount.Text != "" ? Double.Parse(txtInstallmentAmount.Text, NumberStyles.Currency) : 0.00;
            calc.InterestRate = txtInterestRate.Text != "" ? Double.Parse(txtInterestRate.Text, NumberStyles.Float) / 100 : 0.00;
            calc.MonthQtd = txtMonthQtd.Text != "" ? Int32.Parse(txtMonthQtd.Text) : 0;
            calc.TotalAmount = txtTotalAmount.Text != "" ? Double.Parse(txtTotalAmount.Text, NumberStyles.Currency) : 0.00;
            this.radioToTargetField();
            this.radioToTargetService();
        }

        private void radioToTargetField()
        {
            this.targetField = this.getSelectedRadioButtonIndex(this.pnTargetRadios);
        }

        private void radioToTargetService()
        {
            this.targetService = this.getSelectedRadioButtonIndex(this.gpOptions);
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
                Double riseAmount = calc.TotalAmount - calc.InstallmentAmount;
                this.dataGridView1.Rows.Add(calc.MonthQtd, calc.InstallmentAmount, calc.TotalAmount, riseAmount);
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
            this.service = this.services.ElementAt(this.targetService);
            switch (targetField)
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
            this.calc = new Calc(1000.00, 0.01, 12, 0.00);
            this.targetField = 3;

            this.targetService = 1;
            this.services = new List<CalcService>();
            this.services.Add(new SimpleCalcService());
            this.services.Add(new CompoundCalcService());

            this.calcTarget(this.calc);
            this.modelToView(this.calc);
        }

        private void txtCalcField_Leave(object sender, EventArgs e)
        {
            this.prepareAndCalc();
        }

        private void rdTargetService_Click(object sender, EventArgs e)
        {
            this.prepareAndCalc();
        }

    }
}
