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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // if(CheckForSavedBudget(address)) == false { Initialize(); }
            // else load saved and set all values to saved values
            InitializeNewBudget();           
        }
        const int ENVCAP = 16; // Number of envelope buttons on the start page        
        int nextEnv = 1; // Next Envelope button to be .Show-ed
        public PayDay payDay = new PayDay();
        Button[] envButtons = new Button[ENVCAP];

        // Add all envelope buttons to envButtons[]
        // Set all envelope buttons = hidden
        // Set expense labels = 0
        private void InitializeNewBudget()
        {
            envButtons[0] = button1;
            envButtons[1] = button2;
            envButtons[2] = button3;
            envButtons[3] = button4;
            envButtons[4] = button5;

            envButtons[5] = button6;
            envButtons[6] = button7;
            envButtons[7] = button8;
            envButtons[8] = button9;
            envButtons[9] = button10;

            envButtons[10] = button11;
            envButtons[11] = button12;
            envButtons[12] = button13;
            envButtons[13] = button14;
            envButtons[14] = button15;
            envButtons[15] = button16;
            for (int i = 0; i < ENVCAP; i++)
            {
                envButtons[i].Hide();
            }            
            payDayAmountLabel.Text = "0.00";
            expenseLabel.Text = "0.00";
            intoEnvelopeLabel.Text = "0.00";
            payDayBalanceLabel.Text = "0.00";
        }        

        // Opens NewEnvelope form
        private void newEnvButton_Click(object sender, EventArgs e)
        {
            Form newEnvelope = new NewEnvelope(this);
            newEnvelope.Show(); // the form, not the button            
        }

        // Opens ExpenseForm form
        private void editExpensesButton_Click(object sender, EventArgs e)
        {
            ExpenseForm expenseForm = new ExpenseForm(this);
            expenseForm.Show();
        }

        // Sets button#(next).Text to payDay.GetEnvelope's respective name
        // and sets button#(next) to Show()       
        public void ShowNextEnvButton(int next)
        {
            int index = next - 1;
            Envelope env = payDay.GetEnvelope(index);
            envButtons[index].Text = env.GetName();
            envButtons[index].Show();            
        }

        // Getters and Setters
        public int GetNextEnv() { return nextEnv; }

        public void SetNextEnv(int newNext) { nextEnv = newNext; }

        // Expense Calculator Label Getters and Setters
        public string GetPayDayAmountLabel() { return payDayAmountLabel.Text; }
        public string GetExpenseLabel() { return expenseLabel.Text; }
        public string GetIntoEnvelopeLabel() { return intoEnvelopeLabel.Text; }
        public string GetPayDayBalanceLabel() { return payDayBalanceLabel.Text; }

        public void SetPayDayAmountLabel(string _text)
        {
            payDayAmountLabel.Text = _text;
        }
        public void SetExpenseLabel(string _text)
        {
            expenseLabel.Text = _text;
        }
        public void SetIntoEnvelopeLabel(string _text)
        {
            intoEnvelopeLabel.Text = _text;
        }
        public void SetPayDayBalanceLabel(string _text)
        {
            payDayBalanceLabel.Text = _text;
        }

    }
}
