using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            String lastName = Console.ReadLine();
            String firstName = Console.ReadLine();
            String patronymic = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            String userPosition = Console.ReadLine();
            DateTime workStart = DateTime.Parse(Console.ReadLine());

            Employee e = new Employee(lastName, firstName, patronymic, dateOfBirth, userPosition, workStart);
            Console.WriteLine(e.Experience);
            Console.WriteLine(e.Age);
            Console.ReadKey();

        }
    }
}
