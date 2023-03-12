using System;
namespace VS_21_February
{
    internal class Lesson3
    {
        public static void Task0Way1()
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

        public static void Task0Way2()
        {
            int[] numbers = { 0, 2, 5, 7, 9, 12, 13, 15, 0, 12, 9 };
            Console.WriteLine($"\nEnter integer number from 0 to 15 to check if this number is in array");
            int enteredNumber = int.Parse(Console.ReadLine());
            int result = 0;

            foreach (int number in numbers)
            {
                if (number == enteredNumber)
                {
                    result++;
                }
            }

            if(result > 0)
            {
                Console.WriteLine($"The entered integer number {enteredNumber} is in the array");
            }
            else
            {
                Console.WriteLine($"The entered integer number {enteredNumber} is not in the array");
            }
        }

        public static void Task1()
        {
            int[] numbers = { 0, 2, 2, 7, 9, 7, 9, 7, 15, 12, 9, 0, 0, 7, 8 };
            Console.WriteLine($"\nThe array is:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine($"\nEnter integer number from 0 to 15 to delete this number from the array");
            int enteredNumber = int.Parse(Console.ReadLine());
            int result = 0;

            foreach (int number in numbers)
            {
                if (number == enteredNumber)
                {
                    result++;
                }
            }

            if (result > 0)
            {
                Console.WriteLine($"The entered integer number {enteredNumber} is in the array. The array is changed:");
            }
            else
            {
                Console.WriteLine($"The entered integer number {enteredNumber} is not in the array. Nothing changed in the array:");
            }

            foreach (int number in numbers)
            {
                if (number == enteredNumber)
                    continue;
                Console.Write(number + " ");
            }
        }

        public static void Task2()
        {
            Random random = new Random();
            Console.WriteLine($"\nEnter a length number for the array");
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

            Console.WriteLine($"\nMax number is {maxNumber} ");

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
            Console.WriteLine($"Average summ is {avgSumm} ");
        }

        public static void Task3()
        {
            int[] arraysFirst = { 0, 8, 11, 25, 1};
            int[] arraysSecond = { 4, 3, 28, 2, 8};
            int summArrayFirst = 0;
            int summArraySecond = 0;
            Console.WriteLine($"\nThe first array is: ");

            for (int i = 0; i < arraysFirst.Length; i++)
            {
                Console.Write(arraysFirst[i] + " ");
                summArrayFirst += arraysFirst[i];
            }

            Console.WriteLine($"\nThe second array is: ");
            for (int i = 0; i < arraysSecond.Length; i++)
            {
                Console.Write(arraysSecond[i] + " ");
                summArraySecond += arraysSecond[i];
            }

            double avgSummArrayFirst = (double)summArrayFirst / arraysFirst.Length;
            double avgSummArraySecond = (double)summArraySecond / arraysSecond.Length;
            Console.WriteLine($"\nThe average summ of the first array is {avgSummArrayFirst} \nThe average summ of the second array is {avgSummArraySecond} ");

            if (avgSummArrayFirst > avgSummArraySecond)
            {
                Console.WriteLine($"The average summ of the first array {avgSummArrayFirst} is greater than the average summ of the second array {avgSummArraySecond} ");
            }
            else if (avgSummArraySecond > avgSummArrayFirst)
            {
                Console.WriteLine($"The average summ of the second array {avgSummArraySecond} is greater than the average summ of the first array {avgSummArrayFirst} ");
            }
            else
            {
                Console.WriteLine($"The average summ of the first array {avgSummArrayFirst} equals the average summ of the second array {avgSummArraySecond} ");
            }
        }
    }
}

