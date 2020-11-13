using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSharp.Labs.Lab04
{
    class Utils
    {
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f;
            bool ok = true;
            if(n < 0)
            {
                ok = false;
            }
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }

            }

            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static int Greater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
    public class Test
    {
        public static void Main()
        {
            int x;
            int f;
            bool ok;
            Console.WriteLine("Number for factorial:");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if(ok)
            {
                Console.WriteLine("Factorial(" + x + ") = " + f);
            }
            else
            {
                Console.WriteLine("Cannot compute this factorial");
            }

        }
    }
    
}
