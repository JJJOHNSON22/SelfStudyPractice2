using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class DisplayFourTimes
    {
        public void NumberDisplay()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("Please enter a number.");
            string number = valid.NumberValid();
            if (number == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                for (int x = 0; x < 2; x++)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(number);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
