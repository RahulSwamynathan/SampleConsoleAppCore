using System;

namespace SampleConsoleApplication
{
	class Sample
	{
		public Sample ()
		{
			
		}
		public void SampleMethod ()
		{
			Console.WriteLine("SampleMethod");
		}

		public SampleClass Instance ()
		{
			return new SampleClass();
		}
	}
}
