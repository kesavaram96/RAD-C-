class People
{
	private string [] names = new string[100];
	private string [,] fullnames = new string[100,100];
	
	public string this [int i]
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
	
	public string this [int i,int j]
	{
		get
		{
			return fullnames[i,j];
		}
		set
		{
			fullnames[i,j]=value;
		}
	}
}

class Program
{
	static void Main(string [] args)
	{
		People nameCollection = new People();
		nameCollection[0]="Ravi";
		nameCollection[1]="Raja";
		System.Console.WriteLine("Name:{0}",nameCollection[0]);
		System.Console.WriteLine("Name:{0}",nameCollection[1]);
		
		nameCollection[0,0]="Ravi";
		nameCollection[0,1]="Raja";
		System.Console.WriteLine("Firstname:{0} Lastname:{1}",nameCollection[0,0],nameCollection[0,1]);
	}
}