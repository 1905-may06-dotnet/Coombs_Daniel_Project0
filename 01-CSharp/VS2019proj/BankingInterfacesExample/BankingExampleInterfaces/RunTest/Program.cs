using System;
using BankingExampleInterfaces;

namespace RunTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankOfAmerica boa = new Company();
            IChaseBank cb = new Company();

            boa.CreditScore = 7.5M;
            boa.Offer(boa.CreditScore);
            boa.CreditScore = 6M;
            boa.Offer(boa.CreditScore);

            cb.CreditScore = 7.5M;
            cb.Offer(cb.CreditScore);
            cb.CreditScore = 6M;
            cb.Offer(cb.CreditScore);
        }
    }
}
