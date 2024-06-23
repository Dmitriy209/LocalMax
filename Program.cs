using System;

namespace LocalMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lowLimitRandom = -9;
            int highLimitRandom = 9;

            int[] numbers = new int[30];

            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(lowLimitRandom, highLimitRandom + 1);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            int localMax;
            int numberLeft;
            int numberRight;
            int lastIndex = numbers.Length - 1;

            bool isLocalMax = false;

            Console.WriteLine("Все локальные максимумы:");

            if (numbers[0] > numbers[1])
            {
                localMax = numbers[0];

                Console.Write(localMax + " ");
            }

            for (int i = 1; i < lastIndex; i++)
            {
                numberLeft = numbers[i - 1];
                numberRight = numbers[i + 1];

                if (numbers[i] > numberLeft && numbers[i] > numberRight)
                {
                    localMax = numbers[i];
                    Console.Write(localMax + " ");

                    isLocalMax = true;
                }
            }

            if (numbers[lastIndex] > numbers[lastIndex - 1])
            {
                localMax = numbers[lastIndex];

                Console.Write(localMax + " ");
            }

            if (isLocalMax == false)
            {
                Console.Write("Локальных максимумов не обнаружено.");
            }

            Console.WriteLine();
        }
    }
}
