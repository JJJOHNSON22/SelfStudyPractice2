using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class TripleEqual
    {
        public void TripleIf()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("If the two numbers are equal they will be multiplied by 3 instead of getting their sum.");
            Console.WriteLine("Enter the first number.");
            string number1 = valid.NumberValid();
            int n1 = Convert.ToInt32(number1);
            Console.WriteLine("Enter the second number.");
            string number2 = valid.NumberValid();
            int n2 = Convert.ToInt32(number2);
            if (n1 == n2)
            {
                Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            }
            else
            {
                Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            }
            Console.ReadLine();
        }
    }
}
