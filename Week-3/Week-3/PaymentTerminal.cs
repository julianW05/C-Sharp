using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class PaymentTerminal
    {
        private double money;  // amount of cash
        private int coffeeAmount; // number of sold coffees
        private int lunchAmount;  // number of sold lunches

        public PaymentTerminal()
        {
            this.money = 1000;
        }

        public double DrinkCoffee(double payment)
        {
            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment

            if (payment >= 2.50) 
            {
                this.money += 2.50;
                this.coffeeAmount++;
                return payment - 2.50;
            } else
            {
                return payment;
            }
        }

        public double EatLunch(double payment)
        {
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment

            if (payment >= 10.30)
            {
                this.money += 10.30;
                this.lunchAmount++;
                return payment - 10.30;
            }
            else
            {
                return payment;
            }
        }

        public bool DrinkCoffee(PaymentCard card)
        {
            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned

            if (card.balance >= 2.50)
            {
                this.coffeeAmount++;
                card.TakeMoney(2.50);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EatLunch(PaymentCard card)
        {
            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned

            if (card.balance >= 10.30)
            {
                this.lunchAmount++;
                card.TakeMoney(10.30);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            this.money += sum;
            card.AddMoney(sum);
        }

        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}
