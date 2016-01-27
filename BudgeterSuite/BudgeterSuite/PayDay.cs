using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgeterSuite
{
    class PayDay
    {
        Envelope[] envelopes;
        int envCap = 8;
        int envCount = 0;
        double[] payOuts;                

        // Constructor
        public PayDay()
        {
            envelopes = new Envelope[envCap];
            payOuts = new double[envCap];
        }

        // Setters
        public void SetEnvelope(Envelope env, int id)
        {
            envelopes[id] = env;
        }
        public void SetPayOut(double num, int id)
        {
            payOuts[id] = num;
        }

        // Getters
        public Envelope GetEnvelope(int id)
        {
            return envelopes[id];
        }
        public double GetPayOut(int id)
        {
            return payOuts[id];
        }

        // Pay out to envelopes
        public void PayEnvelopes()
        {
            for(int i = 0; i <= envCount; i++)
            {
                envelopes[i].NewTransaction(payOuts[i], "Payday");
            }
        }

        // Add envelopes[] and payouts[] space        
    }
}
