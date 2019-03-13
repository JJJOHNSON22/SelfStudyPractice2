using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class BuildABox
    {
        public void BuildBox()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("Supply us with a number to start building. (2 digit number for best boxes)");
            string number = valid.NumberValid();
            if (number == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine($"Congratulations, here is your new box!\n");
                for (int a = 0; a < 3; a++)
                {
                    Console.Write(number);
                }
                for (int b = 0; b < 5; b++)
                {
                    Console.WriteLine($"{number}    {number}");
                }
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(number);
                }
                Console.ReadLine();
            }
        }
    }
}
