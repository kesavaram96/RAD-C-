using System;
class Eee<T>
{
	private T[] Arr=new T[5];

	public T this[int n]
	{
		get
		{
			return Arr[n];
		}
		set
		{
			Arr[n]=value;
		}
	}
	
	public static void Main(string []args)
	{
		Eee<string> se=new Eee<string>();
		se[0]="dsgsg";
		Console.WriteLine(se[0]);
	}
}