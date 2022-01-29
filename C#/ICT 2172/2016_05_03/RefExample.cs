using System;
class RefExample
{
	static void MyRefMethod(ref int i)
	{
		i=i+66;
	}
	
	static void MyMethod(int i)
	{
		i=i+66;
	}
	
	static void Main()
	{
		int val=2;
		Console.WriteLine("Before calling MyMethod, value is : {0}",val);
		MyMethod(val);
		Console.WriteLine("After calling MyMethod, value is : {0}",val);
		MyRefMethod(ref val);
		Console.WriteLine("After calling MyRefMethod, value is : {0}",val);
		
		val=44;
		MyRefMethod(ref val);
		Console.WriteLine("After calling MyRefMethod, value is : {0}",val);
	}
}