using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise___4__Q1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bNum, pwr;
            int result;
            Console.Write("\n\n  value of one number raised to the power of another :\n");
            Console.Write("------------------------------------------------\n");

            Console.Write(" Input the base  value : ");
            bNum = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input the exponent : ");
            pwr = Convert.ToInt32(Console.ReadLine());

            result = CalcuOfPower(bNum, pwr);//called the function CalcuOfPower

            Console.Write(" The value of {0} to the power of {1} is : {2} \n\n", bNum, pwr, result);
        }

        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
    }
}
