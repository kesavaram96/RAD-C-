using System;
class Client
{
	public static void Main()
	{
		MathExample.Main();
		Console.WriteLine("Main Method in client");
	}
}

class MathExample
{
	public static int Add(int x,int y)
	{
		return x+y;
	}
	
	public static int Main()
	{
		int i=Add(5,10);
		Console.WriteLine(i);
		Console.WriteLine("Main Method in MathExample");
		return 0;
	}
}

class MathExample2
{
	public static void Main(String []args)
	{
		int sum=MathExample.Add(int.Parse(args[0]), int.Parse(args[1]));
		Console.WriteLine("Sum of {0} and {1}:{2}",args[0],args[1],sum);
		Console.WriteLine("Main Method in MathExample2");
	}
}