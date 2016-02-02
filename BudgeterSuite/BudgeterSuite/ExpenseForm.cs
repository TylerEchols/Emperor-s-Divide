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
        double payCheck = 0;
        Expense[] expenses = new Expense[16];
        int expenseCount = 0; // Sits at next open index for expenses[]
        Form1 form1;

        // Constructor
        public ExpenseForm(Form1 _form1)
        {            
            InitializeComponent();
            Form1 form1 = _form1;
        }        

        // Takes user input from TextBoxes into expenses[]
        // // Really could use some error handling here
        public void PopulateExpenses()
        {
            expenseCount = 0;

        }

        // Updates expense labels on Form1
        public void UpdateForm1Info()
        {
            // Will check and print how much the user gets in a paycheck
            payCheck = double.Parse(PayCheckBox.Text());
            form1.SetPayDayAmountLabel($"{payCheck:C}");

            // Will check the and print user's total initial expenses
            double totalExpenses = 0;
            for (int i = 0; i <= expenseCount; i++)
            {
                totalExpenses += expenses[i].GetCost();
            }
            form1.SetExpenseLabel($"{totalExpenses:C}");

            // Adds up and prints payouts
            double payOuts = 0;
            for (int i = 0; i < form1.payDay.GetEnvCount(); i++)
            {
                payOuts += form1.payDay.GetPayOut(i);
            }
            form1.SetIntoEnvelopeLabel($"{payOuts:C}");

            // Subtracts expenses and payouts from paycheck to update Payday Balance label
            double balance = payCheck - totalExpenses - payOuts;
            form1.setPayDayBalanceLabel($"{balance:C}");
        }

        // Getters and Setters
        public double GetPayCheck() { return payCheck; }
        public Expense[] GetExpenses() { return expenses; }
        public int GetExpenseCount() { return expenseCount; }
        public Expense GetExpense(int id)
        {
            return expenses[id];
        }

        public void SetPayCheck(double _payCheck)
        {
            payCheck = _payCheck;
        }
        public void SetExpense(Expense exp, int id)
        {
            expenses[id] = exp;
        }      
    }
}
