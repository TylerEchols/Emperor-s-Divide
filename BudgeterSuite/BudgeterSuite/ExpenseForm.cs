using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgeterSuite
{
    public partial class ExpenseForm : Form
    {
        Form1 form1;
        public ExpenseForm(Form1 _form1)
        {            
            InitializeComponent();
            Form1 form1 = _form1;
        }

        // Updates expense labels on Form1
        public void UpdateInfo()
        {
            // Will check and print how much the user gets in a paycheck
            double payCheck = 0;
            form1.SetPayDayAmountLabel($"{payCheck:C}");

            // Will check the and print user's total initial expenses
            double expenses = 0;
            form1.SetExpenseLabel($"{expenses:C}");

            // Adds up and prints payouts
            double payOuts = 0;
            for (int i = 0; i < form1.payDay.GetEnvCount(); i++)
            {
                payOuts += form1.payDay.GetPayOut(i);
            }
            form1.SetIntoEnvelopeLabel($"{payOuts:C}");

            // Subtracts expenses and payouts from paycheck to update Payday Balance label
            double balance = payCheck - expenses - payOuts;
            form1.setPayDayBalanceLabel($"{balance:C}");
        }
    }
}
