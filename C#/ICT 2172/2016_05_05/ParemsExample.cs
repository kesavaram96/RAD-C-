using System;
public class ParemsExample
{
	public static int SumIntegersWithParams(params int[] numbers)
	{
		int sum=0;
		for(int i=0;i<numbers.Length;i++)
		{
			sum+=numbers[i];
		}
		return sum;
	}
	
	public static int SumIntegers(int[] numbers)
	{
		int sum=0;
		for(int i=0;i<numbers.Length;i++)
		{
			sum+=numbers[i];
		}
		return sum;
	}
	
	public static void UseParamsAsObjects(params object[] list)
	{
		for(int i=0;i<list.Length;i++)
		{
			Console.Write(list[i]+ " ");
		}
		Console.WriteLine();
	}
	
	static void Main()
	{
		//Console.WriteLine("Sum : {0}",SumIntegersSumIntegers{1,2,3,4,5});       <--- Error
		Console.WriteLine("Sum : {0}",SumIntegers(new int[]{1,2,3,4}));
		Console.WriteLine("Sum : {0}",SumIntegersWithParams(1,2,3,4,5,6,7));
		Console.WriteLine("Sum : {0}",SumIntegersWithParams(1,2,3,4));
		Console.WriteLine("Sum : {0}",SumIntegersWithParams());
		
		int[] myIntArray={5,6,7,8,9};
		Console.WriteLine("Sum : {0}",SumIntegersWithParams(myIntArray));
		
		UseParamsAsObjects("hello",'g',5,true,56.65);
		UseParamsAsObjects(new object[]{"hi",'f',88,false,56.6546});
		object[] moa={"hi",'f',88,false,56.6546};
		UseParamsAsObjects();
		UseParamsAsObjects(moa);
	}
}