using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class CharPositionChange
    {
        public void Position()
        {
            Console.Clear();
            Console.WriteLine("The following two words provided will have the first and last letters switch positions.");
            Console.WriteLine("Enter the first word.");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter the second word.");
            string word2 = Console.ReadLine();
            Console.WriteLine($"{word1[word1.Length - 1]}{word1.Substring(1, word1.Length - 2)}{word1[0]}");
            Console.WriteLine($"{word2[word2.Length - 1]}{word2.Substring(1, word2.Length - 2)}{word2[0]}");
            Console.ReadLine();
        }
    }
}
