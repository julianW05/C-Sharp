using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class PaymentCard
    {
        public double balance { get; private set; }

        public PaymentCard(double balance)
        {
            this.balance = balance;
        }

        public void AddMoney(double increase)
        {
            this.balance = this.balance + increase;
        }

        public bool TakeMoney(double amount)
        {
            // implement the method so that it only takes money from the card if
            // the balance is at least the amount parameter.
            // returns true if successful and false otherwise

            if (this.balance >= amount)
            {
                this.balance -= amount;
                return true;
            }

            return false;
        }
    }
}
