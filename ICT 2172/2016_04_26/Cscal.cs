using System;
class Cscal
{
	public static void Main(String []args)
	{
		int a,b,c;
		Console.Write("Enter the value of a : ");
		a=int.Parse(Console.ReadLine());
		Console.Write("Enter the value of b : ");
		b=int.Parse(Console.ReadLine());
		
		c=a+b;
		
		Console.WriteLine("{0}+{1}={2}",a,b,c);
		
		if(a>b)
		{
			Console.WriteLine("{0} is greater than {1}",a,b);
		}
		else
		{
			Console.WriteLine("{1} is greater than {0}",a,b);
		}
	}
}