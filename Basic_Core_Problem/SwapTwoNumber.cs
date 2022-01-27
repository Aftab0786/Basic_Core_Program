using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problem
{
    public class SwapTwoNumber
    {
        // Method for swapping
        public void swap()
        {
            Console.WriteLine("Enter the first Number : ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            FirstNumber = FirstNumber + SecondNumber;
            SecondNumber = FirstNumber - SecondNumber;
            FirstNumber = FirstNumber - SecondNumber;
            Console.WriteLine("After Swapping these Two Numbers : First number is =" + FirstNumber + " and Second number is =" + SecondNumber);
        }

    }
}
