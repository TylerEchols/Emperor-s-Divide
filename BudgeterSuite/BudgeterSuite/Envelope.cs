using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgeterSuite
{
    public class Envelope
    {
        string name;
        double balance;
        Ledger[] history;
        int historyCount;
        int historyCap = 20;
        double[] leftOvers;
        int leftOverCount;
        int leftOverCap = 6;

        // Constructor
        public Envelope (string _name, double _balance)
        {
            name = _name;
            balance = _balance;
            history = new Ledger[historyCap];
            historyCount = 0;
            leftOvers = new double[leftOverCap];
            leftOverCount = 0;
        }

        // Setters
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetBalance(double _balance)
        {
            balance = _balance;
        }
        public void SetHistory(int id, Ledger _ledger)
        {
            history[id] = _ledger;
        }
        public void SetLeftOver(int id, double num)
        {
            leftOvers[id] = num;
        }

        // Getters
        public string GetName()
        {
            return name;
        }
        public double GetBalance()
        {
            return balance;
        }
        public Ledger GetLedger(int id)
        {
            return history[id];
        }
        public double GetLeftOver(int id)
        {
            return leftOvers[id];
        }
        public Ledger[] GetFullHistory() { return history; }

        // Adds to balance and creates a ledger of the transaction
        // by checking whether there's room in history[] and making more if needed
        // then changing balance, creating the ledger entry and increasing historyCount
        public void NewTransaction(double change, string note)
        {
            if(!(historyCount < historyCap))
            {
                AddHistory(historyCap);
            }
            balance += change;
            history[historyCount] = new Ledger(DateTime.Now, change, balance, note);
            historyCount++;
        }

        // Doubles capacity of history[] and size of historyCap
        // by creating a newHistory[] and copying the old entries into it
        public void AddHistory(int cap)
        {
            int newCap = cap * 2;
            Ledger[] newHistory = new Ledger[newCap];
            for(int i = 0; i < cap; i++)
            {
                newHistory[i] = history[i];
            }
            history = newHistory;
            historyCap = newCap;
        }

        // Sets a new leftover value and creates a new record of it
        // by checking whether there's room in leftOvers[] and making more if needed
        // then creating the element and increasing leftOverCount
        public void NewLeftOver(double num)
        {
            if(!(leftOverCount < leftOverCap))
            {
                AddLeftOvers(leftOverCap);
            }
            leftOvers[leftOverCount] = num;
            leftOverCount++;
        }

        // Doubles capacity of leftOvers[] and size of leftOverCap
        public void AddLeftOvers(int cap)
        {
            int newCap = cap * 2;
            double[] newLeftOvers = new double[newCap];
            for (int i = 0; i < cap; i++)
            {
                newLeftOvers[i] = leftOvers[i];
            }
            leftOvers = newLeftOvers;
            leftOverCap = newCap;
        }
    }
}
