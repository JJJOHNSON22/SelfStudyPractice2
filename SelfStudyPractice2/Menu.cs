using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfStudyPractice2
{
    class Menu
    {
        public void UserMenu()
        {
            string display = "0";
            while (display != "x")
            {
                Console.Clear();
                Console.WriteLine("Choose which thing you want to do.");
                Console.WriteLine();
                Console.WriteLine("{1}:How old do I look?");
                Console.WriteLine("{2}:Write number with and without spaces...twice!");
                Console.WriteLine("{3}:Build a box workshop!");
                Console.WriteLine("{4}:Temperatur conversion.");
                Console.WriteLine("{5}:Remove a letter from a word.");
                Console.WriteLine("{6}:Create a sentence with first letter on start and end.");
                Console.WriteLine("{7}:Enter a positive and negative number to return true.");
                Console.WriteLine("{8}:Switch the first and last letter of two words.");
                Console.WriteLine("{9}:Calculate sum of two numbers or multiply by three.");
                Console.WriteLine("{10}:Find the absolute value from the difference of two numbers.");
                Console.WriteLine("{X}Exit.");
                Console.WriteLine();
                display = Console.ReadLine();

                switch (display)
                {
                    case "1": Age age = new Age(); age.HowOld();; break;
                    case "2": DisplayFourTimes four = new DisplayFourTimes(); four.NumberDisplay(); break;
                    case "3": BuildABox box = new BuildABox(); box.BuildBox(); break;
                    case "4": TempConvert temp = new TempConvert(); temp.Celcius(); break;
                    case "5": RemoveIndex remove = new RemoveIndex(); remove.RemoveLetter(); break; 
                    case "6": CreateString sentence = new CreateString(); sentence.MakeString(); break;
                    case "7": PositiveNegative num = new PositiveNegative(); num.NumberCheck(); break;
                    case "8": CharPositionChange pos = new CharPositionChange(); pos.Position(); break;
                    case "9": TripleEqual trip = new TripleEqual(); trip.TripleIf(); break;
                    case "10": AbsoluteValue abs = new AbsoluteValue(); abs.Value(); break;
                    case "x": break;
                    default: break;
                }
            }
        }
    }
}
