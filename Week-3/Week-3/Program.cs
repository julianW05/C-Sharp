using System;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 5-7 --------------------------------
            // create new Station
            HealthStation childrensHospital = new HealthStation();

            // create two new persons
            Person ethan = new Person("Ethan", 1, 110, 7);
            Person peter = new Person("Peter", 33, 176, 85);

            // Try out the Persons and method Weigh
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Test feeding the persons
            childrensHospital.Feed(ethan);
            childrensHospital.Feed(peter);

            // See that the weights have changed
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Keep weighing to increase the 'int weighings'
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);

            // See that the variable has increased to 8
            Console.WriteLine("weighings performed: " + childrensHospital.weighings);

            // ----------------------------------------------
            Console.WriteLine("----------------------------------------------");
            // Exercise 5-8 --------------------------------
            // Card
            PaymentCard petesCard = new PaymentCard(10);

            Console.WriteLine("money " + petesCard.balance);
            bool wasSuccessful = petesCard.TakeMoney(8);
            Console.WriteLine("successfully withdrew: " + wasSuccessful);
            Console.WriteLine("money " + petesCard.balance);

            wasSuccessful = petesCard.TakeMoney(4);
            Console.WriteLine("successfully withdrew: " + wasSuccessful);
            Console.WriteLine("money " + petesCard.balance);

            // Terminal
            PaymentTerminal lunchCafeteria = new PaymentTerminal();
            Console.WriteLine(lunchCafeteria);

            PaymentCard annesCard = new PaymentCard(2);

            Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            bool wasSuccessful1 = lunchCafeteria.EatLunch(annesCard);
            Console.WriteLine("there was enough money: " + wasSuccessful1);

            lunchCafeteria.AddMoneyToCard(annesCard, 100);

            wasSuccessful1 = lunchCafeteria.EatLunch(annesCard);
            Console.WriteLine("there was enough money: " + wasSuccessful1);

            Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            Console.WriteLine(lunchCafeteria);
            // ----------------------------------------------
            Console.WriteLine("-------------------- --------------------------");
            // Exercise 5-9 --------------------------------
            Pet lucy = new Pet("Lucy", "golden retriever");
            Person leo = new Person("Leo", lucy);
            Console.WriteLine(leo);

            Pet stitch = new Pet("Stitch", "blue alien");
            Person mike = new Person("Lilo", stitch);
            Console.WriteLine(mike);

            Pet toothless = new Pet("Toothless", "dragon");
            Person lilo = new Person("Mike", toothless);
            Console.WriteLine(lilo);
            // ----------------------------------------------
            // ----------------------------------------------
            Console.WriteLine("-------------------- --------------------------");
            // Exercise 5-11 --------------------------------
            Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
            Song test = new Song("The Lonely Island", "Jack Sparrow", 195);

            if (jackSparrow.Equals(anotherSparrow))
            {
                Console.WriteLine("Songs are equal.");
            }

            if (jackSparrow.Equals(test))
            {
                Console.WriteLine("Strange things are afoot.");
            }
            // ----------------------------------------------
            Console.WriteLine("-------------------- --------------------------");
            // Exercise 5-14 --------------------------------
            SimpleDate date = new SimpleDate(13, 2, 2015);
            Console.WriteLine("Friday of the examined week is " + date);

            SimpleDate newDate = date.AfterNumberOfDays(7);
            int week = 1;
            while (week <= 7)
            {
                Console.WriteLine("Friday after " + week + " weeks is " + newDate);
                newDate = newDate.AfterNumberOfDays(7);

                week = week + 1;
            }

            Console.WriteLine("The date after 790 days from the examined Friday is ... try it out yourself!");
            // Console.WriteLine("Try " + date.AfterNumberOfDays(790));
            // ----------------------------------------------
            Console.WriteLine("-------------------- --------------------------");
            // Exercise 5-15 --------------------------------
            Money money = new Money(100, 00);
            Money moreMoney = new Money(500, 50);

            Money combined = money.Plus(moreMoney);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(combined);

            Money lessMoney = moreMoney.Minus(money);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);

            lessMoney = lessMoney.Minus(money);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);

            Console.WriteLine(lessMoney.LessThan(moreMoney));
            Console.WriteLine(lessMoney.LessThan(money));

            lessMoney = lessMoney.Minus(moreMoney);
            Console.WriteLine(lessMoney);
            // ----------------------------------------------

        }

        public static void Opd5_15()
        {

        }
    }
}