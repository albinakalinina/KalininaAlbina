using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02new
{
    class Person
    {
        public string Name { get; set; }

        public delegate void Greeting(string name, DateTime time);
        public event Greeting Came;

        public delegate void Leaving(string name);
        public event Leaving Gone;

        public void Greet(string name, DateTime time)
        {
            if (time.Hour < 12)
            {
                Console.WriteLine($"{Name}:Good Morning, {name}!");
            }
            if (time.Hour > 12 && time.Hour < 17)
            {
                Console.WriteLine($"{Name}:Good Day, {name}!");
            }

            if (time.Hour > 17)
            {
                Console.WriteLine($"{Name}:Good Evening, {name}!");
            }
        }
        public void OnCame()
        {
            if (Came != null)
            {
                Came(Name, DateTime.Now);
            }

        }
        public void Leave(string name)
        {
            Console.WriteLine($"{name}, leave the job");
        }

        public void GoneName()
        {

            if (Gone != null)
            {
                Gone(Name);
            }
        }

        public void GoodByeName(string name)
        {
            Console.WriteLine($"{name}, Good Bye!, said {Name}");
        }
        public void GoodBye1()
        {

            if (Gone != null)
            {
                Gone(Name);
            }
        }
    }
}
