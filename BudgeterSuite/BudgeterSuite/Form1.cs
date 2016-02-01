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
        // Set calculator labels = 0
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
            payDayAmountLabel.Text = $"{0:C}";
            expenseLabel.Text = $"{0:C}";
            intoEnvelopeLabel.Text = $"{0:C}";
            payDayBalanceLabel.Text = $"{0:C}";
        }        

        private void newEnvButton_Click(object sender, EventArgs e)
        {
            Form NewEnvelope = new NewEnvelope(this);
            NewEnvelope.Show(); // the form, not the button            
        }

        // Sets button#(next).Text to payDay.GetEnvelope's respective name
        // and sets button#(next) to Show()       
        public void ShowNextEnvButton(int next)
        {
            int index = next - 1;
            Envelope env = payDay.GetEnvelope(index);
            envButtons[index].Text = env.GetName();
            envButtons[index].Show();
            /*
            if (next == 1)
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
            */
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
        public void setPayDayBalanceLabel(string _text)
        {
            payDayBalanceLabel.Text = _text;
        }
    }
}
