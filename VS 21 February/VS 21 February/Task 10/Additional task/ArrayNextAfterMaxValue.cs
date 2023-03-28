using System;
using System.Collections;

namespace VS_21_February.Task10.Additionaltask
{
    public class ArrayAdditionalTask
    {
        public int[] array;

        public ArrayAdditionalTask(int[] array)
        {
            this.array = array;
        }

        public void SortedArray()
        {
            int sort;

            for(int i =0; i < array.Length -1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        sort = array[i];
                        array[i] = array[j];
                        array[j] = sort;						
                    }
                }
            }
        }

        public void DeleteDublicateAndGetValueAfterMax()
        {
            int[] array_distinct = array.Distinct().ToArray();

            Console.WriteLine($"\nValue next after Max Value is: {array_distinct[1]}");
        }
    }
}

