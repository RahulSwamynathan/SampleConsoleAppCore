using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleConsoleApplication
{
	public static class DataOperations
	{
		private static readonly string AlphaNumeric = "0123456789abcdefghijklmnopqrstuvwxyz";
		public static IEnumerable<T> SortingType<T> (this IEnumerable<T> name)
		{
			T holder;
			List<T> names = name.ToList();
			for (int i = 0; i < names.Count; i++)
			{
				bool logic = false;  //Setting inital logic to false
				for (int k = i + 1; k < names.Count; k++)
				{
					if (!int.TryParse(Convert.ToString(names[i]), out int res))  //Check wheather its integer or string
					{
						string first = Convert.ToString(names[i]);
						string second = Convert.ToString(names[k]);
						if (!string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(second)) //Checking the null or empty string
						{
							int firstIndex = AlphaNumeric.IndexOf(first.ToLower().ToCharArray()[0]);
							int secondIndex = AlphaNumeric.IndexOf(second.ToLower().ToCharArray()[0]);

							logic = firstIndex > secondIndex; //Checking the index of first character
							if (firstIndex == secondIndex)  //Checking each character if the first index of both matchs the same
							{
								char[] firstchar = first.ToCharArray();
								for (int j = 0; j < firstchar.Length; j++)
								{
									int firstcharIndex = AlphaNumeric.IndexOf(firstchar[j]);
									int secondcharIndex = second.ToCharArray().Length > firstchar.Length ? AlphaNumeric.IndexOf(second.ToCharArray()[j]) : 0;

									logic = firstcharIndex > secondcharIndex;  //Checking the index of the character one by one
									if (firstcharIndex < secondcharIndex) //Breaking the loop if the character index is less
									{
										break;
									}
									if (logic)  //Replacing the value if the character index is greater
									{
										holder = names[i];
										names[i] = names[k];
										names[k] = holder;
										break;
									}
								}
								logic = false; //Warning: Making the logic false to avoid another swaping
							}
						}
					}
					else
					{
						logic = Convert.ToInt32(names[i]) > Convert.ToInt32(names[k]); //Logic if the given array is an interger
					}

					if (logic)  //Final logic of swaping the values based on the condition
					{
						holder = names[i];
						names[i] = names[k];
						names[k] = holder;
					}
				}
			}
			return names;
		}

		public static IEnumerable<T> ReverseList<T> (this IEnumerable<T> array)
		{
			int length = array.Count();
			for (int i = length - 1; i < length; i--)
			{
				if (i < 0)
				{
					break;
				}
				yield return array.ElementAt<T>(i);
			}
		}

		public static long SecondMax<T> (this IEnumerable<T> lis) where T : struct
		{
			long secondmax = 0;
			List<T> list = lis.ToList();
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (Convert.ToInt64(list[i]) > Convert.ToInt64(list[j]))
					{
						if (Convert.ToInt64(list[j]) > secondmax)
						{
							secondmax = Convert.ToInt64(list[j]);
						}
					}
				}
			}
			return secondmax;
		}
	}
}
