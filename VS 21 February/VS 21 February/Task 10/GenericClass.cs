using System;
namespace VS_21_February.Task10
{
	public class GenericClass<T>
	{
		public T[] array;

		public GenericClass()
		{
			array = new T[0];
		}

		/// <summary>
		/// Add item to Array
		/// </summary>
		/// <param name="item"></param>
		public void AddItemToArray(T item)
		{
			T[] newArray = new T[array.Length + 1];

			for(int i =0; i < array.Length; i++)
			{
				newArray[i] = array[i];
			}

			newArray[array.Length] = item;
			array = newArray;
		}

		/// <summary>
		/// Remove item from Array
		/// </summary>
		/// <param name="item"></param>
		public void RemoveItemFromArray(T item)
		{
			int findIndex = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Equals(item))
				{
					findIndex = i;
					break;
				}
			}

			if (findIndex > -1)
			{
				T[] newArray = new T[array.Length - 1];
				for (int i = 0, j = 0; i < array.Length; i++)
				{
					if (i == findIndex)
						continue;

					newArray[j] = array[i];
					j++;
				}

				array = newArray;
			}
		}

		/// <summary>
		/// Find item in Array by Index
		/// </summary>
		/// <param name="index"></param>
		public void GetItemByIndex(int index)
		{
			try
			{
				T itemInArray = array[index];

				if (index > -1 && index < array.Length)
				{
					Console.WriteLine(itemInArray);
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine($"\n{ex.Message}\nThe array doesn't consist such index. Max index in the array is {array.Length -1}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"\n{ex.Message}");
			}
		}

		/// <summary>
		/// Return Array Length
		/// </summary>
		/// <returns></returns>
		public int ArrayLength()
		{
			return array.Length;
		}
	}
}

