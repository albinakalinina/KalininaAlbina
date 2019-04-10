using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02new
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            var p1 = new Person();
            p1.Name = "p1";
            list.Add(p1);
            var p2 = new Person();
            p2.Name = "p2";
            list.Add(p2);
            var p3 = new Person();
            p3.Name = "p3";
            list.Add(p3);

            GoToWork(p1);
            GoToWork(p2);
            GoToWork(p3);

            GoToHome(p1);
            GoToHome(p2);
            GoToHome(p3);
            Console.ReadLine();
        }

        static List<Person> peopleAlreadyAtWork = new List<Person>();

        static void GoToWork(Person p)
        {
            Console.WriteLine($"{p.Name} came at work.");
            foreach (var alreadyAtWork in peopleAlreadyAtWork)
            {
                p.Came += alreadyAtWork.Greet;
                p.Gone += alreadyAtWork.GoodByeName;
                alreadyAtWork.Gone += p.GoodByeName;
            }
            p.OnCame();
            peopleAlreadyAtWork.Add(p);
        }

        static void GoToHome(Person p)
        {
            peopleAlreadyAtWork.Remove(p);
            foreach (var alreadyAtWork in peopleAlreadyAtWork)
            {
                alreadyAtWork.Came -= p.Greet;
                alreadyAtWork.Gone -= p.GoodByeName;
            }
            Console.WriteLine($"{p.Name} came at home.");
            p.GoneName();
        }

    }
}