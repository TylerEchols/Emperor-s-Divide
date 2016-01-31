using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgeterSuite
{
    public class Ledger
    {
        DateTime timeStamp;
        double change;
        double balance;
        string note;
        
        // Constructor
        public Ledger (DateTime _timeStamp, double _change, double _balance, string _note)
        {
            timeStamp = _timeStamp;
            change = _change;
            balance = _balance;
            note = _note;
        }       

        // Setters
        public void SetTime(DateTime _timeStamp)
        {
            timeStamp = _timeStamp;
        }
        public void SetAmount(double _change)
        {
            change = _change;
        }
        public void SetBalance(double _balance)
        {
            balance = _balance;
        }
        public void SetNote(string _note)
        {
            note = _note;
        }

        // Getters
        public DateTime GetTime()
        {
            return timeStamp;
        }
        public double GetAmount()
        {
            return change;
        }
        public double GetBalance()
        {
            return balance;
        }
        public string GetNote()
        {
            return note;
        }
    }
}
