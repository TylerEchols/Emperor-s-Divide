// Need to find a way to recover expenses. Possibly by loading
// them from the save file between commits, while still editing expenses

// Also need to link this expense page to the Save/Load file functions

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
        const int EXPENSE_MAX = 15;
        Expense[] expenses = new Expense[EXPENSE_MAX];
        TextBox[] nameBoxes = new TextBox[EXPENSE_MAX];
        TextBox[] costBoxes = new TextBox[EXPENSE_MAX];
        Form1 form1;

        // Constructor
        public ExpenseForm(Form1 _form1)
        {            
            InitializeComponent();
            form1 = _form1;
            PopulateNameBoxes();
            PopulateCostBoxes();
            InitializeExpenses();
        }        

        // Puts expNameBoxes into nameBoxes[]
        private void PopulateNameBoxes()
        {
            nameBoxes[0] = expNameBox1;
            nameBoxes[1] = expNameBox2;
            nameBoxes[2] = expNameBox3;
            nameBoxes[3] = expNameBox4;
            nameBoxes[4] = expNameBox5;

            nameBoxes[5] = expNameBox6;
            nameBoxes[6] = expNameBox7;
            nameBoxes[7] = expNameBox8;
            nameBoxes[8] = expNameBox9;
            nameBoxes[9] = expNameBox10;

            nameBoxes[10] = expNameBox11;
            nameBoxes[11] = expNameBox12;
            nameBoxes[12] = expNameBox13;
            nameBoxes[13] = expNameBox14;
            nameBoxes[14] = expNameBox15;
        }

        // Puts expCostBoxes into costBoxes[]
        private void PopulateCostBoxes()
        {
            costBoxes[0] = expCostBox1;
            costBoxes[1] = expCostBox2;
            costBoxes[2] = expCostBox3;
            costBoxes[3] = expCostBox4;
            costBoxes[4] = expCostBox5;

            costBoxes[5] = expCostBox6;
            costBoxes[6] = expCostBox7;
            costBoxes[7] = expCostBox8;
            costBoxes[8] = expCostBox9;
            costBoxes[9] = expCostBox10;

            costBoxes[10] = expCostBox11;
            costBoxes[11] = expCostBox12;
            costBoxes[12] = expCostBox13;
            costBoxes[13] = expCostBox14;
            costBoxes[14] = expCostBox15;
        }

        // Sets expenses[] to shell values
        private void InitializeExpenses()
        {
            for(int i = 0; i < EXPENSE_MAX; i++)
            {
                expenses[i] = new Expense("", 0);
            }
        }

        // Takes user input from TextBoxes into expenses[]
        // // Really could use some error handling here
        public void PopulateExpenses()
        {
            //expenseCount = 0;
            // Read TextBoxes in to expenses[] as long as they've been changed
            // Will blow chunks if both boxes have been changed AND expCostBox.Text doesn't parse to double
            if(expNameBox1.Text != "Name" && expCostBox1.Text != "Cost/Payday")
            { expenses[0] = new Expense(expNameBox1.Text, double.Parse(expCostBox1.Text)); }
            if (expNameBox2.Text != "Name" && expCostBox2.Text != "Cost/Payday")
            { expenses[1] = new Expense(expNameBox2.Text, double.Parse(expCostBox2.Text)); }
            if (expNameBox3.Text != "Name" && expCostBox3.Text != "Cost/Payday")
            { expenses[2] = new Expense(expNameBox3.Text, double.Parse(expCostBox3.Text)); }
            if (expNameBox4.Text != "Name" && expCostBox4.Text != "Cost/Payday")
            { expenses[3] = new Expense(expNameBox4.Text, double.Parse(expCostBox4.Text)); }
            if (expNameBox5.Text != "Name" && expCostBox5.Text != "Cost/Payday")
            { expenses[4] = new Expense(expNameBox5.Text, double.Parse(expCostBox5.Text)); }
            if (expNameBox6.Text != "Name" && expCostBox6.Text != "Cost/Payday")
            { expenses[5] = new Expense(expNameBox6.Text, double.Parse(expCostBox6.Text)); }
            if (expNameBox7.Text != "Name" && expCostBox7.Text != "Cost/Payday")
            { expenses[6] = new Expense(expNameBox7.Text, double.Parse(expCostBox7.Text)); }
            if (expNameBox8.Text != "Name" && expCostBox8.Text != "Cost/Payday")
            { expenses[7] = new Expense(expNameBox8.Text, double.Parse(expCostBox8.Text)); }
            if (expNameBox9.Text != "Name" && expCostBox9.Text != "Cost/Payday")
            { expenses[8] = new Expense(expNameBox9.Text, double.Parse(expCostBox9.Text)); }
            if (expNameBox10.Text != "Name" && expCostBox10.Text != "Cost/Payday")
            { expenses[9] = new Expense(expNameBox10.Text, double.Parse(expCostBox10.Text)); }
            if (expNameBox11.Text != "Name" && expCostBox11.Text != "Cost/Payday")
            { expenses[10] = new Expense(expNameBox11.Text, double.Parse(expCostBox11.Text)); }
            if (expNameBox12.Text != "Name" && expCostBox12.Text != "Cost/Payday")
            { expenses[11] = new Expense(expNameBox12.Text, double.Parse(expCostBox12.Text)); }
            if (expNameBox13.Text != "Name" && expCostBox13.Text != "Cost/Payday")
            { expenses[12] = new Expense(expNameBox13.Text, double.Parse(expCostBox13.Text)); }
            if (expNameBox14.Text != "Name" && expCostBox14.Text != "Cost/Payday")
            { expenses[13] = new Expense(expNameBox14.Text, double.Parse(expCostBox14.Text)); }
            if (expNameBox15.Text != "Name" && expCostBox15.Text != "Cost/Payday")
            { expenses[14] = new Expense(expNameBox15.Text, double.Parse(expCostBox15.Text)); }
        }

        // Adds up expenses[] and updates expense labels on Form1
        public void UpdateForm1Info()
        {
            // Checks and prints how much the user gets in a paycheck
            payCheck = double.Parse(payCheckBox.Text);
            form1.SetPayDayAmountLabel($"{payCheck:C}");

            // Checks and prints user's total initial expenses
            double totalExpenses = 0;
            for (int i = 0; i < EXPENSE_MAX; i++)
            {
                totalExpenses += expenses[i].GetCost();
            }
            form1.SetExpenseLabel($"{totalExpenses:C}");

            // Adds up and prints envelope payouts
            double payOuts = 0;
            for (int i = 0; i < form1.payDay.GetEnvCount(); i++)
            {
                payOuts += form1.payDay.GetPayOut(i);
            }
            form1.SetIntoEnvelopeLabel($"{payOuts:C}");

            // Subtracts expenses and payouts from paycheck to update Payday Balance label
            double balance = payCheck - totalExpenses - payOuts;
            form1.SetPayDayBalanceLabel($"{balance:C}");
        }

        // Getters and Setters
        public double GetPayCheck() { return payCheck; }
        public Expense[] GetExpenses() { return expenses; }
        public int GetExpenseCount() { return EXPENSE_MAX; }
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

        // Sets TextBox.Text back to default
        // Clears expenses[] by setting all names to "" and costs to 0
        // Calls UpdateForm1Info
        private void clearButton_Click(object sender, EventArgs e)
        {
            payCheckBox.Text = "0.00";

            expNameBox1.Text = "Name";
            expNameBox2.Text = "Name";
            expNameBox3.Text = "Name";
            expNameBox4.Text = "Name";
            expNameBox5.Text = "Name";

            expNameBox6.Text = "Name";
            expNameBox7.Text = "Name";
            expNameBox8.Text = "Name";
            expNameBox9.Text = "Name";
            expNameBox10.Text = "Name";

            expNameBox11.Text = "Name";
            expNameBox12.Text = "Name";
            expNameBox13.Text = "Name";
            expNameBox14.Text = "Name";
            expNameBox15.Text = "Name";

            expCostBox1.Text = "Cost/Payday";
            expCostBox2.Text = "Cost/Payday";
            expCostBox3.Text = "Cost/Payday";
            expCostBox4.Text = "Cost/Payday";
            expCostBox5.Text = "Cost/Payday";

            expCostBox6.Text = "Cost/Payday";
            expCostBox7.Text = "Cost/Payday";
            expCostBox8.Text = "Cost/Payday";
            expCostBox9.Text = "Cost/Payday";
            expCostBox10.Text = "Cost/Payday";

            expCostBox11.Text = "Cost/Payday";
            expCostBox12.Text = "Cost/Payday";
            expCostBox13.Text = "Cost/Payday";
            expCostBox14.Text = "Cost/Payday";
            expCostBox15.Text = "Cost/Payday";

            for(int i = 0; i < EXPENSE_MAX; i++)
            {
                expenses[i] = new Expense("", 0);
            }

            UpdateForm1Info();
        }

        // Calls PopulateExpenses and UpdateForm1Info
        // // NEED TO LINK TO SAVE FILE FUNCTION(S)
        private void saveButton_Click(object sender, EventArgs e)
        {
            PopulateExpenses();
            UpdateForm1Info();
        }

        // Toggles whether TextBoxes 6-10 and showBox2 are shown
        // If hiding, also hides buttons 11-15
        private void showButton1_Click(object sender, EventArgs e)
        {
            if(showButton1.Text == "Show More")
            {
                int start = 5;
                int end = 9;               
                for(int i = start; i <= end; i++)
                {
                    nameBoxes[i].Show();
                    costBoxes[i].Show();
                }                
                showButton2.Show();
                showButton1.Text = "Hide";
            }
            else if(showButton1.Text == "Hide")
            {
                int start = 5;
                int end = 14;
                for(int i = start; i <= end; i++)
                {
                    nameBoxes[i].Hide();
                    costBoxes[i].Hide();
                }                
                showButton2.Hide();
                showButton1.Text = "Show More";                
            }
        }

        // Toggles whether TextBoxes 11-15 are shown
        private void showButton2_Click(object sender, EventArgs e)
        {
            if (showButton2.Text == "Show More")
            {
                int start = 10;
                int end = 14;
                for (int i = start; i <= end; i++)
                {
                    nameBoxes[i].Show();
                    costBoxes[i].Show();
                }
                showButton2.Text = "Hide";
            }
            else if (showButton2.Text == "Hide")
            {
                int start = 10;
                int end = 14;
                for (int i = start; i <= end; i++)
                {
                    nameBoxes[i].Hide();
                    costBoxes[i].Hide();
                }
                showButton2.Text = "Show More";
            }
        }
    }
}
