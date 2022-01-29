using System;
class OutExample
{
	static void MyRefMethod(out int x,int y )
	{
		x=y+100;
	}
	
	static void MyMethod(int x,int y)
	{
		x=110;
	}
	
	static void Main()
	{
		int val=20;
		int val2=50;
		Console.WriteLine("Before calling MyMethod, value is : {0}",val);
		MyMethod(val,val2);
		Console.WriteLine("After calling MyMethod, value is : {0}",val);
		MyRefMethod(out val,val2);
		Console.WriteLine("After calling MyRefMethod, value is : {0}",val);
		
		val2=100;
		int val3; //for the "out" we can initalize or not
		MyRefMethod(out val3,val2);
		Console.WriteLine("After calling MyRefMethod, val3 is : {0}",val3);
		
	}
}