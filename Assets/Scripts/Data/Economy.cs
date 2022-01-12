using UnityEngine;

namespace Aeternum
{
    public class Economy
    {
        public double startingBalance = 10000;
        private double currentTotal = 0;
        private double currentBalance;
        private double income;
        private double outcome;
        public double CurrentTotal {get => currentTotal; set=> currentTotal += currentBalance;}
        public double CurrentBalance { get => currentBalance; set => currentBalance = Income + Outcome; }
        public double Income { get => income; set => income = 15; }
        public double Outcome { get => outcome; set => outcome = 5 * -1; }

        public void SolveNextTurn() 
        {
            CurrentTotal += currentBalance;
        }
    }
}
