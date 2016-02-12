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
    public partial class EnvelopeDetailsForm : Form
    {
        Form1 form1;
        int id;
        Envelope envelope;
        Ledger[] history;

        public EnvelopeDetailsForm(Form1 _form1, int id)
        {
            InitializeComponent();
            form1 = _form1;
            envelope = form1.payDay.GetEnvelope(id);
            history = envelope.GetFullHistory();
            PopulateInfo();
        }

        public void PopulateInfo()
        {
            this.Text = envelope.GetName();
        }
    }
}
