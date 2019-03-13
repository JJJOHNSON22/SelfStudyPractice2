using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class CreateString
    {
        public void MakeString()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("Enter a sentence that you would like to display.");
            string input = Console.ReadLine();
            Console.WriteLine($"{input[0]}{input}{input[0]}");
            Console.ReadLine();
        }
    }
}
