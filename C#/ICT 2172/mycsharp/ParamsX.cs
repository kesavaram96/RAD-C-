using System;
class ParamsX
{
	static void printp(params object[] A)
	{
		for(int i=0;i<A.Length;i++)
			Console.Write(A[i]+" ");
		Console.WriteLine();
	}
	
	static void print(object[] A)
	{
		for(int i=0;i<A.Length;i++)
			Console.Write(A[i]+" ");
		Console.WriteLine();
	}
	
	public static void Main()
	{
		printp("gsg",6,'k',8.6);
		
		object[] D={"sghsdghs",true};
		printp(D);
		
		printp(new object[]{'j',4,5.7});
		
		print(new object[]{5,"dhg",'f'});
	}
}