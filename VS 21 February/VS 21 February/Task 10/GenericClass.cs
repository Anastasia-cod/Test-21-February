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

		public int ArrayLength()
		{
			return array.Length;
		}
	}
}

