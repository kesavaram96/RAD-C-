using System;
using hello;
class DllTest
{
	public static void Main(string []args)
	{
		Console.WriteLine("Sum: {0}",DllInCmd.add(2,5));
	}
}