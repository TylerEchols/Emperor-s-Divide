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
            // if(CheckForSavedBudget()) == false { Initialize(); }
            // else load saved and set all values to saved values
            InitializeNewBudget();           
        }
        const int ENVCAP = 16; // Number of envelope buttons on the start page        
        int nextEnv = 1; // Next Envelope button to be .Show-ed
        public PayDay payDay = new PayDay();

        // Set all envelope buttons = hidden
        // Set calculator labels = 0
        private void InitializeNewBudget()
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            payDayAmountLabel.Text = $"{0:C}";
            expenseLabel.Text = $"{0:C}";
            intoEnvelopeLabel.Text = $"{0:C}";
            payDayBalanceLabel.Text = $"{0:C}";
        }

        // Updates calculator labels
        public void UpdateInfo()
        {
            // Will check how much the user gets in a paycheck
            double payCheck = 0;
            payDayAmountLabel.Text = $"{payCheck:C}";

            // Will check the user's initial expenses
            double expenses = 0;
            expenseLabel.Text = $"{expenses:C}";

            // Adds up payouts
            double payOuts = 0;
            for (int i = 0; i < payDay.GetEnvCount(); i++)
            {
                payOuts += payDay.GetPayOut(i);
            }
            intoEnvelopeLabel.Text = $"{payOuts:C}";

            // Subtracts expenses and payouts from paycheck to update Payday Balance
            double balance = payCheck - expenses - payOuts;
            payDayBalanceLabel.Text = $"{balance:C}";
        }

        private void newEnvButton_Click(object sender, EventArgs e)
        {
            Form NewEnvelope = new NewEnvelope(this);
            NewEnvelope.Show(); // the form, not the button            
        }

        // Sets button#(next).Text to payDay.GetEnvelope's respective name
        // and sets button#(next) to Show() for buttons 1-16        
        public void ShowNextEnvButton(int next)
        {
            if(next == 1)
            {
                Envelope env = payDay.GetEnvelope(0);
                button1.Text = env.GetName();
                button1.Show();
            }
            if (next == 2)
            {
                Envelope env = payDay.GetEnvelope(1);
                button2.Text = env.GetName();
                button2.Show();
            }
            if (next == 3)
            {
                Envelope env = payDay.GetEnvelope(2);
                button3.Text = env.GetName();
                button3.Show();
            }
            if (next == 4)
            {
                Envelope env = payDay.GetEnvelope(3);
                button4.Text = env.GetName();
                button4.Show();
            }
            if (next == 5)
            {
                Envelope env = payDay.GetEnvelope(4);
                button5.Text = env.GetName();
                button5.Show();
            }
            if (next == 6)
            {
                Envelope env = payDay.GetEnvelope(5);
                button6.Text = env.GetName();
                button6.Show();
            }
            if (next == 7)
            {
                Envelope env = payDay.GetEnvelope(6);
                button7.Text = env.GetName();
                button7.Show();
            }
            if (next == 8)
            {
                Envelope env = payDay.GetEnvelope(7);
                button8.Text = env.GetName();
                button8.Show();
            }
            if (next == 9)
            {
                Envelope env = payDay.GetEnvelope(8);
                button9.Text = env.GetName();
                button9.Show();
            }
            if (next == 10)
            {
                Envelope env = payDay.GetEnvelope(9);
                button10.Text = env.GetName();
                button10.Show();
            }
            if (next == 11)
            {
                Envelope env = payDay.GetEnvelope(10);
                button11.Text = env.GetName();
                button11.Show();
            }
            if (next == 12)
            {
                Envelope env = payDay.GetEnvelope(11);
                button12.Text = env.GetName();
                button12.Show();
            }
            if (next == 13)
            {
                Envelope env = payDay.GetEnvelope(12);
                button13.Text = env.GetName();
                button13.Show();
            }
            if (next == 14)
            {
                Envelope env = payDay.GetEnvelope(13);
                button14.Text = env.GetName();
                button14.Show();
            }
            if (next == 15)
            {
                Envelope env = payDay.GetEnvelope(14);
                button15.Text = env.GetName();
                button15.Show();
            }
            if (next == 16)
            {
                Envelope env = payDay.GetEnvelope(15);
                button16.Text = env.GetName();
                button16.Show();
            }
        }

        // Getters and Setters
        public int GetNextEnv()
        {
            return nextEnv;
        }

        public void SetNextEnv(int newNext)
        {
            nextEnv = newNext;
        }
    }
}
