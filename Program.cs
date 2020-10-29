using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.TechProg.Test
{
    class Program
    {
        static int search(int[] array, int n, int key)
        {

            for (int index = 0; index < n; index ++)
                if (array[index] == key)
                    return index;
            return -1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Программа производит поиск элементов в заданном массиве");
            int[] array = { 48, 85, 17, 35, 63, 11, 72 };
            int n = array.Length;
            Console.WriteLine("Введите значение искомого ключа");
            int key = int.Parse(Console.ReadLine());
            int res = (search(array, n, key));
            if (res != -1)
                Console.WriteLine("Искомый ключ найден в позиции " + (res + 1));
            else
                Console.WriteLine("Искомый ключ не найден");
            Console.WriteLine("Нажмите любую клавишу для завершения программы");
            Console.ReadKey();

        }
    }
}
