using System;
class Csharp2DArray
{
	public static void Main()
	{
		string [,] names=new string[5,2];
		int rowSize=names.GetLength(0);
		int colSize=names.GetLength(1);
		for(int i=0;i<rowSize;i++)
		{
			Console.WriteLine("Enter the first name and last name : ");
			for(int j=0;j<colSize;j++)
			{
				names[i,j]=Console.ReadLine();
			}
		}
		Console.WriteLine("first names and last names : ");
		for(int i=0;i<rowSize;i++)
		{
			for(int j=0;j<colSize;j++)
			{
				Console.Write(names[i,j]+" ");
			}
			Console.WriteLine();
		}
	}
}