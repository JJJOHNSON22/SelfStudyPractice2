using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class TempConvert
    {
        public void Celcius()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("Enter the number of degrees in celsius.");
            string number = valid.NumberValid();
            int c = Convert.ToInt32(number);
            if (number == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            else
            {
                double k = c * 273.15;
                int f = c * 32;
                Console.WriteLine($"Number of degrees in Celsius is {c}C");
                Console.WriteLine($"Number of degrees in Kelvin is {k}K");
                Console.WriteLine($"Number of degrees in Fahrenheit is {f}F");
                Console.ReadLine();
            }
        }
    }
}
