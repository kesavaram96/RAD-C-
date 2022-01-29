using System;
struct structx
{
	public int n;
	
	public structx(int n)
	{
		this.n=n;
	}
	
	public void print()
	{
		Console.WriteLine("N = {0} in structx",n);
	}
}

class classx
{
	public int n;
	
	public classx(int n)
	{
		this.n=n;
	}
	
	public void print()
	{
		Console.WriteLine("N = {0} in classx",n);
	}
}

class StructAppExample
{
	static void modifyStruct(structx s)
	{
		s.n=10;
		Console.WriteLine("Within modifyStruct N = {0}",s.n);
	}
	
	static void modifyClass(classx c)
	{
		c.n=10;
		Console.WriteLine("Within modifyClass N = {0}",c.n);
	}
	
	public static void Main()
	{
		classx c=new classx(5);
		Console.WriteLine("After Object for class created : ");
		c.print();
		modifyClass(c);
		Console.WriteLine("After ModifyClassValues method Invoked : ");
		c.print();
		Console.WriteLine("\n\n");
		structx s=new structx(5);
		Console.WriteLine("After Object for struct created : ");
		s.print();
		modifyStruct(s);
		Console.WriteLine("After ModifyStructValues method Invoked : ");
		s.print();
	}
}