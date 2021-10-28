using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson2Task1
{

    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
    //Реализуйте вывод на экран информации о пользователе.

    class User
    {

        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; }

        public User()
        {

        }

        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Date = DateTime.Now;
        }

        public void GetAllUserInfo()
        {
            Console.WriteLine($"Login is: {Login}\nName is: {Name}\nSurname is: {Surname}\nAge is: {Age}\nDate is: {Date.ToString()}");
        }

    }
}
