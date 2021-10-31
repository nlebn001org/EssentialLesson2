using System;

namespace EssentialLesson2Task2
{
    class Program
    {
        static double amount = 10;
        static double usdRate = 0.038;
        static double eurRate = 0.033;
        static double rubRate = 2.63;
        static void Main(string[] args)
        {
            Converter conv = new Converter(usdRate, eurRate, rubRate);

            Console.WriteLine(String.Format($"{amount} USD by rate {usdRate} is " + "{0:0.00}", conv.UsdToUah(amount))+ " UAH");
            Console.WriteLine(String.Format($"{amount} EUR by rate {eurRate} is " + "{0:0.00}", conv.EurToUah(amount))+ " UAH");
            Console.WriteLine(String.Format($"{amount} RUB by rate {rubRate} is " + "{0:0.00}", conv.RubToUah(amount))+ " UAH");

            Console.WriteLine();

            Console.WriteLine(String.Format($"{amount} UAH by rate {usdRate} is " + "{0:0.00}", conv.UahToUsd(amount))+ " USD");
            Console.WriteLine(String.Format($"{amount} UAH by rate {eurRate} is " + "{0:0.00}", conv.UahToEur(amount))+ " EUR");
            Console.WriteLine(String.Format($"{amount} UAH by rate {rubRate} is " + "{0:0.00}", conv.UahToRub(amount))+ " RUB");
        }
    }
}
