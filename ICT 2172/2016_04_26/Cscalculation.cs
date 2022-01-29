using System;
class Cscalculation
{
	public static int Add(int a,int b)
	{
		return (a+b);
	}	
	
	public static int Sub(int a,int b)
	{
		return (a-b);
	}
	
	/*public static double Div(double a,double b)
	{
		return (a/b);
	}*/
	
	public static double Div(int a,int b)
	{
		return (a/(double)b);
	}
	
	public static int Mul(int a,int b)
	{
		return (a*b);
	}
	
	public static void Main(String []args)
	{
		int a,b;
		Console.Write("Enter the value of a : ");
		a=int.Parse(Console.ReadLine());
		Console.Write("Enter the value of b : ");
		b=int.Parse(Console.ReadLine());
		
		Console.WriteLine("{0} + {1} = {2}",a,b,Add(a,b));
		Console.WriteLine("{0} - {1} = {2}",a,b,Sub(a,b));
		Console.WriteLine("{0} * {1} = {2}",a,b,Mul(a,b));
		Console.WriteLine("{0} / {1} = {2}",a,b,Div(a,b));
	}
}