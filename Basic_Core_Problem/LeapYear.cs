using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problem
{
    public class LeapYear
    {
        // method for checking leap year
        public void check()
        {
            Console.WriteLine("Enter the year you waant to check and the year should be in four digits");
            int year = Convert.ToInt32(Console.ReadLine());

            // formula for leap year condition
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("This year is leap year: " + year);
            }
            else
            {
                Console.WriteLine("This is not a leap year: " + year);
            }
        }
    }
}
