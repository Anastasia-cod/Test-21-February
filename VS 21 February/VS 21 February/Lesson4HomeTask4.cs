using System;
namespace VS_21_February
{
    internal class Lesson4
	{
        /// <summary>
        /// Replace all occurrences of 'test' in the string with 'testing'. Remove all characters that are numbers from text.
        /// </summary>
        public static void Task1_1()
        {
            string wordsTask1 = "Task 1 666test - 1 Replace123 test 1and 2 Delete all numbers1 3567";
            string result = string.Empty;

            for (int i = 0; i < wordsTask1.Length; i++)
            {
                if (!char.IsDigit(wordsTask1[i]))
                {
                    result += wordsTask1[i];
                }
            }

            Console.WriteLine(result.Replace("test", "testing"));
        }

        /// <summary>
        /// Replace all occurrences of 'test' in the string with 'testing'. Remove all characters that are numbers from text.
        /// </summary>
        public static void Task1_2()
        {
            string wordsTask1 = "Task 1 666test - 1 Replace123 test 1and 2 Delete all numbers1 3567";
            string result = string.Empty;

            foreach (char i in wordsTask1)
            {
                if (Char.IsDigit(i) == true)
                {
                    wordsTask1 = wordsTask1.Replace(i.ToString(), "");
                }
            }

            Console.WriteLine(wordsTask1.Replace("test", "testing"));
        }

        /// <summary>
        /// Using the method of outputting the value to the console, concatenate the words and print the following phrase to the screen:
        /// Welcome to the TMS lesons.
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("Welcome " + "to " + "the " + "TMS " + "lessons.");
        }

        /// <summary>
        /// It is necessary to find "abc" in the given string, writing everything before these characters into the first variable, as well as everything after them into the second.
        /// </summary>
        public static void Task3()
        {
            string wordsTask3 = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            int index = wordsTask3.IndexOf("abc");

            string wordsBefore = wordsTask3.Substring(0, index);
            string wordsAfter = wordsTask3.Substring(index + 3);

            Console.WriteLine(wordsBefore);
            Console.WriteLine(wordsAfter);
        }
    }
}

