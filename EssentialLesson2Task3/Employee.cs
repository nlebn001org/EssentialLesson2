using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson2Task3
{
    class Employee
    {
        string post;
        int expYears;
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Tax { get { return 0.18; } }
        public double Salary { get; }
        public string Post
        {
            get
            {
                return post;
            }
            private set
            {
                if (value.ToLower() == "manager" || value.ToLower() == "programmer" || value.ToLower() == "cleaner")
                {
                    post = value.ToLower();
                }
                else
                {
                    throw new Exception($"{value} is not a post");
                }
            }
        } 
        public int ExpYears
        {
            get
            {
                return expYears;
            }
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception($"Year {value} is not valid");
                }
                else
                {
                    expYears = value;
                }
            }
        }

        public Employee(string name, string surname, string post, int expYears)
        {
            Name = name;
            Surname = surname;
            Salary = SalaryMeth(post, expYears);
        }

        private double SalaryMeth(string post, int expYears)
        {
            ExpYears = expYears;
            Post = post;

            if (Post == "manager")
            {
                return (500 * (ExpYears + 1)) - ((500 * (ExpYears + 1)) * Tax);
            }
            else if (Post == "programmer")
            {
                return (300 * (ExpYears + 1)) - ((300 * (ExpYears + 1)) * Tax);
            }
            else
            {
                return (200 * 1) - ((100 * 1) * Tax);
            }
        }

        public void EmpInfo()
        {
            Console.WriteLine($"Employee's name is: {Name}\nEmployee's surnname is: {Surname}\nEmployee's experience is: {ExpYears} years\nEmployee's post is: {Post}\nEmployee's salary is: {Salary}");
        }

    }
}
