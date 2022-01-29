using System;
using PropertiesEx;
class PropertiesExample2App
{
	public static void Main()
	{
		//PropertiesEx.PropertiesExample pe=new PropertiesEx.PropertiesExample();
		PropertiesExample2 pe=new PropertiesExample2();
		pe.Name="mike";
		pe.Age=44;
		Console.WriteLine("Name is {0} and age is {1}",pe.Name,pe.Age);
		pe.Address="jaffna";
		Console.WriteLine("Address is "+pe.Address);
	}
}