using System;
using Puzzles;

// NOTE: I separated the bulk of the code into the Puzzles.cs file
namespace Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray randomArray = new RandomArray();
            randomArray.PrintMinMax();
            randomArray.PrintSum();
            randomArray.PrintArray();

            Console.WriteLine(Coin.TossMultiple(5));

            NamesProcessor.Print();
            NamesProcessor.Shuffle();
            string longNames = "";
            foreach (string name in NamesProcessor.LongerThanFive())
            {
                longNames += name + "; ";
            }
            Console.WriteLine(longNames);
        }
    }
}
