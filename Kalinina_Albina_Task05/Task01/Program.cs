using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastName = Console.ReadLine();
            string firstName = Console.ReadLine();
            string patronymic = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            User u = new User(lastName, firstName, patronymic, dateOfBirth);
            Console.WriteLine(u.TimeInterval(dateOfBirth));
            Console.ReadKey();



        }
    }
}
