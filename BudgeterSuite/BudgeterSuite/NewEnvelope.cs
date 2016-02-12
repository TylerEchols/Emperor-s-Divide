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
    public partial class NewEnvelope : Form
    {
        private Form1 form1;

        public NewEnvelope(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;                               
        }                

        // Passes the values in the textboxes to Form1's payDay to construct a new envelope
        private void newEnvButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            double balance = double.Parse(balanceBox.Text);
            Envelope newEnv = new Envelope(name, balance);
            double payOut = double.Parse(payOutBox.Text);     
                               
            // Run AddEnvelope and check if it was allowed to via "denied"
            bool denied = form1.payDay.AddEnvelope(newEnv, payOut);   
            if (denied == false)
            {
                form1.ShowNextEnvButton(form1.GetNextEnv());
                form1.SetNextEnv(form1.GetNextEnv() + 1);
                double bal = 0;
                // Update Form1's expense labels
                form1.SetIntoEnvelopeLabel(Convert.ToString(payOut));
                bal += double.Parse(form1.GetPayDayAmountLabel());
                bal -= double.Parse(form1.GetExpenseLabel());
                bal -= double.Parse(form1.GetIntoEnvelopeLabel());
                form1.SetPayDayBalanceLabel(Convert.ToString(bal));
            }
            this.Close();                     
        }
    }
}
