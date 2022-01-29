class MyCollection<T>
{
	private T[] myarr=new T[100];
	
	public T this [int i]
	{
		get
		{
			return myarr[i];
		}
		set
		{
			myarr[i]=value;
		}
	}
}

class Program1
{
	static void Main(string []args)
	{
		MyCollection<string> stringCollection=new MyCollection<string>();
		stringCollection[0]="Hi,Good Morning!!!";
		System.Console.WriteLine(stringCollection[0]);
		
		MyCollection<int> intCollection=new MyCollection<int>();
		intCollection[0]=24;
		System.Console.WriteLine(intCollection[0]);
		
		MyCollection<bool> boolCollection =new MyCollection<bool>();
		boolCollection[0]=true;
		System.Console.WriteLine(boolCollection[0]);
	}
}