using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToBurn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edwin Chen
            Console.WriteLine("How many calories would you like to burn this workout session?");
            double target = Convert.ToDouble(Console.ReadLine());
            double calorie = 0;
            int minute = 0;

            while (calorie < target)
            {
                calorie += 3.9;
                minute++;
                string output = ($"After {minute} minute{(minute == 1 ? "" : "s")}, you have burned {calorie} calories.");
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}
