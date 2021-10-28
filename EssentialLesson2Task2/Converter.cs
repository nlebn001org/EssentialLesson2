using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson2Task2
{
    class Converter
    {
        public double Usd { get; }
        public double Eur { get; }
        public double Rub { get; }



        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public double UsdToUah(double usd)
        {
            return (usd / Usd);
        }
        public double EurToUah(double eur)
        {
            return eur / Eur;
        }
        public double RubToUah(double rub)
        {
            return rub / Rub;
        }

        public double UahToUsd(double uah)
        {
            return uah * Usd;
        }
        public double UahToEur(double uah)
        {
            return uah * Eur;
        }
        public double UahToRub(double uah)
        {
            return uah * Rub;
        }
    }
}
