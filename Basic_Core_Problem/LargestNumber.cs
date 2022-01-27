using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problem
{
    //Method for the checking the largest number among three number
    public class LargestNumber
    {
        public void checkNumber()
        {
            Console.WriteLine("Enter the First number");
            int numone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int numtwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Number");
            int numthree = Convert.ToInt32(Console.ReadLine());
            if(numone > numtwo && numone > numthree)
            {
                Console.WriteLine($"number { numone} is maximum");
            }
            else if (numtwo > numone && numtwo > numthree)
            {
                Console.WriteLine($"number { numtwo} is maximum");
            }
            else
            {
                Console.WriteLine($"number { numthree } is maximum");
            }
        }
    }
}
