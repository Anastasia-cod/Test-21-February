using System;
namespace VS_21_February
{
    internal class Lesson3
    {
        public static void Task1()
        {
            int[] numbers = { 0, 2, 5, 7, 9, 12, 13, 15, 0, 12, 9 };
            Console.WriteLine($"Enter integer number from 0 to 15 to check if this number is in array");

            int enteredNumber = int.Parse(Console.ReadLine());
            int result = 0;

            foreach (int number in numbers)
            {
                if (number == enteredNumber)
                {
                    result++;
                }
            }

            Console.WriteLine($"The entered number {enteredNumber} occurs {result} time in the array");
        }

        public static void Task2()
        {
            int[] numbers = { 0, 2, 5, 7, 9, 12, 13, 15, 0, 12, 9 };
            Console.WriteLine($"Enter integer number from 0 to 15 to delete from array, if this number is in the array");

            int enteredNumber = int.Parse(Console.ReadLine());

            foreach (int number in numbers)
            {
                if (number == enteredNumber)
                    continue;
                Console.Write(number);
            }
        }

        public static void Task3()
        {
            Random random = new Random();

            Console.WriteLine($"Enter a length number for the array");
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[lengthOfArray];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (int)random.NextInt64(0, 100);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            int maxNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            Console.WriteLine($"\n Max number is {maxNumber} ");

            int minNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine($"Min number is {minNumber} ");

            int summ = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                summ += numbers[i];
            }

            double avgSumm = (double)summ / numbers.Length;
            Console.WriteLine($" Average summ is {avgSumm} ");

        }
    }
}

