using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    class Dividelt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Пожалуйста введите первое число");
                string temp = Console.ReadLine();
                int i = int.Parse(temp);
                Console.WriteLine("Пожалуйста введите второе число");
                temp = Console.ReadLine();
                int j = int.Parse(temp);
                int k = i / j;
                Console.WriteLine("Результат деления равен: " + k);
            }
            catch(Exception e)
            {
                Console.WriteLine("Возникло исключение: {0}", e);
            }
        }
    }
}
