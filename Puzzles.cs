using System;
using System.Collections.Generic;

namespace Puzzles
{
    class RandomArray
    {
        public RandomArray()
        {
            _RandArr10 = new int[10];
            _Min = 5;
            _Max = 25;
            Random random = new Random();

            for (int i = 0; i < _RandArr10.Length; ++i)
            {
                _RandArr10[i] = random.Next(_Min, _Max);
            }
        }
        public RandomArray(int randMin, int randMax)
        {
            _RandArr10 = new int[10];
            _Min = randMin;
            _Max = randMax;
            Random random = new Random();

            for (int i = 0; i < 10; ++i)
            {
                _RandArr10[i] = random.Next(_Min, _Max);
            }
        }

        public string ConvertToString()
        {
            string str = _RandArr10[0].ToString();

            for (int i = 1; i < _RandArr10.Length; ++i)
            {
                str += ", " + _RandArr10[i].ToString();
            }

            return str;
        }
        public void PrintArray()
        {
            Console.WriteLine(this.ConvertToString());
        }

        public void PrintMinMax()
        {
            Console.WriteLine($"Min: {ArrayMin}; Max: {ArrayMax}");
        }
        public void PrintSum()
        {
            Console.WriteLine($"Sum: {ArraySum}");
        }

        public int ArrayMin
        {
            get
            {
                int minSoFar = _RandArr10[0];

                for (int i = 1; i < _RandArr10.Length; ++i)
                {
                    minSoFar = _RandArr10[i] < minSoFar ? _RandArr10[i] : minSoFar;
                }
                return minSoFar;
            }
        }
        public int ArrayMax
        {
            get
            {
                int maxSoFar =  _RandArr10[0];

                for (int i = 1; i < _RandArr10.Length; ++i)
                {
                    maxSoFar = _RandArr10[i] > maxSoFar ? _RandArr10[i] : maxSoFar;
                }
                return maxSoFar;
            }
        }
        public int ArraySum
        {
            get
            {
                int sum = _RandArr10[0];

                for (int i = 1; i < _RandArr10.Length; ++i)
                {
                    sum += _RandArr10[i];
                }
                return sum;
            }
        }

        private int[] _RandArr10;
        private int _Min, _Max;
    }

    class Coin
    {
        public static string Toss()
        {
            Console.WriteLine("Tossing coin...");

            Random random = new Random();
            double randomNumber = random.NextDouble();
            string result = randomNumber < 0.5 ? "Heads" : "Tails";

            Console.WriteLine($"Result: {result}");
            return result;
        }
        public static double TossMultiple(int numTosses)
        {
            if (numTosses <= 0)
            {
                Console.WriteLine("Error: Number of tosses must be greater than 0.");
                return -1.0;
            }

            double headsCount = 0;

            for (int i = 0; i < numTosses; ++i)
            {
                if (Coin.Toss() == "Heads")
                {
                    headsCount++;
                }
            }

            return headsCount / numTosses;
        }
    }

    class NamesProcessor
    {
        static NamesProcessor()
        {
            _Names = new List<string>{ "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
        }
        
        public static List<string> Shuffle()
        {
            Console.WriteLine("Shuffling...");
            Random random = new Random();
            int initialCount = _Names.Count;
            int counter = 0;

            while (counter < initialCount)
            {
                int randNum = random.Next(0, initialCount);
                _Names.Add(_Names[randNum]);
                _Names.RemoveAt(randNum);
                counter++;
            }

            NamesProcessor.Print();
            return _Names;
        }

        public static List<string> LongerThanFive()
        {
            List<string> result = new List<string>{};

            foreach (string name in _Names)
            {
                if (name.Length > 5)
                {
                    result.Add(name);
                }
            }

            return result;
        }

        public static void Print()
        {
            string printString = "";
            foreach (string name in _Names)
            {
                printString += name + "; ";
            }

            Console.WriteLine(printString);
        }
        private static List<string> _Names;
    }
}