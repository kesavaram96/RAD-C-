using System;
class csArray
{
	public static void Main()
	{
		int[] numbers;
		Console.WriteLine("Enter the size of the Array : ");
		int size=int.Parse(Console.ReadLine());
		numbers=new int[size];
		Console.WriteLine();
		for(int i=0;i<numbers.Length;i++)
		{
			numbers[i]=int.Parse(Console.ReadLine());
		}
		
		Console.WriteLine("\nElements of the Array");
		for(int i=0;i<numbers.Length;i++)
		{
			Console.Write(numbers[i]+" ");
		}
		
		Console.WriteLine("\n\nprinting number using foreach");
		foreach(int number in numbers)
		{
			Console.Write(number+" ");
		}
		Console.WriteLine("\n");
		
		string[] names={"jake","mike","miller","lee"};
		foreach(string name in names)
		{
			Console.Write(name+" ");
		}
	}
}