using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5


    {
        class Program
        {
            static void Main(string[] args)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (step(a)) Console.WriteLine("yes");
                else Console.WriteLine("No");
                Console.ReadKey();
            }
            public static bool step(int a)
            {
                if (a == 2) return true;
                else if (a % 2 == 0) return step(a / 2);
                else return false;
            }
        }
   }


