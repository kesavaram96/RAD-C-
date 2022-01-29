using System;
class Out1
{
	static void setno(out int x)
	{
		Console.WriteLine("Enter no :");
		x=int.Parse(Console.ReadLine());
	}
	public static void Main()
	{
		int y;
		setno(out y);
		Console.WriteLine("y = {0}",y);
		Console.ReadKey();
	}
}