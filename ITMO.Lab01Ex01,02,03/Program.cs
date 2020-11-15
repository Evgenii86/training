using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Пожалуйста введите свое имя");
            myName = Console.ReadLine();
            Console.WriteLine("Привет, " + myName);
        }
    }
}
