using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleConsoleApplication
{
	static class Program
	{

		static void Main (string[] args)
		{
			List<string> array = new List<string>()
			{
				"Ragul",
				"Rahul",
				"Rahpl"  ,
				"Swamynathanas",
				"Swamynathans",
				"fsdfasdfasdfasdf"  ,
				"Aname",
				"Aaame",
				"Bname",
				"Rahul",
			};
			List<char> arr = new List<char>()
			{
			  'q',
			  'a',
			  'z'
			};
			foreach (var item in arr.SortingType<char>())
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("**************************");

			List<double> doubleValue = new List<double>()
			{
			  5900,
			  9,
			  1563,
			  9895,
			};
			Console.WriteLine($"Second Max value {doubleValue.SecondMax()}");
			foreach (var item in doubleValue.SortingType())
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("**************************");

			List<object> obj = new List<object>()
			{
			  "Swamynathan",
			  9,
			  89,
			  'a'
			};

			foreach (var item in obj.SortingType<object>())
			{
				Console.WriteLine(item);
			}

			List<int> names = new List<int>()
			{
				1,
				10,
				9,
				2,
				15,
				8,
				6,
				3,
				7,
				4,
				25
			};
			foreach (var item in array.SortingType())
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("*********************");

			foreach (var item in names.SortingType())
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("*********************");

			foreach (var item in array.OrderBy(x => x))
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("************************");

			Console.WriteLine($"Second Max value {names.SecondMax<int>()}");
			Console.WriteLine($"First Max value {names.Max<int>()}");
		}

	}
}
