using System;
class DeligateX
{
	public delegate void getMessage(string s);
	
	static void printmsg(string s)
	{
		Console.WriteLine(s);
	}
	
	public static void Main()
	{
		getMessage d1=new getMessage(printmsg);
		d1("hg");
		getMessage d2=printmsg;
		d2("hjdok");
	}
}