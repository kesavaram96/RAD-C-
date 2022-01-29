using System;
class CsharpNullableExample
{
	public static void Main()
	{
		int? number=null; // valiable type
		if(number.HasValue)
		{
			Console.WriteLine("Value of number : (0)",number.Value);
		}
		else
		{
			Console.WriteLine("Value of number is undefined or Null");
		}
		number=10;
		//int mynumber=number;//Compilation error on implicit convertion
		int mynumber2=(int)number;//Compile but it will create a run time error if number is null
		int mynumber3=number.Value;//;//Compile but it will create a run time error if number is null
		
		Console.WriteLine("mynumber2 : "+mynumber2);
		Console.WriteLine("mynumber3 : "+mynumber3);
		
		bool? isNumber=null; //reference type 
		if(isNumber.HasValue)
		{
			Console.WriteLine("Value of number : (0)",number.Value);
		}
		else
		{
			Console.WriteLine("Value of number is undefined or Null");
		}
		
		int? number1=10;
		number1++;
		int? number2=20;
		number2++;
		int number3=(int)(number1+number2); //   int number3=number1+number2; <-wrong
		Console.WriteLine("number3 : "+number3);
		
		int? number4=number1+number2;
		Console.WriteLine("number4 : "+number4);
		
		int? number5=number1.Value+number2.Value;
		Console.WriteLine("number5 : "+number5);
		
		int? num1=null;
		int? num2=9;
		int num3=num1 ?? num2 ?? 50;
		Console.WriteLine("num3 : "+num3);
		
		
	}
}
		