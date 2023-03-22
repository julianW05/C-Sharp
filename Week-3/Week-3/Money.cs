using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class Money
    {
        private int euros;
        private int cents;

        public Money(int euros, int cents)
        {
            if (cents > 99)
            {
                euros = euros + cents / 100;
                cents = cents % 100;
            }

            this.euros = euros;
            this.cents = cents;
        }

        public Money Plus(Money addition)
        {
            int totalEuros = euros + addition.euros;
            int totalCents = cents + addition.cents;

            if (totalCents >= 100)
            {
                totalEuros += totalCents / 100;
                totalCents = totalCents % 100;
            }

            return new Money(totalEuros, totalCents);
        }

        public bool LessThan(Money compared)
        {
            if (euros < compared.euros)
            {
                return true;
            }
            else if (euros == compared.euros && cents < compared.cents)
            {
                return true;
            }

            return false;
        }

        public Money Minus(Money decreaser)
        {
            int diffEuros = euros - decreaser.euros;
            int diffCents = cents - decreaser.cents;

            if (diffCents < 0)
            {
                diffEuros--;
                diffCents += 100;
            }

            if (diffEuros < 0)
            {
                diffEuros = 0;
                diffCents = 0;
            }

            return new Money(diffEuros, diffCents);
        }

        public override string ToString()
        {
            string zero = "";
            if (cents <= 10)
            {
                zero = "0";
            }

            return euros + "." + zero + cents + "e";
        }
    }
}
