using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int lowLimitRandom = 1;
            int highLimitRandom = 9;

            int[] array = new int[30];

            Console.WriteLine("Исходная матрица:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(lowLimitRandom, highLimitRandom + 1);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            int localMax = 0;
            int numberLeft;
            int numberRight;

            bool isLocalMax = false;

            Console.WriteLine("Все локальные максимумы:");

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    numberLeft = 0;
                }
                else
                {
                    numberLeft = array[i - 1];
                }

                if (i == array.Length - 1)
                {
                    numberRight = 0;
                }
                else
                {
                    numberRight = array[i + 1];
                }

                if (array[i] > numberLeft && array[i] > numberRight)
                {
                    localMax = array[i];
                    Console.Write(localMax + " ");

                    isLocalMax = true;
                }
            }

            if (isLocalMax == false)
            {
                Console.Write("Локальных максимумов не обнаружено.");
            }

            Console.WriteLine();
        }
    }
}
