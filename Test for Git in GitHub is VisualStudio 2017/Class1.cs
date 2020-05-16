using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_for_Git_in_GitHub_is_VisualStudio_2017
{
    class Person
    {
        public string name = Console.ReadLine();
        public int age = int.Parse(Console.ReadLine());

        public void WelcomPerson()
        {
            Console.WriteLine("Hello {0} {1}", name, age);
            Console.ReadKey();
        }
    }
}
