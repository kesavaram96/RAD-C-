using System;
class Outex
{
	static void getdetail(out String name,out int age)
	{
		Console.WriteLine("Enter name");
		name=Console.ReadLine();
		Console.WriteLine("Enter age");
		age=int.Parse(Console.ReadLine());
	}
	
	public static void Main()
	{
		String sname;
		int sage;
		getdetail(out sname,out sage);
		Console.WriteLine("{0} age is {1}",sname,sage);
	}
}