using System;
class OutExample2
{
	static void getDetail(out string name,out string rno,out int age)
	{
		Console.Write("Enter your name : ");
		name=Console.ReadLine();
		Console.Write("Enter your RegNo : ");
		rno=Console.ReadLine();
		Console.Write("Enter your Age : ");
		age=int.Parse(Console.ReadLine());
	}
	
	static void Main()
	{
		string stname;
		string stregno;
		int stage;
		getDetail(out stname,out stregno,out stage);
		Console.WriteLine("After calling getDetail \nName : {0} \nRegNo : {1} \nAge : {2}",stname,stregno,stage);
	}
}