using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class InputValidation
    {
        Menu menu = new Menu();

        public string StringValid()
        {
            string userString = Console.ReadLine();

            if (Regex.IsMatch(userString, @"^[a-zA-Z]+$"))
            {
                return userString;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.ReadLine();
                userString = null;
                menu.UserMenu();
            }
            return userString;
        }

        public string NumberValid()
        {
            string userNumber = Console.ReadLine();

            if (Regex.IsMatch(userNumber, @"^[0-9]+$"))
            {
                return userNumber;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.ReadLine();
                userNumber = null;
                menu.UserMenu();
            }
            return userNumber;
        }
    }
}
