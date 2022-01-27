using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problem
{
    public class Factors
    {
        public void Calculate()
        {
            int n, fact = 1, i;
            Console.WriteLine("Enter the number to calculate factor");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
                Console.WriteLine(" fact:" + fact);
            }
            Console.WriteLine("Factorial Number:" + fact);
        }
    }
}
