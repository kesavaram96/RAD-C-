using System;
namespace CSharpPartialClass
{
	public partial class CSharpPartialClassExample
	{
		private string name;
		private string regNo;
		private int age;
		private string stream;
		
		public void readDetails()
		{
			Console.WriteLine("Enter your Name : ");
			name=Console.ReadLine();
			Console.WriteLine("Enter your RegistrationNo : ");
			regNo=Console.ReadLine();
			Console.WriteLine("Enter your Age : ");
			age=int.Parce(Console.ReadLine());
			Console.WriteLine("Enter your Stream : ");
			stream=Console.ReadLine();
		}
	}
}	