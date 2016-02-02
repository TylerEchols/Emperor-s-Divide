using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgeterSuite
{
    public class Expense
    {
        string name;
        double cost;

        // Constructor
        public Expense(string _name, double _cost)
        {
            name = _name;
            cost = _cost;
        }

        // Getters and Setters
        public string GetName() { return name; }
        public double GetCost() { return cost; }

        public void SetName(string _name) { name = _name; }
        public void SetCost(double _cost) { cost = _cost; }
    }
}
