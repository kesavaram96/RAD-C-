using System;
using PropertiesEx;
class PropertiesExampleApp
{
	public static void Main()
	{
		//PropertiesEx.PropertiesExample pe=new PropertiesEx.PropertiesExample();
		PropertiesExample pe=new PropertiesExample();
		pe.setName("Jack");
		pe.setAge(15);
		Console.WriteLine("Name is {0} and age is {1}",pe.getName(),pe.getAge());
	}
}