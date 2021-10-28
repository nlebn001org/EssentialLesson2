using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson2Task4
{
    class Invoice
    {

        const double vat = 0.2;

        string article;
        int quantity;

        public double PriceNoVat { get; }
        public double PriceVat { get; }


        public int Account { get; }
        public string Customer { get; }
        public string Provider { get; }
        public string Article
        {
            get
            {
                return article;
            }
            private set
            {
                if (value.ToLower() == "oat")
                {
                    article = value.ToLower();
                }
                else if (value.ToLower() == "carrot")
                {
                    article = value.ToLower();
                }
                else if (value.ToLower() == "coffee")
                {
                    article = value.ToLower();
                }
                else
                {
                    throw new Exception($"{value} is not available.");
                }
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            private set
            {
                if (value < 1)
                {
                    throw new Exception("Quantity can't be less than 1");
                }
                else
                {
                    quantity = value;
                }
            }
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public double VAT(string article, int quantity)
        {
            return NoVAT(article, quantity) + ((NoVAT(article, quantity)) * vat);
        }

        public double NoVAT(string article, int quantity)
        {
            Article = article;
            Quantity = quantity;

            if (Article == "oat")
            {
                return 10 * Quantity;
            }
            else if (Article == "carrot")
            {
                return 15 * Quantity;
            }
            else
            {
                return 30 * Quantity;
            }
        }

        public void ShowInvoice()
        {
            Console.WriteLine($"Account is {Account}, customer is {Customer}, provider is {Provider}.");
        }

    }
}
