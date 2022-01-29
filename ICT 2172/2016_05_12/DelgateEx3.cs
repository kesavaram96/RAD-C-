using System;
class DelgateEx3
{

	private delegate string GetAMessageB(string msg);
	private delegate int MathCal(int a,int b);
	private delegate double MathCal2(int a,int b);
	
	private static int Add(int a,int b)
	{
		return a+b;
	}
	
	private static int Sub(int a,int b)
	{
		return a-b;
	}
	
	public static double Div(int a,int b)
	{
		return a/(double)b;
	}
	
	private static int Mul(int a,int b)
	{
		return a*b;
	}
	
	public static void Main()
	{
		MathCal add=Add;
		MathCal sub=Sub;
		MathCal mul=Mul;
		MathCal2 div=Div;
		
		Console.WriteLine(add(20,10));
		Console.WriteLine(sub(50,45));
		Console.WriteLine(mul(76,33));
		Console.WriteLine(div(66,23));
	}
}