using System;

namespace EssentialLesson2Task4
{
    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //    Создать класс Invoice.
    //В теле класса создать три поля int account, string customer, string provider, которые должны быть проинициализированы один раз(при создании экземпляра данного класса) без возможности их дальнейшего изменения.
    //В теле класса создать два закрытых поля string article, int quantity
    //Создать метод расчета стоимости заказа с НДС и без НДС.
    //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

    class Program
    {
        static string oat = "oat";
        static string carrot = "carrot";
        static string coffee = "coffee";
        static string oil = "oil";
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(1, "Byer", "Seller");

            Console.WriteLine($"NoVAT price is {inv.NoVAT(coffee, 100)}");
            Console.WriteLine($"VAT price is {inv.VAT(coffee, 100)}");

            inv.ShowInvoice();
        }
    }
}
