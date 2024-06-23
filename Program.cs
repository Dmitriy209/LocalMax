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

            int localMax = int.MinValue;
            int numberLeft;
            int numberRight;

            bool isLocalMax = false;

            Console.WriteLine("Все локальные максимумы:");

            if (numbers[0] > numbers[1])
            {
                localMax = numbers[0];

                Console.Write(localMax + " ");
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                numberLeft = numbers[i - 1];
                numberRight = numbers[i + 1];

                if (i == numbers.Length - 1)
                {
                    numberRight = int.MinValue;
                }

                if (numbers[i] > numberLeft && numbers[i] > numberRight)
                {
                    localMax = numbers[i];
                    Console.Write(localMax + " ");

                    isLocalMax = true;
                }
            }

            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
            {
                localMax = numbers[numbers.Length - 1];

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
