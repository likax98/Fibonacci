using System;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            Console.Write("Fibonachi Limit: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());
            int[] fibonachiNumber = GetNumbers(upperBound);
            Console.WriteLine($"Upper Number: {upperBound}");
            for (int i = 0; i < fibonachiNumber.Length; i++)
            {
                Console.WriteLine(fibonachiNumber[i]);
            }
            Console.ReadKey();
        }

        private static int[] GetNumbers(int upperBound)
        {
            //პირველი 0 და 1-სთვის
            int arrSize = ArrSize(upperBound) + 2;
            int[] numbers = new int[arrSize];
            for (int i = 0; ; i++)
            {
                if (i == arrSize) break;
                if (i == 0 || i == 1)
                {
                    numbers[i] = i;
                    continue;
                }
                //formula f(n) = f(n-2) + fn
                numbers[i] = numbers[i - 2] + numbers[i - 1];
            }
            return numbers;
        }

        static int ArrSize(int upperBound)
        {
            int i = 0, oldVal = 0, prevVal = 1;
            while (true)
            {
                int nextVal = oldVal + prevVal;
                oldVal = prevVal;
                prevVal = nextVal;
                if (nextVal > upperBound) break;
                i++;
            }
            return i;
        }
    }
}
