using System;

namespace SampleConsoleApplication
{
	class SampleClass	: ISample, ISam
	{
		public SampleClass ()
		{
				
		}

		public void SamMethod ()
		{
			Console.WriteLine("Sam Method");
		}

		void ISample.Method ()
		{
			Console.WriteLine("Sample Method");
		}

		public Sample Sample ()
		{
			return new Sample();
		}
	}
}
