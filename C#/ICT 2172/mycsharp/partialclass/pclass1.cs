using System;
namespace ABC
{
	public partial class pclass
	{
		private string name;
		private int age;
		
		public void setDetail()
		{
			Console.WriteLine("Enter name : ");
			name=Console.ReadLine();
			Console.WriteLine("Enter age : ");
			age=Convert.ToInt32(Console.ReadLine());
		}
	}
}