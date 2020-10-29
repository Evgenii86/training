using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Example.TestConsole
{
    class Program
    {
        static bool PresenceOfWater(int water)
        {
            return water != 0;
        }
        static bool ConditionCheck(int i, int t)
        {
            return i <= t;
        }
        static void Main(string[] args)
        {
            //Начало
            
            //Ввод данных

            Console.WriteLine("Если вода есть, введите 1. Если воды нет, введите 0");
            int water = int.Parse(Console.ReadLine());

            //Условие
            if (PresenceOfWater(water))
            {
                Console.WriteLine("Введите количество тарелок, которые необходимо вымыть.");
               
                int t = int.Parse(Console.ReadLine());
                int i = 1;
                while (ConditionCheck(i, t))
                {
                    //Действия
                    Console.WriteLine("Включить воду");
                    Console.WriteLine("Взять губку");
                    Console.WriteLine("Нанести моющее средство");
                    Console.WriteLine("Протереть тарелку губкой");
                    Console.WriteLine("Смыть моющее средство");
                    i = i + 1;
                }
                    //Вывод данных
                Console.WriteLine("Итог: количество вымытых тарелок = " + t.ToString());
            }
        
            Console.ReadKey();
        }
    }
}
