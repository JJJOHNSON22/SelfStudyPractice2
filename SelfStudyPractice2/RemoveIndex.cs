using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class RemoveIndex
    {
        public void RemoveLetter()
        {
            Console.Clear();
            InputValidation valid = new InputValidation();
            Console.WriteLine("Please enter a word you want to use.");
            string userWord = valid.StringValid();
            Console.WriteLine("Enter the letter you wish to remove.");
            char c = Convert.ToChar(Console.ReadLine());
            int x = userWord.IndexOf(c);
            string newWord = "";
            if (userWord == null)
            {
                Menu menu = new Menu();
                menu.UserMenu();
            }
            for (int i = 0; i < userWord.Length; i++)
            {
                if (x == i)
                {
                    continue;
                }
                newWord += userWord[i];
            }
            Console.WriteLine(newWord);
            Console.ReadLine();
        }
    }
}
