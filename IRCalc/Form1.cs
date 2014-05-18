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
    public partial class Form1 : Form
    {
        public Form1()
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
            textBox1.Text = Convert.ToString(calc.InstallmentAmount);
            textBox2.Text = Convert.ToString(calc.InterestRate * 100);
            textBox3.Text = Convert.ToString(calc.MonthQtd);
            textBox4.Text = Convert.ToString(calc.TotalAmount);
            targetToRadio();
            updateDataGrid();
        }

        private void targetToRadio()
        {
            var checkedRadio = panel1.Controls.OfType<RadioButton>().ElementAt(reverseTarget(target));
            checkedRadio.Checked = true;
        }

        private void viewToModel(Calc calc)
        {
            calc.InstallmentAmount = textBox1.Text != "" ? Double.Parse(textBox1.Text) : 0.00;
            calc.InterestRate = textBox2.Text != "" ? Double.Parse(textBox2.Text) / 100 : 0.00;
            calc.MonthQtd = textBox3.Text != "" ? Int32.Parse(textBox3.Text) : 0;
            calc.TotalAmount = textBox4.Text != "" ? Double.Parse(textBox4.Text) : 0.00;
            radioToTarget();
        }

        private void radioToTarget()
        {
            var checkedRadio = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            target = reverseTarget(panel1.Controls.IndexOf(checkedRadio));
        }

        private void updateDataGrid()
        {
            int monthQtd = calc.MonthQtd;
            dataGridView1.Rows.Clear();
            for (var i = 1; i >= 1 && i <= monthQtd; i++)
            {
                Calc line = this.calc;
                line.MonthQtd = i;
                this.calcTarget(line);
                dataGridView1.Rows.Add(calc.MonthQtd, calc.InstallmentAmount, calc.TotalAmount);
            }
        }

        private void prepareAndCalc()
        {
            viewToModel(this.calc);
            calcTarget(this.calc);
            modelToView(this.calc);
        }

        private void calcTarget(Calc calc)
        {
            switch (target)
            {
                case 0:
                    service.InstallmenAmount(calc);
                    break;
                case 1:
                    service.InterestRate(calc);
                    break;
                case 2:
                    service.MonthQtd(calc);
                    break;
                case 3:
                    service.TotalAmount(calc);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            target = 3;
            service = new CompoundCalcService();
            calc = new Calc(1000.00, 0.01, 12, 0.00);

            dataGridView1.Columns.Add("month", "i18n.calc.month");
            dataGridView1.Columns.Add("installmentAmount", "i18n.calc.installment");
            dataGridView1.Columns.Add("totalAmount", "i18n.calc.total");

            modelToView(calc);
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            prepareAndCalc();
        }

    }
}
