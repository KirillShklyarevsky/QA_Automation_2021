using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(CountOfNonRepeatingSymbolsInARow(args[0]));
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static int CountOfNonRepeatingSymbolsInARow(string line)
        {
            if (line is null)
            {
                throw new ArgumentException(nameof(line));
            }

            int maxCount = 0;
            int count = 0;
            char previousSymbol;

            if (line != string.Empty)
            {
                previousSymbol = line[0];
                foreach (char currentSymbol in line)
                {
                    if (currentSymbol != previousSymbol)
                    {
                        count++;
                        previousSymbol = currentSymbol;
                    }
                    else
                    {
                        count = 1;
                        previousSymbol = currentSymbol;
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }

                return maxCount;
            }

            return 0;
        }
    }
}
