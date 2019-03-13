using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class AbsoluteValue
    {
        public void Value()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("Please enter two numbers to find the difference and absolute value.");
            Console.WriteLine("Enter the first number.");
            string number1 = valid.NumberValid();
            int n1 = Convert.ToInt32(number1);
            Console.WriteLine("Now enter a second number.");
            string number2 = valid.NumberValid();
            int n2 = Convert.ToInt32(number2);
            if (n1 > n2)
            {
                Console.WriteLine("Since the first number is bigger then the second number the difference will be multiplied by two.");
                Console.WriteLine($"{n1} - {n2} = |{n1 - n2}| = {Math.Abs((n1 - n2) * 2)}");
            }
            else
            {
                Console.WriteLine($"{n1} - {n2} = |{n1 - n2}| = {Math.Abs(n1 - n2)}");
            }
            Console.ReadLine();
        }
    }
}
