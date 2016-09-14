using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5
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
        { if (a % 2 == 0) return true;
            else return false;
        }
    }
}
    