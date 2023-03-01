using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// It is necessary to remove the word "bad" using the substring method. After that, using the insert command, create a string with the value: Good day!!!!!!!!!!.
        /// Replace last "!" on "?"
        /// </summary>
        public static void Task4()
        {
            string wordsTask4 = "Bad day";
            string replace = "Good";
            string symbols = "!!!!!!!!!";
            string question = "?";

            int firstIndex = wordsTask4.IndexOf("Bad");
            string wordsDelete = wordsTask4.Substring(firstIndex + 3);
            string wordsInsert = wordsDelete.Insert(0, replace);
            string wordsAddSymbols = wordsInsert.Insert(wordsInsert.Length, symbols);

            Console.WriteLine(wordsAddSymbols);

            int lastIndex = wordsAddSymbols.LastIndexOf("!");
            string wordsUpdate = wordsAddSymbols.Substring(0, lastIndex);
            string wordsFinal = wordsUpdate.Insert(wordsUpdate.Length, question);

            Console.WriteLine(wordsFinal);
        }

        public static void Task5()
        {
            string document = "5154-abc-2945-qwt-1a2c";

            //Display the first two blocks of 4 digits on the screen in one line.
            string[] numberOfDocument = document.Split("-");
            string numbersOnly = numberOfDocument[0] + numberOfDocument[2];

            Console.WriteLine($"The first 2 blocks of four numbers is:\n{numbersOnly}");

            //Display the document number on the screen, but replace blocks of three letters with *** (each letter will be replaced with *).
            string documentReplace = document.Replace("deR", "***");
            string documentReplace2 = documentReplace.Replace("Qwt", "***");

            Console.WriteLine($"Replace blocks of three letters with asterisks:\n{documentReplace2}");

            //Display only one letter from the document number in format yyy/ yyy / y / y in lower case.
            string docWithoutSeparator = document.Replace("-", "");
            string onlyLetters = string.Empty;

            for (int i = 0; i < docWithoutSeparator.Length; i++)
            {
                if (!char.IsDigit(docWithoutSeparator[i]))
                {
                    onlyLetters += docWithoutSeparator[i];
                }
            }

            //I need help - How can I add the same separator "/" to different place in one string?
            string documentAddSeparator = onlyLetters.Insert(3, "/");
            string documentAddSeparator2 = documentAddSeparator.Insert(7, "/");
            string documentAddSeparator3 = documentAddSeparator.Insert(8, "/");

            Console.WriteLine(documentAddSeparator2.ToLower());

            //Check whether the document number contains the sequence abc and display a message whether it does or not
            //(moreover, abc and ABC are considered the same sequence).
            int indexLower = document.IndexOf("abc");
            int indexUpper = document.IndexOf("ABC");

            if (indexLower > 0 | indexUpper > 0)
            {
                Console.WriteLine($"The document contains subsequence abc or ABC");
            }
            else
            {
                Console.WriteLine($"The document doesn't contain subsequence abc or ABC");
            }

            //WAY1: Check if the document number starts with the sequence 555.
            //I can't figure out how to avoid case sensitivity in letters.
            //When I insert in Regex
            // [5]{3}[0-9]{1}-[a-z]|[A-Z]{3}-[0-9]{4}-[a-z]|[A-Z]{3}-[0-9]{1}[a-z]|[A-Z]{1}[0-9]{1}[a-z]|[A-Z]{1}
            // It doesn't work.
            Regex regex = new Regex("[5]{3}[0-9]{1}-[a-z]{3}-[0-9]{4}-[a-z]{3}-[0-9]{1}[a-z]{1}[0-9]{1}[a-z]{1}");
            Match match = regex.Match(document);

            if (match.Success)
            {
                Console.WriteLine($"The document first free numbers are 555");
            }
            else
            {
                Console.WriteLine($"The document first free numbers aren't 555");
            }

            //WAY2: Check if the document number starts with the sequence 555.
            if (document[0] == '5' && document[1] == '5' && document[2] == '5')
            {
                Console.WriteLine($"The document first free numbers are 555");
            }
            else
            {
                Console.WriteLine($"The document first free numbers aren't 555");
            }

            //Check if the document number ends with the sequence 1a2b.
            if (document[document.Length - 4] == '1' && document[document.Length - 3] == 'a' && document[document.Length - 2] == '2' && document[document.Length - 1] == 'b')
            {
                Console.WriteLine($"The document last four numbers are 1a2b");
            }
            else
            {
                Console.WriteLine($"The document last four numbers aren't 1a2b");
            }
        }
    }
}

