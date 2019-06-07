using System;

namespace BankingExampleInterfaces
{
    public class Company : IBankOfAmerica, IChaseBank
    {
        decimal ICreditCard.CreditScore { get { decimal CreditScore; }; set { CreditScore = value; }; }

        bool IBankOfAmerica.Offer(decimal CreditScore)
        {
            if (CreditScore > 7M) {
                Console.WriteLine("You qualify for a 20% discount!");
                Console.WriteLine($"Credit score: {CreditScore}");
                return true;
            }
            else
            {
                Console.WriteLine("You do not qualify for a 20% discount.");
                Console.WriteLine($"Credit score: {CreditScore}");
                return false;
            }
        }

        bool IChaseBank.Offer(decimal CreditScore)
        {
            if (CreditScore > 6M && CreditScore < 7.5M)
            {
                Console.WriteLine("You qualify for a 15% discount!");
                Console.WriteLine($"Credit score: {CreditScore}");
                return true;
            }
            else if (CreditScore >= 7.5M) {
                Console.WriteLine("You qualify for a 25% discount!");
                Console.WriteLine($"Credit score: {CreditScore}");
                return true;
            }
            else
            {
                Console.WriteLine("You do not qualify for a discount.");
                Console.WriteLine($"Credit score: {CreditScore}");
                return false;
            }
        }
    }
}
