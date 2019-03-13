using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class PositiveNegative
    {
        public void NumberCheck()
        {
            Console.Clear();
            int[] arr = new int[2];
            InputValidation valid = new InputValidation();
            Console.WriteLine("Enter a positive number and a negative number to return true.");
            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine($"Enter number {x + 1}.");
                arr[x] = Convert.ToInt32(Console.ReadLine());
            }
            if (arr[0] > 0 && arr[1] < 0 || arr[0] < 0 && arr[1] > 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();
        }
    }
}
