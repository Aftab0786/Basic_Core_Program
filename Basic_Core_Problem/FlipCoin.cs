using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problem
{
    public class FlipCoin
    {
        // Method for flip
        public void flip()
        {
            Console.WriteLine("Enter the Number of Time You Want To Flip");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int headcount = 0;
            int tailcount = 0;
            double percentage;
            for (int i = 0; i < num; i++)
            {
                double flip =random.NextDouble();
                if (flip > 0.5)
                {
                    Console.WriteLine("Heads");
                    headcount++;
                    percentage =(headcount / num) * 100;
                    Console.WriteLine("percenatage of Head vs Tails: " + percentage);
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailcount++;
                    percentage = (tailcount / num) * 100;
                    Console.WriteLine("percenatage of Head vs Tails: " + percentage);
                }
            }

        }
    }
}
