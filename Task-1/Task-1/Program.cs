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
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("ArgumentNullException" + ex.Message);
            }

            Console.WriteLine(CountOfUniqueSymbolsInARow(args[0]));
        }

        public static int CountOfNonRepeatingSymbolsInARow(string line)
        {
            if (line is null)
            {
                throw new ArgumentNullException(nameof(line));
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
            else
            {
                return 0;
            }
        }

        public static int CountOfUniqueSymbolsInARow(string line)
        {
            if (line is null)
            {
                throw new ArgumentNullException(nameof(line));
            }

            if (line.Length == 1)
            {
                return 1;
            }

            int maxCount = 0;
            int count = 0;
            string lineCopy = string.Empty;

            if (line != string.Empty)
            {
                for (int i = 1; i < line.Length; i++)
                {
                    lineCopy = lineCopy.Insert(lineCopy.Length, line[i - 1].ToString());
                    count++;

                    for (int j = 0; j < lineCopy.Length; j++)
                    {
                        if (line[i] == lineCopy[j])
                        {
                            if (count > maxCount)
                            {
                                maxCount = count;
                            }

                            line = line.Substring(line.IndexOf(line[i]) + 1);
                            lineCopy = string.Empty;
                            i = 0;
                            count = 0;

                            break;
                        }
                    }

                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }

                return maxCount;
            }
            else
            {
                return 0;
            }
        }
    }
}
