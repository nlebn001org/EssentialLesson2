using System;

namespace EssentialLesson2Task3
{

    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Employee.
    //В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
    //Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
    //Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Employee("Sergei", "Petrov", "manager", 5);
            manager.EmpInfo();
            Console.WriteLine();
            Employee cleaner = new Employee("Vasiliy", "Kupriyanov", "cleaner", 14);
            cleaner.EmpInfo();
           
            Console.WriteLine();
            Employee programmer = new Employee("Tomas", "Palai", "programmer", 10);
            programmer.EmpInfo();
        }
    }
}
