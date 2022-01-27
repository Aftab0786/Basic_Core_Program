using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problem
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter the Harmonic Number");
            double num = Convert.ToDouble(Console.ReadLine());
            double harmonicsum = 0;
            for(double i = 1; i <= num; i++)
            {
                Console.WriteLine("1/" + i + "=" + (1 / i));
                harmonicsum += (1 / i);
            }
            Console.WriteLine("the sum of harmonic number: " + harmonicsum);
        }
    }
}
