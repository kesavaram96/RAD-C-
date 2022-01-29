using System;
class Csforloop
{
	public static void Main(String []args)
	{
		Console.WriteLine("Hi C#");
		Console.WriteLine("Arguments are : ");
		for(int i=0;i<args.Length;i++)
		{
				Console.WriteLine(args[i]);
		}
	}
}