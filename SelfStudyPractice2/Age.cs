using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class Age
    {
        public void HowOld()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("How old are you?");
            string number = valid.NumberValid();
            if (number == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                Console.WriteLine($"You look older than {number}.");
                Console.ReadLine();
            }
        }
    }
}
