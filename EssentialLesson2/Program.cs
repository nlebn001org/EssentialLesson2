using EssentialLesson2Task1;
using System;

namespace EssentialLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Login", "Ivan", "Petrov", 24);

            user.Login = "New login";
            user.GetAllUserInfo();
            //Console.WriteLine(user.ToString());

            Console.ReadKey();
        }
    }
}
