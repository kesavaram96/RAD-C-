using System;
class DelgateEx2
{
	//Declare a delegate
	private delegate void GetAMessage(string msg);
	
	//Create a method for a delegate
	public static void MyMessage(string mymsg)
	{
		Console.WriteLine(mymsg);
	}
	
	public static void SayHi(string name)
	{
		Console.WriteLine("Hi "+name+"!");
	}
	
	public static void SayHello(string name)
	{
		Console.WriteLine("Hello "+name+"!");
	}
	
	public static void SayGoodBye(string name)
	{
		Console.WriteLine("GoodBye "+name+"!");
	}
	
	private static void MethodWithCallback(int param1,int param2,GetAMessage callback)
	{
		callback("The number is : "+(param1+param2).ToString());
	}
	
	public static void Main()
	{
		//Instantiate the delegate and Initialize it
		GetAMessage gmsg=new GetAMessage(MyMessage);
		//or
		GetAMessage gmsg1=MyMessage;
		//Call the delegate
		gmsg("Hello delegate!");
		gmsg1("Have a nice day!");
		
		GetAMessage gmsg2=SayHi;
		gmsg2("David");
		GetAMessage gmsg3=SayHello;
		gmsg3("Mark");
		GetAMessage gmsg4=SayGoodBye;
		gmsg4("Krish");
		GetAMessage gmsga=gmsg2+gmsg3+gmsg4;
		gmsga("Nimal");
		GetAMessage gmsgb=gmsga-gmsg3;
		gmsgb("Mohamad");
		GetAMessage handler=MyMessage;
		MethodWithCallback(3,2,handler);
	}
}