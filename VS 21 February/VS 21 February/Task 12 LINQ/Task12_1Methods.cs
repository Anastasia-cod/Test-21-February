using System;
using System.Collections.Generic;

namespace VS_21_February.Task12LINQ
{
    public class Methods
    {
        public string[] array;
        public List<int> list;

        public Methods(string[] array) => this.array = array;

        public Methods(List<int> list) => this.list = list;

        /// <summary>
        /// Get first word from array that consists of only one letter
        /// </summary>
        public void GetFirstWord()
        {
            var firstWord = array.FirstOrDefault(a => a.Length == 1 && a != "1" && a != "2" && a != "3" && a != "4" && a != "5" && a != "6" && a != "7" && a != "8" && a != "9" && a != "0", "Array doesn't contain word with one letter.");

            Console.WriteLine(firstWord);
        }

        /// <summary>
        /// Get last word from array that consists of substring "ee"
        /// </summary>
        public void GetLastWord()
        {
            var lastWord = array.LastOrDefault(a => a.Contains("ee"), "Array doesn't contain word with substring <ee>.");

            Console.WriteLine(lastWord);
        }

        /// <summary>
        /// Return the last word that matches the condition: the length of the word is not less than min and not more than max.
        /// </summary>
        public string GetWordByCondition(int min, int max)
        {
            var wordByCondition = array.LastOrDefault(a => a.Length > min && a.Length < max, $"Array doesn't contains word which lenght > {min} and < {max}.");

            return wordByCondition;
        }

        /// <summary>
        /// Return the number of unique values in the array.
        /// </summary>
        public int GetCountOfUniqueValue()
        {
            var countUniqueValue = array.Distinct().Count();

            return countUniqueValue;
        }

        /// <summary>
        /// Extract values from 5 (inclusive) that ends with the number "3".
        /// </summary>
        public void GetValuesByCondition()
        {
            var newList = list.Where(a => a.ToString().EndsWith("3") && a > 52);

            foreach(var values in newList)
            {
                Console.WriteLine(values);
            }
        }

        /// <summary>
        /// Return the length of the shortest word.
        /// </summary>
        public int GetCountOfShortestWord()
        {
            var shortWordCount = array.OrderBy(a => a.Length).FirstOrDefault().Count();

            return shortWordCount;
        }

        /// <summary>
        /// Converts the dictionary to a list and swaps each key and value
        /// </summary>
        /// <param name="dictionary"></param>
        public static void DictionaryToListAndChangePlace(Dictionary<string, int> dictionary)
        {
            List<KeyValuePair<string, int>> listDict = dictionary.ToList();

            var newList = from list in listDict
                          let value = list.Value
                          let key = list.Key
                          select new
                          {
                              Key = value,
                              Value = key
                          };

            foreach (var list in newList)
            {
                Console.WriteLine(list);
            }
        }
    }
}

