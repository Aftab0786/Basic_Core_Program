using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problem
{
    public class VowelConstant
    {
        public void CheckVowelConstan()
        {
            Console.WriteLine("Enter the Charcter");
            char alphabet = Convert.ToChar(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
            {
                Console.WriteLine("entered character is vowel");
            }
            else
                Console.WriteLine("entered character is consonant");
        }
    }
    
}
