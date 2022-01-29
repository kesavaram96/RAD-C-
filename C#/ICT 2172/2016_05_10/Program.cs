class People
{
	private string[] names=new string[100];
	
	public string this[int i]
	{
		get
		{
			return names[i];
		}
		set
		{
			names[i]=value;
		}
	}
}

class Program
{
	static void Main(string[] args)
	{
		People nameCollection=new People();
		nameCollection[0]="Ravi";
		nameCollection[1]="Raja";
		System.Console.WriteLine("Name : {0}",nameCollection[0]);
		System.Console.WriteLine("Name : {0}",nameCollection[1]);
	}
}