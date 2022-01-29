using System;
class DelgateEx
{
	//Declare a delegate
	private delegate void GetAMessage(string msg);
	
	//Create a method for a delegate
	public static void MyMessage(string mymsg)
	{
		Console.WriteLine(mymsg);
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
	}
}