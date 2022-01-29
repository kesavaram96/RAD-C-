using System;
class Ref
{
	static void rset(ref int x)
	{
		x=x+5;
	}
	
	static void set(int x)
	{
		x=x+5;
	}
	
	public static void Main()
	{
		int x=10;
		Console.WriteLine(x);
		set(x);
		Console.WriteLine(x);
		rset(ref x);
		Console.WriteLine(x);
	}
}